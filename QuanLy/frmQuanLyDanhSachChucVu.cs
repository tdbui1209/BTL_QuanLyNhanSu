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
    public partial class frmQuanLyDanhSachChucVu : Form
    {
        public frmQuanLyDanhSachChucVu()
        {
            InitializeComponent();
            loadDgvChucVu();
        }

        private bool checkForm()
        {
            //Gỡ bỏ các thông báo lỗi cũ
            eprMessage.Clear();
            bool result = true;
            if (tboMaChucVu.Text.Trim().Length != 3)
            {
                result = false;
                eprMessage.SetError(tboMaChucVu, "Mã chức vụ phải có độ dài là 3");
            }
            if (tboTenChucVu.Text.Trim() == "")
            {
                result = false;
                eprMessage.SetError(tboTenChucVu, "Tên chức vụ không được để trống");
            }
            if (tboTenChucVu.Text.Trim().Length > 30)
            {
                result = false;
                eprMessage.SetError(tboTenChucVu, "Độ dài tên chức vụ phải nhỏ hơn 30");
            }
            return result;
        }

        private void loadDgvChucVu()
        {
            if (chbTimKiem.Checked == false)
            {
                string strQuery = "SELECT * FROM ChucVu";
                DataTable table = Database.Query(strQuery, new Dictionary<string, object>());
                dgvChucVu.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
            else
            {
                string strQuery = "SELECT * FROM ufTimKiemChucVu(@maChucVu,@tenChucVu)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaChucVu.Checked)
                    parameters.Add("@maChucVu", tboMaChucVu.Text);
                else
                    parameters.Add("@maChucVu", "");
                if (chbTenChucVu.Checked)
                    parameters.Add("@tenChucVu", tboTenChucVu.Text);
                else
                    parameters.Add("@tenChucVu", "");
                DataTable table = Database.Query(strQuery, parameters);
                dgvChucVu.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            eprMessage.Clear();
            //Kiểm tra lỗi nhập form (để trống, sai định dạng)
            if (checkForm() == false)
                return;
            //Thực hiện thêm dữ liệu
            string strCommand = "EXEC spThemChucVu @maChucVu,@tenChucVu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters = new Dictionary<string, object>();
            parameters.Add("@maChucVu", tboMaChucVu.Text);
            parameters.Add("@tenChucVu", tboTenChucVu.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                loadDgvChucVu();
                lblStatus.Text = "Thông báo: Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng mã chức vụ")
                    eprMessage.SetError(tboMaChucVu, ex.Message);
                else if (ex.Message == "Trùng tên chức vụ")
                    eprMessage.SetError(tboTenChucVu, ex.Message);
                lblStatus.Text = "Thông báo: " + ex.Message;
            }
        }

        private void dgvPhongBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tboMaChucVu.Text = dgvChucVu.Rows[e.RowIndex].Cells["colMaChucVu"].Value.ToString();
                tboTenChucVu.Text = dgvChucVu.Rows[e.RowIndex].Cells["colTenChucVu"].Value.ToString();
            }
            else
            {
                tboMaChucVu.Text = "";
                tboTenChucVu.Text = "";
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra lỗi nhập form (để trống, sai định dạng)
            bool result = true;
            if (checkForm() == false)
                result = false;
            //Kiểm tra lỗi trùng tên phòng ban
            string strQuery = "SELECT * FROM ChucVu WHERE MaChucVu<>@maChucVu AND TenChucVu=@tenChucVu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucVu", dgvChucVu.CurrentRow.Cells["colMaChucVu"].Value.ToString());
            parameters.Add("@tenChucVu", tboTenChucVu.Text);
            DataTable table = Database.Query(strQuery, parameters);
            if (table.Rows.Count > 0)
            {
                eprMessage.SetError(tboTenChucVu, "Trùng tên chức vụ");
                result = false;
            }
            if (result == false)
                return;
            //Thực hiện sửa dữ liệu
            string strCommand = "UPDATE ChucVu SET TenChucVu=@tenChucVu WHERE MaChucVu=@maChucVu";
            Database.Execute(strCommand, parameters);
            loadDgvChucVu();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "EXEC spXoaChucVu @maChucVu";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maChucVu", dgvChucVu.CurrentRow.Cells["colMaChucVu"].Value.ToString());
                Database.Execute(strCommand, parameters);
                loadDgvChucVu();
                lblStatus.Text = "Thông báo: Xóa dữ liệu thành công";
            }
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadDgvChucVu();
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvChucVu();
        }
        private void frmQuanLyDanhSachChucVu_Load(object sender, EventArgs e)
        {

        }
    }
}
