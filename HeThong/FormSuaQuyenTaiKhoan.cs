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
            }
        }
    }
}
