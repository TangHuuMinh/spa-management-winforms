using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.QuanLy.NhapHang
{
    public partial class QLNhaCungCsp : Form
    {
        public QLNhaCungCsp(TrangChuQL ql)
        {
            InitializeComponent();
            QL = ql;
            dtgvNhaCC.AutoGenerateColumns = false;
            foreach (DataGridViewColumn cl in dtgvNhaCC.Columns)
            {
                cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LoadTable("select * from NHACUNGCAP");
        }
        ConnectDB db = new ConnectDB();
        TrangChuQL QL;
        void LoadTable(string qr)
        {
            DataTable dt = db.getDataTable(qr);
            dtgvNhaCC.DataSource = dt;
            int i = 0;
            int sum = 0;
            foreach (DataRow r in dt.Rows)
            {
                if (r["TRANGTHAI"].ToString().Trim() == "0")
                {
                    dtgvNhaCC.Rows[i].Cells[4].Value = "Ngừng hợp tác";
                    dtgvNhaCC.Rows[i].Cells[4].Style.ForeColor = Color.DarkRed;
                }
                else
                {
                    dtgvNhaCC.Rows[i].Cells[4].Value = "Hợp tác";
                    dtgvNhaCC.Rows[i].Cells[4].Style.ForeColor = Color.DarkGreen;
                }
                i++;
            }
            lbCount.Text = dt.Rows.Count.ToString();
        }
        private void QLNhaCungCsp_Load(object sender, EventArgs e)
        {
            LoadTable("select * from NHACUNGCAP");
            DataTable dt = db.getDataTable("select * from sanpham");
            cbbSanPham.DataSource = dt;
            cbbSanPham.DisplayMember = "TENSP";
            cbbSanPham.ValueMember = "MASP";
            dt = db.getDataTable("select * from NHACUNGCAP");
            cbbMaNCC.DataSource = dt;
            cbbMaNCC.DisplayMember = "TENNCC";
            cbbMaNCC.ValueMember = "MANCC";
            cbbSelect.Items.Add("Tất cả nhà cung cấp");
            cbbSelect.Items.Add("Tìm nhà cung cấp theo tên");
            cbbSelect.Items.Add("Tìm nhà cung cấp theo loại sản phẩm");
            cbbSelect.Items.Add("Tìm nhà cung cấp theo sản phẩm");
            cbbSelect.SelectedIndex = cbbMaNCC.SelectedIndex = cbbMaNCC.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbbSelect.SelectedIndex == 0)
            {
                LoadTable("select * from NhaCUNGCAP");
            }
            else if (cbbSelect.SelectedIndex == 1)
            {
                LoadTable("select * from NhaCUNGCAP where MANCC = '"+cbbMaNCC.SelectedValue.ToString().Trim()+"'");
            }
            else if (cbbSelect.SelectedIndex == 2)
            {
                LoadTable("select NCC.MANCC,NCC.TENNCC,NCC.DIACHI,NCC.SDT,NCC.TRANGTHAI from NhaCUNGCAP NCC,CUNGCAP_SANPHAM SP ,SANPHAM S where NCC.MANCC = SP.MANCC and SP.MASP = S.MASP and S.MALOAISP = '" + cbbSanPham.SelectedValue.ToString().Trim() + "' group by NCC.MANCC,NCC.TENNCC,NCC.DIACHI,NCC.SDT,NCC.TRANGTHAI");
            }
            else
            {
                LoadTable("select NCC.* from NhaCUNGCAP NCC,CUNGCAP_SANPHAM SP where NCC.MANCC = SP.MANCC and SP.MASP = '"+cbbSanPham.SelectedValue.ToString().Trim()+"'");
            }
        }
        private void dtgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string MaNCC = dtgvNhaCC.Rows[row].Cells[0].Value.ToString().Trim();
            if (dtgvNhaCC.Columns[e.ColumnIndex].Name == "CapNhat")
            {
                QL.TaoNhaCungCap_Click(MaNCC, 2);
            }
            else if(dtgvNhaCC.Columns[e.ColumnIndex].Name == "Xem")
            {
                QL.TaoNhaCungCap_Click(MaNCC, 0);
            }
        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSelect.SelectedIndex == 2)
            {
                DataTable dt = db.getDataTable("select * from loai_sanpham");
                cbbSanPham.DataSource = dt;
                cbbSanPham.DisplayMember = "TENLOAISP";
                cbbSanPham.ValueMember = "MALOAISP";
                cbbSanPham.SelectedIndex = 0;
            }
            else if (cbbSelect.SelectedIndex == 3)
            {
                DataTable dt = db.getDataTable("select * from sanpham");
                cbbSanPham.DataSource = dt;
                cbbSanPham.DisplayMember = "TENSP";
                cbbSanPham.ValueMember = "MASP";
                cbbSanPham.SelectedIndex = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Order_Click(sender, e);
        }
    }
}
