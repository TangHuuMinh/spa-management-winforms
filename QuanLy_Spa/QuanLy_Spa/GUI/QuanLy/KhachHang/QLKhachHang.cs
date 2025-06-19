using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.QuanLy.KhachHang
{
    public partial class QLKhachHang : Form
    {
        public QLKhachHang(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            dtgvKhachHang.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvKhachHang.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        public static int status = 0;
        void LoadViewGroup(string query)
        {
            DataTable dskh = db.getDataTable(query);
            dtgvKhachHang.DataSource = dskh;
        }
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtkh = db.getDataTable("select * from KHACHHANG");
            dtgvKhachHang.DataSource = dtkh;
            status = 0;
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH KHÁCH HÀNG\n\n";
            DataTable dt = db.getDataTable("select MAKH, HOTEN,GIOITINH,PHANLOAI,NGSINH,SDT,EMAIL,DIACHI from Khachhang");
            foreach (DataRow r in dt.Rows)
            {
                text += string.Format("{0,-10} - {1,-30} - {2,-7} - {3,-15} - {4,-7} - {5,-15} - {6,-15} - {7,-30}\n\n\n", r["MAKH"].ToString().Trim(), r["HOTEN"].ToString().Trim(), r["GIOITINH"].ToString().Trim(), r["PHANLOAI"].ToString().Trim(), Convert.ToDateTime(r["NGSINH"]).ToString("dd/MM/yyyy").Trim(), r["SDT"].ToString().Trim(), r["EMAIL"].ToString().Trim(), r["DIACHI"].ToString().Trim());
            }
            PDF p = new PDF(text);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã khách hàng", "Họ tên", "Giới tính", "Phân loại", "Ngày sinh", "SĐT", "Email", "Địa chỉ" };
            DataTable dt = db.getDataTable("select MAKH, HOTEN,GIOITINH,PHANLOAI,NGSINH,SDT,EMAIL,DIACHI from Khachhang");
            Excel ex = new Excel(h, dt);
        }
        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string MAKH = dtgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Detail")
                {
                    QL.Detail_Customer_Click(MAKH);
                }
                else if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Send")
                {
                    string mail = db.getDataTable("select EMAIL from KHACHHANG WHERE MAKH = '" + MAKH + "'").Rows[0]["EMAIL"].ToString().Trim();
                    QL.SendMail_Customer_Click(mail);
                }
                else if (dtgvKhachHang.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn muốn xóa khách hàng " + MAKH, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        int k = db.getScalar("select count(*) from lich_hen where makh = '" + MAKH + "'");
                        if (k == 0)
                        {
                            int kq = db.getNonQuery("Delete KHACHHANG where MAKH = '" + MAKH + "'");
                            MessageBox.Show("Xóa thành công!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadViewGroup("SELECT * FROM KHACHHANG");
                        }
                        else MessageBox.Show("Khách hàng" + MAKH + " đang có lịch hẹn chưa hoàn thành ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
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
