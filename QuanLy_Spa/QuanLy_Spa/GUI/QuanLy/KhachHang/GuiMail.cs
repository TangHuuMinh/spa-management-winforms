using QuanLy_Spa.GUI.QuanLy;
using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLy_Spa.GUI.NhanVien.Khach_hang
{
    public partial class GuiMail : Form
    {
        public GuiMail(TrangChuQL ql,string mail)
        {
            InitializeComponent();
            Mail = mail;
            QL = ql;
        }
        TrangChuQL QL;
        string Mail;
        private void txbSend_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(txbSubject.Text.Trim().Length >0)
            {
                if (txbBody.Text.Trim().Length > 0)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("kmt.beautyclinic@gmail.com");
                        mail.To.Add(Mail);
                        mail.Subject = txbSubject.Text;
                        mail.Body = txbBody.Text;

                        if (!string.IsNullOrEmpty(txbFile.Text))
                        {
                            Attachment attachment = new Attachment(txbFile.Text);
                            mail.Attachments.Add(attachment);
                        }

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("kmt.beautyclinic@gmail.com", "xdvt hieq akaj injc");
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                        MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QL.Customer_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nội dung không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txbSubject, "Error");
                }
            }
            else
            {
                MessageBox.Show("Tiêu đề không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txbSubject, "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Customer_Click(sender, e);
        }

        private void GuiMail_Load(object sender, EventArgs e)
        {
            txbTo.Text = Mail;
            txbFrom.Text = "kmt.beautyclinic@gmail.com";
        }

        private void btnUpLoadFIle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn file để đính kèm";
                openFileDialog.Filter = "All Files|*.*"; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txbFile.Text = filePath; 
                }
            }
        }
    }
}
