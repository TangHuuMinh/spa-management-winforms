namespace QuanLy_Spa.GUI.QuanLy.Phong
{
    partial class QLChiTietP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbFloor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSName = new System.Windows.Forms.ComboBox();
            this.cbbSMenu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmudGia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new QuanLy_Spa.CustomControl.VBButton();
            this.btnSave = new QuanLy_Spa.CustomControl.VBButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.Controls.Add(this.groupBox1);
            this.pnAdd.Location = new System.Drawing.Point(12, 12);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(1042, 741);
            this.pnAdd.TabIndex = 174;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txbRoom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbSName);
            this.groupBox1.Controls.Add(this.cbbSMenu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmudGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 704);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txbRoom
            // 
            this.txbRoom.BackColor = System.Drawing.Color.White;
            this.txbRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRoom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoom.ForeColor = System.Drawing.Color.Black;
            this.txbRoom.Location = new System.Drawing.Point(194, 194);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(779, 40);
            this.txbRoom.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 33);
            this.label6.TabIndex = 64;
            this.label6.Text = "Vị trí";
            // 
            // cbbFloor
            // 
            this.cbbFloor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFloor.FormattingEnabled = true;
            this.cbbFloor.Location = new System.Drawing.Point(194, 82);
            this.cbbFloor.Name = "cbbFloor";
            this.cbbFloor.Size = new System.Drawing.Size(779, 41);
            this.cbbFloor.TabIndex = 63;
            this.cbbFloor.SelectedIndexChanged += new System.EventHandler(this.cbbFloor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tầng";
            // 
            // cbbSName
            // 
            this.cbbSName.BackColor = System.Drawing.Color.White;
            this.cbbSName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSName.ForeColor = System.Drawing.Color.Black;
            this.cbbSName.FormattingEnabled = true;
            this.cbbSName.Location = new System.Drawing.Point(194, 418);
            this.cbbSName.Name = "cbbSName";
            this.cbbSName.Size = new System.Drawing.Size(779, 41);
            this.cbbSName.TabIndex = 61;
            this.cbbSName.SelectedIndexChanged += new System.EventHandler(this.cbbSName_SelectedIndexChanged);
            // 
            // cbbSMenu
            // 
            this.cbbSMenu.BackColor = System.Drawing.Color.White;
            this.cbbSMenu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSMenu.ForeColor = System.Drawing.Color.Black;
            this.cbbSMenu.FormattingEnabled = true;
            this.cbbSMenu.Location = new System.Drawing.Point(194, 301);
            this.cbbSMenu.Name = "cbbSMenu";
            this.cbbSMenu.Size = new System.Drawing.Size(779, 41);
            this.cbbSMenu.TabIndex = 60;
            this.cbbSMenu.SelectedIndexChanged += new System.EventHandler(this.cbbSMenu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 33);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tên dịch vụ";
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
            this.nmudGia.Location = new System.Drawing.Point(194, 527);
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
            this.nmudGia.Size = new System.Drawing.Size(779, 40);
            this.nmudGia.TabIndex = 54;
            this.nmudGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 33);
            this.label4.TabIndex = 51;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại dịch vụ";
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
            this.btnExit.Location = new System.Drawing.Point(613, 641);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 47);
            this.btnExit.TabIndex = 76;
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
            this.btnSave.Location = new System.Drawing.Point(796, 641);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 47);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QLChiTietP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 785);
            this.Controls.Add(this.pnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLChiTietP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLChiTietP";
            this.Load += new System.EventHandler(this.QLChiTietP_Load);
            this.pnAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSName;
        private System.Windows.Forms.ComboBox cbbSMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmudGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControl.VBButton btnExit;
        private CustomControl.VBButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}