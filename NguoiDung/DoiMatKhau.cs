using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.NguoiDung
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox_MatKhau.Text.Length == 0)
            {
                errorProvider1.SetError(textBox_MatKhau, "Mật khẩu không được để trống");
            }
            if (textBox_MatKhauMoi.Text.Length == 0)
            {
                errorProvider1.SetError(textBox_MatKhauMoi, "Mật khẩu không được để trống");
            }
            if (textBox_MatKhauMoi.Text != textBox_NhapLaiMatKhau.Text)
            {
                errorProvider1.SetError(textBox_NhapLaiMatKhau, "Mật khẩu không trùng khớp");
            }
            string sqlQuery = "EXEC spDoiMatKhau @tenDangNhap, @matKhau, @matKhauMoi";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", Program.TenDangNhap);
            parameters.Add("@matKhau", textBox_MatKhau.Text);
            parameters.Add("@matKhauMoi", textBox_MatKhauMoi.Text);
            try
            {
                Database.Execute(sqlQuery, parameters);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Sai mật khẩu")
                    errorProvider1.SetError(textBox_MatKhau, ex.Message);
            }
        }
    }
}
