using QuanLy_Spa.GUI.DangNhap;
using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using QuanLy_Spa.DuLieu;

namespace QuanLy_Spa.GUI.NhanVien.Khach_hang
{
    public partial class DetailCustomer : Form
    {
        public DetailCustomer(TrangChuNV tt,int trangthai,string makh)
        {
            InitializeComponent();
            TT = tt;
            TrangThai = trangthai;
            MAKH = makh;
        }
        TrangChuNV TT;
        int TrangThai;
        string MAKH;
        ConnectDB db = new ConnectDB();
        SendEmail S = new SendEmail();
       

        void LoadEnable(bool e)
        {
            txbName.ReadOnly = txbEmail.ReadOnly = txbPhone.ReadOnly = txbAdress.ReadOnly = e;
            rdGenderFemale.Enabled = rdGenderMale.Enabled = dtpkDOB.Enabled = !e;
            cbbStatus.Enabled = false;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from khachhang where MAKH = '" + MAKH + "'");
            txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
            txbEmail.Text = dt.Rows[0]["EMAIL"].ToString().Trim();
            txbPoint.Text = dt.Rows[0]["DIEM"].ToString().Trim();
            txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
            txbAdress.Text = dt.Rows[0]["DIACHI"].ToString().Trim();
            dtpkDOB.Value = Convert.ToDateTime(dt.Rows[0]["NGSINH"]);
            cbbStatus.Text = dt.Rows[0]["PHANLOAI"].ToString();
            rdGenderFemale.Checked = true;
            if (dt.Rows[0]["GIOITINH"].ToString().Trim() == "Nam")
                rdGenderMale.Checked = true;
        }
        string TaoVanBanEmail()
        {
           
            string result = "THÔNG BÁO ĐẾN KHÁCH HÀNG\n";
            result += "Chào quý khách,\n";
            if (TrangThai == 1)
            {
                result += "Chúng tôi rất vui mừng thông báo rằng quý khách đã trở thành hội viên chính thức của Spa KMT\n.";
                result += "Chúng tôi xin gửi tới quý khách một số thông tin liên quan đến việc đăng ký hội viên của mình:\n";
            }
            else
            {
                result += "Chúng tôi xin thông báo rằng thông tin đăng ký hội viên của quý khách tại Spa KMT đã được cập nhật thành công.\n";
                result += "Dưới đây là các thông tin đã được điều chỉnh trong hệ thống của chúng tôi.\n";
            }
            result += "Thông tin hội viên:\n\n\n";

            result += "Họ và tên: "+txbName.Text+"\n";
            string gt = rdGenderFemale.Checked ? rdGenderFemale.Text : "Nam";
            result += "Giới tính : " + gt + "\n";
            result += "Ngày sinh: " + dtpkDOB.Value.ToString("dd/MM/yyyy") + "\n";
            result += "Số điện thoại: "+txbPhone.Text+"\n";
            result += "Email: "+txbEmail.Text+"\n";
            result += "Địa chỉ nhà: "+txbAdress.Text+"\n";
            if (TrangThai == 1)
            {
                result += "Ngày đăng ký: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n\n";
            }
            else
            {
                result += "Ngày điều chỉnh: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n\n";
            }
            result += "Quyền lợi của hội viên:\n";

            result += "Giảm giá[XX]% cho tất cả dịch vụ tại spa.\n";
            result += "Chương trình ưu đãi đặc biệt cho các dịp lễ, sinh nhật, và các sự kiện của spa.\n";
            result += "Cập nhật thông tin ưu đãi qua email và tin nhắn SMS.\n";
            result += "Chúc quý khách có những trải nghiệm tuyệt vời tại Spa KMT!\n";
            result += "Nếu quý khách có bất kỳ thắc mắc nào hoặc cần thêm thông tin, vui lòng liên hệ với chúng tôi qua số điện thoại[0704660316] hoặc email[kmt.beautyclinic@gmail.com].\n";

            result += "Chúng tôi rất hân hạnh được phục vụ quý khách!\n";

            result += "Trân trọng,\n";
            result += "Spa KMT\n";
            return result;
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(0[3|5|7|8|9])\d{8}$";
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            string pattern = @"^[a-zA-ZưứừửữựƯỨỪỬỮỰệợụỵịặăắẳẵằỆỢỤỴỊẶĂẮẲẴẰàáạảãâầấậẩẫbcdđeéẻèẽêếềểễfghiíìịỉĩjklmnoóòọỏõơớờởỡôồốộổỗpqrstuúủùũvwxyýỳỷỹzÀÁẠẢÃÂẦẤẬẨẪBCDĐÉÈẺẼÊẾỀỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕƠỚỜỞỠÔỒỐỘỔỖPQRSTUÚỦÙŨVWXYÝỲỶỸZ\s]+$";
            return new Regex(pattern).IsMatch(name);
        }
        public bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;
            string pattern = @"^[a-zA-ZưứừửữựƯỨỪỬỮỰệợụỵịặăắẳẵằỆỢỤỴỊẶĂẮẲẴẰàáạảãâầấậẩẫbcdđeéẻèẽêếềểễfghiíìịỉĩjklmnoóòọỏõơớờởỡôồốộổỗpqrstuúủùũvwxyýỳỷỹzáàạảãâầấậẩẫàÀÁẠẢÃÂẦẤẬẨẪBCDĐÉÈẺẼÊẾỀỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕƠỚỜỞỠÔỒỐỘỔỖPQRSTUÚỦÙŨVWXYÝỲỶỸZ-ú0-9\s,.-/À-ú]+$";
            return new Regex(pattern).IsMatch(address);
        }
        public bool IsValidAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;
            return age >= 18;
        }
        private void btnExit_Click(object sender, EventArgs e)
        { 
            TT.Customer_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(TrangThai !=0)
            {
                errorProvider1.Clear();
                if (IsValidName(txbName.Text))
                {
                    if (IsValidAge(dtpkDOB.Value))
                    {
                        if (IsValidPhoneNumber(txbPhone.Text))
                        {
                            if (IsValidEmail(txbEmail.Text))
                            {
                                if (IsValidAddress(txbAdress.Text))
                                {
                                    string ma = "'" + txbID.Text.Trim() + "',";
                                    string ten = "N'" + txbName.Text + "',N";
                                    string gioitinh = (rdGenderMale.Checked) ? "'Nam'," : "'Nữ',";
                                    string phanloai = "N'" + cbbStatus.Text + "',";
                                    string ngay = "'" + dtpkDOB.Value.Month + "-" + dtpkDOB.Value.Day + "-" + dtpkDOB.Value.Year + "',";
                                    string sdt = "'" + txbPhone.Text + "',";
                                    string email = "'" + txbEmail.Text + "',";
                                    string adress = "N'" + txbAdress.Text + "'";
                                    int kq = 0;
                                    if (TrangThai == 1)
                                    {
                                        string qr = "INSERT KHACHHANG VALUES(" + ma + ten + gioitinh + phanloai + ngay + sdt + email+ "0," + adress + ")";
                                        kq = db.getNonQuery(qr);
                                        S.Send(txbEmail.Text, "Đăng ký thông tin khách hàng", TaoVanBanEmail());
                                        MessageBox.Show("Đăng ký thông tin khách hàng hoàn tất\nHệ thống đã gửi email thông báo đến khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        string qr = "EXEC dbo.CapNhat_ThongTin_KhachHang " + ma + ten + gioitinh + ngay + sdt + email + adress;
          
                                        kq = db.getNonQuery(qr);
                                        S.Send(txbEmail.Text, "Điều chỉnh thông tin khách hàng", TaoVanBanEmail());
                                        MessageBox.Show("Cập nhật thông tin khách hàng hoàn tất\nHệ thống đã gửi email thông báo đến khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    
                                    TT.Customer_Click(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Địa chỉ sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    errorProvider1.SetError(txbAdress, "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Địa chỉ email sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                errorProvider1.SetError(txbEmail, "Error");
                            }
                        }
                        else
                        { 
                            MessageBox.Show("Số điện thoại sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorProvider1.SetError(txbPhone, "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tuổi cần lớn hơn bằng 18", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(dtpkDOB, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Tên sai định dạng","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    errorProvider1.SetError(txbName, "Error");
                }
            }
            else TT.Customer_Click(sender, e);
        }
        private void DetailCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select Distinct(PHANLOAI) from KHACHHANG");
            cbbStatus.DataSource = dt;
            cbbStatus.DisplayMember = "PHANLOAI";
            cbbStatus.ValueMember = "PHANLOAI";
            txbID.Text = MAKH;
            if(TrangThai == 0)
            {
                lbHeader.Location = new Point(400, 7);
                lbHeader.Text = "Xem chi tiết thông tin khách hàng";
                LoadEnable(true);
                LoadInfo();
            }
            else if(TrangThai==1)
            {
                lbHeader.Location = new Point(424, 7);
                lbHeader.Text = "Đăng ký thông tin khách hàng";
                LoadEnable(false);
                txbPoint.Text = "0";
            }
            else
            {
                lbHeader.Location = new Point(400, 7);
                lbHeader.Text = "Cập nhật thông tin khách hàng";
                LoadEnable(false);
                LoadInfo();
            }
        }
    }
}
