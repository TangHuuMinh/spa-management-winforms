namespace QuanLy_Spa.GUI.QuanLy.DichVu
{
    partial class DLChiTietDV
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
            this.components = new System.ComponentModel.Container();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiDV = new System.Windows.Forms.ComboBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pcbPercent = new System.Windows.Forms.ProgressBar();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.txbAnh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new QuanLy_Spa.CustomControl.VBButton();
            this.btnSave = new QuanLy_Spa.CustomControl.VBButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.Controls.Add(this.btnExit);
            this.pnAdd.Controls.Add(this.btnSave);
            this.pnAdd.Controls.Add(this.lbHeader);
            this.pnAdd.Controls.Add(this.groupBox1);
            this.pnAdd.Location = new System.Drawing.Point(12, 12);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(1052, 762);
            this.pnAdd.TabIndex = 60;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lbHeader.Location = new System.Drawing.Point(462, 12);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(196, 36);
            this.lbHeader.TabIndex = 67;
            this.lbHeader.Text = "Thêm dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cbbLoaiDV);
            this.groupBox1.Controls.Add(this.cbbTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pcbPercent);
            this.groupBox1.Controls.Add(this.btnUploadFile);
            this.groupBox1.Controls.Add(this.txbAnh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmudGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 606);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbLoaiDV
            // 
            this.cbbLoaiDV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiDV.FormattingEnabled = true;
            this.cbbLoaiDV.Location = new System.Drawing.Point(152, 54);
            this.cbbLoaiDV.Name = "cbbLoaiDV";
            this.cbbLoaiDV.Size = new System.Drawing.Size(805, 41);
            this.cbbLoaiDV.TabIndex = 66;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(152, 453);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(805, 41);
            this.cbbTrangThai.TabIndex = 65;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Trạng thái";
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.White;
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.Black;
            this.txbID.Location = new System.Drawing.Point(152, 134);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(805, 40);
            this.txbID.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 27);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã";
            // 
            // pcbPercent
            // 
            this.pcbPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pcbPercent.Location = new System.Drawing.Point(43, 552);
            this.pcbPercent.Name = "pcbPercent";
            this.pcbPercent.Size = new System.Drawing.Size(910, 33);
            this.pcbPercent.Step = 1;
            this.pcbPercent.TabIndex = 1;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.LightGray;
            this.btnUploadFile.Enabled = false;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(846, 370);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(107, 31);
            this.btnUploadFile.TabIndex = 58;
            this.btnUploadFile.Text = "Chọn file";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // txbAnh
            // 
            this.txbAnh.BackColor = System.Drawing.Color.White;
            this.txbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAnh.Enabled = false;
            this.txbAnh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnh.ForeColor = System.Drawing.Color.Black;
            this.txbAnh.Location = new System.Drawing.Point(152, 370);
            this.txbAnh.Name = "txbAnh";
            this.txbAnh.ReadOnly = true;
            this.txbAnh.Size = new System.Drawing.Size(688, 40);
            this.txbAnh.TabIndex = 56;
            this.txbAnh.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmudGia
            // 
            this.nmudGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmudGia.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmudGia.Location = new System.Drawing.Point(152, 285);
            this.nmudGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmudGia.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmudGia.Name = "nmudGia";
            this.nmudGia.Size = new System.Drawing.Size(805, 40);
            this.nmudGia.TabIndex = 54;
            this.nmudGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Giá";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(152, 208);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(805, 40);
            this.txbName.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(614, 703);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 47);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(797, 703);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 47);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DLChiTietDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.pnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLChiTietDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DLChiTietDV";
            this.Load += new System.EventHandler(this.DLChiTietDV_Load);
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ProgressBar pcbPercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.TextBox txbAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomControl.VBButton btnSave;
        private System.Windows.Forms.ComboBox cbbLoaiDV;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label3;
        private CustomControl.VBButton btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}