using QuanLy_Spa.GUI.QuanLy;
using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien(TrangChuQL ql,string maql)
        {
            InitializeComponent();
            QL = ql;
            MAQL = maql;
            dtgvNhanVien.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvNhanVien.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from nhanvien order by TRANGTHAI desc");
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        string MAQL = "";
        void LoadTable(string qr)
        {

            DataTable dt = db.getDataTable(qr);
            dtgvNhanVien.DataSource = dt;
            int i = 0;
            foreach(DataRow r in dt.Rows)
            {
                if (r["TRANGTHAI"].ToString().Trim() == "1")
                {
                    dtgvNhanVien.Rows[i].Cells[4].Value = "Hợp tác";
                }
                else dtgvNhanVien.Rows[i].Cells[4].Value = "Ngưng";
                i++;
            }
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadTable("select * from nhanvien order by TRANGTHAI desc");
        }
        private void btnAddC_Click(object sender, EventArgs e)
        {
            string max = db.getDataTable("select MAX(CONVERT(int,SUBSTRING(MANV,3,3))) AS MAX from NHANVIEN ").Rows[0]["MAX"].ToString();
            int MAX = Convert.ToInt32(max.Trim()) + 1;
            string MaNV = "";
            if (MAX < 10) MaNV = "NV00" + MAX;
            else if (MAX < 100) MaNV = "NV0" + MAX;
            else MaNV = "NV" + MAX;
            QL.Detail_Staff_Click(MaNV, 1);
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH NHÂN VIÊN\n\n";
            DataTable dt = db.getDataTable("select MANV, HOTEN,GIOITINH,CHUCVU,NGSINH,SDT,EMAIL,CCCD,TAIKHOAN_NGHG,DIACHI from NHANVIEN");
            foreach (DataRow r in dt.Rows)
            {
                text += string.Format("{0,-10} - {1,-30} - {2,-7} - {3,-15} - {4,-7} - {5,-15} - {6,-15} - {7,15} - {8,-15} - {9,-30}\n\n\n", r["MANV"].ToString().Trim(), r["HOTEN"].ToString().Trim(), r["GIOITINH"].ToString().Trim(), r["CHUCVU"].ToString().Trim(), Convert.ToDateTime(r["NGSINH"]).ToString("dd/MM/yyyy").Trim(), r["SDT"].ToString().Trim(), r["EMAIL"].ToString().Trim(), r["CCCD"].ToString().Trim(), r["TAIKHOAN_NGHG"].ToString().Trim(), r["DIACHI"].ToString().Trim());
            }
            PDF p = new PDF(text);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã nhân viên", "Họ tên", "Giới tính", "Chức vụ", "Ngày sinh", "SĐT", "Email","CCCD","Tài khoản ngân hàng", "Địa chỉ" ,"Trạng thái"};
            DataTable dt = db.getDataTable("select MANV, HOTEN,GIOITINH,CHUCVU,NGSINH,SDT,EMAIL,CCCD,TAIKHOAN_NGHG,DIACHI,TRANGTHAI from NHANVIEN");
            Excel ex = new Excel(h, dt);
        }
        #region Load lai du lieu
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTable("select * from nhanvien order by TRANGTHAI desc");
            txbSearch.Text = "Tra cứu theo tên";
            txbSearch.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            txbSearch.ForeColor = Color.Gray;
            txbSearch.Enabled = false;
            txbSearch.Enabled = true;
        }
        #endregion
        #region tra cuu theo ten nhan vien
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length == 0 || t.Text == "Tra cứu theo tên")
            { LoadTable("SELECT* FROM NHANVIEN order by TRANGTHAI desc"); }
            else LoadTable("SELECT * FROM NHANVIEN where HOTEN like '%" + txbSearch.Text + "%' order by TRANGTHAI desc");
        }
        private void txbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;

            if (t.Text == "Tra cứu theo tên")
            {
                t.Text = "";
                t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                t.ForeColor = Color.Black;
            }
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
        #endregion
        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string MaNV = dtgvNhanVien.Rows[row].Cells[0].Value.ToString().Trim();
            string Ten = db.getDataTable("select HOTEN from nhanvien where manv = '" + MaNV + "'").Rows[0]["HOTEN"].ToString().Trim();
            if (dtgvNhanVien.Columns[e.ColumnIndex].Name == "Capnhat")
            {
                if (MaNV.Substring(0, 2) != "QL" || MaNV == MAQL)
                {
                   QL.Detail_Staff_Click(MaNV, 2);
                }
                else
                {
                    MessageBox.Show("Bạn và " + Ten + " đồng cấp bậc quản lý nên không thể tiến hành cập nhật", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dtgvNhanVien.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                if (MaNV.Substring(0, 2) == "NV")
                {
                    if (MessageBox.Show("Bạn muốn cấp lại mật khẩu nhân viên " + MaNV, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        MessageBox.Show("Cấp lại mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int kq = db.getNonQuery("update TAIKHOAN set Matkhau = '" + MaNV + "' where MANV = '" + MaNV + "'");
                    }
                }
                else MessageBox.Show("Mật khẩu của cấp quản lý không được phép cấp lại bằng cách này", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtgvNhanVien.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                QL.Detail_Staff_Click(MaNV, 0);
            }
        }
    }
}
