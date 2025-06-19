namespace QuanLy_Spa.QuanLy
{
    partial class QLThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnChart = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.Day_D = new System.Windows.Forms.ToolStripMenuItem();
            this.Month_D = new System.Windows.Forms.ToolStripMenuItem();
            this.Year_D = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.P_Day = new System.Windows.Forms.ToolStripMenuItem();
            this.P_Month = new System.Windows.Forms.ToolStripMenuItem();
            this.P_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.S_Day = new System.Windows.Forms.ToolStripMenuItem();
            this.S_Month = new System.Windows.Forms.ToolStripMenuItem();
            this.S_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.SapHet = new System.Windows.Forms.ToolStripMenuItem();
            this.Con = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChart
            // 
            this.pnChart.BackColor = System.Drawing.Color.White;
            this.pnChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChart.Location = new System.Drawing.Point(13, 73);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(1052, 702);
            this.pnChart.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoanhThu,
            this.SanPham,
            this.DichVu,
            this.KhoHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 57);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DoanhThu
            // 
            this.DoanhThu.AutoSize = false;
            this.DoanhThu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Day_D,
            this.Month_D,
            this.Year_D});
            this.DoanhThu.Image = global::QuanLy_Spa.Properties.Resources.money_bag;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Size = new System.Drawing.Size(200, 50);
            this.DoanhThu.Text = "Doanh thu";
            // 
            // Day_D
            // 
            this.Day_D.Name = "Day_D";
            this.Day_D.Size = new System.Drawing.Size(222, 36);
            this.Day_D.Text = "Theo ngày";
            this.Day_D.Click += new System.EventHandler(this.Day_D_Click);
            // 
            // Month_D
            // 
            this.Month_D.Name = "Month_D";
            this.Month_D.Size = new System.Drawing.Size(222, 36);
            this.Month_D.Text = "Theo tháng";
            this.Month_D.Click += new System.EventHandler(this.Month_D_Click);
            // 
            // Year_D
            // 
            this.Year_D.Name = "Year_D";
            this.Year_D.Size = new System.Drawing.Size(222, 36);
            this.Year_D.Text = "Theo năm";
            this.Year_D.Click += new System.EventHandler(this.Year_D_Click);
            // 
            // SanPham
            // 
            this.SanPham.AutoSize = false;
            this.SanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P_Day,
            this.P_Month,
            this.P_Year});
            this.SanPham.Image = global::QuanLy_Spa.Properties.Resources.shopping_cart;
            this.SanPham.Name = "SanPham";
            this.SanPham.Size = new System.Drawing.Size(200, 50);
            this.SanPham.Text = "Sản phẩm";
            // 
            // P_Day
            // 
            this.P_Day.Name = "P_Day";
            this.P_Day.Size = new System.Drawing.Size(286, 36);
            this.P_Day.Text = "Số bán theo ngày";
            // 
            // P_Month
            // 
            this.P_Month.Name = "P_Month";
            this.P_Month.Size = new System.Drawing.Size(286, 36);
            this.P_Month.Text = "Số bán theo tháng";
            // 
            // P_Year
            // 
            this.P_Year.Name = "P_Year";
            this.P_Year.Size = new System.Drawing.Size(286, 36);
            this.P_Year.Text = "Số bán theo năm";
            // 
            // DichVu
            // 
            this.DichVu.AutoSize = false;
            this.DichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S_Day,
            this.S_Month,
            this.S_Year});
            this.DichVu.Image = global::QuanLy_Spa.Properties.Resources.rest;
            this.DichVu.Name = "DichVu";
            this.DichVu.Size = new System.Drawing.Size(200, 50);
            this.DichVu.Text = "Dịch vụ";
            // 
            // S_Day
            // 
            this.S_Day.Name = "S_Day";
            this.S_Day.Size = new System.Drawing.Size(349, 36);
            this.S_Day.Text = "Lượng khách theo ngày";
            // 
            // S_Month
            // 
            this.S_Month.Name = "S_Month";
            this.S_Month.Size = new System.Drawing.Size(349, 36);
            this.S_Month.Text = "Lượng khách theo tháng";
            // 
            // S_Year
            // 
            this.S_Year.Name = "S_Year";
            this.S_Year.Size = new System.Drawing.Size(349, 36);
            this.S_Year.Text = "Lượng khách theo năm";
            // 
            // KhoHang
            // 
            this.KhoHang.AutoSize = false;
            this.KhoHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SapHet,
            this.Con});
            this.KhoHang.Image = global::QuanLy_Spa.Properties.Resources.document;
            this.KhoHang.Name = "KhoHang";
            this.KhoHang.Size = new System.Drawing.Size(200, 50);
            this.KhoHang.Text = "Kho hàng";
            // 
            // SapHet
            // 
            this.SapHet.Name = "SapHet";
            this.SapHet.Size = new System.Drawing.Size(206, 36);
            this.SapHet.Text = "Sắp hết";
            // 
            // Con
            // 
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(206, 36);
            this.Con.Text = "Còn hàng";
            // 
            // QLThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 787);
            this.Controls.Add(this.pnChart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLThongKe";
            this.Load += new System.EventHandler(this.QLThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem SanPham;
        private System.Windows.Forms.ToolStripMenuItem DichVu;
        private System.Windows.Forms.ToolStripMenuItem P_Day;
        private System.Windows.Forms.ToolStripMenuItem P_Month;
        private System.Windows.Forms.ToolStripMenuItem P_Year;
        private System.Windows.Forms.ToolStripMenuItem S_Day;
        private System.Windows.Forms.ToolStripMenuItem S_Month;
        private System.Windows.Forms.ToolStripMenuItem S_Year;
        private System.Windows.Forms.ToolStripMenuItem Day_D;
        private System.Windows.Forms.ToolStripMenuItem Month_D;
        private System.Windows.Forms.ToolStripMenuItem Year_D;
        private System.Windows.Forms.ToolStripMenuItem KhoHang;
        private System.Windows.Forms.ToolStripMenuItem SapHet;
        private System.Windows.Forms.ToolStripMenuItem Con;
    }
}