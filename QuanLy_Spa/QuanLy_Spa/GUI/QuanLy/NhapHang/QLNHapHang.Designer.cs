namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    partial class QLNHapHang
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
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Xem danh sách phiếu nhập");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Tạo phiếu nhập");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("In file phiếu nhập dạng PDF");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("In file phiếu nhập dạng Excel");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("In file", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Quản lý phiếu nhập", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Xem danh sách nhà cung cấp");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Thêm nhà cung cấp mới");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("In file nhà cung cấp dạng PDF");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("In file nhà cung cấp dạng Excel");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("In file", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Quản lý nhà cung cấp", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode35});
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TV = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 69);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 698);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(338, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vui lòng lựa chọn trong danh mục để chuyển trang";
            // 
            // TV
            // 
            this.TV.AllowDrop = true;
            this.TV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV.Location = new System.Drawing.Point(21, 57);
            this.TV.Name = "TV";
            treeNode25.Checked = true;
            treeNode25.Name = "DSPN";
            treeNode25.Text = "Xem danh sách phiếu nhập";
            treeNode26.Name = "TPN";
            treeNode26.Text = "Tạo phiếu nhập";
            treeNode27.Name = "INPDF_PN";
            treeNode27.Text = "In file phiếu nhập dạng PDF";
            treeNode28.Name = "INEXCEL_PN";
            treeNode28.Text = "In file phiếu nhập dạng Excel";
            treeNode29.Name = "Node6";
            treeNode29.Text = "In file";
            treeNode30.Checked = true;
            treeNode30.Name = "Node0";
            treeNode30.Text = "Quản lý phiếu nhập";
            treeNode31.Name = "DSNCC";
            treeNode31.Text = "Xem danh sách nhà cung cấp";
            treeNode32.Name = "TNCC";
            treeNode32.Text = "Thêm nhà cung cấp mới";
            treeNode33.Name = "INPDF_NCC";
            treeNode33.Text = "In file nhà cung cấp dạng PDF";
            treeNode34.Name = "INEXCEL_NCC";
            treeNode34.Text = "In file nhà cung cấp dạng Excel";
            treeNode35.Name = "Node12";
            treeNode35.Text = "In file";
            treeNode36.Checked = true;
            treeNode36.Name = "Node9";
            treeNode36.Text = "Quản lý nhà cung cấp";
            this.TV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode36});
            this.TV.Size = new System.Drawing.Size(1007, 527);
            this.TV.TabIndex = 0;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // QLNHapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLNHapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLNHapHang";
            this.Load += new System.EventHandler(this.QLNHapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TV;
        private System.Windows.Forms.Label label2;
    }
}