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

namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    public partial class QLPhieuNhap : Form
    {
        public QLPhieuNhap(TrangChuQL ql,string maql)
        {
            InitializeComponent();
            QL = ql;
            MAQL = maql;
            dtgvPhieuNhap.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvPhieuNhap.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from phieunhap where NGAYGIAO is NULL");
        }
        ConnectDB db = new ConnectDB();
        TrangChuQL QL;
        string MAQL;
        void LoadTable(string qr)
        {
            DataTable dt = db.getDataTable(qr);
            dtgvPhieuNhap.DataSource = dt;
            int i = 0;
            int sum = 0;
            foreach(DataRow r in dt.Rows)
            {
                dtgvPhieuNhap.Rows[i].Cells[1].Value = r["MANV"].ToString().Trim();
                string tenncc = db.getDataTable("select * from NHACUNGCAP where MANCC = '" + r["MANCC"].ToString().Trim()+ "'").Rows[0]["TENNCC"].ToString().Trim();
                dtgvPhieuNhap.Rows[i].Cells[3].Value = tenncc.ToString();
                string nd = Convert.ToDateTime(r["NGAYDAT"].ToString().Trim()).ToString("dd/MM/yyyy");
                dtgvPhieuNhap.Rows[i].Cells[4].Value = nd.ToString();
                if (r["NGAYGIAO"].ToString().Trim() == "")
                {
                    dtgvPhieuNhap.Rows[i].Cells[5].Value = "Null";
                    dtgvPhieuNhap.Rows[i].Cells[6].Value = "Chờ nhận";
                    dtgvPhieuNhap.Rows[i].Cells[6].Style.ForeColor = Color.DarkRed;
                    dtgvPhieuNhap.Rows[i].Cells[2].Value = "Null";
                    dtgvPhieuNhap.Rows[i].Cells[2].Style.ForeColor = Color.DarkRed;
                }
                else
                {
                    string nn = Convert.ToDateTime(r["NGAYGIAO"].ToString().Trim()).ToString("dd/MM/yyyy");
                    dtgvPhieuNhap.Rows[i].Cells[5].Value = nn.ToString();
                    dtgvPhieuNhap.Rows[i].Cells[6].Value = "Hoàn thành";
                    dtgvPhieuNhap.Rows[i].Cells[6].Style.ForeColor = Color.DarkGreen;
                    dtgvPhieuNhap.Rows[i].Cells[2].Value = r["NV_XACNHAN"].ToString().Trim();
                    dtgvPhieuNhap.Rows[i].Cells[2].Style.ForeColor = Color.DarkGreen;
                }
                int tt = Convert.ToInt32(db.getDataTable("select sum(SOLUONG*GIA) as 'TONG' from CHITIET_PHIEUNHAP where MAHDCC = '" + r["MAHDCC"].ToString().Trim() +"'").Rows[0]["TONG"].ToString().Trim());
                string thanhtien = string.Format("{0:0,0 vnd}", tt);
                sum += tt;
                dtgvPhieuNhap.Rows[i].Cells[7].Value = thanhtien.ToString();
                i++;
            }
            lbCount.Text = dt.Rows.Count.ToString();
            lbTotal.Text = string.Format("{0:0,0 vnd}", sum);
        }
        private void QLPhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select * from NHACUNGCAP");
            cbbNhaCC.DataSource = dt;
            cbbNhaCC.DisplayMember = "TENNCC";
            cbbNhaCC.ValueMember = "MANCC";
            dt = db.getDataTable("select * from PHIEUNHAP");
            cbbMaPN.DataSource = dt;
            cbbMaPN.DisplayMember = "MAHDCC";
            cbbMaPN.ValueMember = "MAHDCC";
            cbbSelect.Items.Add("Tất cả phiếu nhập");
            cbbSelect.Items.Add("Phiếu nhập có trạng thái hoàn thành");
            cbbSelect.Items.Add("Phiếu nhập có trạng thái đang chờ");
            cbbSelect.Items.Add("Tìm theo mã phiếu nhập");
            cbbSelect.Items.Add("Tìm theo nhà cung cấp");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : ngày/tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : năm");
            cbbSelect.Items.Add("Tìm theo ngày giao : ngày/tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày giao : tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày giao : năm");
            cbbSelect.SelectedIndex = cbbMaPN.SelectedIndex = cbbNhaCC.SelectedIndex = 0;
            cbbSelect.SelectedIndex = 2;
            LoadTable("select * from phieunhap where NGAYGIAO is NULL");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(cbbSelect.SelectedIndex == 0 )
            {
                LoadTable("select * from phieunhap");
            }
            else if(cbbSelect.SelectedIndex == 1)
            {
                LoadTable("select * from phieunhap where ngaygiao is not null");
            }
            else if (cbbSelect.SelectedIndex == 2)
            {
                LoadTable("select * from phieunhap where ngaygiao is null");
            }
            else if (cbbSelect.SelectedIndex == 3)
            {
                LoadTable("select * from phieunhap where MAHDCC = '"+cbbMaPN.SelectedValue.ToString().Trim()+"'");
            }
            else if (cbbSelect.SelectedIndex == 4)
            {
                LoadTable("select * from phieunhap where MANCC = '" + cbbNhaCC.SelectedValue.ToString().Trim() + "'");
            }
            else if (cbbSelect.SelectedIndex == 5)
            {
                LoadTable("select * from phieunhap where Ngaydat = '"+dtpkDayFind.Value.ToString("yyyy-MM-dd")+"'");
            }
            else if (cbbSelect.SelectedIndex == 6)
            {
                LoadTable("select * from PHIEUNHAP where NGAYDAT like '" + dtpkDayFind.Value.ToString("yyyy-MM") + "-%'");
            }
            else if (cbbSelect.SelectedIndex == 7)
            {
                LoadTable("select * from phieunhap where year(ngaydat) = "+dtpkDayFind.Value.Year);
            }
            else if (cbbSelect.SelectedIndex == 8)
            {
                LoadTable("select * from phieunhap where NgayGiao = '" + dtpkDayFind.Value.ToString("yyyy-MM-dd") + "'");
            }
            else if (cbbSelect.SelectedIndex == 9)
            {
                LoadTable("select * from PHIEUNHAP where NgayGiao like '" + dtpkDayFind.Value.ToString("yyyy-MM") + "-%'");
            }
            else
            {
                LoadTable("select * from phieunhap where year(ngaygiao) = " + dtpkDayFind.Value.Year);
            }
        }

        private void dtgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string MAPN = dtgvPhieuNhap.Rows[row].Cells[0].Value.ToString().Trim();
            if (dtgvPhieuNhap.Columns[e.ColumnIndex].Name == "CapNhat")
            {
                if (MessageBox.Show("Bạn muốn điều chỉnh thông tin đơn hàng " + MAPN, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (dtgvPhieuNhap.Rows[row].Cells[5].Value.ToString().Trim() != "Null")
                    {
                        MessageBox.Show("Không thể điều chỉnh thông tin đơn hàng đã xác nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        QL.TaoPhieuNhap_Click(2, MAPN);
                    }
                }
            }
            else if (dtgvPhieuNhap.Columns[e.ColumnIndex].Name == "Xem")
            {
                QL.TaoPhieuNhap_Click(0, MAPN);
            }
            else if (dtgvPhieuNhap.Columns[e.ColumnIndex].Name == "Xoa")
            {
               if(MessageBox.Show("Bạn muốn hủy phiếu nhập "+MAPN,"",MessageBoxButtons.YesNo,MessageBoxIcon.Question) !=  DialogResult.No)
                {
                    if(dtgvPhieuNhap.Rows[row].Cells[5].Value.ToString().Trim()!= "Null")
                    {
                        MessageBox.Show("Không thể xóa phiếu nhập đã thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dtgvPhieuNhap.Rows.RemoveAt(row);
                        int kq = db.getNonQuery("delete CHITIET_PHIEUNHAP where MAHDCC = '" + MAPN + "'");
                        kq = db.getNonQuery("delete PHIEUNHAP where MAHDCC = '" + MAPN + "'");
                    }
                }
            }
            else if (dtgvPhieuNhap.Columns[e.ColumnIndex].Name == "XacNhan")
            {
                if (MessageBox.Show("Bạn muốn xác nhận đơn hàng " + MAPN+" đã được giao thành công?\n Lưu ý:\nKhi đã xác nhận thì không thể thay đổi!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (dtgvPhieuNhap.Rows[row].Cells[5].Value.ToString().Trim() != "Null")
                    {
                        MessageBox.Show("Không thể xác nhận đơn hàng\nĐơn "+MAPN+" đã được xác nhận trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int kq = db.getNonQuery("update PHIEUNHAP set NGAYGIAO = GETDATE() where MAHDCC = '" + MAPN + "'");
                        kq = db.getNonQuery("update PHIEUNHAP set NV_XACNHAN = '"+MAQL+"' where MAHDCC = '" + MAPN + "'");
                        DataTable dt = db.getDataTable("select * from chitiet_phieunhap where MAHDCC = '" + MAPN + "'");
                        foreach(DataRow r in dt.Rows)
                        {
                            string sl = r["SOLUONG"].ToString().Trim();
                            kq = db.getNonQuery("update sanpham set slton += " + sl + " where MASP = '" + r["MASP"].ToString().Trim() + "'");
                        }
                        dtgvPhieuNhap.Rows.RemoveAt(row);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Order_Click(sender, e);
        }

   
    }
}
