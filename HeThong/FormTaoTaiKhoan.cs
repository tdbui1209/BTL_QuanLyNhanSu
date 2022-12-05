using QuanLyNhanSu;
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
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void checkBox_QuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_QuanLy.Checked)
            {
                checkBox_QuanLyNhanSu.Checked = true;
                checkBox_QuanLyPhongBan.Checked = true;
            }
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            if (textBox_NhapLaiMatKhau.Text != textBox_MatKhau.Text)
            {
                errorProvider1.SetError(textBox_NhapLaiMatKhau, "Mật khẩu không khớp!");
                return;
            }
            string strCommand = "EXEC spThemNguoiDung @TenDangNhap, @MatKhau, @TrangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters = new Dictionary<string, object>();
            parameters.Add("@TenDangNhap", textBox_TenDangNhap.Text);
            parameters.Add("@MatKhau", textBox_MatKhau.Text);
            parameters.Add("@TrangThai", true);
            try
            {
                Database.Execute(strCommand, parameters);
                sttStrip.Text = "Thông báo: Tạo tài khoản thành công!";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Tài khoản đã tồn tại")
                    errorProvider1.SetError(textBox_TenDangNhap, ex.Message);
            }

            // Phan Quyen Chuc Nang
            strCommand = "EXEC spPhanQuyen @TenDangNhap, @MaChucNang";

            if (checkBox_HeThong.Checked)
            {
                parameters = new Dictionary<string, object>();
                parameters.Add("@TenDangNhap", textBox_TenDangNhap.Text);
                parameters.Add("@MaChucNang", 1);
                Database.Execute(strCommand, parameters);
            }

            if (checkBox_QuanLyPhongBan.Checked)
            {
                parameters = new Dictionary<string, object>();
                parameters.Add("@TenDangNhap", textBox_TenDangNhap.Text);
                parameters.Add("@MaChucNang", 7);
                Database.Execute(strCommand, parameters);
            }

            if (checkBox_QuanLyNhanSu.Checked)
            {
                parameters = new Dictionary<string, object>();
                parameters.Add("@TenDangNhap", textBox_TenDangNhap.Text);
                parameters.Add("@MaChucNang", 8);
                Database.Execute(strCommand, parameters);
            }
        }
    }
}
