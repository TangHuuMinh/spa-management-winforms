using QuanLy_Spa.GUI.DangNhap;
using QuanLy_Spa.GUI.QuanLy;
using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa
{
    public partial class DangNhapF : Form
    {
        public DangNhapF()
        {
            InitializeComponent();
        }
        bool IsShow = false;
        ConnectDB db = new ConnectDB();
        bool checkAccount()
        {
            string pass = txbPass.Text;
            string user = txbID.Text;
            int kq = db.getScalar("select count(*) from TAIKHOAN where MANV collate SQL_Latin1_General_CP1_CS_AS like '" + user + "' and MATKHAU collate SQL_Latin1_General_CP1_CS_AS like '" + pass + "'");
            if (kq > 0) return true;
            return false;
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            lbError.Visible = false;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (checkAccount())
            {
                this.Hide();
                Form f = new TrangChuNV(txbID.Text);
                if (txbID.Text.Substring(0, 2) == "QL")
                {
                    f = new TrangChuQL(txbID.Text);
                }
                f.ShowDialog();
                f = null;
                this.Show();
            }
            else
            {
                lbError.Visible = true;
                errorProvider1.SetError(txbID, "Nhập lại mã nhân viên");
                errorProvider2.SetError(txbPass, "Nhập lại mật mã");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new QuenMatKhauF();
            f.ShowDialog();
            f = null;
            this.Show();
        }
    }
}
