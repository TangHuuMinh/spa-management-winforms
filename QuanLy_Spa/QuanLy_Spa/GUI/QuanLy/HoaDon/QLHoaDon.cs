using OfficeOpenXml.Style;
using OfficeOpenXml;
using QuanLy_Spa.GUI.QuanLy;
using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLy_Spa
{
    public partial class QLHoaDon : Form
    {
        public QLHoaDon(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            foreach (DataGridViewColumn cl in dtgvHoaDon.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dtgvHoaDon.AutoGenerateColumns = false;
            LoadTable("select * from HOADON where ngaylap is not null");
        }
        DataTable dthd = new DataTable();
        ConnectDB db = new ConnectDB();
        string IDBILL = "";
        int Des = 0;
        TrangChuQL QL;
        void LoadTable(string qr)
        {
            DataTable dt = db.getDataTable(qr);
            dtgvHoaDon.DataSource = dt;
            int i = 0;
            foreach(DataRow r in dt.Rows)
            {
                int kq = db.getScalar("select count(*) from khachhang where  MAKH = '" + r["MAKH"].ToString().Trim() + "'");
                if (kq > 0)
                {
                    dtgvHoaDon.Rows[i].Cells[1].Value = db.getDataTable("select HOTEN from khachhang where MAKH = '" + r["MAKH"].ToString().Trim() + "'").Rows[0]["HOTEN"].ToString().Trim();
                    
                }
                else dtgvHoaDon.Rows[i].Cells[1].Value = "Khách vãng lai";
                string MAHD = r["MAHD"].ToString().Trim();
                int TongTien = Convert.ToInt32(db.getScalar("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON('" + MAHD + "') SELECT @SUM"));
                dtgvHoaDon.Rows[i].Cells[4].Value = string.Format("{0:0,0 vnd}", TongTien);
                i++;
            }
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtnv = db.getDataTable("select * from nhanvien where MaNV like 'NV%'");
            cbbStaff.DataSource = dtnv;
            cbbStaff.DisplayMember = "HOTEN";
            cbbStaff.ValueMember = "MANV";
            cbbStaff.SelectedIndex = 0;
            LoadTable("select * from HOADON where ngaylap is not null");
        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MAHD = dtgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dtgvHoaDon.Columns[e.ColumnIndex].Name == "TongTien")
            {
                QL.Detail_Bills_Click(MAHD);
            }
        }
        private void ListB_Click(object sender, EventArgs e)
        {
            LoadTable("select * from HOADON where ngaylap is not null");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string manv = cbbStaff.SelectedValue.ToString().Trim();
            string bd = string.Format("{0:MM-dd-yyyy}", dtpkStart.Value.ToString());
            string kt = string.Format("{0:MM-dd-yyyy}", dtpkEnd.Value.ToString());
            LoadTable("SELECT * FROM HOADON WHERE MANV = '"+manv+"' AND NGAYLAP>= '"+bd+ "' AND NGAYLAP<='"+kt+"'");
        }

        private void TimeAsc_Click(object sender, EventArgs e)
        {
            LoadTable("select * from HOADON where ngaylap is not null order by NGAYLAP asc");
        }

        private void TimeDesc_Click(object sender, EventArgs e)
        {
            LoadTable("select * from HOADON where ngaylap is not null order by NGAYLAP desc");
        }

        private void printP_Click(object sender, EventArgs e)
        {
            string text = "\t\t\tDANH SÁCH HÓA ĐƠN\n\n";
            int i = 0;
            foreach (DataRow r in (dtgvHoaDon.DataSource as DataTable).Rows)
            {
                string mahd = dtgvHoaDon.Rows[i].Cells[0].Value.ToString().Trim();
                string ten = dtgvHoaDon.Rows[i].Cells[1].Value.ToString().Trim();
                string manv = dtgvHoaDon.Rows[i].Cells[2].Value.ToString().Trim();
                string thoigian = dtgvHoaDon.Rows[i].Cells[3].Value.ToString().Trim();
                string tongtien = dtgvHoaDon.Rows[i].Cells[4].Value.ToString().Trim();
                text += string.Format("{0,-10} - {1,-30} - {2,-10} - {3,-10} - {4,-10} \n\n\n",mahd,ten,manv,thoigian,tongtien);
                i++;
            }
            PDF p = new PDF(text);
        }

        private void printE_Click(object sender, EventArgs e)
        {
            string[] h = new string[] { "Mã hóa đơn", "Khách hàng", "nhân viên thanh toán", "Thời gian", "Thành tiền"};
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu file Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                    for (int i = 0; i < h.Length; i++)
                        worksheet.Cells[1, i + 1].Value = h[i];
                    for (int i = 0; i < dtgvHoaDon.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgvHoaDon.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dtgvHoaDon.Rows[i].Cells[j].Value.ToString().Trim();
                        }
                    }
                    using (var range = worksheet.Cells[1, 1, 1, 3])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }
                    worksheet.Cells.AutoFitColumns();
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("File Excel đã được tạo thành công tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MoneyAsc_Click(object sender, EventArgs e)
        {
            LoadTable("select * from HOADON where ngaylap is not null order by (DBO.TONGTIEN_HOADON(MAHD)) asc");
        }

        private void MoneyDesc_Click(object sender, EventArgs e)
        {
            LoadTable("select * from HOADON where ngaylap is not null order by (DBO.TONGTIEN_HOADON(MAHD)) desc");
        }
    }
}