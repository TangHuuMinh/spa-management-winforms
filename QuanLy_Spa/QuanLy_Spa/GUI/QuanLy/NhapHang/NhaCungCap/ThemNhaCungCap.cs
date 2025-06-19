using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;

namespace QuanLy_Spa.GUI.QuanLy.NhapHang.NhaCungCap
{
    public partial class ThemNhaCungCap : Form
    {
        public ThemNhaCungCap(TrangChuQL ql,string mncc,int tt)
        {
            InitializeComponent();
            QL = ql;
            MANCC = mncc;
            TRANGTHAI = tt;
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        KhuVuc KV = new KhuVuc();
        string TP, Q  = "";
        string MANCC = "";
        int TRANGTHAI;
        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            string pattern = @"^[a-zA-ZưứừửữựƯỨỪỬỮỰàáạảãâầấậẩẫbcdđeéẻèẽêệợụỵịặăắẳẵằỆỢỤỴỊẶĂẮẲẴẰếềểễfghiíìịỉĩjklmnoóòọỏõơớờởỡôồốộổỗpqrstuúủùũvwxyýỳỷỹzÀÁẠẢÃÂẦẤẬẨẪBCDĐÉÈẺẼÊẾỀỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕƠỚỜỞỠÔỒỐỘỔỖPQRSTUÚỦÙŨVWXYÝỲỶỸZ\s]+$";
            return new Regex(pattern).IsMatch(name);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$|^\d{11}$");
        }
        void LoadEnabled(bool e)
        {
            cbbKhuVuc.Enabled = cbbQuan.Enabled = cbbTrangThai.Enabled= !e;
            txbDiachi.ReadOnly = txbSDT.ReadOnly = txbTENNCC.ReadOnly = e;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from NHACUNGCAP where MANCC = '" +MANCC +"'");
            txbTENNCC.Text = dt.Rows[0]["TENNCC"].ToString().Trim();
            string diachi = dt.Rows[0]["DIACHI"].ToString().Trim();
            string[] dc = diachi.Split(',');
            string[] t = dt.Rows[0]["DIACHI"].ToString().Trim().Split(' ');
            string temp = "";
            for (int i=0;i<t.Length-2;i++)
            {
                temp += t[i]+" ";
            }
            txbDiachi.Text = temp;
            txbAdress.Text = diachi;
            for (int i = 0; i < KV.TP.Length; i++)
            {
                if (KV.TP[i] == dc[dc.Length - 1].Trim())
                {
                    cbbKhuVuc.SelectedIndex = i;
                    cbbQuan.DataSource = KV.KHUVUC(i);
                    cbbQuan.Text = dc[dc.Length - 2];
                    break;
                }
            }
            cbbTrangThai.Text = (dt.Rows[0]["TRANGTHAI"].ToString().Trim() =="1") ? "Hợp tác" : "Ngưng hợp tác";
            txbSDT.Text = dt.Rows[0]["SDT"].ToString().Trim();
            txbAdress.Text = dt.Rows[0]["DIACHI"].ToString().Trim();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (TRANGTHAI > 0)
            {
                if (MessageBox.Show("Bạn chưa lưu lại thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (TRANGTHAI == 1) QL.Order_Click(sender, e);
                    else QL.DSNhaCungCap_Click(sender, e);
                }
            }
            else QL.DSNhaCungCap_Click(sender, e);
        }

        private void cbbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbQuan.DataSource = KV.KHUVUC(cbbKhuVuc.SelectedIndex);
            cbbQuan.SelectedIndex = 0;
            TP = cbbKhuVuc.Text;
            string[] t = cbbQuan.Text.Split(' ');
            if (t[0] == "Quận") Q = ", Q." + t[1] + ", ";
            else Q = ", Q." + cbbQuan.Text + ", ";
            txbAdress.Text = txbDiachi.Text + Q + TP;
        }

        private void cbbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] t = cbbQuan.Text.Split(' ');
            if (t[0] == "Quận") Q = ", Q." + t[1] + ", ";
            else Q =", Q." +cbbQuan.Text + ", ";
            txbAdress.Text = txbDiachi.Text+Q+TP;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (IsValidName(txbTENNCC.Text))
            {
                if (IsValidPhoneNumber(txbSDT.Text))
                {
                    if (txbDiachi.Text.Trim().Length > 0)
                    {
                        string ten = "N'" + txbTENNCC.Text + "',N'";
                        string diachi = txbAdress.Text + "',";
                        string sdt = "'" + txbSDT.Text + "',";
                        string trangthai = cbbTrangThai.SelectedIndex.ToString();
                        if (TRANGTHAI == 1)
                        {
                            string qr = "exec DBO.THEM_NHACUNGCAP '" + MANCC + "'," + ten + diachi + "'" + txbSDT.Text+"'";
                            int kq = db.getNonQuery(qr);
                            MessageBox.Show("Thêm Nhà cung cấp thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string qr = "exec DBO.CAPNHAT_NHACUNGCAP '" + MANCC + "'," + ten + diachi + sdt + trangthai;
                            int kq = db.getNonQuery(qr);
                            MessageBox.Show("Điều chỉnh thông tin Nhà cung cấp thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (TRANGTHAI == 1) QL.Order_Click(sender, e);
                        else QL.DSNhaCungCap_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Địa chỉ sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txbDiachi, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txbSDT, "Error");
                }
            }
            else
            {
                MessageBox.Show("Tên sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txbTENNCC, "Error");
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTrangThai.SelectedIndex==0)
            {
                if (MessageBox.Show("Ngừng hợp tác với nhà cung cấp : " + txbTENNCC.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    cbbTrangThai.SelectedIndex = 1;
                }
            }
        }

        private void txbDiachi_TextChanged(object sender, EventArgs e)
        {
            txbAdress.Text = txbDiachi.Text + Q + TP;
        }

        private void ThemNhaCungCap_Load(object sender, EventArgs e)
        {
            txbMANCC.Text = MANCC;
            cbbKhuVuc.DataSource = KV.TP;
            cbbQuan.DataSource = KV.KHUVUC(0);
            cbbKhuVuc.SelectedIndex = cbbQuan.SelectedIndex = 0;
            TP = KV.TP[0] + ", ";
            Q = "Q." + cbbQuan.Text + ", ";
            txbAdress.Text = TP + Q + txbDiachi.Text;
            cbbTrangThai.Items.Add("Ngưng hợp tác");
            cbbTrangThai.Items.Add("Hợp tác");
            if (TRANGTHAI==0)
            {
                LoadEnabled(true);
                LoadInfo();
            }
            else if(TRANGTHAI ==1)
            {
                LoadEnabled(false);
                cbbTrangThai.Enabled = false;
                cbbTrangThai.SelectedIndex = 1;
            }
            else
            {
                LoadEnabled(false);
                LoadInfo();
            }
        }
    }
}
