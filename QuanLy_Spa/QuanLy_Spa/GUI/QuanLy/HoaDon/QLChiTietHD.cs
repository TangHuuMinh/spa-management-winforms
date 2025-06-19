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

namespace QuanLy_Spa.GUI.QuanLy.HoaDon
{
    public partial class QLChiTietHD : Form
    {
        public QLChiTietHD(TrangChuQL ql,string mahd)
        {
            InitializeComponent();
            MAHD = mahd;
            QL = ql;
        }
        ConnectDB db = new ConnectDB();
        TrangChuQL QL;
        string MAHD;
        void LoadTable()
        {
            DataTable dt = db.getDataTable("select * from HOADON where MAHD = '" + MAHD + "'");
            txbIDStaff.Text = dt.Rows[0]["MANV"].ToString().Trim() +" - "+ db.getDataTable("select * from nhanvien where manv = '" + dt.Rows[0]["MANV"].ToString().Trim() + "'").Rows[0]["HOTEN"].ToString().Trim(); ;
            string makh = dt.Rows[0]["MAKH"].ToString().Trim();
            txbNameC.Text = "Khách vãng lai";
            if (makh !="")
            {
                txbNameC.Text = db.getDataTable("select * from khachhang where makh = '" + makh + "'").Rows[0]["HOTEN"].ToString().Trim();
            }
            DataTable dtsp = db.getDataTable("select * from CHITIET_HOADON_SP where MAHD = '" + MAHD + "'");
            DataTable dtdv = db.getDataTable("select * from CHITIET_HOADON_DV where MAHD = '" + MAHD + "'");
            int i = 0;
            int sum = 0;
            foreach(DataRow dr in dtsp.Rows)
            {
                dtgvProduct.Rows.Add(dr);
                dtgvProduct.Rows[i].Cells[0].Value = dr["MASP"].ToString().Trim();
                dtgvProduct.Rows[i].Cells[1].Value =db.getDataTable("select * from SANPHAM where MASP = '"+dr["MASP"].ToString().Trim()+"'").Rows[0]["TENSP"].ToString().Trim();
                int g = Convert.ToInt32(dr["GIA"].ToString().Trim());
                int sl = Convert.ToInt32(dr["SOLUONG"].ToString().Trim());
                dtgvProduct.Rows[i].Cells[2].Value = string.Format("{0:0,0}", g);
                dtgvProduct.Rows[i].Cells[3].Value = sl;
                dtgvProduct.Rows[i].Cells[4].Value = string.Format("{0:0,0}", g *sl);
                i++;
                sum += (g * sl);
            }
            foreach (DataRow dr in dtdv.Rows)
            {
                bool check = false;
                for (int j= 0;j < dtgvProduct.RowCount;j++)
                {
                    if (dtgvProduct.Rows[j].Cells[0].Value.ToString().Trim()== dr["MADV"].ToString().Trim())
                    {
                        int sl = Convert.ToInt32(dtgvProduct.Rows[j].Cells[3].Value.ToString().Trim()) + 1;
                        int g = Convert.ToInt32(dr["GIA"].ToString().Trim());
                        dtgvProduct.Rows[j].Cells[3].Value = sl.ToString();
                        dtgvProduct.Rows[j].Cells[4].Value = string.Format("{0:0,0}", g*sl);
                        sum += g;
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    dtgvProduct.Rows.Add(dr);
                    dtgvProduct.Rows[i].Cells[0].Value = dr["MADV"].ToString().Trim();
                    dtgvProduct.Rows[i].Cells[1].Value = db.getDataTable("select * from DICHVU where MADV = '" + dr["MADV"].ToString().Trim() + "'").Rows[0]["TENDV"].ToString().Trim();
                    int g = Convert.ToInt32(dr["GIA"].ToString().Trim());
                    dtgvProduct.Rows[i].Cells[2].Value = string.Format("{0:0,0}", g);
                    dtgvProduct.Rows[i].Cells[3].Value = "1";
                    dtgvProduct.Rows[i].Cells[4].Value = string.Format("{0:0,0}", g);
                    i++;
                    sum += g;
                }
            }
            lbTotalPrice.Text = string.Format("{0:0,0 VND}",sum);
        }

        private void QLChiTietHD_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            QL.Bills_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Bills_Click(sender, e);
        }

        private void pnDetailBill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
