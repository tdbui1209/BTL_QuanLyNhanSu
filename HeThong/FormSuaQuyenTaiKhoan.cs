using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.HeThong
{
    public partial class FormSuaQuyenTaiKhoan : Form
    {
        public FormSuaQuyenTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormSuaQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            Dictionary<string, object> parameres = new Dictionary<string, object>();
            parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
            DataTable quyenTaiKhoan = Database.Query(strQuery, parameres);

            for (int i = 0; i < quyenTaiKhoan.Rows.Count; i++)
            {
                if (quyenTaiKhoan.Rows[i]["TenChucNang"].ToString() == "He Thong")
                {
                    checkBox_HeThong.Checked = true;
                }
                if (quyenTaiKhoan.Rows[i]["TenChucNang"].ToString() == "Quan Ly")
                {
                    checkBox_QuanLy.Checked = true;
                }
                if (quyenTaiKhoan.Rows[i]["TenChucNang"].ToString() == "Quan Ly Phong Ban")
                {
                    checkBox_QuanLyPhongBan.Checked = true;
                }
                if (quyenTaiKhoan.Rows[i]["TenChucNang"].ToString() == "Quan Ly Nhan Su")
                {
                    checkBox_QuanLyNhanSu.Checked = true;
                }
                if (quyenTaiKhoan.Rows[i]["TenChucNang"].ToString() == "Quan Ly Chuc Vu")
                {
                    checkBox_QuanLyChucVu.Checked = true;
                }
            }

            if (checkBox_QuanLyNhanSu.Checked && checkBox_QuanLyPhongBan.Checked && checkBox_QuanLyChucVu.Checked)
            {
                checkBox_QuanLy.Checked = true;
            }
        }

        private void checkBox_QuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_QuanLy.Checked)
            {
                checkBox_QuanLyChucVu.Checked = true;
                checkBox_QuanLyNhanSu.Checked = true;
                checkBox_QuanLyPhongBan.Checked = true;
            } else
            {
                checkBox_QuanLyChucVu.Checked = false;
                checkBox_QuanLyNhanSu.Checked = false;
                checkBox_QuanLyPhongBan.Checked = false;
            }
        }

        private void checkBox_QuanLyPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_QuanLyPhongBan.Checked)
                checkBox_QuanLy.Checked = false;
            if (checkBox_QuanLyNhanSu.Checked && checkBox_QuanLyPhongBan.Checked && checkBox_QuanLyChucVu.Checked)
            {
                checkBox_QuanLy.Checked = true;
            }
        }

        private void checkBox_QuanLyNhanSu_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_QuanLyNhanSu.Checked)
                checkBox_QuanLy.Checked = false;
            if (checkBox_QuanLyNhanSu.Checked && checkBox_QuanLyPhongBan.Checked && checkBox_QuanLyChucVu.Checked)
            {
                checkBox_QuanLy.Checked = true;
            }
        }

        private void checkBox_QuanLyChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_QuanLyChucVu.Checked)
                checkBox_QuanLy.Checked = false;
            if (checkBox_QuanLyNhanSu.Checked && checkBox_QuanLyPhongBan.Checked && checkBox_QuanLyChucVu.Checked)
            {
                checkBox_QuanLy.Checked = true;
            }
        }

        private List<string> layChucNang()
        {
            string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            Dictionary<string, object> parameres = new Dictionary<string, object>();
            parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
            DataTable quyenTaiKhoan = Database.Query(strQuery, parameres);
            List<string> chucNangs = new List<string>();
            for (int i = 0; i < quyenTaiKhoan.Rows.Count; i++)
            {
                chucNangs.Add(quyenTaiKhoan.Rows[i]["TenChucNang"].ToString());
            }
            return chucNangs;
        }
        private void button_Sua_Click(object sender, EventArgs e)
        {
            string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            Dictionary<string, object> parameres = new Dictionary<string, object>();
            parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
            DataTable quyenTaiKhoan = Database.Query(strQuery, parameres);
            List<string> chucNangs = new List<string>();

            for (int i = 0; i < quyenTaiKhoan.Rows.Count; i++)
            {
                chucNangs.Add(quyenTaiKhoan.Rows[i]["TenChucNang"].ToString());
            }

            // Xoa Quyen
            if (!checkBox_HeThong.Checked && chucNangs.Contains("He Thong"))
            {
                strQuery = "exec spXoaQuyen @tenDangNhap, @chucNang";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "He Thong");
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (!checkBox_QuanLyNhanSu.Checked && chucNangs.Contains("Quan Ly Nhan Su"))
            {
                strQuery = "exec spXoaQuyen @tenDangNhap, @chucNang";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Nhan Su");
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (!checkBox_QuanLyPhongBan.Checked && chucNangs.Contains("Quan Ly Phong Ban"))
            {
                strQuery = "exec spXoaQuyen @tenDangNhap, @chucNang";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Phong Ban");
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (!checkBox_QuanLyChucVu.Checked && chucNangs.Contains("Quan Ly Chuc Vu"))
            {
                strQuery = "exec spXoaQuyen @tenDangNhap, @chucNang";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Chuc Vu");
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            // Them Quyen
            if (checkBox_HeThong.Checked && !chucNangs.Contains("He Thong"))
            {
                strQuery = "exec spThemQuyen @tenDangNhap, @chucNang, @nguoiSua";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "He Thong");
                parameres.Add("@nguoiSua", Program.TenDangNhap);
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (checkBox_QuanLyNhanSu.Checked && !chucNangs.Contains("Quan Ly Nhan Su"))
            {
                strQuery = "exec spThemQuyen @tenDangNhap, @chucNang, @nguoiSua";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Nhan Su");
                parameres.Add("@nguoiSua", Program.TenDangNhap);
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (checkBox_QuanLyPhongBan.Checked && !chucNangs.Contains("Quan Ly Phong Ban"))
            {
                strQuery = "exec spThemQuyen @tenDangNhap, @chucNang, @nguoiSua";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Phong Ban");
                parameres.Add("@nguoiSua", Program.TenDangNhap);
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }

            if (checkBox_QuanLyChucVu.Checked && !chucNangs.Contains("Quan Ly Chuc Vu"))
            {
                strQuery = "exec spThemQuyen @tenDangNhap, @chucNang, @nguoiSua";
                parameres = new Dictionary<string, object>();
                parameres.Add("@tenDangNhap", FormQuanLyTaiKhoan.TenDangNhap);
                parameres.Add("@chucNang", "Quan Ly Chuc Vu");
                parameres.Add("@nguoiSua", Program.TenDangNhap);
                Database.Execute(strQuery, parameres);
                chucNangs = layChucNang();
            }
            MessageBox.Show("Thay đổi quyền tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}