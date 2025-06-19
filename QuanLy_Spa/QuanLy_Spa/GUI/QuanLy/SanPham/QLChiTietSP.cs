using QuanLy_Spa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Spa.GUI.QuanLy.SanPham
{
    public partial class QLChiTietSP : Form
    {
        public QLChiTietSP(TrangChuQL ql, int trangthai, string masp)
        {
            InitializeComponent();
            MASP = masp;
            TRANGTHAI = trangthai;
            QL = ql;
        }
        string MASP;
        ConnectDB db = new ConnectDB();
        TrangChuQL QL;
        int TRANGTHAI;
        bool start = false;
        void LoadEnable(bool e)
        {
            cbbLoaiSP.Enabled = cbbCompany.Enabled = btnUploadFile.Enabled = nmudGia.Enabled = !e;
            txbAnh.ReadOnly = txbName.ReadOnly = e;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from SANPHAM where MASP = '" + MASP + "'");
            cbbLoaiSP.Text = db.getDataTable("select * from LOAI_SANPHAM where MALOAISP = '" +dt.Rows[0]["MALOAISP"].ToString().Trim()+"'").Rows[0]["TENLOAISP"].ToString().Trim();
            txbAnh.Text = dt.Rows[0]["ANH"].ToString().Trim();
            txbID.Text = MASP;
            txbName.Text = dt.Rows[0]["TENSP"].ToString().Trim();
            nmudGia.Value =  Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString().Trim());
            txbSLTon.Text = dt.Rows[0]["SLTON"].ToString().Trim();
            string mancc = db.getDataTable("select * from CUNGCAP_SANPHAM where MASP = '" + MASP+ "'").Rows[0]["MANCC"].ToString().Trim();
            cbbCompany.Text = db.getDataTable("select * from NHACUNGCAP where MANCC = '" + mancc + "'").Rows[0]["TENNCC"].ToString().Trim();
        }
        private void QLChiTietSP_Load(object sender, EventArgs e)
        {
            cbbLoaiSP.DataSource = db.getDataTable("select * from LOAI_SANPHAM ");
            cbbLoaiSP.DisplayMember = "TENLOAISP";
            cbbLoaiSP.ValueMember = "MALOAISP";
            cbbCompany.DataSource = db.getDataTable("select * from NHACUNGCAP ");
            cbbCompany.DisplayMember = "TENNCC";
            cbbCompany.ValueMember = "MANCC";
            txbID.Text = MASP;
            if (TRANGTHAI == 0)
            {
                lbHeader.Text = "Xem thông tin chi tiết sản phẩm";
                LoadEnable(true);
                LoadInfo();

            }
            else if (TRANGTHAI == 1)
            {
                LoadEnable(false);
                txbSLTon.Text = "0";
            }
            else
            {
                lbHeader.Text = "Cập nhật thông tin sản phẩm";
                LoadEnable(false);
                LoadInfo();
                cbbLoaiSP.Enabled = false;
            }
            start = true;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog.Title = "Chọn file ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string rsFolderPath = Path.Combine(projectPath, "Product_Resources");
                if (!Directory.Exists(rsFolderPath))
                {
                    Directory.CreateDirectory(rsFolderPath);
                }
                string fileName = txbID.Text + Path.GetExtension(sourceFilePath);
                string destinationFilePath = Path.Combine(rsFolderPath, fileName);
                File.Copy(sourceFilePath, destinationFilePath, true);
                txbAnh.Text = fileName;
                MessageBox.Show("File ảnh đã chọn: " + fileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TRANGTHAI != 0)
            {
                if (txbName.Text.Trim().Length > 0)
                {
                    int kq = db.getScalar("select count(*) from LOAI_SANPHAM where TENLOAISP = N'" + cbbLoaiSP.Text.Trim()+"'");
                    if (kq != 0)
                    {
                        kq = db.getScalar("select count(*) from NHACUNGCAP where TENNCC = N'" + cbbCompany.Text.Trim() + "'");
                        if (kq != 0)
                        {
                            string mldv = cbbLoaiSP.SelectedValue.ToString().Trim();
                            string madv = txbID.Text;
                            string tendv = txbName.Text;
                            string anh = txbAnh.Text;
                            string gia = nmudGia.Value.ToString();
                            string qr = "insert sanpham values('" + madv + "',N'" + tendv + "'," + gia + ",'" + anh + "','" + mldv + "',GETDATE(),0)";
                            if (TRANGTHAI == 1)
                            {
                                kq = db.getNonQuery(qr);
                                string mancc = cbbCompany.SelectedValue.ToString().Trim();
                                qr = "insert cungcap_sanpham values('" + mancc + "','" + madv + "',1)";
                                kq = db.getNonQuery(qr);
                                MessageBox.Show("Thêm sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (anh == "") anh = "NULL";
                                else anh = "'" + anh + "'";
                                qr = "exec dbo.CapNhat_ThongTin_SanPham @MASP = '" + madv.Trim() + "', @TENSP = N'" + tendv + "',@ANH = " + anh + ",@GIATIEN = " + gia;
                                kq = db.getNonQuery(qr);
                                kq = db.getNonQuery("update cungcap_sanpham set MANCC = '" + cbbCompany.SelectedValue.ToString().Trim() + "' where MASP = '" + MASP + "'");
                                MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn lại nhà cung cấp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorProvider1.SetError(cbbCompany, "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn lại loại sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(cbbLoaiSP, "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tên không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txbName, "Error");
                    return;
                }
            }
            QL.Product_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Product_Click(sender, e);
        }
    }
}
