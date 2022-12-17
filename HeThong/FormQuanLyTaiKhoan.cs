using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.HeThong
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        private static string tenDangNhap;
        public static string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
            public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void loadData()
        {
            string strQuery = "SELECT TenDangNhap, IIF(TrangThai='true', N'Hoạt động', N'Bị khóa') AS TrangThai FROM NguoiDung";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            dgv_TaiKhoan.DataSource = Database.Query(strQuery, parameters);
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (textBox_TenDangNhap.Text.Length == 0)
            {
                loadData();
            }
            else
            {
                string strQuery = "SELECT TenDangNhap, TrangThai FROM dbo.ufLayTaiKhoan(@tenDangNhap, @active)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", textBox_TenDangNhap.Text.Trim());
                if (checkBox_Active.Checked)
                {
                    parameters.Add("@active", true);
                }
                else
                {
                    parameters.Add("@active", false);
                }
                dgv_TaiKhoan.DataSource = Database.Query(strQuery, parameters);
            }
        }

        private void dgv_TaiKhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            treeView_PhanQuyen.Nodes.Clear();
            string tenTaiKhoan = dgv_TaiKhoan.Rows[e.RowIndex].Cells["TenTaiKhoan"].Value.ToString();
            bool active;
            if (dgv_TaiKhoan.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString() == "Hoạt động")
                active = true;
            else
                active = false;
            textBox_TenDangNhap.Text = tenTaiKhoan;
            checkBox_Active.Checked = active;
            if (active)
            {
                button_MoTaiKhoan.Enabled = false;
                button_KhoaTaiKhoan.Enabled = true;
            }
            else
            {
                button_KhoaTaiKhoan.Enabled = false;
                button_MoTaiKhoan.Enabled = true;
            }
            string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tenTaiKhoan);
            DataTable quyenTaiKhoan = Database.Query(strQuery, parameters);
            treeView_PhanQuyen.Nodes.Add("Quyền tài khoản");
            for (int i = 0; i < quyenTaiKhoan.Rows.Count; i++)
            {
                treeView_PhanQuyen.Nodes[0].Nodes.Add(quyenTaiKhoan.Rows[i]["TenChucNang"].ToString());
            }
            TenDangNhap = tenTaiKhoan;
        }

        private void button_KhoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string strQuery = "EXEC spKhoaTaiKhoan @tenDangNhap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", textBox_TenDangNhap.Text);
            Database.Execute(strQuery, parameters);
            loadData();
        }

        private void button_MoTaiKhoan_Click(object sender, EventArgs e)
        {
            string strQuery = "EXEC spMoTaiKhoan @tenDangNhap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", textBox_TenDangNhap.Text);
            Database.Query(strQuery, parameters);
            loadData();
        }

        private void button_ThayDoiQuyen_Click(object sender, EventArgs e)
        {
            FormSuaQuyenTaiKhoan form = new FormSuaQuyenTaiKhoan();
            form.ShowDialog();
        }
    }
}
