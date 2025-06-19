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
using System.Xml.Linq;

namespace QuanLy_Spa
{
    public partial class SanPhamF : Form
    {
        public SanPhamF(string manv)
        {
            InitializeComponent();
            MANV = manv;
            foreach (DataGridViewColumn cl in dtgvBill.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ConnectDB db = new ConnectDB();
        public static string MANV { get; set; }
        int nowpage = 1;
        int totalpage = 1;
        int cd = -1;
        string MALSP = "";
        Random r = new Random();
        DataTable dtsp = new DataTable();
        #region method
        void LoadNewPage()
        {
            nowpage = 1;
            txbNowPage.Text = "1";
            totalpage = dtsp.Rows.Count % 6 == 0 ? dtsp.Rows.Count / 6 : (dtsp.Rows.Count / 6) + 1;
            if (totalpage == 0) totalpage = 1;
            txbTotalPage.Text = "/ " + totalpage.ToString();
            LoadPage(dtsp);
        }
        void LoadPage(DataTable dtsp)
        {

            flpnProduct.Controls.Clear();
            if (dtsp.Rows.Count > 0)
            {
                int sum = (nowpage == totalpage) ? (dtsp.Rows.Count) : (nowpage * 6);
                for (int i = (nowpage - 1) * 6; i < sum; i++)
                {
                    DataRow dr = dtsp.Rows[i];
                    Panel p = new Panel();
                    p.Size = new Size(221, 279);
                    p.Margin = new Padding(8, 10, 10, 10);
                    p.BorderStyle = BorderStyle.FixedSingle;

                    Label SLTon = new Label();
                    SLTon.BackColor = Color.White;
                    SLTon.Text = dr[6].ToString().Trim(); 
                    SLTon.Location = new Point(170, 3);
                    SLTon.ForeColor = Color.Black;
                    SLTon.Font = new Font("Times New Roman", 12);
                    SLTon.Size = new Size(48, 30);
                    SLTon.TextAlign = ContentAlignment.MiddleCenter;
                    SLTon.AutoSize = false;

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(140, 140);
                    pb.Location = new Point(30, 3);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (dr[3].ToString().Trim() == "")
                    { pb.Image = new Bitmap(Application.StartupPath + "\\Product_Resources\\empty-img.png"); }
                    else
                    { pb.Image = new Bitmap(Application.StartupPath + "\\Product_Resources\\"+ dr[3].ToString().Trim()); }

                    Label lbName = new Label();
                    lbName.AutoSize = true;
                    lbName.Size = new Size(171, 25);
                    lbName.Location = new Point(25, 165);
                    lbName.ForeColor = Color.MidnightBlue;
                    lbName.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                    string name = dr[1].ToString();
                    lbName.Text = name.Length < 20 ? name : name.Substring(0, 21) + "...";

                    Label lbPrice = new Label();
                    lbPrice.AutoSize = true;
                    lbPrice.Size = new Size(137, 25);
                    lbPrice.Location = new Point(60, 202);
                    lbPrice.ForeColor = Color.FromArgb(195, 0, 0);
                    lbPrice.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                    lbPrice.Text = string.Format("{0:0,0 vnđ}",Convert.ToInt32(dr[2].ToString().Trim()));

                    System.Windows.Forms.Button bt = new System.Windows.Forms.Button();
                    int SLTON = Convert.ToInt32(dr[6].ToString());
                    bt.Text = SLTON == 0 ? ("Hết hàng") : "Chọn";
                    if(SLTON==0) SLTon.ForeColor = Color.Red;
                    bt.Enabled = SLTON == 0 ? false : true;
                    bt.ForeColor = Color.White;
                    bt.BackColor = SLTON == 0 ? Color.White : Color.DodgerBlue;
                    bt.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Size = new Size(140, 31);
                    bt.Location = new Point(35, 239);
                    bt.Tag =  dr[0].ToString();
                    bt.Click += Bt_Click;

                    p.Controls.Add(SLTon);
                    p.Controls.Add(lbName);
                    p.Controls.Add(lbPrice);
                    p.Controls.Add(bt);
                    p.Controls.Add(pb);
                    flpnProduct.Controls.Add(p);
                }
            }
        }
        void LoadLoaiSP()
        {
            DataTable dt = db.getDataTable("select * from LOAI_SANPHAM");
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += Item_Click; ;
                item.Tag = r["MALOAISP"];
                Category.DropDownItems.Add(item);
                MALSP = r["MALOAISP"].ToString();
            }
        }
        void LoadHoaDon()
        {
            DataTable dt = db.getDataTable("select * from HOADON where NGAYLAP is null");
            cbbHoaDon.DataSource = dt;
            cbbHoaDon.DisplayMember = "MAHD";
            cbbHoaDon.ValueMember = "MAHD";
            LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString().Trim());
        }
        void LoadChiTietHoaDon(string mahd)
        {
            DataTable dt = db.getDataTable("select 1 as ID,TENSP,ct.SOLUONG from CHITIET_HOADON_SP ct,SANPHAM SP where MAHD = '"+mahd+"' and SP.MASP = ct.MASP");

            dtgvBill.DataSource = dt;
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                i++;
                r["ID"] = i.ToString();
            }
            dt = db.getDataTable("DECLARE @SUM INT SET @SUM = DBO.TONGTIEN_HOADON_SP('HD006') SELECT @SUM AS SUM");
            foreach (DataRow r in dt.Rows)
            {
                lbToTalPrice.Text = r["SUM"].ToString();
            }
            lbSumCount.Text = db.getScalar("select count(*) from CHITIET_HOADON_SP where MAHD = '" + cbbHoaDon.SelectedValue.ToString().Trim() + "'").ToString();
        }
        string GetIDProduct(string name)
        {
            DataTable dt = db.getDataTable("select MASP from SANPHAM where TENSP = N'" + name + "'");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["MASP"].ToString();
            return n.Trim();
        }
        string GetPriceProduct(string masp)
        {
            DataTable dt = db.getDataTable("select GIATIEN from SANPHAM where MASP = '" + masp + "'");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["GIATIEN"].ToString();
            return n.Trim();
        }
        int GetQuantityProductFromDetailBill(string mahd,string masp)
        {
            DataTable dt = db.getDataTable("select SOLUONG from chitiet_hoadon_sp where MASP = '" + masp + "' and mahd ='"+mahd+"'");
            string n = "";
            foreach (DataRow dr in dt.Rows)
                n = dr["SOLUONG"].ToString().Trim();
            return Convert.ToInt32(n);
        }
        int KiemTraSLTon(string MASP)
        {
            DataTable dt = db.getDataTable("select SLTON from SANPHAM where MASP = '" + MASP + "'");
            string n = "1";
            foreach (DataRow dr in dt.Rows)
                n = dr["SLTON"].ToString().Trim();
            return Convert.ToInt32(n);
        }
        int KiemTraTrangThaiTonTai(string mahd,string MASP)
        {
            return db.getScalar("select count(*) from chitiet_hoadon_sp where MAHD = '"+mahd+"' and masp ='"+MASP+"'");
        }
        #endregion
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            MALSP = item.Tag.ToString();
            dtsp = db.getDataTable("select * from SANPHAM where MALOAISP='" + item.Tag.ToString() + "'");
            LoadNewPage();
        }
        private void SanPhamF_Load(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM");
            LoadNewPage();
            LoadHoaDon();
            LoadLoaiSP();
        }
        #region Thêm sản phẩm vào hóa đơn
        private void Bt_Click(object sender, EventArgs e)
        {
            int kq = db.getScalar("select count(*) from HOADON where MAHD = '" + cbbHoaDon.Text.ToString().Trim() + "'");
            if (kq > 0)
            {
                Button b = sender as Button;
                int rs;
                bool c = (int.TryParse(nmudBS.Value.ToString(), out rs));
                if ( c && rs>0)
                {
                    if (rs > KiemTraSLTon(b.Tag.ToString().Trim()))
                    {
                        MessageBox.Show("Số lượng sản phẩm thêm lớn hơn số lượng tồn", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string msp = "'" + b.Tag.ToString().Trim() + "',";
                        string mhd = "'" + cbbHoaDon.SelectedValue.ToString().Trim() + "',";
                        string sl = rs + ",";
                        float gia = (float)Convert.ToDouble(GetPriceProduct(b.Tag.ToString().Trim()));
                        string qr = "insert CHITIET_HOADON_SP values(" + mhd + msp + sl + gia + ")";
                        kq = 0;
                        if (KiemTraTrangThaiTonTai(cbbHoaDon.SelectedValue.ToString().Trim(), b.Tag.ToString().Trim()) != 0)
                        {
                            int slc = GetQuantityProductFromDetailBill(cbbHoaDon.SelectedValue.ToString().Trim(), b.Tag.ToString().Trim());
                            qr = "EXEC DBO.CAPNHAT_SOLUONGTON_CAPNHAT_HD @MAHD = " + mhd + "@MASP=" + msp + "@SLMOI =" + (slc + rs);
                            kq = db.getNonQuery(qr);
                        }
                        else
                        {
                            kq = db.getNonQuery(qr);
                        }
                        dtsp = db.getDataTable("select * from sanpham");
                        if(KiemTraSLTon(b.Tag.ToString().Trim())==0) LoadPage(dtsp);
                        LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString());

                    }
                }
                else MessageBox.Show("Định dạng số lượng sản phẩm thêm đang không đúng","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            else
            {
                MessageBox.Show("Vui lòng chọn lại hóa đơn", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
        #region Chuyển trang
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (nowpage > 1)
            {
                nowpage--;
                txbNowPage.Text = nowpage.ToString();
                LoadPage(dtsp);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nowpage + 1 <= totalpage)
            {
                nowpage++;
                txbNowPage.Text = nowpage.ToString();
                LoadPage(dtsp);
            }
        }
        #endregion
        #region Lấy tất cả sản phẩm
        private void Menu_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM");
            LoadNewPage();
        }
        #endregion
        #region Sản phẩm còn hàng
        private void Active_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where SLTON > 0");
            LoadNewPage();
        }
        #endregion
        #region Sản phẩm hết hàng
        private void NoneActive_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where SLTON = 0");
            LoadNewPage();
        }
        #endregion
        #region Sản phẩm theo giá tiền
        private void S0_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN < 100000");
            LoadNewPage();
        }
        private void S1_Click(object sender, EventArgs e)
        {
            nowpage = 1;
            txbNowPage.Text = "1";
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN >= 100000 and GIATIEN <300000");
            totalpage = dtsp.Rows.Count % 6 == 0 ? dtsp.Rows.Count / 6 : (dtsp.Rows.Count / 6) + 1;
            txbTotalPage.Text = "/ " + totalpage.ToString();
            LoadPage(dtsp);
        }
        private void S2_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN >= 300000 and GIATIEN <500000");
            LoadNewPage();
        }
        private void S3_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN >= 500000 and GIATIEN <1000000");
            LoadNewPage();
        }
        private void S4_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN <1000000");
            LoadNewPage();
        }
        private void S5_Click(object sender, EventArgs e)
        {
            dtsp = db.getDataTable("select * from SANPHAM where GIATIEN >= 1000000");
            LoadNewPage();
        }
        #endregion
        #region Sản phẩm theo tên
        private void txbName_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text == "Tra cứu theo tên")
            {
                t.Text = "";
                t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                t.ForeColor = Color.Black;
            }
        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text != "" && txbName.Text != "Tra cứu theo tên") dtsp= db.getDataTable("select * from sanpham where TENSP like '%" + txbName.Text + "%'");
            else dtsp = db.getDataTable("select * from sanpham");
            LoadNewPage();
        }
        private void txbName_MouseLeave(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Trim().Length < 1)
            {
                t.Text = "Tra cứu theo tên";
                t.Font = new Font("Times New Roman", 12, FontStyle.Italic);
                t.ForeColor = Color.Gray;

            }
            t.Enabled = false;
            t.Enabled = true;
        }
        #endregion
        #region Danh sách hóa đơn
        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString().Trim());
        }
        #endregion
        #region Xoá sản phẩm khỏi hóa đơn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int kq = db.getScalar("select count(*) from HOADON where MAHD = '" + cbbHoaDon.Text.ToString().Trim() + "'");
            if (kq > 0)
            {
                string mahd = cbbHoaDon.SelectedValue.ToString().Trim();
                List<string> DS_XOA = new List<string>();
                for (int i = 0; i < dtgvBill.Rows.Count; i++)
                {
                    if ((bool)dtgvBill.Rows[i].Cells[0].FormattedValue)
                    {
                        DS_XOA.Add(GetIDProduct(dtgvBill.Rows[i].Cells[2].Value.ToString().Trim()));
                    }
                }
                foreach (string s in DS_XOA)
                {
                    kq = db.getNonQuery("delete CHITIET_HOADON_SP where MAHD = '" + mahd + "' and MASP = '" + s + "'");
                }
                dtsp = db.getDataTable("select * from sanpham");
                LoadPage(dtsp);
                LoadChiTietHoaDon(cbbHoaDon.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại hóa đơn", "",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        #endregion
    }
}
