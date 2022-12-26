using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.QuanLy
{
    public partial class frmSuaNhanVien : Form
    {
        private void loadCbbQueQuan()
        {
            cbbQueQuan.DataSource = Database.Query("SELECT * FROM TinhThanh", new Dictionary<string, object>());
        }
        private void loadCbbDanToc()
        {
            cbbDanToc.DataSource = Database.Query("SELECT * FROM DanToc", new Dictionary<string, object>());
        }
        private void loadCbbTonGiao()
        {
            cbbTonGiao.DataSource = Database.Query("SELECT * FROM TonGiao", new Dictionary<string, object>());
        }
        private void loadCbbTinhThanh()
        {
            cbbTinhThanh.DataSource = Database.Query("SELECT * FROM TinhThanh", new Dictionary<string, object>());
        }
        private void loadCbbChucVu()
        {
            cbbChucVu.DataSource = Database.Query("SELECT * FROM ChucVu", new Dictionary<string, object>());
        }
        private void loadCbbPhongBan()
        {
            cbbPhongBan.DataSource = Database.Query("SELECT * FROM PhongBan", new Dictionary<string, object>());
        }
        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        public frmSuaNhanVien(int maNhanVien)
        {
            InitializeComponent();
            loadCbbQueQuan();
            loadCbbDanToc();
            loadCbbTonGiao();
            loadCbbTinhThanh();
            loadCbbChucVu();
            loadCbbPhongBan();
            loadCbbNgoaiNgu();
            loadForm(maNhanVien);
        }


        private void loadForm(int maNhanVien)
        {
            tboMaNhanVien.Text = maNhanVien.ToString();
            string strQuery = "SELECT * FROM NhanVien WHERE MaNhanVien=@maNhanVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNhanVien", maNhanVien);
            DataTable nhanViens = Database.Query(strQuery, parameters);
            if (nhanViens.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại nhân viên có mã là " + maNhanVien.ToString(), "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                DataRow nhanVien = nhanViens.Rows[0];
                tboHo.Text = nhanVien["Ho"].ToString();
                tboTen.Text = nhanVien["Ten"].ToString();
                cbbQueQuan.SelectedValue = nhanVien["MaQueQuan"];
                dtpNgaySinh.Value = DateTime.Parse(nhanVien["NgaySinh"].ToString());
                if (nhanVien["GioiTinh"] == null)
                    chbGioiTinh.Checked = false;
                else if (nhanVien["GioiTinh"].ToString() == "True")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tboHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btoThemNgoaiNgu_Click(object sender, EventArgs e)
        {
  
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            if(KiemTraThongTin())
            {
                try
                {
                    string strCommand = "EXEC spSuaNhanVien @maNhanVien";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@ho", tboHo.Text);
                    parameters.Add("@ten", tboTen.Text);
                    parameters.Add("@ngaySinh", dtpNgaySinh.Value);
                    if (chbGioiTinh.Checked == false)
                        parameters.Add("gGioiTinh", null);
                    else
                        parameters.Add("gGioiTinh", rdbNam.Checked);
                    parameters.Add("@diaChi", tboDiaChi.Text);
                    parameters.Add("@Email", tboEmail.Text);
                    parameters.Add("@dienThoai", tboDienThoai.Text);
                    parameters.Add("@nguoiSua", Program.TenDangNhap);
                    Database.Execute(strCommand, parameters);
                    int maNhanVien = (int)Database.Query("SELECT MAX(MaNhanVien) FROM NhanVien", new Dictionary<string, object>()).Rows[0][0];
                    MessageBox.Show("Sửa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }


        private bool KiemTraThongTin()
        {
            if (tboHo.Text == "")
            {
                MessageBox.Show("Vui lòng điền họ và tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboHo.Focus();
                return false;
            }
            if (tboTen.Text == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboTen.Focus();
                return false;
            }
            if (tboEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền Email của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboEmail.Focus();
                return false;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tboDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboDienThoai.Focus();
                return false;
            }
            if (tboDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboDiaChi.Focus();
                return false;
            }
            return true;
        }
        private void btoXoaNgoaiNgu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
