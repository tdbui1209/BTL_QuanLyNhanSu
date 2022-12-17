using BTL_QuanyNhanSu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.QuanLy
{
    public partial class frmThemNhanVien : Form
    {
        private DataTable ngoaiNguNhanViens = new DataTable();
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
        public frmThemNhanVien()
        {
            InitializeComponent();
            loadCbbQueQuan();
            loadCbbDanToc();
            loadCbbTonGiao();
            loadCbbTinhThanh();
            loadCbbChucVu();
            loadCbbPhongBan();
            loadCbbNgoaiNgu();
            dgvNgoaiNguNhanVien.AutoGenerateColumns = false;
            ngoaiNguNhanViens.Columns.Add("MaNgoaiNgu");
            ngoaiNguNhanViens.Columns.Add("TenNgoaiNgu");
            ngoaiNguNhanViens.Columns.Add("GhiChu");
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string strCommand = "INSERT NhanVien(Ho,Ten,NgaySinh,GioiTinh,MaQueQuan,MaDanToc,MaTonGiao,DiaChi,MaTinhThanh,DienThoai,Email,MaPhongBan,MaChucVu,NguoiSua,ThoiDiemSua) VALUES(@ho,@ten,@ngaySinh,@gioiTinh,@maQueQuan,@maDanToc,@maTonGiao,@diaChi,@maTinhThanh,@dienThoai,@email,@maPhongBan,@maChucVu,@nguoiSua, default)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ho", tboHo.Text);
            parameters.Add("@ten", tboTen.Text);
            parameters.Add("@ngaySinh", dtpNgaySinh.Value);
            if (chbGioiTinh.Checked == false)
                parameters.Add("@gioiTinh", null);
            else
                parameters.Add("@gioiTinh", rdbNam.Checked);
            parameters.Add("@maQueQuan", cbbQueQuan.SelectedValue);
            parameters.Add("@maDanToc", cbbDanToc.SelectedValue);
            parameters.Add("@maTonGiao", cbbTonGiao.SelectedValue);
            parameters.Add("@diaChi", tboDiaChi.Text);
            parameters.Add("@maTinhThanh", cbbTinhThanh.SelectedValue);
            parameters.Add("@dienThoai", tboDienThoai.Text);
            parameters.Add("@Email", tboEmail.Text);
            parameters.Add("@maChucVu", cbbChucVu.SelectedValue);
            parameters.Add("@maPhongBan", cbbPhongBan.SelectedValue);
            parameters.Add("@nguoiSua", Program.TenDangNhap);
            Database.Execute(strCommand, parameters);
            int maNhanVien = (int)Database.Query("SELECT MAX(MaNhanVien) FROM NhanVien", new Dictionary<string, object>()).Rows[0][0];
            for (int i = 0; i < ngoaiNguNhanViens.Rows.Count; ++i)
            {
                strCommand = "INSERT NgoaiNguNhanVien VALUES(@maNhanVien,@maNgoaiNgu,@ghiChu)";
                parameters = new Dictionary<string, object>();
                parameters.Add("@maNhanVien", maNhanVien);
                parameters.Add("@maNgoaiNgu", ngoaiNguNhanViens.Rows[i]["MaNgoaiNgu"]);
                parameters.Add("@ghiChu", ngoaiNguNhanViens.Rows[i]["GhiChu"]);
                Database.Execute(strCommand, parameters);
            }
            sttStrip_label.Text = "Thông báo: Thêm nhân viên thành công!";
        }

        private void btoThemNgoaiNgu_Click(object sender, EventArgs e)
        {
            DataRow ngoaiNguNhanVien = ngoaiNguNhanViens.NewRow();
            ngoaiNguNhanVien["MaNgoaiNgu"] = cbbNgoaiNgu.SelectedValue;
            ngoaiNguNhanVien["TenNgoaiNgu"] = cbbNgoaiNgu.Text;
            ngoaiNguNhanVien["GhiChu"] = tboGhiChu.Text;
            ngoaiNguNhanViens.Rows.Add(ngoaiNguNhanVien);
            dgvNgoaiNguNhanVien.DataSource = ngoaiNguNhanViens;
            btoXoaNgoaiNgu.Enabled = dgvNgoaiNguNhanVien.Rows.Count > 0;
        }

        private void btoXoaNgoaiNgu_Click(object sender, EventArgs e)
        {
            ngoaiNguNhanViens.Rows.RemoveAt(dgvNgoaiNguNhanVien.CurrentRow.Index);
            dgvNgoaiNguNhanVien.DataSource = ngoaiNguNhanViens;
            btoXoaNgoaiNgu.Enabled = dgvNgoaiNguNhanVien.Rows.Count > 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void tbpNgoaiNgu_Click(object sender, EventArgs e)
        {

        }
    }
}
