using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLy_Spa.QuanLy
{
    public partial class QLThongKe : Form
    {
        public QLThongKe()
        {
            InitializeComponent();
        }
        ConnectDB db = new ConnectDB();
        string Row = "", Row1 = "";
        string MASP = "", MADV = "";
        string TENSP = "", TENDV = "";
        string MALSP = "";
        #region San pham con hang ton
        void LoadSPConHang()
        {
            DataTable dt = db.getDataTable("select * from LOAI_SANPHAM");
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += SPConHang_Click;
                item.Tag = (r["MALOAISP"].ToString().Trim() + 0);
                SapHet.DropDownItems.Add(item);
            }
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += SPConHang_Click ;
                item.Tag = (r["MALOAISP"].ToString().Trim() + 1);
                Con.DropDownItems.Add(item);
            }
        }
        private void SPConHang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string MA = item.Tag.ToString();
            if (MA.Substring(6,1).ToString() == "0")
            {
                MALSP = MA.Substring(0, 6).ToString().Trim();
                paint3();
            }
            else if (MA.Substring(6,1).ToString() == "1")
            {
                MALSP = MA.Substring(0, 6).ToString().Trim();
                paint4();
            }
        }
        #endregion
        void LoadSanPham()
        {
            DataTable dt = db.getDataTable("select * from LOAI_SANPHAM");
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAISP"].ToString().Trim() + i);
                P_Day.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from SANPHAM where MALOAISP = '"+ r["MALOAISP"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENSP"].ToString();
                    item1.Text = r1["TENSP"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MASP"].ToString().Trim() + i);
                    item.Click += Item_Click;
                    item.DropDownItems.Add(item1);
                }
            }
            i++;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAISP"].ToString().Trim() + i);
                P_Month.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from SANPHAM where MALOAISP = '" + r["MALOAISP"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENSP"].ToString();
                    item1.Text = r1["TENSP"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MASP"].ToString().Trim() + i);
                    item.Click += Item_Click;
                    item.DropDownItems.Add(item1);
                }
            }
            i++;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENLOAISP"].ToString();
                item.Text = r["TENLOAISP"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAISP"].ToString().Trim() + i);
                P_Year.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from SANPHAM where MALOAISP = '" + r["MALOAISP"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENSP"].ToString();
                    item1.Text = r1["TENSP"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MASP"].ToString().Trim() + i);
                    item.Click += Item_Click;
                    item.DropDownItems.Add(item1);
                }
            }
        }
        void LoadDichVu()
        {
            DataTable dt = db.getDataTable("select * from LOAI_DICHVU");
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENDV"].ToString();
                item.Text = r["TENDV"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAIDV"].ToString().Trim() + i);
                S_Day.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from DICHVU where MALOAIDV = '" + r["MALOAIDV"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENDV"].ToString();
                    item1.Text = r1["TENDV"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MADV"].ToString().Trim() + i);
                    item.DropDownItems.Add(item1);
                    item1.Click += Item_Click;
                }
            }
            i++;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENDV"].ToString();
                item.Text = r["TENDV"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAIDV"].ToString().Trim() + i);
                S_Month.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from DICHVU where MALOAIDV = '" + r["MALOAIDV"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENDV"].ToString();
                    item1.Text = r1["TENDV"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MADV"].ToString().Trim() + i);
                    item.DropDownItems.Add(item1);
                    item1.Click += Item_Click;
                }
            }
            i++;
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = r["TENDV"].ToString();
                item.Text = r["TENDV"].ToString();
                item.Click += Item_Click;
                item.Tag = (r["MALOAIDV"].ToString().Trim() + i);
                S_Year.DropDownItems.Add(item);
                DataTable dt1 = db.getDataTable("select * from DICHVU where MALOAIDV = '" + r["MALOAIDV"].ToString().Trim() + "'");
                foreach (DataRow r1 in dt1.Rows)
                {
                    ToolStripMenuItem item1 = new ToolStripMenuItem();
                    item1.Name = r1["TENDV"].ToString();
                    item1.Text = r1["TENDV"].ToString();
                    item1.Click += Item_Click;
                    item1.Tag = (r1["MADV"].ToString().Trim() + i);
                    item.DropDownItems.Add(item1);
                    item1.Click += Item_Click;
                }
            }
        }
        private void QLThongKe_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadSanPham();
            LoadSPConHang();
            Row = "NGAY";
            paint();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string MA = item.Tag.ToString();
            if (MA.Substring(0, 2).ToString() == "SP")
            {
                Row1 = MA.Substring(5, 1).ToString();
                TENSP = item.Text.Trim();
                MASP = MA.Substring(0, 5).ToString();
                paint1();
            }
            else if(MA.Substring(0, 2).ToString() == "DV")
            {
                Row1 = MA.Substring(5, 1).ToString();
                TENDV = item.Text.Trim();
                MADV = MA.Substring(0, 5).ToString();
                paint2();
            }
        }
        #region Doanh thu
        private void Day_D_Click(object sender, EventArgs e)
        {
            Row = "NGAY";
            paint();
        }
        private void Month_D_Click(object sender, EventArgs e)
        {
            Row = "THANG";
            paint();
        }
        private void Year_D_Click(object sender, EventArgs e)
        {
            Row = "NAM";
            paint();
        }
        #endregion
        void paint()
        {
            pnChart.Controls.Clear();
            Label lbchart = new Label();
            lbchart.Location = new Point(380, 11);
            lbchart.Font = new Font("MV Boli", 20, FontStyle.Bold);
            lbchart.AutoSize = true;
            lbchart.ForeColor = Color.Black;
            Chart chart = new Chart();
            chart.Size = new Size(1009, 617);
            chart.Location = new Point(21, 80);
            chart.Palette = ChartColorPalette.Excel;
            chart.BackColor = Color.White;

            pnChart.Controls.Add(chart);
            

            DataTable dt = db.getDataTable("select * from DoanhThuTheoNam()");
            lbchart.Text = "Thống kê doanh thu theo năm";
            string str = "Năm";
            if (Row == "THANG")
            {
                lbchart.Location = new Point(250, 11);
                lbchart.Text = "Thống kê doanh thu theo tháng ( năm " + DateTime.Now.Year+" )";
                str = "Tháng";
                dt = db.getDataTable("select * from DoanhThuTheoThang(" + DateTime.Now.Year + ")");
            }
            else if (Row == "NGAY")
            {
                lbchart.Location = new Point(250, 11);
                lbchart.Text = "Thống kê doanh thu theo ngày ( tháng " + DateTime.Now.Month +"/" + DateTime.Now.Year + " )";
                dt = db.getDataTable("select * from DoanhThuTheoNgay(" + DateTime.Now.Month + ")");
                str = "Ngày";
            }
            var s = new Series();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            s.YValueType = ChartValueType.Auto;
            s.ChartType = SeriesChartType.Column;
            if (Row == "THANG")
            {
                s.ChartType = SeriesChartType.Area;
                for (int i=1;i<=12;i++)
                {
                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r[Row].ToString().Trim()) == i)
                        {
                            s.Points.AddXY(Convert.ToInt32(r[Row].ToString().Trim()), Convert.ToInt32(r["TONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if(!check)
                    {
                        s.Points.AddXY(i,0);
                    }
                }
                
            }
            else if (Row == "NGAY")
            {
                s.ChartType = SeriesChartType.Spline;
                int songay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                for (int i = 1; i <= songay; i++)
                {
                    
                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r[Row].ToString().Trim()) == i)
                        {
                        
                            s.Points.AddXY(Convert.ToInt32(r[Row].ToString().Trim()), Convert.ToInt32(r["TONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        s.Points.AddXY(i, 0);
                        
                    }
                }
                
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    s.Points.AddXY(Convert.ToInt32(r[Row].ToString().Trim()), Convert.ToInt32(r["TONG"].ToString()));
                }
            }
            s.Name = "Doanh Thu";
            
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Title = str;
            chart.ChartAreas[0].AxisY.Title = "Giá trị";
            s.IsValueShownAsLabel = true;
            chart.Series.Add(s);
            pnChart.Controls.Add(lbchart);
        }
        void paint1()
        {
            pnChart.Controls.Clear();
            Label lbchart = new Label();
            lbchart.Location = new Point(380, 11);
            lbchart.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbchart.AutoSize = true;
            lbchart.ForeColor = Color.Black;
            Label lbName = new Label();
            lbName.Location = new Point(10, 55);
            lbName.Font = new Font("Times New Roman", 17, FontStyle.Bold);
            lbName.AutoSize = true;
            lbName.ForeColor = Color.DarkRed;
            Chart chart = new Chart();
            chart.Size = new Size(1009, 617);
            chart.Location = new Point(21, 80);
            chart.Palette = ChartColorPalette.Excel;
            chart.BackColor = Color.White;

            pnChart.Controls.Add(chart);
            pnChart.Controls.Add(lbName);

            DataTable dt = db.getDataTable("select * from SOBAN_SP_THEONAM('"+MASP+"')");
            lbchart.Text = "Thống kê số lượng bán theo năm";
            lbName.Text = TENSP;
            string str = "Năm";
            if (Row1 == "0")
            {
                lbchart.Location = new Point(250, 11);
                
                lbchart.Text = "Thống kê số lượng bán theo ngày ( tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year + " )";
                lbName.Text = TENSP;
                str = "Ngày";
                dt = db.getDataTable("select * from SOBAN_SP_THEONGAY(" + DateTime.Now.Month + ",'"+MASP+"')");
            }
            else if (Row1 == "1")
            {
                lbchart.Location = new Point(250, 11);
                lbchart.Text = "Thống kê số lượng bán theo tháng ( năm " + DateTime.Now.Year + " )";
                lbName.Text = TENSP;
                dt = db.getDataTable("select * from SOBAN_SP_THEOTHANG(" + DateTime.Now.Year + ",'" + MASP + "')");
                str = "Tháng";
            }
            var s = new Series();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            s.YValueType = ChartValueType.Auto;
            s.ChartType = SeriesChartType.Column;
            if (Row1 == "1")
            {
                s.ChartType = SeriesChartType.Area;
                for (int i = 1; i <= 12; i++)
                {
                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r["THANG"].ToString().Trim()) == i)
                        {
                            s.Points.AddXY(i, Convert.ToInt32(r["SOLUONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        s.Points.AddXY(i, 0);
                    }
                }
            }
            else if (Row1 == "0")
            {
                s.ChartType = SeriesChartType.Spline;
                int songay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                for (int i = 1; i <= songay; i++)
                {

                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r["NGAY"].ToString().Trim()) == i)
                        {

                            s.Points.AddXY(i, Convert.ToInt32(r["SOLUONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        s.Points.AddXY(i, 0);

                    }
                }

            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    s.Points.AddXY(Convert.ToInt32(r["NAM"].ToString().Trim()), Convert.ToInt32(r["SOLUONG"].ToString()));
                }
            }
            s.Name = "Doanh Thu";

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Title = str;
            chart.ChartAreas[0].AxisY.Title = "Giá trị";
            s.IsValueShownAsLabel = true;
            chart.Series.Add(s);
            int X = Convert.ToInt32((pnChart.Width - lbName.Size.Width) / 2);
            lbName.Location = new Point(X, lbName.Location.Y);
            pnChart.Controls.Add(lbchart);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        void paint2()
        {
            pnChart.Controls.Clear();
            Label lbchart = new Label();
            lbchart.Location = new Point(380, 11);
            lbchart.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbchart.AutoSize = true;
            lbchart.ForeColor = Color.Black;
            Label lbName = new Label();
            lbName.Location = new Point(10, 55);
            lbName.Font = new Font("Times New Roman", 17, FontStyle.Bold);
            lbName.AutoSize = true;
            lbName.ForeColor = Color.DarkRed;
            Chart chart = new Chart();
            chart.Size = new Size(1009, 617);
            chart.Location = new Point(21, 80);
            chart.Palette = ChartColorPalette.Excel;
            chart.BackColor = Color.White;

            pnChart.Controls.Add(chart);
            pnChart.Controls.Add(lbName);

            DataTable dt = db.getDataTable("select * from LUONG_PV_THEONAM('" + MADV + "')");
            lbchart.Text = "Thống kê lượng phục vụ theo năm";
            lbName.Text = TENDV;
            string str = "Năm";
            if (Row1 == "0")
            {
                lbchart.Location = new Point(250, 11);

                lbchart.Text = "Thống kê lượng phục vụ theo ngày ( tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year + " )";
                lbName.Text = TENDV;
                str = "Ngày";
                dt = db.getDataTable("select * from LUONG_PV_THEONGAY(" + DateTime.Now.Month + ",'" + MADV + "')");
            }
            else if (Row1 == "1")
            {
                lbchart.Location = new Point(250, 11);
                lbchart.Text = "Thống kê lượng phục vụ theo tháng ( năm " + DateTime.Now.Year + " )";
                lbName.Text = TENDV;
                dt = db.getDataTable("select * from LUONG_PV_THEOTHANG(" + DateTime.Now.Year + ",'" + MADV + "')");
                str = "Tháng";
            }
            var s = new Series();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            s.YValueType = ChartValueType.Auto;
            s.ChartType = SeriesChartType.Column;
            if (Row1 == "1")
            {
                s.ChartType = SeriesChartType.Area;
                for (int i = 1; i <= 12; i++)
                {
                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r["THANG"].ToString().Trim()) == i)
                        {
                            s.Points.AddXY(i, Convert.ToInt32(r["SOLUONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        s.Points.AddXY(i, 0);
                    }
                }
            }
            else if (Row1 == "0")
            {
                s.ChartType = SeriesChartType.Spline;
                int songay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                for (int i = 1; i <= songay; i++)
                {

                    bool check = false;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (Convert.ToInt32(r["NGAY"].ToString().Trim()) == i)
                        {

                            s.Points.AddXY(i, Convert.ToInt32(r["SOLUONG"].ToString()));
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        s.Points.AddXY(i, 0);

                    }
                }

            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    s.Points.AddXY(Convert.ToInt32(r["NAM"].ToString().Trim()), Convert.ToInt32(r["SOLUONG"].ToString()));
                }
            }
            s.Name = "Doanh Thu";

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Title = str;
            chart.ChartAreas[0].AxisY.Title = "Giá trị";
            s.IsValueShownAsLabel = true;
            chart.Series.Add(s);
            int X = Convert.ToInt32((pnChart.Width - lbName.Size.Width) / 2);
            lbName.Location = new Point(X, lbName.Location.Y);
            pnChart.Controls.Add(lbchart);
        }
        void paint3()
        {
            pnChart.Controls.Clear();
            Label lbchart = new Label();
            lbchart.Location = new Point(380, 11);
            lbchart.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbchart.AutoSize = true;
            lbchart.ForeColor = Color.Black;
            Chart chart = new Chart();
            chart.Size = new Size(1009, 617);
            chart.Location = new Point(21, 80);
            chart.Palette = ChartColorPalette.Excel;
            chart.BackColor = Color.White;

            pnChart.Controls.Add(chart);


            DataTable dt = db.getDataTable("select *from SANPHAM where SLTON <=3 and MALOAISP = '"+MALSP+"'");
            lbchart.Text = "Bảng thống kê những sản phẩm đang cần nhập thêm hàng";
            lbchart.Location = new Point(250, 11);
            string str = "Tên sản phẩm";
            var s = new Series();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            s.YValueType = ChartValueType.Auto;
            s.ChartType = SeriesChartType.Column;
            s.ChartType = SeriesChartType.Column ;
            foreach (DataRow r in dt.Rows)
            {
                s.Points.AddXY(r["TENSP"].ToString(), Convert.ToInt32(r["SLTON"].ToString().Trim()));
            }
           
            s.Name = "Số lượng còn";

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Title = str;
            chart.ChartAreas[0].AxisY.Title = "Giá trị";
            s.IsValueShownAsLabel = true;
            chart.Series.Add(s);
            pnChart.Controls.Add(lbchart);
        }
        void paint4()
        {
            pnChart.Controls.Clear();
            Label lbchart = new Label();
            lbchart.Location = new Point(380, 11);
            lbchart.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lbchart.AutoSize = true;
            lbchart.ForeColor = Color.Black;
            Chart chart = new Chart();
            chart.Size = new Size(1009, 617);
            chart.Location = new Point(21, 80);
            chart.Palette = ChartColorPalette.Excel;
            chart.BackColor = Color.White;

            pnChart.Controls.Add(chart);


            DataTable dt = db.getDataTable("select *from SANPHAM where SLTON >3 and MALOAISP = '" + MALSP + "'");
            lbchart.Text = "Bảng thống kê số lượng sản phẩm còn tồn trong kho";
            lbchart.Location = new Point(250, 11);
            string str = "Tên sản phẩm";
            var s = new Series();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            s.YValueType = ChartValueType.Auto;
            s.ChartType = SeriesChartType.Column;
            s.ChartType = SeriesChartType.Spline;
            foreach (DataRow r in dt.Rows)
            {
                s.Points.AddXY(r["TENSP"].ToString(), Convert.ToInt32(r["SLTON"].ToString().Trim()));
            }

            s.Name = "Số lượng còn";

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Title = str;
            chart.ChartAreas[0].AxisY.Title = "Giá trị";
            s.IsValueShownAsLabel = true;
            chart.Series.Add(s);
            pnChart.Controls.Add(lbchart);
        }
    }
}
