namespace QuanLy_Spa.GUI.QuanLy.LichHen
{
    partial class QLLichHen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpkDayFind = new System.Windows.Forms.DateTimePicker();
            this.cbbDichVu = new System.Windows.Forms.ComboBox();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.dtgvLich = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new QuanLy_Spa.CustomControl.VBButton();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLich)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cbbDichVu
            // 
            this.cbbDichVu.FormattingEnabled = true;
            this.cbbDichVu.Location = new System.Drawing.Point(489, 12);
            this.cbbDichVu.Name = "cbbDichVu";
            this.cbbDichVu.Size = new System.Drawing.Size(239, 35);
            this.cbbDichVu.TabIndex = 2;
            this.cbbDichVu.Text = "Nhà cung cấp";
            // 
            // cbbKH
            // 
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(318, 13);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(165, 35);
            this.cbbKH.TabIndex = 1;
            this.cbbKH.Text = "Mã phiếu";
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
            // dtgvLich
            // 
            this.dtgvLich.AllowUserToAddRows = false;
            this.dtgvLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLich.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLich.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvLich.ColumnHeadersHeight = 50;
            this.dtgvLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.NhaCungCap,
            this.NgayNhap,
            this.NgayNhan,
            this.NgayHen,
            this.Thoigian,
            this.TongTien,
            this.TinhTrang});
            this.dtgvLich.EnableHeadersVisualStyles = false;
            this.dtgvLich.Location = new System.Drawing.Point(12, 65);
            this.dtgvLich.Name = "dtgvLich";
            this.dtgvLich.RowHeadersVisible = false;
            this.dtgvLich.RowHeadersWidth = 62;
            this.dtgvLich.RowTemplate.Height = 28;
            this.dtgvLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLich.Size = new System.Drawing.Size(1046, 655);
            this.dtgvLich.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 184;
            this.label1.Text = "DANH SÁCH LỊCH HẸN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSelect);
            this.panel1.Controls.Add(this.dtgvLich);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.dtpkDayFind);
            this.panel1.Controls.Add(this.cbbDichVu);
            this.panel1.Controls.Add(this.cbbKH);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 733);
            this.panel1.TabIndex = 183;
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
            // MaPN
            // 
            this.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPN.DataPropertyName = "MAHDCC";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.MaPN.DefaultCellStyle = dataGridViewCellStyle11;
            this.MaPN.FillWeight = 100.0647F;
            this.MaPN.HeaderText = "Mã lịch hẹn";
            this.MaPN.MinimumWidth = 8;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.NhaCungCap.DefaultCellStyle = dataGridViewCellStyle12;
            this.NhaCungCap.FillWeight = 132.6551F;
            this.NhaCungCap.HeaderText = "Mã KH";
            this.NhaCungCap.MinimumWidth = 8;
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle13;
            this.NgayNhap.FillWeight = 100.0647F;
            this.NgayNhap.HeaderText = "Khách hàng";
            this.NgayNhap.MinimumWidth = 8;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // NgayNhan
            // 
            this.NgayNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayNhan.DefaultCellStyle = dataGridViewCellStyle14;
            this.NgayNhan.FillWeight = 205.2663F;
            this.NgayNhan.HeaderText = "Dịch vụ";
            this.NgayNhan.MinimumWidth = 8;
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.ReadOnly = true;
            // 
            // NgayHen
            // 
            this.NgayHen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.NgayHen.DefaultCellStyle = dataGridViewCellStyle15;
            this.NgayHen.FillWeight = 88.352F;
            this.NgayHen.HeaderText = "Ngày hẹn";
            this.NgayHen.MinimumWidth = 8;
            this.NgayHen.Name = "NgayHen";
            this.NgayHen.ReadOnly = true;
            // 
            // Thoigian
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Thoigian.DefaultCellStyle = dataGridViewCellStyle16;
            this.Thoigian.FillWeight = 88.352F;
            this.Thoigian.HeaderText = "Thời gian";
            this.Thoigian.MinimumWidth = 8;
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.ReadOnly = true;
            // 
            // TongTien
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle17;
            this.TongTien.FillWeight = 100.0647F;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TinhTrang
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.TinhTrang.DefaultCellStyle = dataGridViewCellStyle18;
            this.TinhTrang.FillWeight = 88.352F;
            this.TinhTrang.HeaderText = "Trạng thái";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // QLLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1076, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLLichHen";
            this.Load += new System.EventHandler(this.QLLichHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLich)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl.VBButton btnFind;
        private System.Windows.Forms.DateTimePicker dtpkDayFind;
        private System.Windows.Forms.ComboBox cbbDichVu;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.ComboBox cbbSelect;
        private System.Windows.Forms.DataGridView dtgvLich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}