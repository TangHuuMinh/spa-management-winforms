using OfficeOpenXml.Export.HtmlExport.StyleCollectors.StyleContracts;
using Org.BouncyCastle.Crmf;
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
using static iTextSharp.text.pdf.PdfDocument;

namespace QuanLy_Spa.GUI.NhanVien.ThanhToan
{
    public partial class DetailBill : Form
    {
        public DetailBill(TrangChuNV tt,string manv,string mahd)
        {
            InitializeComponent();
            dtgvService.AutoGenerateColumns = false;
            dtgvProduct.AutoGenerateColumns = false;
            TT = tt;
            MANV = manv;
            MAHD = mahd;
            LoadChitiet(MAHD);
        }
        TrangChuNV TT;
        string MANV, MAHD;
        ConnectDB db = new ConnectDB();
        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            TT.Paid_Click(sender, e);
        }
        private void lbExit_Click(object sender, EventArgs e)
        {
            TT.Paid_Click(sender, e);
        }
        #endregion
        string GetNameProduct(string masp)
        {
            DataTable d = db.getDataTable("select * from sanpham where masp = '" + masp + "'");
            foreach (DataRow row in d.Rows)
            {
                return row["TENSP"].ToString();
            }
            return "";
        }
        string GetNameService(string madv)
        {
            DataTable d = db.getDataTable("select * from dichvu where madv = '" + madv + "'");
            foreach (DataRow row in d.Rows)
            {
                return row["TENDV"].ToString();
            }
            return "";
        }
        void LoadChitiet(string mahd)
        {
            DataTable dtsp = db.getDataTable("select * from CHITIET_HOADON_SP where MAHD = '" + mahd + "'");
            DataTable dtdv = db.getDataTable("select * from CHITIET_HOADON_DV where MAHD = '" + mahd + "'");
            dtgvProduct.DataSource = dtsp;
            dtgvService.DataSource = dtdv;
            int TongTien = Convert.ToInt32(db.getScalar("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON('" + mahd + "') SELECT @SUM"));
            lbTotalPrice.Text = string.Format("{0:0,0 VNĐ}", TongTien);
            if (dtgvProduct.RowCount == 0)
            {
                dtgvService.Location = new Point(12, 254);
                dtgvProduct.Visible = false;
            }
            if (dtgvService.RowCount == 0) dtgvService.Visible = false;
            int i = 0;
            foreach (DataRow row in dtsp.Rows)
            {
                dtgvProduct.Rows[i].Cells[1].Value = GetNameProduct(row["MASP"].ToString().Trim()).ToString();
                int sl = Convert.ToInt32(row["SOLUONG"].ToString().Trim());
                int g = Convert.ToInt32(row["GIA"].ToString().Trim());
                dtgvProduct.Rows[i].Cells[2].Value = string.Format("{0:0,0}", g);
                dtgvProduct.Rows[i].Cells[4].Value = string.Format("{0:0,0}", (g * sl));
                i++;
            }
            i = 0;
            foreach (DataRow row in dtdv.Rows)
            {
                dtgvService.Rows[i].Cells[3].Value = "1";
                int g = Convert.ToInt32(row["GIA"].ToString().Trim());
                dtgvService.Rows[i].Cells[2].Value = string.Format("{0:0,0}", g);
                dtgvService.Rows[i].Cells[1].Value = GetNameService(row["MADV"].ToString().Trim()).ToString();
                dtgvService.Rows[i].Cells[4].Value = string.Format("{0:0,0}", g);
                i++;
            }
        }
        private void DetailBill_Load(object sender, EventArgs e)
        {
            txbIDStaff.Text = MANV;
            txbDate.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
            DataTable dt = db.getDataTable("select * from Khachhang");
            cbbMAKH.Items.Add("Trống");
            foreach (DataRow r in dt.Rows)
                cbbMAKH.Items.Add(r["MAKH"].ToString().Trim());
            LoadChitiet(MAHD);
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvProduct.Columns[e.ColumnIndex].Name == "Delete")
            {
                int kq = db.getNonQuery("DELETE CHITIET_HOADON_SP WHERE MAHD ='" + MAHD + "' AND MASP = '" + dtgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() + "'");
                LoadChitiet(MAHD);
            }
        }

        private void dtgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvService.Columns[e.ColumnIndex].Name == "Xoa")
            {
                int kq = db.getNonQuery("DELETE CHITIET_HOADON_DV WHERE MAHD ='" + MAHD + "' AND MADV = '" + dtgvService.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() + "'");
                LoadChitiet(MAHD);
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            int kq = db.getScalar("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON('" + MAHD + "') SELECT @SUM");
            if (kq > 0)
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn " + MAHD + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    int rs = db.getNonQuery("UPDATE HOADON SET NGAYLAP = GETDATE() WHERE MAHD = '" + MAHD + "'");
                    rs = db.getNonQuery("UPDATE HOADON SET MANV = '"+MANV+"' WHERE MAHD = '" + MAHD + "'");
                    if (cbbMAKH.SelectedIndex > 0) rs = db.getNonQuery("UPDATE HOADON SET MAKH ='" + cbbMAKH.SelectedItem.ToString() + "' WHERE MAHD = '" + MAHD + "'");
                    DataTable dt = db.getDataTable("select * from CHITIET_HOADON_DV where MAHD = '" + MAHD + "'");
                    foreach(DataRow r in dt.Rows)
                    {
                        kq = db.getNonQuery("update phong_dichvu set trangthai = 0 where maph = '" + r["MAPH"].ToString().Trim() + "'");
                    }
                    MessageBox.Show("Thanh toán thành công","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TT.Paid_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn cần chứa ít nhất 1 sản phẩm hoặc dịch vụ để thanh toán","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void cbbMAKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMAKH.SelectedIndex==0)
            {
                txbNameC.Text = "";
            }
            else if(cbbMAKH.SelectedIndex>0)
            {
                txbNameC.Text = db.getDataTable("select HOTEN from khachhang where MAKH = '" + cbbMAKH.SelectedItem.ToString() + "'").Rows[0]["HOTEN"].ToString().Trim();
            }
        }
        
    }
}
