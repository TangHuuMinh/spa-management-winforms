using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;
using System.Windows.Forms;
namespace QuanLy_Spa.DuLieu
{
    public class PDF
    {
        public PDF(string text)
        {
            try
            { 

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; 
                saveFileDialog.Title = "Chọn nơi lưu file PDF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                    document.Open();
                    string fontPath = @"C:\Windows\Fonts\Arial.ttf"; // Đảm bảo rằng bạn có font này
                    BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    Font font = new Font(baseFont, 12);
                    Paragraph p = new Paragraph(text, font);
                    document.Add(p);
                    document.Close();
                    MessageBox.Show("File PDF đã được tạo thành công tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
