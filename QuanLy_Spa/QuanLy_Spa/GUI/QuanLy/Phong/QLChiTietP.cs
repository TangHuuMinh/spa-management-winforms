using QuanLy_Spa.GUI.QuanLy.KhachHang;
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

namespace QuanLy_Spa.GUI.QuanLy.Phong
{
    public partial class QLChiTietP : Form
    {
        public QLChiTietP(TrangChuQL ql,int trangthai,string maph)
        {
            InitializeComponent();
            QL = ql;
            MAPH = maph;
            TRANGTHAI = trangthai;
        }
        TrangChuQL QL;
        string MAPH;
        int TRANGTHAI;
        int start = 0, begin = 0;
        ConnectDB db = new ConnectDB();
        void LoadEnabled(bool e)
        {
            cbbFloor.Enabled = cbbSMenu.Enabled = cbbSName.Enabled = e;
            txbRoom.ReadOnly = !e;
            nmudGia.Enabled = e;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from phong_dichvu where maph = '" + MAPH + "'");
            DataTable dv = db.getDataTable("select * from dichvu where madv = '" + dt.Rows[0]["MADV"].ToString().Trim() + "'");
            cbbSMenu.Text = db.getDataTable("select * from loai_dichvu where maloaidv = '" + dv.Rows[0]["MALOAIDV"].ToString().Trim() + "'").Rows[0]["TENDV"].ToString().Trim() ;
            cbbSName.Text = dv.Rows[0]["TENDV"].ToString().Trim();
            cbbFloor.Text = "Tầng " + MAPH[1];
            txbRoom.Text = MAPH;
            nmudGia.Value = Convert.ToInt32(dv.Rows[0]["GIA"].ToString());
        }
        private void QLChiTietP_Load(object sender, EventArgs e)
        {
            cbbFloor.Items.Add("Tầng 1");
            cbbFloor.Items.Add("Tầng 2");
            cbbFloor.Items.Add("Tầng 3");
            cbbSMenu.DataSource = db.getDataTable("select * from loai_dichvu");
            cbbSMenu.DisplayMember = "TENDV";
            cbbSMenu.ValueMember = "MALOAIDV";
            cbbSName.DataSource = db.getDataTable("select * from dichvu where maloaidv = '" + cbbSMenu.SelectedValue.ToString().Trim() + "'");
            cbbSName.DisplayMember = "TENDV";
            cbbSName.ValueMember = "MADV";
            start = 1;
            cbbSMenu.SelectedIndex = 0;
            cbbFloor.Text = "Tầng " + MAPH[1];
            txbRoom.Text = MAPH;
            if (TRANGTHAI==0)
            {
                LoadEnabled(false);
                LoadInfo();
            }
            else if(TRANGTHAI==1)
            {
                LoadEnabled(true);
            }
            else
            {
                LoadEnabled(false);
                LoadInfo();
                txbRoom.ReadOnly = true;
                cbbSMenu.Enabled = cbbSName.Enabled = true;
                
            }
            nmudGia.Enabled = false;
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Calendar_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (TRANGTHAI!=0)
            {
                string qr;
                if (TRANGTHAI == 1)
                {
                    qr = "insert PHONG values('"+txbRoom.Text+"',1)";
                    int k = db.getNonQuery(qr);
                    qr = "insert PHONG_DICHVU values('" + txbRoom.Text + "','" + cbbSName.SelectedValue.ToString().Trim() + "',0" + ")";
                    MessageBox.Show("Thêm phòng thành công công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    qr = "update phong_dichvu set madv = '"+cbbSName.SelectedValue.ToString().Trim()+"' where MAPH = '"+txbRoom.Text+"'";
                    MessageBox.Show("Cập nhật thông tin phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                int kq = db.getNonQuery(qr);
                QL.Calendar_Click(sender, e);
            }
            else QL.Calendar_Click(sender,e);
        }

        private void cbbSMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            begin = 0;
            if (start == 1)
            {
                cbbSName.DataSource = db.getDataTable("select * from dichvu where maloaidv = '" + cbbSMenu.SelectedValue.ToString().Trim() + "'");
                cbbSName.DisplayMember = "TENDV";
                cbbSName.ValueMember = "MADV";
                begin = 1;
                cbbSName.SelectedIndex = 0;
                int kq = Convert.ToInt32(db.getDataTable("select * from DICHVU where MADV = '" + cbbSName.SelectedValue.ToString().Trim() + "'").Rows[0]["GIA"].ToString().Trim());
                nmudGia.Value = kq;
            }
        }

        private void cbbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(start==1)
            {
                int kq = Convert.ToInt32(db.getDataTable("select max(substring(MAPH,3,2)) as 'MAX' from PHONG_DICHVU where substring(MAPH,2,1) = " + (cbbFloor.SelectedIndex + 1)).Rows[0]["MAX"].ToString().Trim());
                kq += 1;
                if (kq < 10)
                    txbRoom.Text = "P" + (cbbFloor.SelectedIndex+1) + "0" + kq;
                else txbRoom.Text = "P" + (cbbFloor.SelectedIndex+1) + kq;
            }
        }

        private void cbbSName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (begin == 1)
            {
                int kq = Convert.ToInt32(db.getDataTable("select * from DICHVU where MADV = '" + cbbSName.SelectedValue.ToString().Trim()+"'").Rows[0]["GIA"].ToString().Trim());
                nmudGia.Value = kq;
            }
        }
    }
}
