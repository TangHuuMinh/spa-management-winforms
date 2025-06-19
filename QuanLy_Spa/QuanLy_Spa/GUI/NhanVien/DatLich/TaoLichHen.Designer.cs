namespace QuanLy_Spa.GUI.NhanVien.DatLich
{
    partial class TaoLichHen
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
            this.pnContent_Service = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMLH = new System.Windows.Forms.ComboBox();
            this.btnDescEnd = new System.Windows.Forms.Button();
            this.btnAscEnd = new System.Windows.Forms.Button();
            this.btnDescStart = new System.Windows.Forms.Button();
            this.btnAscStart = new System.Windows.Forms.Button();
            this.txbEnd = new System.Windows.Forms.TextBox();
            this.txbStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new QuanLy_Spa.CustomControl.VBButton();
            this.btnSave = new QuanLy_Spa.CustomControl.VBButton();
            this.cbbMAKH = new System.Windows.Forms.ComboBox();
            this.pnContent_Service.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent_Service
            // 
            this.pnContent_Service.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContent_Service.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContent_Service.Controls.Add(this.groupBox1);
            this.pnContent_Service.Location = new System.Drawing.Point(11, 9);
            this.pnContent_Service.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent_Service.Name = "pnContent_Service";
            this.pnContent_Service.Size = new System.Drawing.Size(1060, 769);
            this.pnContent_Service.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbbMAKH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbMLH);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDescEnd);
            this.groupBox1.Controls.Add(this.btnAscEnd);
            this.groupBox1.Controls.Add(this.btnDescStart);
            this.groupBox1.Controls.Add(this.btnAscStart);
            this.groupBox1.Controls.Add(this.txbEnd);
            this.groupBox1.Controls.Add(this.txbStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbService);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpkDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbPhone);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 741);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mã lịch hẹn";
            // 
            // cbbMLH
            // 
            this.cbbMLH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMLH.FormattingEnabled = true;
            this.cbbMLH.Location = new System.Drawing.Point(190, 49);
            this.cbbMLH.Name = "cbbMLH";
            this.cbbMLH.Size = new System.Drawing.Size(809, 35);
            this.cbbMLH.TabIndex = 82;
            this.cbbMLH.SelectedIndexChanged += new System.EventHandler(this.cbbMLH_SelectedIndexChanged);
            // 
            // btnDescEnd
            // 
            this.btnDescEnd.BackgroundImage = global::QuanLy_Spa.Properties.Resources.sort_des;
            this.btnDescEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescEnd.FlatAppearance.BorderSize = 0;
            this.btnDescEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescEnd.Location = new System.Drawing.Point(969, 564);
            this.btnDescEnd.Name = "btnDescEnd";
            this.btnDescEnd.Size = new System.Drawing.Size(33, 29);
            this.btnDescEnd.TabIndex = 79;
            this.btnDescEnd.Text = "\r\n";
            this.btnDescEnd.UseVisualStyleBackColor = true;
            this.btnDescEnd.Click += new System.EventHandler(this.btnDescEnd_Click);
            // 
            // btnAscEnd
            // 
            this.btnAscEnd.BackgroundImage = global::QuanLy_Spa.Properties.Resources.sort_asc2;
            this.btnAscEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAscEnd.FlatAppearance.BorderSize = 0;
            this.btnAscEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscEnd.Location = new System.Drawing.Point(930, 562);
            this.btnAscEnd.Name = "btnAscEnd";
            this.btnAscEnd.Size = new System.Drawing.Size(33, 29);
            this.btnAscEnd.TabIndex = 78;
            this.btnAscEnd.Text = "\r\n";
            this.btnAscEnd.UseVisualStyleBackColor = true;
            this.btnAscEnd.Click += new System.EventHandler(this.btnAscEnd_Click);
            // 
            // btnDescStart
            // 
            this.btnDescStart.BackgroundImage = global::QuanLy_Spa.Properties.Resources.sort_des;
            this.btnDescStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescStart.FlatAppearance.BorderSize = 0;
            this.btnDescStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescStart.Location = new System.Drawing.Point(969, 495);
            this.btnDescStart.Name = "btnDescStart";
            this.btnDescStart.Size = new System.Drawing.Size(33, 29);
            this.btnDescStart.TabIndex = 77;
            this.btnDescStart.Text = "\r\n";
            this.btnDescStart.UseVisualStyleBackColor = true;
            this.btnDescStart.Click += new System.EventHandler(this.btnDescStart_Click);
            // 
            // btnAscStart
            // 
            this.btnAscStart.BackgroundImage = global::QuanLy_Spa.Properties.Resources.sort_asc2;
            this.btnAscStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAscStart.FlatAppearance.BorderSize = 0;
            this.btnAscStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscStart.Location = new System.Drawing.Point(928, 494);
            this.btnAscStart.Name = "btnAscStart";
            this.btnAscStart.Size = new System.Drawing.Size(33, 29);
            this.btnAscStart.TabIndex = 76;
            this.btnAscStart.Text = "\r\n";
            this.btnAscStart.UseVisualStyleBackColor = true;
            this.btnAscStart.Click += new System.EventHandler(this.btnAscStart_Click);
            // 
            // txbEnd
            // 
            this.txbEnd.BackColor = System.Drawing.Color.White;
            this.txbEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnd.ForeColor = System.Drawing.Color.Black;
            this.txbEnd.Location = new System.Drawing.Point(192, 556);
            this.txbEnd.Name = "txbEnd";
            this.txbEnd.ReadOnly = true;
            this.txbEnd.Size = new System.Drawing.Size(722, 35);
            this.txbEnd.TabIndex = 75;
            // 
            // txbStart
            // 
            this.txbStart.BackColor = System.Drawing.Color.White;
            this.txbStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStart.ForeColor = System.Drawing.Color.Black;
            this.txbStart.Location = new System.Drawing.Point(192, 489);
            this.txbStart.Name = "txbStart";
            this.txbStart.ReadOnly = true;
            this.txbStart.Size = new System.Drawing.Size(722, 35);
            this.txbStart.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã khách hàng";
            // 
            // cbbService
            // 
            this.cbbService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(190, 335);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(809, 35);
            this.cbbService.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 63;
            this.label6.Text = "Giờ kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 61;
            this.label5.Text = "Dịch vụ";
            // 
            // dtpkDay
            // 
            this.dtpkDay.CustomFormat = "dd/MM/yyyy";
            this.dtpkDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDay.Location = new System.Drawing.Point(191, 410);
            this.dtpkDay.Name = "dtpkDay";
            this.dtpkDay.Size = new System.Drawing.Size(810, 35);
            this.dtpkDay.TabIndex = 60;
            this.dtpkDay.Value = new System.DateTime(2024, 10, 3, 20, 34, 26, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Giờ hẹn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ngày";
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.White;
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.ForeColor = System.Drawing.Color.Black;
            this.txbPhone.Location = new System.Drawing.Point(191, 257);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(809, 35);
            this.txbPhone.TabIndex = 57;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(191, 185);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(809, 35);
            this.txbName.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "SĐT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 27);
            this.label8.TabIndex = 54;
            this.label8.Text = "Họ tên";
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
            this.btnExit.Location = new System.Drawing.Point(642, 663);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 47);
            this.btnExit.TabIndex = 81;
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
            this.btnSave.Location = new System.Drawing.Point(825, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 47);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbMAKH
            // 
            this.cbbMAKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMAKH.FormattingEnabled = true;
            this.cbbMAKH.Location = new System.Drawing.Point(192, 116);
            this.cbbMAKH.Name = "cbbMAKH";
            this.cbbMAKH.Size = new System.Drawing.Size(809, 35);
            this.cbbMAKH.TabIndex = 84;
            this.cbbMAKH.SelectedIndexChanged += new System.EventHandler(this.cbbMAKH_SelectedIndexChanged);
            // 
            // TaoLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 786);
            this.Controls.Add(this.pnContent_Service);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaoLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TaoLichHen";
            this.Load += new System.EventHandler(this.TaoLichHen_Load);
            this.pnContent_Service.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContent_Service;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.TextBox txbEnd;
        private System.Windows.Forms.TextBox txbStart;
        private System.Windows.Forms.Button btnAscStart;
        private System.Windows.Forms.Button btnDescStart;
        private System.Windows.Forms.Button btnDescEnd;
        private System.Windows.Forms.Button btnAscEnd;
        private CustomControl.VBButton btnExit;
        private CustomControl.VBButton btnSave;
        private System.Windows.Forms.ComboBox cbbMLH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMAKH;
    }
}