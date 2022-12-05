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

namespace BTL_QuanyNhanSu
{
    public partial class FormDangNhap : Form
    {
        private bool authentication = false;

        public bool Authentication
        {
            get { return authentication; }
        }
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void dangNhap() 
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", textBox_TenDangNhap.Text);
            parameters.Add("@matKhau", textBox_MatKhau.Text);
            string strCommand = "EXEC spDangNhap @tenDangNhap,@matKhau";
            try
            {
                Database.Execute(strCommand, parameters);
                authentication = true;
                Program.TenDangNhap = textBox_TenDangNhap.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        private void button_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }

        private void textBox_TenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }

        private void textBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Thoat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }
    }
}
