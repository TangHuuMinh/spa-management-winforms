using QuanLy_Spa.CustomControl;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLy_Spa
{
    public partial class LichHenF : Form
    {
        public LichHenF(TrangChuNV nv)
        {
            InitializeComponent();
            NV = nv;
        }
        TrangChuNV NV;
        int total = 1;
        int nowpage = 1;
        ConnectDB db = new ConnectDB();
        string qr = "";
        string[] colors = new string[]
        {
            "#FF5733", // A: Đỏ tươi
            "#1E3A8A", // B: Xanh biển đậm
            "#FFC107", // C: Vàng
            "#388E3C", // D: Xanh lá cây đậm
            "#FF7043", // E: Cam sáng
            "#F50057", // F: Hồng
            "#2196F3", // G: Xanh dương
            "#9C27B0", // H: Tím đậm
            "#4CAF50", // I: Xanh lá nhạt
            "#009688", // J: Xanh ngọc
            "#FFEB3B", // K: Vàng nhạt
            "#795548", // L: Nâu đất
            "#9E9E9E", // M: Xám
            "#8BC34A", // N: Xanh lá cây nhạt
            "#FF9800", // O: Cam
            "#E040FB", // P: Tím nhạt
            "#3F51B5", // Q: Màu xanh navy
            "#D32F2F", // R: Đỏ đậm
            "#9C27B0", // S: Màu mận
            "#03A9F4", // T: Màu xanh dương nhạt
            "#CDDC39", // U: Màu vàng chanh
            "#B0BEC5", // V: Màu bạc
            "#FF4081", // W: Màu hồng nhạt
            "#212121", // X: Màu xám đen
            "#8BC34A", // Y: Màu xanh lá cây rực rỡ
            "#795548"  // Z: Màu nâu
        };
        private void LichHenF_Load(object sender, EventArgs e)
        {
            int kq = db.getNonQuery("update lich_hen set trangthai = 2 where NGAY_DAT_LICH < '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0");
            DataTable dt = db.getDataTable("select * from LICH_HEN where NGAY_DAT_LICH = GETDATE() and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc");
            nowpage = total = 1;
            if (dt.Rows.Count > 0)
            {
                total = dt.Rows.Count / 5;
                if (dt.Rows.Count % 5 != 0) total += 1;
            }
            txbNowPage.Text = nowpage.ToString();
            txbTotalPage.Text = "  /  "+ total.ToString();
            qr = "select * from LICH_HEN where NGAY_DAT_LICH = '"+DateTime.Now.ToString("yyyy-MM-dd")+ "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc";
            changePage(qr);
        }
        void LoadInfo(DataRow r)
        {
            Panel p = new Panel();
            p.BackColor = Color.White;
            p.Padding = new Padding(10, 10, 10, 10);
            p.Size = new Size(1045, 102);
            MainContainer.Controls.Add(p);

            DataTable KhachHang = db.getDataTable("select * from khachhang where makh = '" + r["MAKH"].ToString().Trim() + "'");
            string[] ten = KhachHang.Rows[0]["HOTEN"].ToString().Trim().Split(' ');
            VBButton BT = new VBButton();
            BT.Size = new Size(45, 45);
            BT.BorderRadius = 22;
            BT.Location = new Point(20, 30);
            char T = Convert.ToChar((ten[ten.Length - 1])[0].ToString().ToUpper());
            int k = (Convert.ToInt32(T));
            if (k >= 90 || k<65) k = 65;
            BT.BackColor = ColorTranslator.FromHtml(colors[k-65]);
            BT.ForeColor = Color.White;
            BT.Text = (ten[ten.Length - 1])[0].ToString();

            Label Name = new Label();
            Name.Location = new Point(86, 25);
            Name.AutoSize = true;
            Name.Text = KhachHang.Rows[0]["HOTEN"].ToString().Trim();

            LinkLabel Email = new LinkLabel();
            Email.Location = new Point(86, 58);
            Email.AutoSize = true;
            Email.Text = KhachHang.Rows[0]["EMAIL"].ToString().Trim();

            Label Phone = new Label();
            Phone.Location = new Point(318, 36);
            Phone.Text = KhachHang.Rows[0]["SDT"].ToString().Trim();

            Label Service = new Label();
            Service.Location = new Point(497, 36);
            Service.Text = db.getDataTable("select * from dichvu where MADV = '" +r["MADV"].ToString().Trim()+"'").Rows[0]["TENDV"].ToString().Trim();

            Label CalenderDay = new Label();
            CalenderDay.Location = new Point(696, 25);
            CalenderDay.Text = Convert.ToDateTime(r["NGAY_DAT_LICH"].ToString().Trim()).ToString("dd/MM/yyyy");

            Label Calender = new Label();
            Calender.Location = new Point(690, 58);
            Calender.Text = r["THOIGIAN_BATDAU"].ToString().Trim()+" - "+ r["THOIGIAN_KETTHUC"].ToString().Trim();

            string tt = r["TRANGTHAI"].ToString().Trim();
            Label Status = new Label();
            Status.Location = new Point(862, 36);
            Status.ForeColor = (tt == "0") ? Color.Red : ((tt == "1") ? Color.Blue : Color.Green);
            Status.Text = (tt == "0") ? "Chưa đến" : "Hoàn thành";
            Status.Tag = Convert.ToInt32(r["MALICHHEN"].ToString().Trim());
            Status.DoubleClick += Status_DoubleClick;

            Panel pn = new Panel();
            pn.BackColor = Color.LightGray;
            pn.Size = new Size(1043, 2);
            pn.Location = new Point(0, 97);

            p.Controls.Add(BT);
            p.Controls.Add(Name);
            p.Controls.Add(Email);
            p.Controls.Add(Service);
            p.Controls.Add(Calender);
            p.Controls.Add(CalenderDay);
            p.Controls.Add(Phone);
            p.Controls.Add(Status);
            p.Controls.Add(pn);

        }

        private void Status_DoubleClick(object sender, EventArgs e)
        {
            int tag = Convert.ToInt32((sender as Label).Tag);
            string tt = (sender as Label).Text.Trim();
            DateTime d = Convert.ToDateTime(db.getDataTable("select NGAY_DAT_LICH from lich_hen where MALICHHEN = " + tag).Rows[0]["NGAY_DAT_LICH"].ToString().Trim());
            if (d.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                if (tt == "Chưa đến")
                {
                    if (MessageBox.Show("Khách đã đến và xác nhận tại quầy?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {

                        int kq = db.getNonQuery("update LICH_HEN set TRANGTHAI = 1 where MALICHHEN = " + tag);
                        changePage(qr);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa đến ngày hẹn?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changePage(string qr)
        {
            MainContainer.Controls.Clear();
            DataTable dt = db.getDataTable(qr);
            if (dt.Rows.Count > 0)
            {
                int sum = 5 * nowpage;
                if (dt.Rows.Count % 5 != 0 && total == nowpage) sum = dt.Rows.Count;
                for (int i = ((nowpage - 1) * 5); i < sum; i++)
                {
                    LoadInfo(dt.Rows[i]);
                }
            }
        }
        #region Page 
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (nowpage > 1)
            {
                nowpage--;
                txbNowPage.Text = nowpage.ToString();
                changePage(qr);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nowpage + 1 <= total)
            {
                nowpage++;
                txbNowPage.Text = nowpage.ToString();
                changePage(qr);
            }
        }



        #endregion
        private void lbOderDay_Click(object sender, EventArgs e)
        {

            DateTime dtp = dtpk.Value;
            Label lb = sender as Label;
            panel2.Location = new Point(lb.Location.X-1,panel2.Location.Y);
            DataTable dt = db.getDataTable("select * from LICH_HEN where NGAY_DAT_LICH = '" + dtp.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc");
            nowpage = total = 1;
            if (dt.Rows.Count > 0)
            {
                total = dt.Rows.Count / 5;
                if (dt.Rows.Count % 5 != 0) total += 1;
            }
            txbNowPage.Text = nowpage.ToString();
            txbTotalPage.Text = "  /  " + total.ToString();
            qr = "select * from LICH_HEN where NGAY_DAT_LICH = '" + dtp.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc";
            changePage(qr);
        }

        private void lbSet_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            panel2.Location = new Point(lb.Location.X - 1, panel2.Location.Y);
            NV.Craete_Calendar_Click(1);
        }

        //private void lbCancel_Click(object sender, EventArgs e)
        //{
        //    Label lb = sender as Label;
        //    panel2.Location = new Point(lb.Location.X - 1, panel2.Location.Y);
        //    DataTable dt = db.getDataTable("select * from LICH_HEN where NGAY_DAT_LICH < '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and trangthai = 0 order by THOIGIAN_BATDAU asc");
        //    nowpage = total = 1;
        //    if (dt.Rows.Count > 0)
        //    {
        //        total = dt.Rows.Count / 5;
        //        if (dt.Rows.Count % 5 != 0) total += 1;
        //    }
        //    txbNowPage.Text = nowpage.ToString();
        //    txbTotalPage.Text = "  /  " + total.ToString();
        //    qr = "select * from LICH_HEN where NGAY_DAT_LICH < '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and trangthai = 0 order by THOIGIAN_BATDAU asc";
        //    changePage(qr);
        //}

        private void lbNowDay_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
            Label lb = sender as Label;
            panel2.Location = new Point(lb.Location.X - 1, panel2.Location.Y);
            DataTable dt = db.getDataTable("select * from LICH_HEN where NGAY_DAT_LICH = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by THOIGIAN_BATDAU asc");
            nowpage = total = 1;
            if (dt.Rows.Count > 0)
            {
                total = dt.Rows.Count / 5;
                if (dt.Rows.Count % 5 != 0) total += 1;
            }
            txbNowPage.Text = nowpage.ToString();
            txbTotalPage.Text = "  /  " + total.ToString();
            qr = "select * from LICH_HEN where NGAY_DAT_LICH = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc";
            changePage(qr);
        }
        private void lbEdit_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            panel2.Location = new Point(lb.Location.X - 1, panel2.Location.Y);
            NV.Craete_Calendar_Click(2);
        }
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            if(panel2.Location.X == lbOderDay.Location.X-1)
            {
                DateTime dtp = dtpk.Value;
  
                DataTable dt = db.getDataTable("select * from LICH_HEN where NGAY_DAT_LICH = '" + dtp.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc");
                nowpage = total = 1;
                if (dt.Rows.Count > 0)
                {
                    total = dt.Rows.Count / 5;
                    if (dt.Rows.Count % 5 != 0) total += 1;
                }
                txbNowPage.Text = nowpage.ToString();
                txbTotalPage.Text = "  /  " + total.ToString();
                qr = "select * from LICH_HEN where NGAY_DAT_LICH = '" + dtp.ToString("yyyy-MM-dd") + "' and TRANGTHAI = 0 order by THOIGIAN_BATDAU asc";
                changePage(qr);
            }
        }
    }
}
