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

namespace QuanLy_Spa.GUI.QuanLy.LichHen
{
    public partial class QLLichHen : Form
    {
        public QLLichHen(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            dtgvLich.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvLich.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from lich_hen where ngay_dat_lich ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by THOIGIAN_BATDAU asc");
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        void LoadTable(string qr)
        {
            DataTable dt = db.getDataTable(qr);
            dtgvLich.DataSource = dt;
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                dtgvLich.Rows[i].Cells[0].Value = r["MALICHHEN"].ToString().Trim();
                DataTable Dv = db.getDataTable("select * from dichvu where madv ='" + r["MADV"].ToString().Trim() + "'");
                DataTable Kh = db.getDataTable("select * from khachhang where makh ='" + r["MAKH"].ToString().Trim() + "'");
                dtgvLich.Rows[i].Cells[1].Value = r["MAKH"].ToString().Trim();
                dtgvLich.Rows[i].Cells[2].Value = Kh.Rows[0]["HOTEN"].ToString().Trim();
                dtgvLich.Rows[i].Cells[3].Value = Dv.Rows[0]["TENDV"].ToString().Trim();
                dtgvLich.Rows[i].Cells[4].Value = Convert.ToDateTime(r["NGAY_DAT_LICH"].ToString().Trim()).ToString("dd/MM/yyyy");
                dtgvLich.Rows[i].Cells[5].Value = (r["THOIGIAN_BATDAU"].ToString().Trim()+" - "+ r["THOIGIAN_KETTHUC"].ToString().Trim()).ToString();
                if (r["TRANGTHAI"].ToString().Trim() == "1")
                {
                    dtgvLich.Rows[i].Cells[7].Value = "Hoàn thành";
                    dtgvLich.Rows[i].Cells[7].Style.ForeColor = Color.DarkGreen;
                }
                else if (r["TRANGTHAI"].ToString().Trim() == "2")
                {
                    dtgvLich.Rows[i].Cells[7].Value = "Hủy hẹn";
                    dtgvLich.Rows[i].Cells[7].Style.ForeColor = Color.DarkRed;
                }
                else 
                {
                    dtgvLich.Rows[i].Cells[7].Value = "Chờ";
                    dtgvLich.Rows[i].Cells[7].Style.ForeColor = Color.Blue;
                }
                
                string thanhtien = string.Format("{0:0,0 vnd}", Convert.ToInt32(Dv.Rows[0]["GIA"].ToString().Trim()));
                dtgvLich.Rows[i].Cells[6].Value = thanhtien.ToString();
                i++;
            }
        }
        private void QLLichHen_Load(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select * from khachhang");
            cbbKH.DataSource = dt;
            cbbKH.DisplayMember = "HOTEN";
            cbbKH.ValueMember = "MAKH";
            dt = db.getDataTable("select * from DICHVU");
            cbbDichVu.DataSource = dt;
            cbbDichVu.DisplayMember = "TENDV";
            cbbDichVu.ValueMember = "MADV";
            cbbSelect.Items.Add("Tất cả lịch hẹn");
            cbbSelect.Items.Add("Lịch hẹn có trạng thái hoàn thành");
            cbbSelect.Items.Add("Lịch hẹn có trạng thái đang chờ");
            cbbSelect.Items.Add("Lịch hẹn có trạng thái hủy");
            cbbSelect.Items.Add("Tìm theo mã khách hàng");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : ngày/tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : tháng/năm");
            cbbSelect.Items.Add("Tìm theo ngày đặt  : năm");
            cbbSelect.Items.Add("Tìm theo mã khách hàng và năm");
            cbbSelect.Items.Add("Tìm theo mã khách hàng và tháng/năm");
            cbbSelect.Items.Add("Tìm theo mã khách hàng và ngày/tháng/năm");
            cbbSelect.Items.Add("Tìm theo dịch vụ và năm");
            cbbSelect.Items.Add("Tìm theo dịch vụ và tháng/năm");
            cbbSelect.Items.Add("Tìm theo dịch vụ và ngày/tháng/năm");
            cbbSelect.SelectedIndex = 5;
            LoadTable("select * from lich_hen where ngay_dat_lich ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by THOIGIAN_BATDAU asc");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(cbbSelect.SelectedIndex ==0)
            {
                LoadTable("select * from lich_hen");
            }
            else if(cbbSelect.SelectedIndex == 1)
            {
                LoadTable("select * from lich_hen where TRANGTHAi = 1");
            }
            else if (cbbSelect.SelectedIndex == 2)
            {
                LoadTable("select * from lich_hen where TRANGTHAi = 0");
            }
            else if (cbbSelect.SelectedIndex == 3)
            {
                LoadTable("select * from lich_hen where TRANGTHAi = 2");
            }
            else if (cbbSelect.SelectedIndex == 4)
            {
                LoadTable("select * from lich_hen where makh ='" + cbbKH.SelectedValue.ToString().Trim()+"'");
            }
            else if (cbbSelect.SelectedIndex == 5)
            {
                LoadTable("select * from lich_hen where ngay_dat_lich ='" + dtpkDayFind.Value.ToString("yyyy-MM-dd")+"'");
            }
            else if (cbbSelect.SelectedIndex == 6)
            {
                LoadTable("select * from lich_hen where year(ngay_dat_lich) =" + dtpkDayFind.Value.Year + " and Month(ngay_dat_lich) = "+ dtpkDayFind.Value.Month);
            }
            else if (cbbSelect.SelectedIndex == 7)
            {
                LoadTable("select * from lich_hen where year(ngay_dat_lich) =" + dtpkDayFind.Value.Year);
            }
            else if (cbbSelect.SelectedIndex == 8)
            {
                LoadTable("select * from lich_hen where makh = '"+cbbKH.SelectedValue.ToString().Trim()+"' and year(ngay_dat_lich) =" + dtpkDayFind.Value.Year);
            }
            else if (cbbSelect.SelectedIndex == 9)
            {
                LoadTable("select * from lich_hen where makh = '" + cbbKH.SelectedValue.ToString().Trim() + "' and year(ngay_dat_lich) =" + dtpkDayFind.Value.Year + " and Month(ngay_dat_lich) = " + dtpkDayFind.Value.Month);
            }
            else if (cbbSelect.SelectedIndex == 10)
            {
                LoadTable("select * from lich_hen where makh = '" + cbbKH.SelectedValue.ToString().Trim() + "' and ngay_dat_lich ='" + dtpkDayFind.Value.ToString("yyyy-MM-dd")+"'");
            }
            else if (cbbSelect.SelectedIndex == 11)
            {
                LoadTable("select * from lich_hen where madv = '" + cbbDichVu.SelectedValue.ToString().Trim() + "' and year(ngay_dat_lich) =" + dtpkDayFind.Value.Year);
            }
            else if (cbbSelect.SelectedIndex == 12)
            {
                LoadTable("select * from lich_hen where madv = '" + cbbDichVu.SelectedValue.ToString().Trim() + "' and year(ngay_dat_lich) =" + dtpkDayFind.Value.Year + " and Month(ngay_dat_lich) = " + dtpkDayFind.Value.Month);
            }
            else if (cbbSelect.SelectedIndex == 13)
            {
                LoadTable("select * from lich_hen where madv = '" + cbbDichVu.SelectedValue.ToString().Trim() + "' and ngay_dat_lich ='" + dtpkDayFind.Value.ToString("yyyy-MM-dd")+"'");
            }
        }
    }
}
