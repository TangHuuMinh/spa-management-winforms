using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Data;

namespace QuanLy_Spa.DuLieu
{
    public class Excel
    {
        public Excel(string[] h,DataTable d)
        {
            try
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    // Tạo file Excel mới
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Thêm một sheet mới vào file
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Đặt tiêu đề cho các cột
                        for(int i=0;i<h.Length;i++)
                            worksheet.Cells[1, i+1].Value = h[i];

                        // Đặt giá trị mẫu vào các ô
                        for (int i = 0; i < d.Rows.Count; i++)
                        {
                            for (int j = 0; j < d.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = d.Rows[i][j].ToString().Trim();
                            }
                        }

                        // Tạo một hàng tiêu đề đậm
                        using (var range = worksheet.Cells[1, 1, 1, 3])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        }

                        // Tự động điều chỉnh độ rộng của cột theo nội dung
                        worksheet.Cells.AutoFitColumns();

                        // Lưu file Excel
                        FileInfo excelFile = new FileInfo(filePath);
                        excelPackage.SaveAs(excelFile);

                        MessageBox.Show("File Excel đã được tạo thành công tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
