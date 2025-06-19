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

namespace QuanLy_Spa.GUI.QuanLy.DichVu
{
    public partial class DLChiTietDV : Form
    {
        public DLChiTietDV(TrangChuQL ql, int trangthai ,string madv)
        {
            InitializeComponent();
            MADV = madv;
            TRANGTHAI = trangthai;
            QL = ql;
        }
        string MADV;
        ConnectDB db = new ConnectDB();
        TrangChuQL QL;
        int TRANGTHAI;
        void LoadEnable(bool e)
        {
            cbbLoaiDV.Enabled = cbbTrangThai.Enabled = btnUploadFile.Enabled = nmudGia.Enabled = !e;
            txbAnh.ReadOnly = txbName.ReadOnly = e;
        }
        void LoadInfo()
        {
            DataTable dt = db.getDataTable("select * from DichVU where MADV = '" + MADV + "'");
            cbbLoaiDV.Text = db.getDataTable("select * from Loai_DICHVU where MALOAIDV = '" +dt.Rows[0]["MALOAIDV"].ToString().Trim()+"'").Rows[0]["TENDV"].ToString().Trim();
            txbAnh.Text = dt.Rows[0]["ANH"].ToString().Trim();
            txbID.Text = MADV;
            txbName.Text = dt.Rows[0]["TENDV"].ToString().Trim();
            nmudGia.Value = Convert.ToInt32(dt.Rows[0]["GIA"].ToString().Trim());
            cbbTrangThai.Text = (dt.Rows[0]["TRANGTHAI"].ToString().Trim()=="1") ? "Hoạt động" : "Ngừng";
        }
        private void DLChiTietDV_Load(object sender, EventArgs e)
        {
            cbbLoaiDV.DataSource = db.getDataTable("select * from LOAI_DICHVU ");
            cbbLoaiDV.DisplayMember = "TENDV";
            cbbLoaiDV.ValueMember = "MALOAIDV";
            txbID.Text = MADV;
            if(TRANGTHAI==0)
            {
                lbHeader.Text = "Xem thông tin chi tiết dịch vụ";
                LoadEnable(true);
                LoadInfo();
                
            }
            else if(TRANGTHAI ==1)
            {
                LoadEnable(false);
                cbbTrangThai.Enabled = false;
                cbbTrangThai.Text = "Hoạt động";
            }
            else
            {
                lbHeader.Text = "Cập nhật thông tin dịch vụ";
                LoadEnable(false);
                cbbLoaiDV.Enabled = false;
                LoadInfo();
            }
            
            cbbTrangThai.Items.Add("Ngừng");
            cbbTrangThai.Items.Add("Hoạt động");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QL.Service_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(TRANGTHAI!=0)
            {
                if(txbName.Text.Trim().Length > 0)
                {
                    int kq = db.getScalar("select count(*) from LOAI_DICHVU where TENDV = N'" + cbbLoaiDV.Text.Trim() + "'");
                    if (kq != 0)
                    {

                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn lại loại dịch vụ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(cbbLoaiDV, "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tên không được để  trống","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    errorProvider1.SetError(txbName, "Error");
                    return;
                }
            }
            else QL.Service_Click(sender, e);
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTrangThai.SelectedIndex == 0)
            {
                if(MessageBox.Show("Bạn muốn ngừng hoạt động dịch vụ???","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    cbbTrangThai.SelectedIndex = 1;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pcbPercent.Value < 100)
            {
                pcbPercent.Value += 5;
            }
            else
            {
                timer1.Stop();
                string mldv = cbbLoaiDV.SelectedValue.ToString().Trim();
                string madv = txbID.Text;
                string tendv = txbName.Text;
                string anh = txbAnh.Text;
                string gia = nmudGia.Value.ToString();
                int tt = cbbTrangThai.SelectedIndex;
                string qr = "insert dichvu values('" + madv + "',N'" + tendv + "'," + gia + ",null,'" + mldv + "',"+tt+")";
                if (TRANGTHAI==1)
                {
                    int kq = db.getNonQuery(qr);
                    MessageBox.Show("Thêm dịch vụ thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    qr = "exec dbo.CapNhat_ThongTin_DichVu @MADV = '" + madv.Trim() + "', @TENDV = N'" + tendv + "',@GIA = " + gia + ",@ANH = null,@LOAIDV = '" + mldv + "'";
                    int kq = db.getNonQuery(qr);
                    kq = db.getNonQuery("UPDATE DICHVU SET TRANGTHAI = "+tt+" WHERE MADV = '"+txbID.Text+"'");
                    MessageBox.Show("Cập nhật thông tin dịch vụ thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                QL.Service_Click(sender, e);
            }
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
                string rsFolderPath = Path.Combine(projectPath, "Service_Resources");
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
    }
}
