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

namespace QuanLy_Spa
{
    public partial class DichVuF : Form
    {
        public DichVuF(string manv)
        {
            InitializeComponent();
            MANV = manv;
            dtgvDichVu_Phong.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvDichVu_Phong.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn cl in dtgvBill.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadHoaDon();
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
            row = 0;
            LoadLoaiDV();
        }
        ConnectDB db = new ConnectDB();
        public int row = -1;
        public static string MANV { get; set; }
        string MALDV = "";
        bool IsShowInfo = false;
        int countInfo = 0;
        #region Function
        void LoadLoaiDV()
        {
            DataTable dt = db.getDataTable("select * from LOAI_DICHVU");
            foreach(DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENDV"].ToString();
                item.Text = r["TENDV"].ToString();
                item.Click += Item_Click;
                item.Tag = r["MALOAIDV"];
                Sort.DropDownItems.Add(item);
                MALDV = r["MALOAIDV"].ToString();
            }
        }
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            MALDV = t.Tag.ToString();
            LoadTable("select MAPH, N'Tầng ' + SUBSTRING(MAPH, 2, 1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where MALOAIDV = '"+MALDV+ "' and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        void LoadHoaDon()
        {
            DataTable dt = db.getDataTable("select * from HOADON where NGAYLAP is null");
            cbbHoaDon.DataSource = dt;
            cbbHoaDon.DisplayMember = "MAHD";
            cbbHoaDon.ValueMember = "MAHD";
            LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString());
        }
        void LoadChiTietHoaDon(string mahd)
        {
            DataTable dt = db.getDataTable("select 1 as ID,TENDV,ct.MAPH from CHITIET_HOADON_DV ct,DICHVU DV where MAHD = '" + mahd + "' and DV.MADV = ct.MADV");
            dtgvBill.DataSource = dt;
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                i++;
                r["ID"] = i.ToString();
            }
            dt = db.getDataTable("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON_DV('"+mahd+"') SELECT @SUM AS SUM");
            foreach (DataRow r in dt.Rows)
            {
                lbToTalPrice.Text = string.Format("{0:0,0}", Convert.ToInt32(r["SUM"].ToString().Trim()));
            }
            lbSumCount.Text = db.getScalar("select count(*) from CHITIET_HOADON_DV where MAHD = '" + cbbHoaDon.SelectedValue.ToString().Trim() + "'").ToString();
        }
        void LoadTable(string query)
        {
            DataTable dt = db.getDataTable(query);
            dtgvDichVu_Phong.DataSource = dt;
            int j = 0;
            foreach (DataRow r in dt.Rows)
            {
                if (r["TRANGTHAI"].ToString().Trim() == "0")
                {
                    dtgvDichVu_Phong.Rows[j].Cells[4].Style.ForeColor = Color.DarkRed;
                    dtgvDichVu_Phong.Rows[j].Cells[4].Value = "Trống";
                }
                else
                {
                    dtgvDichVu_Phong.Rows[j].Cells[4].Style.ForeColor = Color.DarkGreen;
                    dtgvDichVu_Phong.Rows[j].Cells[4].Value = "Đang hoạt động";
                }
                dtgvDichVu_Phong.Rows[j].Cells[3].Value = string.Format("{0:0,0}", Convert.ToInt32(r["GIA"].ToString().Trim()));
                j++;
            }
            dtgvDichVu_Phong.CurrentCell = null;
        }
        string GetIDService(string name)
        {
            DataTable dt = db.getDataTable("select MADV from DICHVU where TENDV = N'" + name + "'");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["MADV"].ToString();
            return n.Trim();
        }
        string GetPriceService(string name)
        {
            DataTable dt = db.getDataTable("select GIA from DICHVU where TENDV = N'" + name + "'");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["GIA"].ToString();
            return n.Trim();
        }
        void XoaDichVu_Phong(string maph)
        {
            int i = 0;
            foreach(DataGridViewRow row in dtgvDichVu_Phong.Rows)
            {
                if (row.Cells[4].Value.ToString()==maph)
                {
                    i++;
                }
            }
            dtgvDichVu_Phong.Rows[i].Cells[4].Style.ForeColor = Color.DarkRed;
            DataTable dt = db.getDataTable("select MADV from PHONG_DICHVU where MAPH = '" + maph + "'");
            string mdv = "";
            foreach (DataRow r in dt.Rows)
            {
                mdv = r["MADV"].ToString().Trim();
                int kq = db.getNonQuery("delete CHITIET_HOADON_DV where MAPH = '" + maph + "' and madv = '" + mdv + "'");
            }

        }

        #endregion
        private void DichVuF_Load(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        private void dtgvDichVu_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void NoneActive_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.TRANGTHAI = 0 and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        private void Active_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.TRANGTHAI = 1 and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        #region danh sách dịch vụ theo tầng
        private void F1_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where MAPH like'%P1%' and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        private void F2_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where MAPH like'%P2%' and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        private void F3_Click(object sender, EventArgs e)
        {
            LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where MAPH like'%P3%' and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
        }
        #endregion
        #region Danh sách hóa đơn
        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString().Trim());
        }
        #endregion
        #region thêm dịch vụ vào hóa đơn
        private void BtnThem_Click(object sender, EventArgs e)
        {
            int kq = db.getScalar("select count(*) from HOADON where MAHD = '" + cbbHoaDon.Text.ToString().Trim() + "'");
            if (kq > 0)
            {
                if (row != -1)
                {
                    if (dtgvDichVu_Phong.Rows[row].Cells[4].Value.ToString() != "Đang hoạt động")
                    {
                        string mdv = GetIDService(dtgvDichVu_Phong.Rows[row].Cells[2].Value.ToString().Trim());
                        string mp = ",'" + dtgvDichVu_Phong.Rows[row].Cells[0].Value.ToString().Trim() + "'";
                        string gia = GetPriceService(dtgvDichVu_Phong.Rows[row].Cells[2].Value.ToString().Trim());
                        string mhd = "'" + cbbHoaDon.SelectedValue.ToString().Trim() + "',";
                        mdv = "'" + mdv + "',";
                        kq = db.getNonQuery("insert CHITIET_HOADON_DV values(" + mhd + mdv + gia + mp + ")");
                        dtgvDichVu_Phong.Rows[row].Cells[4].Value = "Đang hoạt động";
                        dtgvDichVu_Phong.Rows[row].Cells[4].Style.ForeColor = Color.DarkGreen;
                        LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString());
                        row = -1;
                        dtgvDichVu_Phong.CurrentCell = null;
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Phòng đang phục vụ khách! Vui lòng chọn phòng khác", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại hóa đơn", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
        #region xóa dịch vụ khỏi hóa đơn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int kq = db.getScalar("select count(*) from HOADON where MAHD = '" + cbbHoaDon.Text.ToString().Trim() + "'");
            if (kq > 0)
            {
                List<string> DS_XOA = new List<string>();
                for (int i = 0; i < dtgvBill.Rows.Count; i++)
                {
                    if ((bool)dtgvBill.Rows[i].Cells[0].FormattedValue)
                    {
                        DS_XOA.Add(dtgvBill.Rows[i].Cells[3].Value.ToString().Trim());
                    }
                }
                DataTable d = dtgvDichVu_Phong.DataSource as DataTable;
                d.PrimaryKey = new DataColumn[] { d.Columns["MAPH"] };
                foreach (string s in DS_XOA)
                {
                    XoaDichVu_Phong(s);
                }
                DataTable dtb = db.getDataTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
                foreach(DataRow r in dtb.Rows)
                {
                    if (d.Rows.Find(r["MAPH"]) == null)
                    {
                        dtb.Rows.Remove(r);
                    }
                }
                dtgvDichVu_Phong.DataSource = dtb;
                int j = 0;
                foreach (DataRow r in dtb.Rows)
                {
                    if (r["TRANGTHAI"].ToString().Trim() == "0")
                    {
                        dtgvDichVu_Phong.Rows[j].Cells[4].Style.ForeColor = Color.DarkRed;
                        dtgvDichVu_Phong.Rows[j].Cells[4].Value = "Trống";
                    }
                    else
                    {
                        dtgvDichVu_Phong.Rows[j].Cells[4].Style.ForeColor = Color.DarkGreen;
                        dtgvDichVu_Phong.Rows[j].Cells[4].Value = "Đang hoạt động";
                    }
                    dtgvDichVu_Phong.Rows[j].Cells[3].Value = string.Format("{0:0,0}", Convert.ToInt32(r["GIA"].ToString().Trim()));
                    j++;
                }
                LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString());
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại hóa đơn", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
        #region Tìm kiếm theo tên
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text != "" && txbName.Text != "Tra cứu theo tên")
            {
                LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where TENDV like '%" + txbName.Text + "%' and PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
            }
            else
            {
                LoadTable("select MAPH ,N'Tầng '+SUBSTRING(MAPH,2,1) as VITRI, TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI");
            }
        }
        private void txbName_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text == "Tra cứu theo tên")
            {
                t.Text = "";
                t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                t.ForeColor = Color.Black;
            }
        }
        private void txbName_MouseLeave(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Trim().Length < 1)
            {
                t.Text = "Tra cứu theo tên";
                t.Font = new Font("Times New Roman", 12, FontStyle.Italic);
                t.ForeColor = Color.Gray;
                
            }
            t.Enabled = false;
            t.Enabled = true;
        }
        #endregion
    }
}
