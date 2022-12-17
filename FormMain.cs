using BTL_QuanyNhanSu.HeThong;
using BTL_QuanyNhanSu.NguoiDung;
using BTL_QuanyNhanSu.QuanLy;
using System.Data;

namespace BTL_QuanyNhanSu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormDangNhap form = new FormDangNhap();
            form.ShowDialog();

            if (!form.Authentication) 
            {
                Application.Exit();
            }
            else
            {
                
                string strQuery = "SELECT * FROM dbo.ufLayPhanQuyen(@tenDangNhap)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", Program.TenDangNhap);
                DataTable chucNangs = Database.Query(strQuery, parameters);
                List<string> lstChucNang = new List<string>();
                for (int i = 0; i < chucNangs.Rows.Count; ++i)
                    lstChucNang.Add(chucNangs.Rows[i]["TenChucNang"].ToString());

                mni_HeThong.Enabled = lstChucNang.Contains("He Thong");
                // mni_QuanLy.Enabled = lstChucNang.Contains("Quan Ly");
                // mni_NguoiDung.Enabled = lstChucNang.Contains("Nguoi Dung");
                mni_QuanLyPhongBan.Enabled = lstChucNang.Contains("Quan Ly Phong Ban");
                mni_QuanLyNhanSu.Enabled = lstChucNang.Contains("Quan Ly Nhan Su");
            }
        }

        private void mni_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan form = new FormTaoTaiKhoan();
            form.ShowDialog();
        }

        private void mni_QuanLyNhanSu_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhSachNhanVien form = new frmQuanLyDanhSachNhanVien();
            form.ShowDialog();
        }

        private void mni_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan form = new FormQuanLyTaiKhoan();
            form.ShowDialog();
        }

        private void mni_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
        }

        private void mni_QuanLyPhongBan_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhSachPhongBan form = new frmQuanLyDanhSachPhongBan();
            form.ShowDialog();
        }

        private void mni_NhatKy_Click(object sender, EventArgs e)
        {
            FormNhatKy form = new FormNhatKy();
            form.ShowDialog();
        }

        private void mni_QuanLyChucVu_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhSachChucVu form = new frmQuanLyDanhSachChucVu();
            form.ShowDialog();
        }
    }
}