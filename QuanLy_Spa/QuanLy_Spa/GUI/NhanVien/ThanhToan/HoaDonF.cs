using QuanLy_Spa.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLy_Spa
{
    public partial class HoaDonF : Form
    {
        public HoaDonF(TrangChuNV tt, string manv)
        {
            InitializeComponent();
            TT = tt;
            dtgvHoaDon.AutoGenerateColumns = false;
            dt = db.getDataTable("select * from HOADON where NgayLap is null");
            MaNhanVien = manv;
            LoadHoaDon();
        }    
        ConnectDB db = new ConnectDB();
        DataTable dt = new DataTable();
        TrangChuNV TT;
        string IDBILL = "";
        int Des = 0;
        int Show = 0;
        public static string MaNhanVien { get; set; }
        private void HoaDonF_Load(object sender, EventArgs e)
        {
            LoadTongTienTatCaHoaDon();
        }
        #region Function
        void LoadTongTienTatCaHoaDon()
        {
            int i = 0;
            foreach (DataGridViewRow row in dtgvHoaDon.Rows)
            {
                string MAHD = dtgvHoaDon.Rows[i].Cells[0].Value.ToString();
                int TongTien = Convert.ToInt32(db.getScalar("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON('" + MAHD + "') SELECT @SUM"));
                dtgvHoaDon.Rows[i].Cells[3].Value = string.Format("{0:0,0}",TongTien);
                i++;
            }
        }
        void LoadHoaDon()
        {
            dtgvHoaDon.DataSource = dt;
            foreach(DataGridViewRow r in dtgvHoaDon.Rows)
            {
                if (r.Cells[1].Value.ToString().Trim() == "")
                {
                    r.Cells[1].Value = "Trống";
                }
                else if (db.getScalar("select count(*) from khachhang where makh ='" + r.Cells[1].Value.ToString() + "'")!=0)
                {
                    DataTable d = db.getDataTable("select * from khachhang where makh = '" + r.Cells[1].Value.ToString().Trim() + "'");
                    r.Cells[1].Value = d.Rows[0]["HOTEN"].ToString();
                }
                if(r.Cells[2].Value.ToString().Trim() == "")
                {
                    r.Cells[2].Value = MaNhanVien;
                }
                else
                {
                    r.Cells[2].Value = r.Cells[2].Value.ToString().Trim();
                }
            }
            LoadTongTienTatCaHoaDon();
        }
        int KiemTraTrangThaiHD(string mahd)
        {
            return db.getScalar("select count(*) from HOADON where NGAYLAP is null and MAHD ='" + mahd + "'");
        }
        #endregion     
        #region datagridview
        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MAHD = dtgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dtgvHoaDon.Columns[e.ColumnIndex].Name == "TongTien")
            {
                if (KiemTraTrangThaiHD(MAHD.Trim())==0)
                {
                    MessageBox.Show("Bạn không có quyền xem hóa đơn đã thanh toán","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    IDBILL = MAHD.Trim();
                    TT.Detail_Paid_Click(IDBILL);
                }
            }
            else if (dtgvHoaDon.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn muốn xóa hóa đơn " + MAHD, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (KiemTraTrangThaiHD(MAHD.Trim()) == 0)
                    {
                        MessageBox.Show("Bạn không có quyền xóa hóa đơn đã thanh toán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        int kq = db.getNonQuery("DELETE CHITIET_HOADON_SP WHERE MAHD ='" + MAHD + "'");
                        kq = db.getNonQuery("DELETE CHITIET_HOADON_DV WHERE MAHD ='" + MAHD + "'");
                        kq = db.getNonQuery("DELETE HOADON WHERE MAHD ='" + MAHD + "'");
                        if (Show == 0) dt = db.getDataTable("select * from HOADON where NgayLap is null");
                        else dt = db.getDataTable("select * from HOADON");
                        LoadHoaDon();
                    }
                }
            }
        }
        #endregion
        #region RadioButton
        private void cbPaid_CheckedChanged(object sender, EventArgs e)
        {
            Show = 0;
            string query = "select * from HOADON where NgayLap is null";
            if (cbAll.Checked)
            { query = "select * from HOADON"; Show = 1; }
            else if (cbPaid.Checked)
            { query = "select * from HOADON where NgayLap is not null"; Show = 2; }
            dt = db.getDataTable(query);
            LoadHoaDon();
        }
        #endregion
        #region TextBox
        private void txbNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbNameSearch.Text.Trim().Length > 0)
            {
                if (Show == 0) dt = db.getDataTable("select HOADON.* from HOADON,KHACHHANG where NgayLap is null and KHACHHANG.MAKH = HOADON.MAKH and HOTEN like '%" + txbNameSearch.Text + "%'");
                else dt = db.getDataTable("select HOADON.* from HOADON,KHACHHANG where KHACHHANG.MAKH = HOADON.MAKH and HOTEN like '%" + txbNameSearch.Text + "%'");
            }
            else
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NgayLap is null");
                else dt = db.getDataTable("select * from HOADON");
            
            }
            LoadHoaDon();
        }
  
        private void txbIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbIDSearch.Text.Trim().Length > 0)
            {
                if (Show == 0) dt = db.getDataTable("select HOADON.* from HOADON,KHACHHANG where NgayLap is null and KHACHHANG.MAKH = HOADON.MAKH and KHACHHANG.MAKH like '%" + txbIDSearch.Text + "%'");
                else dt = db.getDataTable("select HOADON.* from HOADON,KHACHHANG where KHACHHANG.MAKH = HOADON.MAKH and KHACHHANG.MAKH like '%" + txbIDSearch.Text + "%'");
            }
            else
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NgayLap is null");
                else dt = db.getDataTable("select * from HOADON");

            }
            LoadHoaDon();
        }
        #endregion
        #region InsertBill
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable d = db.getDataTable("select Max(CONVERT(int,SUBSTRING(MAHD,3,3)))+1 as MAX  from hoadon");
            string mahd = "'HD";
            int max = Convert.ToInt32(d.Rows[0]["MAX"].ToString());
            if (max < 10) mahd += "00" + max + "',"; 
            else if (max < 100) mahd += "0" + max + "',";
            else mahd += "" + max + "',";

            string qr = "insert HOADON values("+mahd+ "null,null,'"+MaNhanVien+"'" + ")";
            int kq = db.getNonQuery(qr);
            if (Show == 0) dt = db.getDataTable("select * from HOADON where NgayLap is null");
            else dt = db.getDataTable("select * from HOADON");
            LoadHoaDon();
        }

        #endregion
        #region SapXep
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (Des == 0)
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NGAYLAP is null  order by (select DBO.TONGTIEN_HOADON(MAHD))  asc ");
                else dt = db.getDataTable("select * from HOADON  order by (select DBO.TONGTIEN_HOADON(MAHD))  asc");
                LoadHoaDon();
                Des = 1;
            }
            else
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NGAYLAP is null  order by (select DBO.TONGTIEN_HOADON(MAHD))  desc ");
                else dt = db.getDataTable("select * from HOADON  order by (select DBO.TONGTIEN_HOADON(MAHD))  desc");
                LoadHoaDon();
                Des = 0;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (Des == 0)
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NGAYLAP is null  order by (select DBO.TONGTIEN_HOADON(MAHD))  asc ");
                else dt = db.getDataTable("select * from HOADON  order by (select DBO.TONGTIEN_HOADON(MAHD))  asc");
                LoadHoaDon();
                Des = 1;
            }
            else
            {
                if (Show == 0) dt = db.getDataTable("select * from HOADON where NGAYLAP is null  order by (select DBO.TONGTIEN_HOADON(MAHD))  desc ");
                else dt = db.getDataTable("select * from HOADON  order by (select DBO.TONGTIEN_HOADON(MAHD))  desc");
                LoadHoaDon();
                Des = 0;
            }
        }
        #endregion
    }
}
