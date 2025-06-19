namespace QuanLy_Spa.GUI.QuanLy.SanPham
{
    partial class QLChiTietSP
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
            this.btnExit = new QuanLy_Spa.CustomControl.VBButton();
            this.btnSave = new QuanLy_Spa.CustomControl.VBButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbSLTon = new System.Windows.Forms.TextBox();
            this.cbbCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.txbAnh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.Controls.Add(this.btnExit);
            this.pnAdd.Controls.Add(this.btnSave);
            this.pnAdd.Controls.Add(this.groupBox2);
            this.pnAdd.Controls.Add(this.lbHeader);
            this.pnAdd.Location = new System.Drawing.Point(12, 12);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(1053, 761);
            this.pnAdd.TabIndex = 166;
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
            this.btnExit.Location = new System.Drawing.Point(630, 711);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 47);
            this.btnExit.TabIndex = 72;
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
            this.btnSave.Location = new System.Drawing.Point(813, 711);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 47);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txbSLTon);
            this.groupBox2.Controls.Add(this.cbbCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbLoaiSP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnUploadFile);
            this.groupBox2.Controls.Add(this.txbAnh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nmudGia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(20, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 620);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txbSLTon
            // 
            this.txbSLTon.BackColor = System.Drawing.Color.White;
            this.txbSLTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSLTon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSLTon.ForeColor = System.Drawing.Color.Black;
            this.txbSLTon.Location = new System.Drawing.Point(220, 540);
            this.txbSLTon.Name = "txbSLTon";
            this.txbSLTon.ReadOnly = true;
            this.txbSLTon.Size = new System.Drawing.Size(737, 40);
            this.txbSLTon.TabIndex = 69;
            // 
            // cbbCompany
            // 
            this.cbbCompany.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(220, 293);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(737, 41);
            this.cbbCompany.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 67;
            this.label4.Text = "Nhà cung cấp";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(220, 54);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(737, 41);
            this.cbbLoaiSP.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Số lượng tồn kho";
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.White;
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.Black;
            this.txbID.Location = new System.Drawing.Point(220, 134);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(737, 40);
            this.txbID.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 27);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã sản phẩm";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.LightGray;
            this.btnUploadFile.Enabled = false;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(846, 462);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(107, 40);
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
            this.txbAnh.Location = new System.Drawing.Point(220, 462);
            this.txbAnh.Name = "txbAnh";
            this.txbAnh.ReadOnly = true;
            this.txbAnh.Size = new System.Drawing.Size(620, 40);
            this.txbAnh.TabIndex = 56;
            this.txbAnh.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ảnh minh họa";
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
            this.nmudGia.Location = new System.Drawing.Point(220, 377);
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
            this.nmudGia.Size = new System.Drawing.Size(737, 40);
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
            this.label2.Location = new System.Drawing.Point(38, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Giá tiền";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(220, 208);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(737, 40);
            this.txbName.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên sản phẩm";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lbHeader.Location = new System.Drawing.Point(466, 25);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(226, 36);
            this.lbHeader.TabIndex = 66;
            this.lbHeader.Text = "Thêm sản phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QLChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 785);
            this.Controls.Add(this.pnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLChiTietSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLChiTietSP";
            this.Load += new System.EventHandler(this.QLChiTietSP_Load);
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Label label3;
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
        private CustomControl.VBButton btnExit;
        private CustomControl.VBButton btnSave;
        private System.Windows.Forms.ComboBox cbbCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSLTon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}