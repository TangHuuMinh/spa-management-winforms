namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    partial class QLPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CapNhat = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new QuanLy_Spa.CustomControl.VBButton();
            this.dtpkDayFind = new System.Windows.Forms.DateTimePicker();
            this.cbbNhaCC = new System.Windows.Forms.ComboBox();
            this.cbbMaPN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new QuanLy_Spa.CustomControl.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSelect);
            this.panel1.Controls.Add(this.dtgvPhieuNhap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.dtpkDayFind);
            this.panel1.Controls.Add(this.cbbNhaCC);
            this.panel1.Controls.Add(this.cbbMaPN);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 733);
            this.panel1.TabIndex = 0;
            // 
            // cbbSelect
            // 
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.Location = new System.Drawing.Point(18, 12);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.Size = new System.Drawing.Size(294, 35);
            this.cbbSelect.TabIndex = 179;
            this.cbbSelect.Text = "Tìm phiếu nhập theo...";
         
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AllowUserToAddRows = false;
            this.dtgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPhieuNhap.ColumnHeadersHeight = 50;
            this.dtgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.NguoiDat,
            this.NguoiNhan,
            this.NhaCungCap,
            this.NgayNhap,
            this.NgayNhan,
            this.TinhTrang,
            this.TongTien,
            this.Xem,
            this.CapNhat,
            this.Xoa,
            this.XacNhan});
            this.dtgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(12, 65);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.RowHeadersVisible = false;
            this.dtgvPhieuNhap.RowHeadersWidth = 62;
            this.dtgvPhieuNhap.RowTemplate.Height = 28;
            this.dtgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(1046, 591);
            this.dtgvPhieuNhap.TabIndex = 2;
           
            this.dtgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNhap_CellContentClick);
            // 
            // MaPN
            // 
            this.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPN.DataPropertyName = "MAHDCC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.MaPN.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaPN.FillWeight = 113.2569F;
            this.MaPN.HeaderText = "Mã PN";
            this.MaPN.MinimumWidth = 8;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            // 
            // NguoiDat
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.NguoiDat.DefaultCellStyle = dataGridViewCellStyle3;
            this.NguoiDat.HeaderText = "Người đặt";
            this.NguoiDat.MinimumWidth = 8;
            this.NguoiDat.Name = "NguoiDat";
            this.NguoiDat.ReadOnly = true;
            // 
            // NguoiNhan
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.NguoiNhan.DefaultCellStyle = dataGridViewCellStyle4;
            this.NguoiNhan.HeaderText = "Người nhận";
            this.NguoiNhan.MinimumWidth = 8;
            this.NguoiNhan.Name = "NguoiNhan";
            this.NguoiNhan.ReadOnly = true;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.NhaCungCap.DefaultCellStyle = dataGridViewCellStyle5;
            this.NhaCungCap.FillWeight = 150.1439F;
            this.NhaCungCap.HeaderText = "Nhà cung cấp";
            this.NhaCungCap.MinimumWidth = 8;
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayNhap.FillWeight = 113.2569F;
            this.NgayNhap.HeaderText = "Ngày đặt";
            this.NgayNhap.MinimumWidth = 8;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // NgayNhan
            // 
            this.NgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayNhan.DefaultCellStyle = dataGridViewCellStyle7;
            this.NgayNhan.FillWeight = 113.2569F;
            this.NgayNhan.HeaderText = "Ngày nhận";
            this.NgayNhan.MinimumWidth = 8;
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.TinhTrang.DefaultCellStyle = dataGridViewCellStyle8;
            this.TinhTrang.FillWeight = 113.2569F;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // TongTien
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle9;
            this.TongTien.FillWeight = 113.2569F;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // Xem
            // 
            this.Xem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Xem.DefaultCellStyle = dataGridViewCellStyle10;
            this.Xem.FillWeight = 66.47728F;
            this.Xem.HeaderText = "Chi tiết";
            this.Xem.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Xem.MinimumWidth = 8;
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Text = "👁️";
            this.Xem.UseColumnTextForLinkValue = true;
            // 
            // CapNhat
            // 
            this.CapNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.CapNhat.DefaultCellStyle = dataGridViewCellStyle11;
            this.CapNhat.FillWeight = 62.33773F;
            this.CapNhat.HeaderText = "Cập nhật";
            this.CapNhat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CapNhat.MinimumWidth = 8;
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.ReadOnly = true;
            this.CapNhat.Text = "🔄";
            this.CapNhat.UseColumnTextForLinkValue = true;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle12;
            this.Xoa.FillWeight = 54.7566F;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Xoa.MinimumWidth = 8;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "🗑️";
            this.Xoa.UseColumnTextForLinkValue = true;
            // 
            // XacNhan
            // 
            this.XacNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.XacNhan.DefaultCellStyle = dataGridViewCellStyle13;
            this.XacNhan.HeaderText = "Xác nhận";
            this.XacNhan.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.XacNhan.MinimumWidth = 8;
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.ReadOnly = true;
            this.XacNhan.Text = "✅";
            this.XacNhan.UseColumnTextForLinkValue = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lbSum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(18, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 46);
            this.panel2.TabIndex = 177;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.ForeColor = System.Drawing.Color.Red;
            this.lbSum.Location = new System.Drawing.Point(750, 10);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(92, 32);
            this.lbSum.TabIndex = 5;
            this.lbSum.Text = "0 VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng nợ :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(405, 10);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(92, 32);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "0 VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền :";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.ForeColor = System.Drawing.Color.Red;
            this.lbCount.Location = new System.Drawing.Point(204, 10);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(28, 32);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng phiếu nhập :";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.BorderRadius = 15;
            this.btnFind.BorderSize = 1;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(905, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 32);
            this.btnFind.TabIndex = 176;
            this.btnFind.Text = "🔍 Tìm kiếm";
            this.btnFind.TextColor = System.Drawing.Color.White;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtpkDayFind
            // 
            this.dtpkDayFind.CustomFormat = "dd/MM/yyyy";
            this.dtpkDayFind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDayFind.Location = new System.Drawing.Point(734, 13);
            this.dtpkDayFind.Name = "dtpkDayFind";
            this.dtpkDayFind.Size = new System.Drawing.Size(165, 35);
            this.dtpkDayFind.TabIndex = 3;
            // 
            // cbbNhaCC
            // 
            this.cbbNhaCC.FormattingEnabled = true;
            this.cbbNhaCC.Location = new System.Drawing.Point(489, 12);
            this.cbbNhaCC.Name = "cbbNhaCC";
            this.cbbNhaCC.Size = new System.Drawing.Size(239, 35);
            this.cbbNhaCC.TabIndex = 2;
            this.cbbNhaCC.Text = "Nhà cung cấp";
            // 
            // cbbMaPN
            // 
            this.cbbMaPN.FormattingEnabled = true;
            this.cbbMaPN.Location = new System.Drawing.Point(318, 13);
            this.cbbMaPN.Name = "cbbMaPN";
            this.cbbMaPN.Size = new System.Drawing.Size(165, 35);
            this.cbbMaPN.TabIndex = 1;
            this.cbbMaPN.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 1;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(905, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 39);
            this.btnExit.TabIndex = 182;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QLPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1076, 785);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLPhieuNhap";
            this.Load += new System.EventHandler(this.QLPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkDayFind;
        private System.Windows.Forms.ComboBox cbbNhaCC;
        private System.Windows.Forms.ComboBox cbbMaPN;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.DataGridView dtgvPhieuNhap;
        private System.Windows.Forms.ComboBox cbbSelect;
        private CustomControl.VBButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewLinkColumn Xem;
        private System.Windows.Forms.DataGridViewLinkColumn CapNhat;
        private System.Windows.Forms.DataGridViewLinkColumn Xoa;
        private System.Windows.Forms.DataGridViewLinkColumn XacNhan;
    }
}