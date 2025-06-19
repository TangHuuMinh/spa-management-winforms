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
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using QuanLy_Spa.DuLieu;
namespace QuanLy_Spa.GUI.DangNhap
{
    public partial class QuenMatKhauF : Form
    {
        public QuenMatKhauF()
        {
            InitializeComponent();
            lbCaptcha.Text = TaoMaCatpcha();
        }
        SendEmail s = new SendEmail();
        ConnectDB db = new ConnectDB();
        Random r = new Random();
        string MaXacNhan = "";
        string TaoMaCatpcha()
        {
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                result += Convert.ToChar(r.Next(97, 122)).ToString();
            }
            result += r.Next(0,9).ToString();
            return result;
        }
        string TaoVanBan()
        {
            string name = db.getDataTable("select HOTEN from nhanvien where MANV = '" + txbID.Text + "'").Rows[0]["HOTEN"].ToString();
            string result = "Chào ,"+name+"\n";

            result += "Tôi là quản lý của Spa KMT. \n";
            result+="Tôi gửi đến bạn mã xác nhận để xác minh việc cấp lại mật khẩu của bạn.\n";
            MaXacNhan = TaoMaCatpcha();
            result += "Mã xác nhận: "+MaXacNhan+"\n";

            result += "Vui lòng sử dụng mã xác nhận này trong hệ thống để hoàn tất quá trình cấp lại mật khẩu.\n";
            result+= "Nếu bạn không yêu cầu đặt lại mật khẩu, vui lòng liên hệ lại với chúng tôi ngay lập tức để đảm bảo an toàn cho tài khoản của bạn.\n";

            result += "Trân trọng,\n";
            result += "Quản lý Spa KMT\n";
            return result;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string email = txbEmail.Text;
            if (btnSend.Text == "Gửi")
            {
                if (id.Trim().Length < 1 || email.Trim().Length < 1)
                {
                    lbCaptcha.Text = TaoMaCatpcha();
                    txbCaptcha.Text = "";
                    MessageBox.Show("Tên đăng nhập và Email không được để trống!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kq = db.getScalar("select count(*) from NHANVIEN where MANV collate SQL_Latin1_General_CP1_CS_AS like '" + id + "' and EMAIL collate SQL_Latin1_General_CP1_CS_AS like '" + email + "'");
                if (kq == 0)
                {
                    lbCaptcha.Text = TaoMaCatpcha();
                    txbCaptcha.Text = "";
                    MessageBox.Show("Tên đăng nhập và Email không đúng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txbCaptcha.Text.Trim().Length < 1)
                    {
                        lbCaptcha.Text = TaoMaCatpcha();
                        txbCaptcha.Text = "";
                        MessageBox.Show("Mã catpcha không được để trống!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (txbCaptcha.Text == lbCaptcha.Text)
                        {
                            s.Send(txbEmail.Text, "Xác nhận cấp lại mật khẩu cho nhân viên", TaoVanBan());
                            txbID.Enabled = txbID.Enabled = false;
                            lbCaptcha.Visible = false;
                            label4.Text = "Nhập mã vừa nhận được";
                            btnSend.Text = "Hoàn thành";
                            txbCaptcha.Text = "";
                            txbCaptcha.Width += 205;
                            label7.Location = new Point(label7.Location.X + 65, label7.Location.Y);
                        }
                        else
                        {
                            lbCaptcha.Text = TaoMaCatpcha();
                            txbCaptcha.Text = "";
                            MessageBox.Show("Mã catpcha không đúng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }

                }
            }
            else
            {
                if(txbCaptcha.Text != MaXacNhan)
                {
                    MessageBox.Show("Mã xác nhận không đúng,vui lòng kiểm tra lại email!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int kq = db.getNonQuery("update taikhoan set matkhau = '" + txbID.Text + "' where manv = '" + txbID.Text + "'");
                    MessageBox.Show("Cấp lại mật khẩu thành công!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
