
using QuanLy_Spa.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLy_Spa.DuLieu;

namespace QuanLy_Spa
{
    public partial class KhachHangF : Form
    {

        public KhachHangF(TrangChuNV tt)
        {
            InitializeComponent();
            TT = tt;
            dtgvKhachHang.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvKhachHang.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        TrangChuNV TT;
        ConnectDB db = new ConnectDB();
        public static int status = 0;
        #region Function
        void LoadViewGroup(string query)
        {
            DataTable dskh = db.getDataTable(query);
            dtgvKhachHang.DataSource = dskh;
        }
        string CreateID()
        {
            DataTable dt = db.getDataTable("select MAX(substring(MAKH,3,3)) as MAX from khachhang");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["MAX"].ToString();
            if (Convert.ToInt32(n) < 10) return "KH00" + (Convert.ToInt32(n)+1);
            else if (Convert.ToInt32(n) < 100) return "KH0"+(Convert.ToInt32(n) + 1);
            else return "KH"+(Convert.ToInt32(n) + 1);
        }
        #endregion
        private void KhachHangF_Load(object sender, EventArgs e)
        {
            DataTable dtkh = db.getDataTable("select * from KHACHHANG");
            dtgvKhachHang.DataSource = dtkh;
            status = 0;
        }
        private void btnAddC_Click(object sender, EventArgs e)
        {
            string MAKH = CreateID();
            TT.Add_Customer_Click(1,MAKH);
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH KHÁCH HÀNG\n\n";
            DataTable dt = db.getDataTable("select MAKH, HOTEN,GIOITINH,PHANLOAI,NGSINH,SDT,EMAIL,DIACHI from Khachhang");
            foreach(DataRow r in dt.Rows)
            {
                text += string.Format("{0,-10} - {1,-30} - {2,-7} - {3,-15} - {4,-7} - {5,-15} - {6,-15} - {7,-30}\n\n\n", r["MAKH"].ToString().Trim(), r["HOTEN"].ToString().Trim(), r["GIOITINH"].ToString().Trim(), r["PHANLOAI"].ToString().Trim(), Convert.ToDateTime(r["NGSINH"]).ToString("dd/MM/yyyy").Trim(), r["SDT"].ToString().Trim(), r["EMAIL"].ToString().Trim(), r["DIACHI"].ToString().Trim());
            }
            PDF p = new PDF(text);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã khách hàng","Họ tên","Giới tính","Phân loại","Ngày sinh","SĐT","Email","Địa chỉ" };
            DataTable dt = db.getDataTable("select MAKH, HOTEN,GIOITINH,PHANLOAI,NGSINH,SDT,EMAIL,DIACHI from Khachhang");
            Excel ex = new Excel(h,dt);
        }
        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Detail")
                {
                    string MAKH = dtgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    TT.Add_Customer_Click(0,MAKH);
                }
                else if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Update")
                {
                    string MAKH = dtgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    TT.Add_Customer_Click(2,MAKH);
                }
                else if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Delete")
                {
                    MessageBox.Show("Xóa thất bại!!!\nBạn không có quyền xóa thông tin khách hàng\nVui lòng liên hệ quản lý để xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "Tra cứu theo tên";
            txbSearch.Font = new Font("Times New Roman", 11, FontStyle.Italic);
            txbSearch.ForeColor = Color.Gray;
            txbSearch.Enabled = false;
            txbSearch.Enabled = true;
            LoadViewGroup("SELECT * FROM KHACHHANG");
        }
        #region Tra cứu theo tên
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length == 0 || t.Text == "Tra cứu theo tên")
            { LoadViewGroup("SELECT* FROM KHACHHANG"); }
            else LoadViewGroup("SELECT * FROM DBO.DANHSACH_KHACH_THEO_TEN('%" + txbSearch.Text + "%')");
        }
        private void txbSearch_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length < 1)
            {
                t.Text = "Tra cứu theo tên";
                t.Font = new Font("Times New Roman", 12, FontStyle.Italic);
                t.ForeColor = Color.Gray;
                t.Enabled = false;
                t.Enabled = true;
            }
        }
        private void txbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text == "Tra cứu theo tên")
            {
                t.Text = "";
                t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                t.ForeColor = Color.Black;
                t.Enabled = true;
            }
        }
        #endregion
    }
}
