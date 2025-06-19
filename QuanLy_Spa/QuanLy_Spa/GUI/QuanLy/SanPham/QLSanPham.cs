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

namespace QuanLy_Spa.GUI.QuanLy.SanPham
{
    public partial class QLSanPham : Form
    {
        public QLSanPham(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            dtgvSanPham.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvSanPham.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from sanpham");
        }
        ConnectDB db = new ConnectDB();
        DataTable dtpd = new DataTable();
        TrangChuQL QL;
        void LoadTable(string qr)
        {
            DataTable dt = db.getDataTable(qr);
            dtgvSanPham.DataSource = dt;
            int j = 0;
            foreach (DataRow r in dt.Rows)
            {
                dtgvSanPham.Rows[j].Cells[2].Value = string.Format("{0:0,0 vnd}", Convert.ToInt32(r["GIATIEN"].ToString().Trim()));
                j++;
            }
        }
        private void QLSanPham_Load(object sender, EventArgs e)
        {
            LoadTable("select * from sanpham");
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH DỊCH VỤ\n\n";
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA from DICHVU");
            foreach (DataRow r in dt.Rows)
            {
                text += string.Format("{0,-10} - {1,-40} - {2,-10}\n\n\n", r["MADV"].ToString().Trim(), r["TENDV"].ToString().Trim(),string.Format("{0:0,0 VND}",Convert.ToInt32(r["GIA"].ToString().Trim())));
            }
            PDF p = new PDF(text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã dịch vụ", "Tên dịch vụ", "Giá" };
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA from DICHVU");
            Excel ex = new Excel(h, dt);
        }

        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string MaSP = dtgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            if (dtgvSanPham.Columns[e.ColumnIndex].Name == "Detail")
            {
                QL.Deatil_Product_Click(0, MaSP);
            }
            else if (dtgvSanPham.Columns[e.ColumnIndex].Name == "Update")
            {
                QL.Deatil_Product_Click(2, MaSP);
            }
        }

        #region timkiem
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTable("select * from sanpham");
            txbSearch.Text = "Tra cứu theo tên";
            txbSearch.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            txbSearch.ForeColor = Color.Gray;
            txbSearch.Enabled = false;
            txbSearch.Enabled = true;
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length == 0 || t.Text == "Tra cứu theo tên")
            { LoadTable("SELECT* FROM SANPHAM"); }
            else LoadTable("SELECT * FROM SANPHAM where TENSP like '%" + txbSearch.Text + "%'");
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

        private void btnAddC_Click(object sender, EventArgs e)
        {
            string max = db.getDataTable("select MAX(CONVERT(int,SUBSTRING(MASP,3,3))) AS MAX from SANPHAM ").Rows[0]["MAX"].ToString();
            int MAX = Convert.ToInt32(max.Trim()) + 1;
            string MaSP = "";
            if (MAX < 10) MaSP = "SP00" + MAX;
            else if (MAX < 100) MaSP = "SP0" + MAX;
            else MaSP = "SP" + MAX;
            QL.Deatil_Product_Click(1, MaSP);
        }
    }
}
