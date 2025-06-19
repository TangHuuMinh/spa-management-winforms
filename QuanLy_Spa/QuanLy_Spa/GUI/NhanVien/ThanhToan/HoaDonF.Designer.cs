namespace QuanLy_Spa
{
    partial class HoaDonF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNotPaid = new System.Windows.Forms.RadioButton();
            this.cbPaid = new System.Windows.Forms.RadioButton();
            this.cbAll = new System.Windows.Forms.RadioButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbNameSearch = new System.Windows.Forms.TextBox();
            this.txbIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdClient = new System.Windows.Forms.RadioButton();
            this.rdVisitor = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAdd = new QuanLy_Spa.CustomControl.VBButton();
            this.panel1.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbNotPaid);
            this.panel1.Controls.Add(this.cbPaid);
            this.panel1.Controls.Add(this.cbAll);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.txbNameSearch);
            this.panel1.Controls.Add(this.txbIDSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 491);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 27);
            this.label13.TabIndex = 35;
            this.label13.Text = "Tên khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 27);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã khách hàng";
            // 
            // cbNotPaid
            // 
            this.cbNotPaid.AutoSize = true;
            this.cbNotPaid.Checked = true;
            this.cbNotPaid.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotPaid.ForeColor = System.Drawing.Color.Gray;
            this.cbNotPaid.Location = new System.Drawing.Point(55, 369);
            this.cbNotPaid.Name = "cbNotPaid";
            this.cbNotPaid.Size = new System.Drawing.Size(206, 32);
            this.cbNotPaid.TabIndex = 33;
            this.cbNotPaid.TabStop = true;
            this.cbNotPaid.Text = "Chưa thanh toán";
            this.cbNotPaid.UseVisualStyleBackColor = true;
            this.cbNotPaid.CheckedChanged += new System.EventHandler(this.cbPaid_CheckedChanged);
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.ForeColor = System.Drawing.Color.Gray;
            this.cbPaid.Location = new System.Drawing.Point(55, 310);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(180, 32);
            this.cbPaid.TabIndex = 32;
            this.cbPaid.TabStop = true;
            this.cbPaid.Text = "Đã thanh toán";
            this.cbPaid.UseVisualStyleBackColor = true;
            this.cbPaid.CheckedChanged += new System.EventHandler(this.cbPaid_CheckedChanged);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAll.ForeColor = System.Drawing.Color.Gray;
            this.cbAll.Location = new System.Drawing.Point(56, 428);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(100, 32);
            this.cbAll.TabIndex = 31;
            this.cbAll.TabStop = true;
            this.cbAll.Text = "Tất cả";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbPaid_CheckedChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Location = new System.Drawing.Point(332, 54);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(636, 696);
            this.panel14.TabIndex = 30;
            // 
            // txbNameSearch
            // 
            this.txbNameSearch.BackColor = System.Drawing.Color.White;
            this.txbNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameSearch.ForeColor = System.Drawing.Color.Gray;
            this.txbNameSearch.Location = new System.Drawing.Point(20, 196);
            this.txbNameSearch.Name = "txbNameSearch";
            this.txbNameSearch.Size = new System.Drawing.Size(263, 35);
            this.txbNameSearch.TabIndex = 27;
            this.txbNameSearch.TextChanged += new System.EventHandler(this.txbNameSearch_TextChanged);
            // 
            // txbIDSearch
            // 
            this.txbIDSearch.BackColor = System.Drawing.Color.White;
            this.txbIDSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.txbIDSearch.Location = new System.Drawing.Point(22, 106);
            this.txbIDSearch.Name = "txbIDSearch";
            this.txbIDSearch.Size = new System.Drawing.Size(261, 35);
            this.txbIDSearch.TabIndex = 26;
            this.txbIDSearch.TextChanged += new System.EventHandler(this.txbIDSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(898, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sắp xếp theo giá tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.groupBox1);
            this.pnControl.Controls.Add(this.panel1);
            this.pnControl.Location = new System.Drawing.Point(13, 13);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(318, 754);
            this.pnControl.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdClient);
            this.groupBox1.Controls.Add(this.rdVisitor);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 250);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hóa đơn";
            // 
            // rdClient
            // 
            this.rdClient.AutoSize = true;
            this.rdClient.ForeColor = System.Drawing.Color.Gray;
            this.rdClient.Location = new System.Drawing.Point(56, 135);
            this.rdClient.Name = "rdClient";
            this.rdClient.Size = new System.Drawing.Size(204, 32);
            this.rdClient.TabIndex = 34;
            this.rdClient.Text = "Khách thân thiết";
            this.rdClient.UseVisualStyleBackColor = true;
            // 
            // rdVisitor
            // 
            this.rdVisitor.AutoSize = true;
            this.rdVisitor.Checked = true;
            this.rdVisitor.ForeColor = System.Drawing.Color.Gray;
            this.rdVisitor.Location = new System.Drawing.Point(55, 67);
            this.rdVisitor.Name = "rdVisitor";
            this.rdVisitor.Size = new System.Drawing.Size(188, 32);
            this.rdVisitor.TabIndex = 32;
            this.rdVisitor.TabStop = true;
            this.rdVisitor.Text = "Khách vãng lai";
            this.rdVisitor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hóa đơn";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSort.BackgroundImage")));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(1031, 38);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(30, 30);
            this.btnSort.TabIndex = 29;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TongTien,
            this.Delete});
            this.dtgvHoaDon.EnableHeadersVisualStyles = false;
            this.dtgvHoaDon.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvHoaDon.Location = new System.Drawing.Point(351, 85);
            this.dtgvHoaDon.MultiSelect = false;
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvHoaDon.RowHeadersVisible = false;
            this.dtgvHoaDon.RowHeadersWidth = 62;
            this.dtgvHoaDon.RowTemplate.Height = 28;
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.Size = new System.Drawing.Size(708, 679);
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
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.TongTien.FillWeight = 139.6284F;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.FillWeight = 52.09536F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(263, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // HoaDonF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 772);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDonF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HoaDonF";
            this.Load += new System.EventHandler(this.HoaDonF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDSearch;
        private System.Windows.Forms.TextBox txbNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cbNotPaid;
        private System.Windows.Forms.RadioButton cbPaid;
        private System.Windows.Forms.RadioButton cbAll;
        private CustomControl.VBButton btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdClient;
        private System.Windows.Forms.RadioButton rdVisitor;
        private System.Windows.Forms.Label label2;
    }
}