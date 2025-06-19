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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLy_Spa
{
    public partial class QLPhong : Form
    {
        public QLPhong(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            dtgvDichVu_Phong.AutoGenerateColumns = false;
            foreach(DataGridViewColumn cl in dtgvDichVu_Phong.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select MAPH ,TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV order by (substring(PDV.MAPH,2,3)) asc");
        }

        TrangChuQL QL;
        int row = -1;
        ConnectDB db = new ConnectDB();
        string MALDV = "LDV001";
        int tang = 0;
        int trangthai = 2;
        void LoadTable(string query)
        {
            DataTable dt = db.getDataTable(query);
            dtgvDichVu_Phong.DataSource = dt;
            int j = 0;
            foreach (DataRow r in dt.Rows)
            {

                if (r["TRANGTHAI"].ToString() == "0")
                {
                    r["TRANGTHAI"] = "Trống";
                    dtgvDichVu_Phong.Rows[j].Cells[3].Style.ForeColor = Color.DarkGreen;
                }
                else
                {
                    r["TRANGTHAI"] = "Đang hoạt động";
                    dtgvDichVu_Phong.Rows[j].Cells[3].Style.ForeColor = Color.DarkRed;
                }
                dtgvDichVu_Phong.Rows[j].Cells[2].Value = string.Format("{0:0,0}", Convert.ToInt32(r["GIA"].ToString().Trim()));
                j++;
            }
            dtgvDichVu_Phong.CurrentCell = null;
        }
        private void QLDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select * from loai_dichvu");
            cbbLoaiDV.DataSource = dt;
            cbbLoaiDV.DisplayMember = "TENDV";
            cbbLoaiDV.ValueMember = "MALOAIDV";
            cbbViTri.Items.Add("...Tất cả...");
            cbbViTri.Items.Add("Tầng " + 1);
            cbbViTri.Items.Add("Tầng " + 2);
            cbbViTri.Items.Add("Tầng " + 3);
            cbbViTri.SelectedIndex = cbbLoaiDV.SelectedIndex = 0;
            LoadTable("select MAPH , TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV order by (substring(PDV.MAPH,2,3)) asc");
            
        }
        #region radiobutton
        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked) trangthai = 1;
            else if (rbRest.Checked) trangthai = 0;
            else trangthai = 2;
            string qr = "select MAPH ,TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV";
            if (trangthai == 2) qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "'";
            else qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "' and PDV.TRANGTHAI = " + trangthai;

            if (tang == 0) qr += " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            else qr += " and substring(PDV.MAPH,2,1)=" + tang + " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            LoadTable(qr);
        }
        #endregion
        private void dtgvDichVu_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            string MaPH = dtgvDichVu_Phong.Rows[row].Cells[0].Value.ToString().Trim();
            if (dtgvDichVu_Phong.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                QL.Detail_Calendar_Click(MaPH, 0);
            }
            else if (dtgvDichVu_Phong.Columns[e.ColumnIndex].Name == "CapNhat")
            {
                if (dtgvDichVu_Phong.Rows[row].Cells[3].Value.ToString().Trim() == "Đang hoạt động")
                {
                    MessageBox.Show("Phòng đang trong trạng thái hoạt động\nVui lòng chờ đến khi hoàn tất việc phục vụ khách hàng để tiến hành cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else  QL.Detail_Calendar_Click(MaPH, 2);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            txbSearch.Text = "Tra cứu theo tên";
            txbSearch.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            txbSearch.ForeColor = Color.Gray;
            txbSearch.Enabled = false;
            txbSearch.Enabled = true;
            cbbViTri.SelectedIndex = cbbLoaiDV.SelectedIndex = 0;
            LoadTable("select MAPH ,TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV order by (substring(PDV.MAPH,2,3)) asc");
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH DỊCH VỤ\n\n";
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA from DICHVU");
            foreach (DataRow r in dt.Rows)
            {
                text += string.Format("{0,-10} - {1,-40} - {2,-10}\n\n\n", r["MADV"].ToString().Trim(), r["TENDV"].ToString().Trim(), string.Format("{0:0,0 VND}", Convert.ToInt32(r["GIA"].ToString().Trim())));
            }
            PDF p = new PDF(text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã dịch vụ", "Tên dịch vụ", "Giá" };
            DataTable dt = db.getDataTable("select MADV, TENDV,GIA from DICHVU");
            Excel ex = new Excel(h, dt);
        }
        #region tim kiem theo ten
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
            if (t.Text.Trim().Length == 0 || t.Text == "Tra cứu theo tên")
            { LoadTable("select MAPH , TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV order by (substring(PDV.MAPH,2,3)) asc"); }
            else LoadTable("select MAPH , TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV where PDV.MADV = DV.MADV and DV.TENDV like'%" + txbSearch.Text+"%'");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(db.getDataTable("select max(substring(MAPH,3,2)) as 'MAX' from PHONG_DICHVU where substring(MAPH,2,1) = 1").Rows[0]["MAX"].ToString().Trim());
            kq += 1;
            string MaPh = "P1" + kq;
            if (kq < 10) MaPh = "P10" + kq;
            QL.Detail_Calendar_Click(MaPh,1);
        }

        private void cbbLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MALDV = cbbLoaiDV.SelectedValue.ToString().Trim();
            string qr = "select MAPH ,TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV";
            if (trangthai == 2) qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "'";
            else qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "' and PDV.TRANGTHAI = " + trangthai;
            if (tang == 0) qr += " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            else qr += " and substring(PDV.MAPH,2,1)=" + tang + " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            LoadTable(qr);
        }

        private void cbbViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            tang = cbbViTri.SelectedIndex;
            string qr = "select MAPH ,TENDV,DV.GIA,PDV.TRANGTHAI from PHONG_DICHVU PDV, DICHVU DV";
            if (trangthai == 2)  qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "'";
            else qr += " where PDV.MADV = DV.MADV and DV.MALOAIDV = '" + MALDV + "' and PDV.TRANGTHAI = " + trangthai;

            if (tang == 0) qr += " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            else qr += " and substring(PDV.MAPH,2,1)=" + tang + " group by MAPH ,MAPH , DV.TENDV,DV.GIA,PDV.TRANGTHAI";
            LoadTable(qr);
        }
    }
}
