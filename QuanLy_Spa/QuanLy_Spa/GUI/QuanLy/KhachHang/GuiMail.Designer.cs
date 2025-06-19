namespace QuanLy_Spa.GUI.NhanVien.Khach_hang
{
    partial class GuiMail
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
            this.txbSend = new QuanLy_Spa.CustomControl.VBButton();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpLoadFIle = new QuanLy_Spa.CustomControl.VBButton();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.txbBody = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.pnName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnAdd.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.btnExit);
            this.pnAdd.Controls.Add(this.txbSend);
            this.pnAdd.Controls.Add(this.gbAddCustomer);
            this.pnAdd.Controls.Add(this.lbHeader);
            this.pnAdd.Location = new System.Drawing.Point(12, 45);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(1053, 759);
            this.pnAdd.TabIndex = 37;
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
            this.btnExit.Location = new System.Drawing.Point(668, 709);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 47);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbSend
            // 
            this.txbSend.BackColor = System.Drawing.Color.SteelBlue;
            this.txbSend.BorderColor = System.Drawing.Color.Black;
            this.txbSend.BorderRadius = 15;
            this.txbSend.BorderSize = 1;
            this.txbSend.FlatAppearance.BorderSize = 0;
            this.txbSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txbSend.ForeColor = System.Drawing.Color.White;
            this.txbSend.Location = new System.Drawing.Point(848, 709);
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(177, 47);
            this.txbSend.TabIndex = 38;
            this.txbSend.Text = "Gửi";
            this.txbSend.TextColor = System.Drawing.Color.White;
            this.txbSend.UseVisualStyleBackColor = false;
            this.txbSend.Click += new System.EventHandler(this.txbSend_Click);
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.BackColor = System.Drawing.Color.LightGray;
            this.gbAddCustomer.Controls.Add(this.panel3);
            this.gbAddCustomer.Controls.Add(this.pnName);
            this.gbAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAddCustomer.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCustomer.Location = new System.Drawing.Point(5, 75);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(1043, 614);
            this.gbAddCustomer.TabIndex = 36;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Thông tin";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnUpLoadFIle);
            this.panel3.Controls.Add(this.txbFile);
            this.panel3.Controls.Add(this.txbBody);
            this.panel3.Controls.Add(this.txbSubject);
            this.panel3.Controls.Add(this.txbFrom);
            this.panel3.Controls.Add(this.txbTo);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(259, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 547);
            this.panel3.TabIndex = 28;
            // 
            // btnUpLoadFIle
            // 
            this.btnUpLoadFIle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpLoadFIle.BorderColor = System.Drawing.Color.Black;
            this.btnUpLoadFIle.BorderRadius = 15;
            this.btnUpLoadFIle.BorderSize = 1;
            this.btnUpLoadFIle.FlatAppearance.BorderSize = 0;
            this.btnUpLoadFIle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpLoadFIle.ForeColor = System.Drawing.Color.White;
            this.btnUpLoadFIle.Location = new System.Drawing.Point(569, 488);
            this.btnUpLoadFIle.Name = "btnUpLoadFIle";
            this.btnUpLoadFIle.Size = new System.Drawing.Size(177, 34);
            this.btnUpLoadFIle.TabIndex = 39;
            this.btnUpLoadFIle.Text = "Mở file";
            this.btnUpLoadFIle.TextColor = System.Drawing.Color.White;
            this.btnUpLoadFIle.UseVisualStyleBackColor = false;
            this.btnUpLoadFIle.Click += new System.EventHandler(this.btnUpLoadFIle_Click);
            // 
            // txbFile
            // 
            this.txbFile.BackColor = System.Drawing.Color.White;
            this.txbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFile.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFile.ForeColor = System.Drawing.Color.Black;
            this.txbFile.Location = new System.Drawing.Point(24, 493);
            this.txbFile.Name = "txbFile";
            this.txbFile.ReadOnly = true;
            this.txbFile.Size = new System.Drawing.Size(539, 40);
            this.txbFile.TabIndex = 7;
            // 
            // txbBody
            // 
            this.txbBody.BackColor = System.Drawing.Color.White;
            this.txbBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBody.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBody.ForeColor = System.Drawing.Color.Black;
            this.txbBody.Location = new System.Drawing.Point(24, 251);
            this.txbBody.Multiline = true;
            this.txbBody.Name = "txbBody";
            this.txbBody.Size = new System.Drawing.Size(726, 214);
            this.txbBody.TabIndex = 5;
            // 
            // txbSubject
            // 
            this.txbSubject.BackColor = System.Drawing.Color.White;
            this.txbSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubject.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubject.ForeColor = System.Drawing.Color.Black;
            this.txbSubject.Location = new System.Drawing.Point(24, 157);
            this.txbSubject.Multiline = true;
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(726, 68);
            this.txbSubject.TabIndex = 6;
            // 
            // txbFrom
            // 
            this.txbFrom.BackColor = System.Drawing.Color.White;
            this.txbFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFrom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrom.Location = new System.Drawing.Point(24, 20);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.ReadOnly = true;
            this.txbFrom.Size = new System.Drawing.Size(726, 40);
            this.txbFrom.TabIndex = 5;
            // 
            // txbTo
            // 
            this.txbTo.BackColor = System.Drawing.Color.White;
            this.txbTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTo.ForeColor = System.Drawing.Color.Black;
            this.txbTo.Location = new System.Drawing.Point(24, 86);
            this.txbTo.Name = "txbTo";
            this.txbTo.ReadOnly = true;
            this.txbTo.Size = new System.Drawing.Size(726, 40);
            this.txbTo.TabIndex = 4;
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.label1);
            this.pnName.Controls.Add(this.lb4);
            this.pnName.Controls.Add(this.lb2);
            this.pnName.Controls.Add(this.label15);
            this.pnName.Controls.Add(this.label2);
            this.pnName.Controls.Add(this.label21);
            this.pnName.Controls.Add(this.label22);
            this.pnName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnName.Location = new System.Drawing.Point(17, 43);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(236, 547);
            this.pnName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "File đính kèm";
            // 
            // lb4
            // 
            this.lb4.ForeColor = System.Drawing.Color.Red;
            this.lb4.Location = new System.Drawing.Point(114, 250);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(24, 27);
            this.lb4.TabIndex = 10;
            this.lb4.Text = "*";
            // 
            // lb2
            // 
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(84, 156);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(24, 27);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "*";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cửa hàng";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(13, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 27);
            this.label21.TabIndex = 3;
            this.label21.Text = "Chủ đề";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(165, 27);
            this.label22.TabIndex = 3;
            this.label22.Text = "Khách hàng";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbHeader.Location = new System.Drawing.Point(289, 10);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(525, 51);
            this.lbHeader.TabIndex = 33;
            this.lbHeader.Text = "Gửi Mail Đến Khách Hàng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 848);
            this.Controls.Add(this.pnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuiMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GuiMail";
            this.Load += new System.EventHandler(this.GuiMail_Load);
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAdd;
        private CustomControl.VBButton btnExit;
        private CustomControl.VBButton txbSend;
        private System.Windows.Forms.TextBox txbBody;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnUpLoadFIle;
    }
}