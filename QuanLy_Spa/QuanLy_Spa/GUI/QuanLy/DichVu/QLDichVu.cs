using QuanLy_Spa.GUI.QuanLy;
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
using System.Xml.Linq;

namespace QuanLy_Spa.QuanLy
{
    public partial class QLDichVu : Form
    {
        public QLDichVu(TrangChuQL ql)
        {
            InitializeComponent();
            dtgvDichVu.AutoGenerateColumns = false;
            QL = ql;
            foreach(DataGridViewColumn cl in dtgvDichVu.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from dichvu");
        }
        ConnectDB db = new ConnectDB();
        DataTable dtsv = new DataTable();
        TrangChuQL QL;
        string MALDV = "";

        void LoadTable(string qr)
        {      
            dtsv = db.getDataTable(qr);
            dtgvDichVu.DataSource = dtsv;
            int i = 0;
            foreach(DataRow r in dtsv.Rows)
            {
                if (r["TRANGTHAI"].ToString().Trim() == "1")
                {
                    dtgvDichVu.Rows[i].Cells[2].Value = "Hoạt động";
                }
                else
                {
                    dtgvDichVu.Rows[i].Cells[2].Value = "Ngưng hoạt động";
                }
                i++;
            }
        }
        private void QLDichVu_Load(object sender, EventArgs e)
        {
            LoadTable("select * from dichvu");
        }

        // them dich vu
        private void btnAddC_Click(object sender, EventArgs e)
        {
            string max = db.getDataTable("select MAX(CONVERT(int,SUBSTRING(MADV,3,3))) AS MAX from DICHVU ").Rows[0]["MAX"].ToString();
            int MAX = Convert.ToInt32(max.Trim()) + 1;
            string MaDV = "";
            if (MAX < 10) MaDV = "DV00" + MAX;
            else if (MAX < 100) MaDV = "DV0" + MAX;
            else MaDV = "DV" + MAX;
            QL.Deatil_Service_Click(1, MaDV);

        }

        // xuat pdf
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH DỊCH VỤ\n\n";
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA,TRANGTHAI from DICHVU");
            foreach (DataRow r in dt.Rows)
            {
                string tt = (r["TRANGTHAI"].ToString().Trim() == "1") ? "Đang hoạt động" : "Ngừng";
                text += string.Format("{0,-10} - {1,-40} - {2,-15} - {3,-15} \n\n\n", r["MADV"].ToString().Trim(), r["TENDV"].ToString().Trim(), r["GIA"].ToString().Trim(), tt);
            }
            PDF p = new PDF(text);
        }

        //xuat excel
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] {"Mã dịch vụ","Tên dịch vụ","Giá","Trạng thái"};
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA,TRANGTHAI from DICHVU");
            Excel ex = new Excel(h, dt);

        }
        //load lai danh sach dich vu
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTable("select * from dichvu");
            txbSearch.Text = "Tra cứu theo tên";
            txbSearch.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            txbSearch.ForeColor = Color.Gray;
            txbSearch.Enabled = false;
            txbSearch.Enabled = true;
        }
        #region tim kiemdich vu theo ten
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length == 0 || t.Text == "Tra cứu theo tên")
            { LoadTable("SELECT* FROM DICHVU"); }
            else LoadTable("SELECT * FROM DICHVU where TENDV like '%" + txbSearch.Text + "%'");
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
        private void dtgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string MaDV = dtgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            if (dtgvDichVu.Columns[e.ColumnIndex].Name == "Detail")
            {
                QL.Deatil_Service_Click(0, MaDV);
            }
            else if (dtgvDichVu.Columns[e.ColumnIndex].Name == "Update")
            {
                QL.Deatil_Service_Click(2, MaDV);
            }
        }
    }
}
