using OfficeOpenXml.Filter;
using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    public partial class TaoPhieuNhap : Form
    {
        public TaoPhieuNhap(TrangChuQL ql,string mpn,string mql,int trangthai)
        {
            InitializeComponent();
            QL = ql;
            MAQL = mql;
            dtgvPhieuNhap.RowTemplate.Height = 40;
            TRANGTHAI = trangthai;
            MAPN = mpn;
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        int TRANGTHAI;
        string MAQL;
        string MAPN = "";
        int start = 0;
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from chitiet_phieunhap where mahdcc = '" + MAPN + "'");
            foreach(DataRow r in dt.Rows)
            {
                dtgvPhieuNhap.Rows.Add(new DataGridViewRow());
                int i = dtgvPhieuNhap.Rows.Count - 1;
                dtgvPhieuNhap.Rows[i].Cells[0].Value = r["MASP"].ToString().Trim();
                dtgvPhieuNhap.Rows[i].Cells[1].Value = db.getDataTable("select * from SANPHAM where MASP = '"+r["MASP"].ToString().Trim()+"'").Rows[0]["TENSP"].ToString().Trim();
                int g = Convert.ToInt32(r["GIA"].ToString().Trim());
                int sl = Convert.ToInt32(r["SOLUONG"].ToString().Trim());
                dtgvPhieuNhap.Rows[i].Cells[2].Value = g.ToString();
                dtgvPhieuNhap.Rows[i].Cells[3].Value = sl.ToString();
                dtgvPhieuNhap.Rows[i].Cells[4].Value = (string.Format("{0:0,0 vnd}", g*sl)).ToString();
            }
        }
        private void TaoPhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select * from NHACUNGCAP");
            cbbNCC.DataSource = dt;
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";

            dt = db.getDataTable("select * from LOAI_SANPHAM where MALOAISP = 'LSP001'");
            cbbLSP.DataSource = dt;
            cbbLSP.DisplayMember = "TENLOAISP";
            cbbLSP.ValueMember = "MALOAISP";

            dt = db.getDataTable("select SP.* from SANPHAM SP where MALOAISP ='LSP001'");
            cbbSP.DataSource = dt;
            cbbSP.DisplayMember = "TENSP";
            cbbSP.ValueMember = "MASP";
            cbbLSP.SelectedIndex = cbbNCC.SelectedIndex = cbbSP.SelectedIndex = 0;
            dt = db.getDataTable("select SP.* from SANPHAM SP where SP.MALOAISP = 'LSP001'");
            nmGIA.Value = Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString().Trim());
            start = 1;
            if(TRANGTHAI !=1)
            {
                LoadInfo();
                if (TRANGTHAI == 0)
                {
                    btnAdd.Visible = false;
                }
                int i = 0;
                string MASP = dtgvPhieuNhap.Rows[i].Cells[0].Value.ToString().Trim();
                cbbNCC.Text = db.getDataTable("select N.* from NHACUNGCAP N, CUNGCAP_SANPHAM CC where CC.MANCC = N.MANCC and CC.MASP = '" + MASP + "'").Rows[0]["TENNCC"].ToString().Trim();
                cbbLSP.Text = db.getDataTable("select L.* from LOAI_SANPHAM L,SANPHAM S where S.MALOAISP = L.MALOAISP and S.MASP = '" + MASP + "'").Rows[0]["TENLOAISP"].ToString().Trim();
                cbbSP.Text = dtgvPhieuNhap.Rows[i].Cells[1].Value.ToString().Trim();
                nmGIA.Value = Convert.ToInt32(dtgvPhieuNhap.Rows[i].Cells[2].Value.ToString().Trim());
                nmSL.Value = Convert.ToInt32(dtgvPhieuNhap.Rows[i].Cells[3].Value.ToString().Trim());
            }
        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 1)
            {
                DataTable dt = db.getDataTable("select L.MALOAISP ,L.TENLOAISP from LOAI_SANPHAM L, CUNGCAP_SANPHAM C,SANPHAM S where S.MASP = C.MASP and S.MALOAISP = L.MALOAISP and C.MANCC = '" + cbbNCC.SelectedValue.ToString().Trim() + "' group by L.MALOAISP ,L.TENLOAISP");
                cbbLSP.DataSource = dt;
                cbbLSP.DisplayMember = "TENSP";
                cbbLSP.ValueMember = "MALOAISP";
            }
        }

        private void cbbLSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 1)
            {
                DataTable dt = db.getDataTable("select SP.* from SANPHAM SP ,CUNGCAP_SANPHAM CC where CC.MASP= SP.MASP and SP.MALOAISP = '" + cbbLSP.SelectedValue.ToString().Trim() + "' and CC.MANCC= '" + cbbNCC.SelectedValue.ToString().Trim() + "'");
                cbbSP.DataSource = dt;
                cbbSP.DisplayMember = "TENSP";
                cbbSP.ValueMember = "MASP";
                dt = db.getDataTable("select * from sanpham where masp = '" + cbbSP.SelectedValue.ToString().Trim() + "'");
                nmGIA.Value = Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString().Trim());
            }
        }

        private void cbbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 1)
            {
                DataTable dt = db.getDataTable("select * from sanpham where masp = '" + cbbSP.SelectedValue.ToString().Trim() + "'");
                nmGIA.Value = Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString().Trim());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mancc = "";
            if (dtgvPhieuNhap.Rows.Count > 0)
            {
                mancc = db.getDataTable("select * from cungcap_sanpham where masp = '" + dtgvPhieuNhap.Rows[0].Cells[0].Value.ToString().Trim() + "'").Rows[0]["MANCC"].ToString().Trim();
            }
            string ncc = db.getDataTable("select * from cungcap_sanpham where masp = '" + cbbSP.SelectedValue.ToString().Trim() + "'").Rows[0]["MANCC"].ToString().Trim();
            if (mancc == ncc || dtgvPhieuNhap.Rows.Count == 0)
            {
                int kt = db.getScalar("select count(*) from sanpham where tensp = N'" + cbbSP.Text.ToString().Trim() + "'");
                if (kt > 0)
                {
                    int sl, g;
                    errorProvider1.Clear();
                    if (int.TryParse(nmGIA.Value.ToString(), out g))
                    {
                        if (int.TryParse(nmSL.Value.ToString(), out sl))
                        {
                            int check = 0;
                            foreach (DataGridViewRow r in dtgvPhieuNhap.Rows)
                            {
                                if (r.Cells[0].Value.ToString().Trim() == cbbSP.SelectedValue.ToString().Trim())
                                {
                                    int slcu = Convert.ToInt32(r.Cells[3].Value.ToString().Trim()) + sl;
                                    r.Cells[3].Value = slcu.ToString();
                                    r.Cells[2].Value = (nmGIA.Value).ToString();
                                    r.Cells[4].Value = (string.Format("{0:0,0 vnd}", slcu * g)).ToString();
                                    check = 1;
                                    break;
                                }
                            }
                            if (check == 0)
                            {
                                dtgvPhieuNhap.Rows.Add(new DataGridViewRow());
                                int i = dtgvPhieuNhap.Rows.Count - 1;
                                dtgvPhieuNhap.Rows[i].Cells[0].Value = cbbSP.SelectedValue.ToString().Trim();
                                dtgvPhieuNhap.Rows[i].Cells[1].Value = cbbSP.Text.ToString().Trim();
                                dtgvPhieuNhap.Rows[i].Cells[2].Value = (nmGIA.Value).ToString();
                                dtgvPhieuNhap.Rows[i].Cells[3].Value = nmSL.Value.ToString();
                                dtgvPhieuNhap.Rows[i].Cells[4].Value = (string.Format("{0:0,0 vnd}", nmGIA.Value * nmSL.Value)).ToString();
                            }
                        }
                        else errorProvider1.SetError(nmSL, "error");
                    }
                    else errorProvider1.SetError(nmGIA, "error");
                }
                else errorProvider1.SetError(cbbSP, "error");
            }
            else { MessageBox.Show("Mỗi phiếu nhập chỉ bao gồm 1 nhà cung cấp", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (TRANGTHAI > 0)
            {
                if (MessageBox.Show("Bạn chưa lưu lại thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (TRANGTHAI == 1) QL.Order_Click(sender, e);
                    else QL.DSPhieuNhap_Click(sender, e);
                }
            }
            else QL.DSPhieuNhap_Click(sender, e);
        }

        private void dtgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TRANGTHAI != 0)
            {
                if (MessageBox.Show("Bạn muốn xóa sản phẩm?\n"+cbbSP.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    string MaSP = dtgvPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    if (dtgvPhieuNhap.Columns[e.ColumnIndex].Name == "Xoa")
                    {
                        dtgvPhieuNhap.Rows.Remove(dtgvPhieuNhap.Rows[e.RowIndex]);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TRANGTHAI == 1)
            {
                if (MessageBox.Show("Tạo phiếu nhập ???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (dtgvPhieuNhap.Rows.Count > 0)
                    {
                        string mancc = db.getDataTable("select * from cungcap_sanpham where masp = '" + dtgvPhieuNhap.Rows[0].Cells[0].Value.ToString().Trim() + "'").Rows[0]["MANCC"].ToString().Trim();
                        int kq = db.getNonQuery("insert PHIEUNHAP values('" + MAPN + "','" + mancc + "',GETDATE(),NULL,'" + MAQL + "',null)");
                        foreach (DataGridViewRow r in dtgvPhieuNhap.Rows)
                        {
                            string msp = r.Cells[0].Value.ToString().Trim();
                            string g = r.Cells[2].Value.ToString().Trim();
                            string sl = r.Cells[3].Value.ToString().Trim();

                            kq = db.getNonQuery("insert CHITIET_PHIEUNHAP values('" + MAPN + "','" + msp + "'," + g + "," + sl + ")");
                        }

                        MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QL.DSPhieuNhap_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Phiếu nhập cần có ít nhất 1 sản phẩm !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else if (TRANGTHAI == 2)
            {
                if (MessageBox.Show("Lưu thay đổi ???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (dtgvPhieuNhap.Rows.Count > 0)
                    {
                        string mancc = db.getDataTable("select * from cungcap_sanpham where masp = '" + dtgvPhieuNhap.Rows[0].Cells[0].Value.ToString().Trim() + "'").Rows[0]["MANCC"].ToString().Trim();
                        int kq = db.getNonQuery("delete CHITIET_PHIEUNHAP where MAHDCC = '" + MAPN + "'");
                        kq = db.getNonQuery("UPDATE PHIEUNHAP set MANV = '"+MAQL+"' where MAHDCC = '" + MAPN + "'");
                        foreach (DataGridViewRow r in dtgvPhieuNhap.Rows)
                        {
                            string msp = r.Cells[0].Value.ToString().Trim();
                            string g = r.Cells[2].Value.ToString().Trim();
                            string sl = r.Cells[3].Value.ToString().Trim();

                            kq = db.getNonQuery("insert CHITIET_PHIEUNHAP values('" + MAPN + "','" + msp + "'," + g + "," + sl + ")");
                        }

                        MessageBox.Show("Cập nhật đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QL.DSPhieuNhap_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Phiếu nhập cần có ít nhất 1 sản phẩm !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void dtgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            string MASP = dtgvPhieuNhap.Rows[i].Cells[0].Value.ToString().Trim();
            cbbNCC.Text = db.getDataTable("select N.* from NHACUNGCAP N, CUNGCAP_SANPHAM CC where CC.MANCC = N.MANCC and CC.MASP = '" + MASP + "'").Rows[0]["TENNCC"].ToString().Trim();
            cbbLSP.Text = db.getDataTable("select L.* from LOAI_SANPHAM L,SANPHAM S where S.MALOAISP = L.MALOAISP and S.MASP = '" + MASP + "'").Rows[0]["TENLOAISP"].ToString().Trim();
            cbbSP.Text = dtgvPhieuNhap.Rows[i].Cells[1].Value.ToString().Trim();
            nmGIA.Value = Convert.ToInt32(dtgvPhieuNhap.Rows[i].Cells[2].Value.ToString().Trim());
            nmSL.Value = Convert.ToInt32(dtgvPhieuNhap.Rows[i].Cells[3].Value.ToString().Trim());
            
        }
    }
}
