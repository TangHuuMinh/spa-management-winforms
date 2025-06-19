using QuanLy_Spa.GUI.NhanVien.Khach_hang;
using QuanLy_Spa.GUI.QuanLy.DichVu;
using QuanLy_Spa.GUI.QuanLy.HoaDon;
using QuanLy_Spa.GUI.QuanLy.KhachHang;
using QuanLy_Spa.GUI.QuanLy.LichHen;
using QuanLy_Spa.GUI.QuanLy.NhanVien;
using QuanLy_Spa.GUI.QuanLy.NhapHang;
using QuanLy_Spa.GUI.QuanLy.NhapHang.NhaCungCap;
using QuanLy_Spa.GUI.QuanLy.Phong;
using QuanLy_Spa.GUI.QuanLy.SanPham;
using QuanLy_Spa.Data;
using QuanLy_Spa.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.QuanLy
{
    public partial class TrangChuQL : Form
    {
        public TrangChuQL(string manv)
        {
            InitializeComponent();
            MANV = manv;
            lbStaffName.Text = "Xin chào " + db.getDataTable("select HOTEN from nhanvien where manv = '" + MANV + "'").Rows[0]["HOTEN"].ToString() + " !";
        }
        ConnectDB db = new ConnectDB();
        string KiemTra(int h)
        {
            if (h > 0 && h <= 10)
            {
                return "Xin chào bạn! Chúc bạn buổi sáng tốt lành!";
            }
            else if (h > 10 && h <= 12)
            {
                return "Xin chào bạn! Chúc bạn buổi trưa tốt lành!";
            }
            else if (h > 12 && h < 18)
            {
                return "Xin chào bạn! Chúc bạn buổi chiều tốt lành!";
            }
            else
            {
                return "Xin chào bạn! Chúc bạn buổi tối tốt lành!";
            }
        }

        public static string MANV { get; set; }
        string Hello;
        int i = 0;
        int count = 0;
        int status = 0;
        private void Home_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = false;
            pnMenu.Visible = pnTalk.Visible = true;
        }
        #region hiệu ứng animation 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txbHello.Text != Hello)
            {
                txbHello.Text += Hello[i];
                i++;
            }
            else
            {
                timer1.Stop();
                i = 0;

                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count > 20)
            {
                timer2.Stop();
                count = 0;
                txbHello.Text = "";
                Hello = KiemTra(DateTime.Now.Hour) + Environment.NewLine;

                Hello += "Hãy làm việc thật chăm chỉ nhé!";
                Hello += Environment.NewLine + "Liên hệ : 0704xxxxxx để được hỗ trợ!";
                timer1.Start();
            }
            count++;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            lbDay.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            lbTime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
        #endregion
        #region Đăng xuất
        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void TrangChuQL_Load(object sender, EventArgs e)
        {
            lbDoanhThu.Text = db.getDataTable("select SUM(DBO.TONGTIEN_HOADON(MAHD)) as 'TONG' from HOADON where NGAYLAP = GETDATE()").Rows[0]["TONG"].ToString();
            if (lbDoanhThu.Text == "") lbDoanhThu.Text = "0";
            lbCall.Text = db.getScalar("select count(*) from LICH_HEN where NGAY_DAT_LICH = GETDATE()").ToString();
            lbClient.Text = db.getScalar("select count(*) from HOADON where MAKH IN (select MAKH from KHACHHANG) and NGAYLAP = GETDATE()").ToString();
            lbBill.Text = db.getScalar("select count(*) from HOADON where MAKH NOT IN (select MAKH from KHACHHANG) and NGAYLAP = GETDATE()").ToString();
            pnMenu.Visible = pnTalk.Visible = true;
            Hello = KiemTra(DateTime.Now.Hour) + Environment.NewLine;
            Hello += "Hãy làm việc thật chăm chỉ nhé!";
            Hello += Environment.NewLine + "Liên hệ : 0704xxxxxx để được hỗ trợ!";
            timer1.Start();
            timer3.Start();
        }
        public void Service_Click(object sender, EventArgs e)
        {
            foreach(ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Service.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLDichVu fr = new QLDichVu(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Deatil_Service_Click(int trangthai,string MADV)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Service.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            DLChiTietDV fr = new DLChiTietDV(this,trangthai,MADV);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Product_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Product.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLSanPham fr = new QLSanPham(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Deatil_Product_Click(int trangthai, string MASP)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Product.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLChiTietSP fr = new QLChiTietSP(this, trangthai, MASP);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Customer_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Customer.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLKhachHang fr = new QLKhachHang(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Detail_Customer_Click(string makh)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Customer.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLChiTietKH fr = new QLChiTietKH(this,makh);
            fr.MdiParent = this;
            fr.Show();
        }
        public void SendMail_Customer_Click(string mail)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Customer.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            GuiMail fr = new GuiMail(this, mail);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Staff_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Staff.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLNhanVien fr = new QLNhanVien(this,MANV);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Detail_Staff_Click(string manv , int trangthai)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Staff.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLChiTietNV fr = new QLChiTietNV(this,manv,trangthai);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Bills_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Bills.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLHoaDon fr = new QLHoaDon(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Detail_Bills_Click(string mahd)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Bills.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLChiTietHD fr = new QLChiTietHD(this,mahd);
            fr.MdiParent = this;
            fr.Show();
        }
        private void ThongKe_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            ThongKe.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLThongKe fr = new QLThongKe();
            fr.MdiParent = this;
            fr.Show();
        }
        public void Order_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Order.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLNHapHang fr = new QLNHapHang(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void DSPhieuNhap_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Order.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLPhieuNhap fr = new QLPhieuNhap(this,MANV);
            fr.MdiParent = this;
            fr.Show();
        }
        public void TaoPhieuNhap_Click(int TT,string mapn)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Order.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            TaoPhieuNhap fr = new TaoPhieuNhap(this,mapn,MANV,TT);
            fr.MdiParent = this;
            fr.Show();
        }
        public void DSNhaCungCap_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Order.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLNhaCungCsp fr = new QLNhaCungCsp(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void TaoNhaCungCap_Click(string MANCC,int TRANGTHAI)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Order.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            ThemNhaCungCap fr = new ThemNhaCungCap(this, MANCC,TRANGTHAI);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Calendar_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Calendar.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLPhong fr = new QLPhong(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Detail_Calendar_Click(string maph,int trangthai)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            Calendar.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLChiTietP fr = new QLChiTietP(this,trangthai, maph);
            fr.MdiParent = this;
            fr.Show();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LichHen_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
                item.BackColor = Color.FromArgb(60, 60, 60);
            LichHen.BackColor = Color.FromArgb(80, 80, 80);
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            QLLichHen fr = new QLLichHen(this);
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
