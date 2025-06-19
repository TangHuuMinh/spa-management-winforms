using iTextSharp.text;
using QuanLy_Spa.Data;
using QuanLy_Spa.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    public partial class QLNHapHang : Form
    {
        public QLNHapHang(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            TV.ExpandAll();
        }
        TrangChuQL QL;
        ConnectDB db = new ConnectDB();
        private void TV_Click(object sender, EventArgs e)
        {
            string tv = TV.SelectedNode.ToString();
            tv = tv.Substring(10, tv.Length - 10);
            if(tv=="Xem danh sách phiếu nhập")
            {
                QL.DSPhieuNhap_Click(sender, e);
            }
            else if (tv == "Xem danh sách nhà cung cấp")
            {
                QL.DSNhaCungCap_Click(sender, e);
            }
            else if (tv == "In file phiếu nhập dạng PDF")
            {
                string text = "\t\t\tDANH SÁCH PHIẾU NHẬP\n\n";
                DataTable dt = db.getDataTable("select P.MAHDCC,N.TENNCC,P.NGAYDAT,P.NGAYGIAO,SUM(CT.GIA*CT.SOLUONG) as'TONG' from PHIEUNHAP P, NHACUNGCAP N,CHITIET_PHIEUNHAP CT WHERE P.MAHDCC = CT.MAHDCC and P.MANCC = N.MANCC GROUP BY P.MAHDCC,N.TENNCC,P.NGAYDAT,P.NGAYGIAO");
                foreach (DataRow r in dt.Rows)
                {
                    string nn = Convert.ToDateTime(r["NGAYDAT"].ToString().Trim()).ToString("dd/MM/yyyy");
                    string ng = "NULL";
                    if (r["NGAYGIAO"].ToString().Trim() !="")
                    { ng = Convert.ToDateTime(r["NGAYGIAO"].ToString().Trim()).ToString("dd/MM/yyyy"); }
                     
                    string tt = string.Format("{0:0,0 vnd}",Convert.ToInt32(r["TONG"].ToString().Trim()));
                    text += string.Format("{0,-10} - {1,-40} - {2,-10} - {3,-10} - {4,-10}\n\n\n", r["MAHDCC"].ToString().Trim(), r["TENNCC"].ToString().Trim(),nn,ng,tt );
                }
                PDF p = new PDF(text);
            }
            else if (tv == "In file phiếu nhập dạng Excel")
            {
                string[] h = new string[] { "Mã phiếu nhập","Mã nhà cung cấp", "Tên nhà cung cấp", "Ngày đặt","Ngày giao","Thành tiền" };
                DataTable dt = db.getDataTable("select P.MAHDCC,N.MANCC,N.TENNCC,P.NGAYDAT,P.NGAYGIAO,SUM(CT.GIA*CT.SOLUONG) as'TONG' from PHIEUNHAP P, NHACUNGCAP N,CHITIET_PHIEUNHAP CT WHERE P.MAHDCC = CT.MAHDCC and P.MANCC = N.MANCC GROUP BY P.MAHDCC,N.MANCC,N.TENNCC,P.NGAYDAT,P.NGAYGIAO");
                Excel ex = new Excel(h, dt);
            }
            else if(tv == "In file nhà cung cấp dạng PDF")
            {
                MessageBox.Show("Lưu ý\nHệ thống chỉ in ra danh sách công ty còn hợp tác","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                string text = "\t\t\tDANH SÁCH NHÀ CUNG CẤP\n\n";
                DataTable dt = db.getDataTable("select MANCC,TENNCC,DIACHI,SDT from NhaCUNGCAP where TRANGTHAI = 1");
                foreach (DataRow r in dt.Rows)
                {
                    text += string.Format("{0,-10} - {1,-40} - {2,-50} - {3,-10}\n\n\n", r["MANCC"].ToString().Trim(), r["TENNCC"].ToString().Trim(), r["DIACHI"].ToString().Trim(), r["SDT"].ToString().Trim());
                }
                PDF p = new PDF(text);
                
            }
            else if(tv == "In file nhà cung cấp dạng Excel")
            {
                MessageBox.Show("Lưu ý\nHệ thống chỉ in ra danh sách công ty còn hợp tác", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string[] h = new string[] { "Mã nhà cung cấp", "Tên nhà cung cấp", "Địa chỉ","Số điện thoại" };
                DataTable dt = db.getDataTable("select MANCC,TENNCC,DIACHI,SDT from NhaCUNGCAP where TRANGTHAI = 1");
                Excel ex = new Excel(h, dt);
            }
            else if(tv== "Tạo phiếu nhập")
            {
                string MAPN;
                int MAX = Convert.ToInt32(db.getDataTable("select MAX(substring(MAHDCC,5,3))+1 as 'MAX' from PHIEUNHAP").Rows[0]["MAX"].ToString().Trim());
                if (MAX < 10) MAPN = "HDCC00" + MAX;
                else if (MAX < 100) MAPN = "HDCC0" + MAX;
                else MAPN = "HDCC" + MAX;
                QL.TaoPhieuNhap_Click(1,MAPN);
            }
            else if(tv== "Thêm nhà cung cấp mới")
            {
                string MANCC = db.getDataTable("select MAX(substring(MANCC,4,3))+1 as 'MAX' from NHACUNGCAP").Rows[0]["MAX"].ToString().Trim();
                int max = Convert.ToInt32(MANCC);
                string MA = (max < 10) ? ("NCC00" +max) : ((max < 100) ? ("NCC0"+max) : ("NCC0"+max));
                QL.TaoNhaCungCap_Click(MA,1);
            }
        }

        private void QLNHapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
