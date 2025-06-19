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

namespace QuanLy_Spa.GUI.QuanLy.KhachHang
{
    public partial class QLChiTietKH : Form
    {
        public QLChiTietKH(TrangChuQL ql,string makh)
        {
            InitializeComponent();
            QL = ql;
            MAKH = makh;
            LoadInfo();
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        string MAKH;
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from khachhang where MAKH = '" + MAKH + "'");
            txbID.Text = MAKH;
            txbName.Text = dt.Rows[0]["HOTEN"].ToString().Trim();
            txbEmail.Text = dt.Rows[0]["EMAIL"].ToString().Trim();
            txbPoint.Text = dt.Rows[0]["DIEM"].ToString().Trim();
            txbPhone.Text = dt.Rows[0]["SDT"].ToString().Trim();
            txbAdress.Text = dt.Rows[0]["DIACHI"].ToString().Trim();
            dtpkDOB.Value = Convert.ToDateTime(dt.Rows[0]["NGSINH"]);
            cbbStatus.Text = dt.Rows[0]["PHANLOAI"].ToString();
            rdGenderFemale.Checked = true;
            if (dt.Rows[0]["GIOITINH"].ToString().Trim() == "Nam")
                rdGenderMale.Checked = true;
        }
        private void QLChiTietKH_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QL.Customer_Click(sender,e);
        }
    }
}
