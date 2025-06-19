namespace QuanLy_Spa.GUI.QuanLy.HoaDon
{
    partial class QLChiTietHD
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
            this.pnDetailBill = new System.Windows.Forms.Panel();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbNameC = new System.Windows.Forms.TextBox();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDStaff = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDetailBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDetailBill
            // 
            this.pnDetailBill.BackColor = System.Drawing.Color.White;
            this.pnDetailBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDetailBill.Controls.Add(this.lbTotalPrice);
            this.pnDetailBill.Controls.Add(this.label11);
            this.pnDetailBill.Controls.Add(this.lbExit);
            this.pnDetailBill.Controls.Add(this.btnExit);
            this.pnDetailBill.Controls.Add(this.txbNameC);
            this.pnDetailBill.Controls.Add(this.dtgvProduct);
            this.pnDetailBill.Controls.Add(this.label3);
            this.pnDetailBill.Controls.Add(this.txbIDStaff);
            this.pnDetailBill.Controls.Add(this.label12);
            this.pnDetailBill.Controls.Add(this.label2);
            this.pnDetailBill.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDetailBill.Location = new System.Drawing.Point(6, 33);
            this.pnDetailBill.Margin = new System.Windows.Forms.Padding(2);
            this.pnDetailBill.Name = "pnDetailBill";
            this.pnDetailBill.Size = new System.Drawing.Size(1064, 720);
            this.pnDetailBill.TabIndex = 163;
            this.pnDetailBill.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDetailBill_Paint);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPrice.Location = new System.Drawing.Point(828, 656);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(104, 37);
            this.lbTotalPrice.TabIndex = 43;
            this.lbTotalPrice.Text = "0 VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(66, 656);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 37);
            this.label11.TabIndex = 42;
            this.label11.Text = "Tổng tiền thanh toán";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Location = new System.Drawing.Point(938, 16);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(79, 33);
            this.lbExit.TabIndex = 41;
            this.lbExit.Text = "Thoát";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::QuanLy_Spa.Properties.Resources.logout1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(901, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 31);
            this.btnExit.TabIndex = 39;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbNameC
            // 
            this.txbNameC.BackColor = System.Drawing.Color.White;
            this.txbNameC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNameC.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameC.ForeColor = System.Drawing.Color.Maroon;
            this.txbNameC.Location = new System.Drawing.Point(237, 148);
            this.txbNameC.Name = "txbNameC";
            this.txbNameC.ReadOnly = true;
            this.txbNameC.Size = new System.Drawing.Size(787, 33);
            this.txbNameC.TabIndex = 6;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowUserToAddRows = false;
            this.dtgvProduct.AllowUserToResizeColumns = false;
            this.dtgvProduct.AllowUserToResizeRows = false;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.TEN,
            this.GIA,
            this.SOLUONG,
            this.ThanhTien});
            this.dtgvProduct.EnableHeadersVisualStyles = false;
            this.dtgvProduct.GridColor = System.Drawing.Color.White;
            this.dtgvProduct.Location = new System.Drawing.Point(5, 213);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvProduct.RowHeadersVisible = false;
            this.dtgvProduct.RowHeadersWidth = 62;
            this.dtgvProduct.RowTemplate.Height = 28;
            this.dtgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduct.Size = new System.Drawing.Size(1049, 417);
            this.dtgvProduct.TabIndex = 34;
            // 
            // MA
            // 
            this.MA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.MA.DefaultCellStyle = dataGridViewCellStyle2;
            this.MA.FillWeight = 101.87F;
            this.MA.HeaderText = "Mã";
            this.MA.MinimumWidth = 8;
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TEN.DefaultCellStyle = dataGridViewCellStyle3;
            this.TEN.FillWeight = 173.8673F;
            this.TEN.HeaderText = "Tên";
            this.TEN.MinimumWidth = 8;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.GIA.DefaultCellStyle = dataGridViewCellStyle4;
            this.GIA.FillWeight = 77.14091F;
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 8;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle5;
            this.SOLUONG.FillWeight = 51.13636F;
            this.SOLUONG.HeaderText = "SL";
            this.SOLUONG.MinimumWidth = 8;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien.FillWeight = 166.9489F;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // txbIDStaff
            // 
            this.txbIDStaff.BackColor = System.Drawing.Color.White;
            this.txbIDStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIDStaff.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDStaff.ForeColor = System.Drawing.Color.Maroon;
            this.txbIDStaff.Location = new System.Drawing.Point(237, 80);
            this.txbIDStaff.Name = "txbIDStaff";
            this.txbIDStaff.ReadOnly = true;
            this.txbIDStaff.Size = new System.Drawing.Size(787, 33);
            this.txbIDStaff.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(386, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(356, 41);
            this.label12.TabIndex = 34;
            this.label12.Tag = "";
            this.label12.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên";
            // 
            // QLChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 787);
            this.Controls.Add(this.pnDetailBill);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLChiTietHD";
            this.Load += new System.EventHandler(this.QLChiTietHD_Load);
            this.pnDetailBill.ResumeLayout(false);
            this.pnDetailBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDetailBill;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbNameC;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDStaff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}