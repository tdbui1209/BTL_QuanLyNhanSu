using BTL_QuanyNhanSu.HeThong;
using QuanLyNhanSu;
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
                mni_QuanLy.Enabled = lstChucNang.Contains("Quan Ly");
                mni_NguoiDung.Enabled = lstChucNang.Contains("Nguoi Dung");
                mni_ThongTinCaNhan.Enabled = lstChucNang.Contains("Thong Tin Ca Nhan");
            }
        }

        private void mni_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan form = new FormTaoTaiKhoan();
            form.ShowDialog();
        }
    }
}