
using QuanLy_Spa.GUI.NhanVien.DatLich;
using QuanLy_Spa.GUI.NhanVien.Khach_hang;
using QuanLy_Spa.GUI.NhanVien.ThanhToan;
using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLy_Spa
{
    public partial class TrangChuNV : Form
    {
        public TrangChuNV(string manv)
        {
            InitializeComponent();
            MANV = manv;
            lbStaffName.Text = "Xin chào "+ db.getDataTable("select HOTEN from nhanvien where manv = '" + MANV + "'").Rows[0]["HOTEN"].ToString() +" !";
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
        public void Customer_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            KhachHangF fr = new KhachHangF(this);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Add_Customer_Click(int TrangThai,string MAKH)
        {
            //Trạng thái : 0 (Xem) 1 (Thêm) 2 (Sửa)
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            DetailCustomer fr = new DetailCustomer(this,TrangThai,MAKH);
            fr.MdiParent = this;

            fr.Show();
            fr.Dock = DockStyle.Fill;
        }
        private void Service_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            DichVuF fr = new DichVuF(MANV);
            fr.MdiParent = this;
            fr.Show();
            
        }
        public void Calendar_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            LichHenF fr = new LichHenF(this);
            fr.MdiParent = this;
            fr.Show();

        }
        public void Craete_Calendar_Click(int tt)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            TaoLichHen fr = new TaoLichHen(this,tt);
            fr.MdiParent = this;
            fr.Show();

        }
        public void Paid_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            HoaDonF fr = new HoaDonF(this,MANV);
            fr.MdiParent = this;
            fr.Show();
        }
        public void Detail_Paid_Click(string MAHD)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            DetailBill fr = new DetailBill(this,MANV,MAHD);
            fr.MdiParent = this;
            fr.Show();
        }
        private void Product_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = pnTalk.Visible = false;
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;
            SanPhamF fr = new SanPhamF(MANV);
            fr.MdiParent = this;
            fr.Show();
        }
        private void TrangChu_Load(object sender, EventArgs e)
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
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
