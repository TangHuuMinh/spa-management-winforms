using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLy_Spa.GUI.QuanLy.NhanVien
{
    public partial class QLChiTietNV : Form
    {
        public QLChiTietNV(TrangChuQL ql,string manv,int tt)
        {
            InitializeComponent();
            QL = ql;
            MANV = manv;
            TRANGTHAI = tt;
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        SendEmail S = new SendEmail();
        int TRANGTHAI;
        string MANV;
        public string TaoEmail()
        {
            // Khởi tạo thông báo
            string result = "THÔNG BÁO ĐẾN NHÂN VIÊN\n";
            result += "Xin chào,\n";

            if (TRANGTHAI == 1)

            {
                result += "Chúc mừng bạn đã trở thành nhân viên của hệ thống Spa KMT.\n";
                result += "Dưới đây là thông tin chi tiết của bạn:\n";
            }
            else
            {
                result += "Thông tin của bạn hiện tại đã được cập nhật thành công trong hệ thống.\n";
                result += "Dưới đây là các thông tin đã được điều chỉnh trong hệ thống của chúng tôi.\n";
            }

            result += "Thông tin nhân viên:\n\n";
            result += "Họ và tên: " + txbName.Text + "\n";
            result += "Mã nhân viên: " + txbID.Text + "\n";
            result += "Mật khẩu : " + txbID.Text + "\n";
            result += "Ngày sinh: " + dtpkDOB.Value + "\n";
            result += "Số điện thoại: " + txbPhone.Text + "\n";
            result += "Email: " + txbEmail.Text + "\n";
            result += "CCCD: " + txbCCCD.Text + "\n";
            result += "Tài khoản ngân hàng MB: " + txbIMG.Text + "\n";
            result += "Địa chỉ nhà: " + txbAdress.Text + "\n";
            result += "Ngày điều chỉnh: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n";

            result += "Quyền lợi của nhân viên:\n";
            result += "- Được hưởng các chế độ đãi ngộ và phúc lợi theo quy định của Spa KMT.\n";
            result += "- Tham gia các khóa đào tạo nâng cao nghiệp vụ.\n";
            result += "- Tham gia các sự kiện nội bộ và các chương trình phúc lợi khác.\n";

            result += "Chúng tôi rất mong quý nhân viên sẽ gắn bó và phát triển cùng Spa KMT.\n";
            result += "Nếu quý nhân viên có bất kỳ thắc mắc nào, vui lòng liên hệ bộ phận nhân sự để được hỗ trợ.\n";

            result += "Trân trọng,\n";
            result += "Spa KMT\n";

            return result;
        }
        bool start = false;
        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            string pattern = @"^[a-zA-ZưứừửữựƯỨỪỬỮỰàáạảãâầấậẩẫbcdđeéẻèẽêệợụỵịặăắẳẵằỆỢỤỴỊẶĂẮẲẴẰếềểễfghiíìịỉĩjklmnoóòọỏõơớờởỡôồốộổỗpqrstuúủùũvwxyýỳỷỹzÀÁẠẢÃÂẦẤẬẨẪBCDĐÉÈẺẼÊẾỀỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕƠỚỜỞỠÔỒỐỘỔỖPQRSTUÚỦÙŨVWXYÝỲỶỸZ\s]+$";
            return new Regex(pattern).IsMatch(name);
        }
        public bool IsValidAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;
            return age >= 18;
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email);
        }
        public bool IsValidCitizenID(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 12 || !Regex.IsMatch(id, @"^\d+$"))
            {
                return false;
            }
            return true;
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
        public bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;
            string pattern = @"^[a-zA-ZưứừửữựƯỨỪỬỮỰệợụỵịặăắẳẵằỆỢỤỴỊẶĂẮẲẴẰàáạảãâầấậẩẫbcdđeéẻèẽêếềểễfghiíìịỉĩjklmnoóòọỏõơớờởỡôồốộổỗpqrstuúủùũvwxyýỳỷỹzáàạảãâầấậẩẫàÀÁẠẢÃÂẦẤẬẨẪBCDĐÉÈẺẼÊẾỀỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕƠỚỜỞỠÔỒỐỘỔỖPQRSTUÚỦÙŨVWXYÝỲỶỸZ-ú0-9\s,.-/À-ú]+$";
            return new Regex(pattern).IsMatch(address);
        }
       
        void LoadEnable(bool e)
        {
            rdGenderFemale.Enabled = rdGenderMale.Enabled = !e;
            cbbTrangThai.Enabled = cbbStatus.Enabled = dtpkDOB.Enabled = !e;
            txbName.ReadOnly = txbPhone.ReadOnly = txbCCCD.ReadOnly = txbEmail.ReadOnly =  txbAdress.ReadOnly= e;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from NHANVIEN where MANV = '" + MANV + "'");
            txbID.Text = MANV;
            cbbTrangThai.Text = (dt.Rows[0]["TRANGTHAI"].ToString().Trim() == "1") ? "Hợp tác" : "Ngưng hợp tác";
            cbbStatus.Text = dt.Rows[0]["CHUCVU"].ToString().Trim();
            dtpkDOB.Value = Convert.ToDateTime(dt.Rows[0]["NGSINH"]);
            txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
            txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
            txbCCCD.Text = dt.Rows[0]["CCCD"].ToString().Trim();
            txbEmail.Text = dt.Rows[0]["EMAIL"].ToString().Trim();
            txbIMG.Text = dt.Rows[0]["ANH"].ToString().Trim();
            
            txbAdress.Text = dt.Rows[0]["DIACHI"].ToString().Trim();
            rdGenderFemale.Checked = true;
            if (dt.Rows[0]["GIOITINH"].ToString().Trim() == "Nam") rdGenderMale.Checked = true;
            if (txbIMG.Text.Trim() == "")
            {
                if (rdGenderMale.Checked)
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\Male.jpg");
                else
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\female.jpg");
            }
            else pbAnh.Image = new Bitmap(Application.StartupPath + "\\StaffResources\\" + txbIMG.Text.Trim());
        }
        private void QLChiTietNV_Load(object sender, EventArgs e)
        {
            cbbStatus.DataSource = db.getDataTable("select distinct(CHUCVU) from NHANVIEN where SUBSTRING(MANV,1,2) = 'NV'");
            cbbStatus.DisplayMember = "CHUCVU";
            cbbStatus.ValueMember = "CHUCVU";
            if (TRANGTHAI == 0)
            {
                groupBox2.Text = "Xem thông tin nhân viên";
                LoadEnable(true);
                LoadInfo();

            }
            else if (TRANGTHAI == 1)
            {
                txbID.Text = MANV;
                groupBox2.Text = "Thêm nhân viên mới";
                LoadEnable(false);
                cbbStatus.SelectedIndex = 0;
                cbbTrangThai.Enabled = false;
            }
            else
            {
                groupBox2.Text = "Điều chỉnh thông tin nhân viên";
                LoadEnable(false);
                LoadInfo();
            }
            cbbTrangThai.Items.Add("Ngưng hợp tác");
            cbbTrangThai.Items.Add("Hợp tác");
            if(TRANGTHAI==1) cbbTrangThai.SelectedIndex = 1;
            else
            {
                if (cbbTrangThai.Text == "Hợp tác")
                    cbbTrangThai.SelectedIndex = 1;
                else cbbTrangThai.SelectedIndex = 0;
            }
            if (txbIMG.Text.Trim() == "")
            {
                if (rdGenderMale.Checked)
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\Male.jpg");
                else
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\female.jpg");
            }
            else pbAnh.Image = new Bitmap(Application.StartupPath + "\\StaffResources\\" + txbIMG.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(TRANGTHAI!=0)
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
                                if (IsValidCitizenID(txbCCCD.Text))
                                {
                                    if (IsValidAddress(txbAdress.Text))
                                    {
                                        string ma = "'" + txbID.Text.Trim() + "',";
                                        string ten = "N'" + txbName.Text + "',N";
                                        string gioitinh = (rdGenderMale.Checked) ? "'Nam'," : "'Nữ',";
                                        string ngay = "'" + string.Format("{0:MM-dd-yyyy}", dtpkDOB.Value).ToString() + "',";
                                        string phanloai = "N'" + cbbStatus.Text + "',";
                                        string sdt = "'" + txbPhone.Text + "',";
                                        string email = "'" + txbEmail.Text + "',";
                                        string cccd = "'" + txbCCCD.Text + "',";
                                        string mb = txbIMG.Text + "',";
                                        string adress = "N'" + txbAdress.Text + "',";
                                        string anh = txbIMG.Text.Trim();
                                        if (anh == "") anh = "null";
                                        else anh = "'" + anh + "'";
                                        if (TRANGTHAI == 1)
                                        {
                                            string qr = "INSERT NHANVIEN VALUES(" + ma + ten + gioitinh + phanloai + ngay + sdt + email + cccd + adress +anh+ ",1)";
                                            int kq = db.getNonQuery(qr);
                                            S.Send(txbEmail.Text, "Điều chỉnh thông tin nhân viên", TaoEmail());
                                            MessageBox.Show("Đăng ký thông tin nhân viên hoàn tất\nHệ thống đã gửi email thông báo đến nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            string qr = "EXEC dbo.CapNhat_ThongTin_NhanVien " + ma + ten + gioitinh + phanloai + ngay + sdt + email + cccd  + adress + cbbTrangThai.SelectedIndex;
                                            int kq = db.getNonQuery(qr);
                                            kq = db.getNonQuery("update nhanvien set ANH = "+anh+" where MANV ='"+txbID.Text.Trim()+"'");
                                            S.Send(txbEmail.Text, "Điều chỉnh thông tin nhân viên", TaoEmail());
                                            MessageBox.Show("Cập nhật thông tin nhân viên hoàn tất\nHệ thống đã gửi email thông báo đến nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        QL.Staff_Click(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Địa chỉ sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        errorProvider1.SetError(txbAdress, "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mã định danh cccd sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    errorProvider1.SetError(txbCCCD, "Error");
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
                    MessageBox.Show("Tên sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txbName, "Error");
                }
            }
            else QL.Staff_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Staff_Click(sender, e);
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTrangThai.SelectedIndex == 0)
            {
                if(MessageBox.Show("Ngừng hợp tác với nhân viên : "+txbName.Text+" ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    cbbTrangThai.SelectedIndex = 1;
                }
            }
        }

        private void rdGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (txbIMG.Text.Trim() == "")
            {
                if (rdGenderMale.Checked)
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\Male.jpg");
                else
                    pbAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\female.jpg");
            }
            else pbAnh.Image = new Bitmap(Application.StartupPath + "\\StaffResources\\" + txbIMG.Text.Trim());
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog.Title = "Chọn file ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string rsFolderPath = Path.Combine(projectPath, "StaffResources");
                if (!Directory.Exists(rsFolderPath))
                {
                    Directory.CreateDirectory(rsFolderPath);
                }
                string fileName = txbID.Text + Path.GetExtension(sourceFilePath);
                string destinationFilePath = Path.Combine(rsFolderPath, fileName);
                File.Copy(sourceFilePath, destinationFilePath, true);
                txbIMG.Text = fileName;
                pbAnh.Image = Image.FromFile(openFileDialog.FileName);
                MessageBox.Show("File ảnh đã chọn: " + fileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
    }
}
