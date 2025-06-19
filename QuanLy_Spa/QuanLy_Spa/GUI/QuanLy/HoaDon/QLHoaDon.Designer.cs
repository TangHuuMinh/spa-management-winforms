namespace QuanLy_Spa
{
    partial class QLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListB = new System.Windows.Forms.ToolStripMenuItem();
            this.SortB = new System.Windows.Forms.ToolStripMenuItem();
            this.DayTimeS = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyS = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintB = new System.Windows.Forms.ToolStripMenuItem();
            this.printP = new System.Windows.Forms.ToolStripMenuItem();
            this.printE = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new QuanLy_Spa.CustomControl.VBButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListB,
            this.SortB,
            this.PrintB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 54);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ListB
            // 
            this.ListB.AutoSize = false;
            this.ListB.Image = global::QuanLy_Spa.Properties.Resources.document;
            this.ListB.Name = "ListB";
            this.ListB.Size = new System.Drawing.Size(200, 50);
            this.ListB.Text = "Danh sách";
            this.ListB.Click += new System.EventHandler(this.ListB_Click);
            // 
            // SortB
            // 
            this.SortB.AutoSize = false;
            this.SortB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DayTimeS,
            this.MoneyS});
            this.SortB.Image = global::QuanLy_Spa.Properties.Resources.sort_asc;
            this.SortB.Name = "SortB";
            this.SortB.Size = new System.Drawing.Size(182, 50);
            this.SortB.Text = "Sắp xếp";
            // 
            // DayTimeS
            // 
            this.DayTimeS.CheckOnClick = true;
            this.DayTimeS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeAsc,
            this.TimeDesc});
            this.DayTimeS.Image = global::QuanLy_Spa.Properties.Resources.calendar1;
            this.DayTimeS.Name = "DayTimeS";
            this.DayTimeS.Size = new System.Drawing.Size(270, 36);
            this.DayTimeS.Text = "Thời gian";
            // 
            // TimeAsc
            // 
            this.TimeAsc.Image = global::QuanLy_Spa.Properties.Resources.sort_asc1;
            this.TimeAsc.Name = "TimeAsc";
            this.TimeAsc.Size = new System.Drawing.Size(270, 36);
            this.TimeAsc.Text = "Tăng dần";
            this.TimeAsc.Click += new System.EventHandler(this.TimeAsc_Click);
            // 
            // TimeDesc
            // 
            this.TimeDesc.Image = global::QuanLy_Spa.Properties.Resources.sort_des;
            this.TimeDesc.Name = "TimeDesc";
            this.TimeDesc.Size = new System.Drawing.Size(270, 36);
            this.TimeDesc.Text = "Giảm dần";
            this.TimeDesc.Click += new System.EventHandler(this.TimeDesc_Click);
            // 
            // MoneyS
            // 
            this.MoneyS.CheckOnClick = true;
            this.MoneyS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoneyAsc,
            this.MoneyDesc});
            this.MoneyS.Image = global::QuanLy_Spa.Properties.Resources.money_bag;
            this.MoneyS.Name = "MoneyS";
            this.MoneyS.Size = new System.Drawing.Size(270, 36);
            this.MoneyS.Text = "Thành tiền";
            // 
            // MoneyAsc
            // 
            this.MoneyAsc.Image = global::QuanLy_Spa.Properties.Resources.sort_asc1;
            this.MoneyAsc.Name = "MoneyAsc";
            this.MoneyAsc.Size = new System.Drawing.Size(270, 36);
            this.MoneyAsc.Text = "Tăng dần";
            this.MoneyAsc.Click += new System.EventHandler(this.MoneyAsc_Click);
            // 
            // MoneyDesc
            // 
            this.MoneyDesc.Image = global::QuanLy_Spa.Properties.Resources.sort_des;
            this.MoneyDesc.Name = "MoneyDesc";
            this.MoneyDesc.Size = new System.Drawing.Size(270, 36);
            this.MoneyDesc.Text = "Giảm dần";
            this.MoneyDesc.Click += new System.EventHandler(this.MoneyDesc_Click);
            // 
            // PrintB
            // 
            this.PrintB.AutoSize = false;
            this.PrintB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printP,
            this.printE});
            this.PrintB.Image = global::QuanLy_Spa.Properties.Resources.info_sign;
            this.PrintB.Name = "PrintB";
            this.PrintB.ShowShortcutKeys = false;
            this.PrintB.Size = new System.Drawing.Size(182, 50);
            this.PrintB.Text = "In file";
            // 
            // printP
            // 
            this.printP.AutoSize = false;
            this.printP.Image = ((System.Drawing.Image)(resources.GetObject("printP.Image")));
            this.printP.Name = "printP";
            this.printP.Size = new System.Drawing.Size(200, 30);
            this.printP.Text = "In file Excel";
            this.printP.Click += new System.EventHandler(this.printE_Click);
            // 
            // printE
            // 
            this.printE.AutoSize = false;
            this.printE.Image = global::QuanLy_Spa.Properties.Resources.pdf;
            this.printE.Name = "printE";
            this.printE.Size = new System.Drawing.Size(200, 30);
            this.printE.Text = "In file pdf";
            this.printE.Click += new System.EventHandler(this.printP_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Detail,
            this.MANV,
            this.NgayLap,
            this.TongTien});
            this.dtgvHoaDon.EnableHeadersVisualStyles = false;
            this.dtgvHoaDon.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvHoaDon.Location = new System.Drawing.Point(12, 174);
            this.dtgvHoaDon.MultiSelect = false;
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvHoaDon.RowHeadersVisible = false;
            this.dtgvHoaDon.RowHeadersWidth = 62;
            this.dtgvHoaDon.RowTemplate.Height = 28;
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.Size = new System.Drawing.Size(1053, 577);
            this.dtgvHoaDon.TabIndex = 28;
            this.dtgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 89.064F;
            this.Column1.HeaderText = "Mã HD";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DataPropertyName = "MAKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.Detail.FillWeight = 199.5639F;
            this.Detail.HeaderText = "Khách";
            this.Detail.MinimumWidth = 8;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            this.MANV.DefaultCellStyle = dataGridViewCellStyle4;
            this.MANV.FillWeight = 134.0132F;
            this.MANV.HeaderText = "Mã NV";
            this.MANV.MinimumWidth = 8;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NGAYLAP";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayLap.HeaderText = "Thời gian";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.TongTien.FillWeight = 139.6284F;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(828, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 98);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 2);
            this.panel2.TabIndex = 51;
            // 
            // cbbStaff
            // 
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(528, 89);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(269, 35);
            this.cbbStaff.TabIndex = 50;
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEnd.Location = new System.Drawing.Point(162, 108);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(200, 35);
            this.dtpkEnd.TabIndex = 49;
            // 
            // dtpkStart
            // 
            this.dtpkStart.CustomFormat = "dd/MM/yyyy";
            this.dtpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStart.Location = new System.Drawing.Point(162, 65);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(200, 35);
            this.dtpkStart.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 47;
            this.label13.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ngày kết thúc";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(878, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 67);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 787);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.dtpkEnd);
            this.Controls.Add(this.dtpkStart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLHoaDon";
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ListB;
        private System.Windows.Forms.ToolStripMenuItem PrintB;
        private System.Windows.Forms.ToolStripMenuItem printP;
        private System.Windows.Forms.ToolStripMenuItem printE;
        private System.Windows.Forms.ToolStripMenuItem SortB;
        private System.Windows.Forms.ToolStripMenuItem DayTimeS;
        private System.Windows.Forms.ToolStripMenuItem MoneyS;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Panel panel3;
        private CustomControl.VBButton btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.ToolStripMenuItem TimeAsc;
        private System.Windows.Forms.ToolStripMenuItem TimeDesc;
        private System.Windows.Forms.ToolStripMenuItem MoneyAsc;
        private System.Windows.Forms.ToolStripMenuItem MoneyDesc;
    }
}