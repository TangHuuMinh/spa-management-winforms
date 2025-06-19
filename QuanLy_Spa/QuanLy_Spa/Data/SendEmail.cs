using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace QuanLy_Spa.DuLieu
{
    public class SendEmail
    {
        public void Send(string email,string sub,string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("kmt.beautyclinic@gmail.com");
                mail.To.Add(email);
                mail.Subject = sub;
                mail.Body = body;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("kmt.beautyclinic@gmail.com", "xdvt hieq akaj injc");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
