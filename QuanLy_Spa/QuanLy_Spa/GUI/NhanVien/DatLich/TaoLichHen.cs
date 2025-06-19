using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.NhanVien.DatLich
{
    public partial class TaoLichHen : Form
    {
        public TaoLichHen(TrangChuNV nv,int tt)
        {
            InitializeComponent();
            NV = nv;
            TRANGTHAI = tt;
        }
        int TRANGTHAI;
        TrangChuNV NV;
        ConnectDB db = new ConnectDB();
        SendEmail S = new SendEmail();
        int start = 0;
        string TaoVanBanEmail()
        {

            string result = "THÔNG BÁO ĐẾN KHÁCH HÀNG\n";
            result += "Chào quý khách,\n";
            if (TRANGTHAI == 1)
            {
                result += "Cảm ơn quý khách vì đã tin tưởng sử dụng dịch vụ của Spa KMT\n.";
                result += "Chúng tôi xin gửi tới quý khách một số thông tin liên quan đến lịch hẹn của mình:\n";
            }
            else
            {
                result += "Chúng tôi xin thông báo rằng lịch hẹn của quý khách tại Spa KMT đã được cập nhật thành công.\n";
                result += "Dưới đây là các thông tin đã được điều chỉnh trong hệ thống của chúng tôi.\n";
            }
            result += "Thông tin hội viên:\n\n\n";

            result += "Họ và tên: " + txbName.Text + "\n";
            result += "Dịch vụ: " +cbbService.Text + "\n";
            result += "Ngày hẹn: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n";
            result += "Thời gian: " + txbStart.Text + " - " + txbEnd.Text + "\n";
            result += "Ngày điều chỉnh: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n\n";
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
        private void TaoLichHen_Load(object sender, EventArgs e)
        {
            cbbMLH.DataSource = db.getDataTable("select MALICHHEN from LICH_HEN where trangthai = 0");
            cbbMLH.DisplayMember = "MALICHHEN";
            cbbMLH.ValueMember = "MALICHHEN";
            cbbService.DataSource = db.getDataTable("select * from dichvu");
            cbbService.DisplayMember = "TENDV";
            cbbService.ValueMember = "MADV";
            cbbMAKH.DataSource = db.getDataTable("select * from khachhang");
            cbbMAKH.DisplayMember = "MAKH";
            cbbMAKH.ValueMember = "MAKH";
            cbbMAKH.SelectedIndex = cbbMLH.SelectedIndex = 0;
            if (TRANGTHAI == 2)
            {
                cbbMAKH.Enabled = false;
                DataTable dt = db.getDataTable("select k.* from lich_hen l,khachhang k where l.makh = k.makh and l.malichhen ='" + cbbMLH.SelectedValue.ToString().Trim() + "'");
                cbbMAKH.Text = dt.Rows[0]["MAKH"].ToString().Trim();
                txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
                txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
                dt = db.getDataTable("select l.* from lich_hen l where l.malichhen ='" + cbbMLH.SelectedValue.ToString().Trim() + "'");
                txbStart.Text = dt.Rows[0]["THOIGIAN_BATDAU"].ToString().Trim();
                txbEnd.Text = dt.Rows[0]["THOIGIAN_KETTHUC"].ToString().Trim();
                dtpkDay.Value= Convert.ToDateTime(dt.Rows[0]["NGAY_DAT_LICH"].ToString().Trim());
            }
            else
            {
                cbbMLH.Enabled = false;
                cbbMAKH.Enabled = true;
                cbbMLH.Text = db.getDataTable("select MAX(MALICHHEN)+1 as 'MAX' from lich_hen where TRANGTHAI =0").Rows[0]["MAX"].ToString().Trim();
                DataTable dt = db.getDataTable("select * from khachhang where MAKH = 'KH001'");
                cbbMAKH.Text = "KH001";
                txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
                txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
                dtpkDay.Value = DateTime.Now;
                txbStart.Text = "07:00";
                txbEnd.Text = "09:00";
            }
            start = 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            NV.Calendar_Click(sender, e);
        }

        private void cbbMAKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 1)
            {
                DataTable dt = db.getDataTable("select * from khachhang where makh ='" + cbbMAKH.SelectedValue.ToString().Trim() + "'");
                txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
                txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
            }
        }

        private void cbbMLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 1)
            {
                if (TRANGTHAI == 2)
                {
                    cbbMAKH.Enabled = false;
                    DataTable dt = db.getDataTable("select k.* from lich_hen l,khachhang k where l.makh = k.makh and l.malichhen ='" + cbbMLH.SelectedValue.ToString().Trim() + "'");
                    cbbMAKH.Text = dt.Rows[0]["MAKH"].ToString().Trim();
                    txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
                    txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
                    dt = db.getDataTable("select l.* from lich_hen l where l.malichhen ='" + cbbMLH.SelectedValue.ToString().Trim() + "'");
                    txbStart.Text = dt.Rows[0]["THOIGIAN_BATDAU"].ToString().Trim();
                    txbEnd.Text = dt.Rows[0]["THOIGIAN_KETTHUC"].ToString().Trim();
                    dtpkDay.Value = Convert.ToDateTime(dt.Rows[0]["NGAY_DAT_LICH"].ToString().Trim());
                }
            }
        }

        private void btnAscStart_Click(object sender, EventArgs e)
        {
            string st = txbStart.Text.Substring(0, 2);
            int s = Convert.ToInt32(st) + 1;
            if (s >= 20) return;
            txbStart.Text =  s + ":00";
            if (s < 10) txbStart.Text = "0" + s + ":00";
        }

        private void btnDescStart_Click(object sender, EventArgs e)
        {
            string st = txbStart.Text.Substring(0, 2);
            int s = Convert.ToInt32(st) - 1;
            if (s <= 7) return;
            txbStart.Text = s + ":00";
            if (s < 10) txbStart.Text = "0" + s + ":00";
        }

        private void btnAscEnd_Click(object sender, EventArgs e)
        {
            string end = txbEnd.Text.Substring(0, 2);
            int en = Convert.ToInt32(end) + 1;
            if (en >= 22) return;
            txbEnd.Text = en + ":00";
            if (en < 10) txbEnd.Text = "0" + en + ":00";
        }

        private void btnDescEnd_Click(object sender, EventArgs e)
        {
            string end = txbEnd.Text.Substring(0, 2);
            int en = Convert.ToInt32(end) - 1;
            if (en <= 9) return;
            txbEnd.Text = en + ":00";
            if (en < 10) txbEnd.Text = "0" + en + ":00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txbEnd.Text.Substring(0, 2)) - Convert.ToInt32(txbStart.Text.Substring(0, 2)) > 0)
            {
                string email = db.getDataTable("select * from khachhang where makh = '" + cbbMAKH.Text.Trim() + "'").Rows[0]["EMAIL"].ToString().Trim();
                if (TRANGTHAI == 1)
                {
                    int kq = db.getNonQuery("insert lich_hen values('" + cbbMAKH.Text.Trim() + "','" + cbbService.SelectedValue.ToString().Trim() + "','" + txbStart.Text + "','" + txbEnd.Text + "','"+dtpkDay.Value.ToString("yyyy-MM-dd").Trim()+"',0)");
                    MessageBox.Show("Đặt lịch thành công\nHệ thống đã gửi mail thông báo cho khách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    S.Send(email, "Đặt lịch hẹn spa", TaoVanBanEmail());
              
                }
                else
                {
                    int kq = db.getNonQuery("update lich_hen set MADV = '" + cbbService.SelectedValue.ToString().Trim() + "' where MALICHHEN = " + cbbMLH.Text.Trim());
                    kq = db.getNonQuery("update lich_hen set THOIGIAN_BATDAU = '" + txbStart.Text.ToString().Trim() + "' where MALICHHEN = " + cbbMLH.Text.Trim());
                    kq = db.getNonQuery("update lich_hen set THOIGIAN_KETTHUC = '" + txbEnd.Text.ToString().Trim() + "' where MALICHHEN = " + cbbMLH.Text.Trim());
                    kq = db.getNonQuery("update lich_hen set NGAY_DAT_LICH = '" + dtpkDay.Value.ToString("yyyy-MM-dd").Trim() + "' where MALICHHEN = " + cbbMLH.Text.Trim());
                    MessageBox.Show("Điều  chỉnh thành công\nHệ thống đã gửi mail thông báo cho khách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    S.Send(email, "Điều chỉnh lịch hẹn spa", TaoVanBanEmail());
                }
                NV.Calendar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thời gian bắt đầu cần trứơc thòi gian kết thúc 1 tiếng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
