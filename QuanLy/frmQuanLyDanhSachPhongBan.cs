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
    public partial class frmQuanLyDanhSachPhongBan : Form
    {
        private string maPhongBan = "";
        public string MaPhongBan
        {
            get { return maPhongBan; }
        }
        private bool isEdited = false;
        public bool IsEdited
        {
            get { return isEdited; }
        }
        public frmQuanLyDanhSachPhongBan()
        {
            InitializeComponent();
            loadDgvPhongBan();
        }
        private bool checkForm()
        {
            //Gỡ bỏ các thông báo lỗi cũ
            eprMessage.Clear();
            bool result = true;
            if (tboMaPhongBan.Text.Trim().Length != 3)
            {
                result = false;
                eprMessage.SetError(tboMaPhongBan, "Mã phòng ban phải có độ dài là 3");
            }
            if (tboTenPhongBan.Text.Trim() == "")
            {
                result = false;
                eprMessage.SetError(tboTenPhongBan, "Tên phòng ban không được để trống");
            }
            if (tboTenPhongBan.Text.Trim().Length > 30)
            {
                result = false;
                eprMessage.SetError(tboTenPhongBan, "Độ dài tên phòng ban phải nhỏ hơn 30");
            }
            return result;
        }

        private void loadDgvPhongBan()
        {
            if (chbTimKiem.Checked == false)
            {
                string strQuery = "SELECT * FROM PhongBan";
                DataTable table = Database.Query(strQuery, new Dictionary<string, object>());
                dgvPhongBan.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
            else
            {
                string strQuery = "SELECT * FROM ufTimKiemPhongBan(@maPhongBan,@tenPhongBan)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaPhongBan.Checked)
                    parameters.Add("@maPhongBan", tboMaPhongBan.Text);
                else
                    parameters.Add("@maPhongBan", "");
                if (chbTenPhongBan.Checked)
                    parameters.Add("@tenPhongBan", tboTenPhongBan.Text);
                else
                    parameters.Add("@tenPhongBan", "");
                DataTable table = Database.Query(strQuery, parameters);
                dgvPhongBan.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("alo");
            eprMessage.Clear();
            //Kiểm tra lỗi nhập form (để trống, sai định dạng)
            if (checkForm() == false)
                return;
            //Thực hiện thêm dữ liệu
            string strCommand = "EXEC spThemPhongBan @maPhongBan,@tenPhongBan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters = new Dictionary<string, object>();
            parameters.Add("@maPhongBan", tboMaPhongBan.Text);
            parameters.Add("@tenPhongBan", tboTenPhongBan.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                loadDgvPhongBan();
                lblStatus.Text = "Thông báo: Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng mã phòng ban")
                    eprMessage.SetError(tboMaPhongBan, ex.Message);
                else if (ex.Message == "Trùng tên phòng ban")
                    eprMessage.SetError(tboTenPhongBan, ex.Message);
                lblStatus.Text = "Thông báo: " + ex.Message;
            }
        }

        private void dgvPhongBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tboMaPhongBan.Text = dgvPhongBan.Rows[e.RowIndex].Cells["colMaPhongBan"].Value.ToString();
                tboTenPhongBan.Text = dgvPhongBan.Rows[e.RowIndex].Cells["colTenPhongBan"].Value.ToString();
            }
            else
            {
                tboMaPhongBan.Text = "";
                tboTenPhongBan.Text = "";
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra lỗi nhập form (để trống, sai định dạng)
            bool result = true;
            if (checkForm() == false)
                result = false;
            //Kiểm tra lỗi trùng tên phòng ban
            string strQuery = "SELECT * FROM PhongBan WHERE MaPhongBan<>@maPhongBan AND TenPhongBan=@tenPhongBan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhongBan", dgvPhongBan.CurrentRow.Cells["colMaPhongBan"].Value.ToString());
            parameters.Add("@tenPhongBan", tboTenPhongBan.Text);
            DataTable table = Database.Query(strQuery, parameters);
            if (table.Rows.Count > 0)
            {
                eprMessage.SetError(tboTenPhongBan, "Trùng tên phòng ban");
                result = false;
            }
            if (result == false)
                return;
            //Thực hiện sửa dữ liệu
            string strCommand = "UPDATE PhongBan SET TenPhongBan=@tenPhongBan WHERE MaPhongBan=@maPhongBan";
            Database.Execute(strCommand, parameters);
            loadDgvPhongBan();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "EXEC spXoaPhongBan @maPhongBan";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maPhongBan", dgvPhongBan.CurrentRow.Cells["colMaPhongBan"].Value.ToString());
                MessageBox.Show(dgvPhongBan.CurrentRow.Cells["colMaPhongBan"].Value.ToString());
                Database.Execute(strCommand, parameters);
                loadDgvPhongBan();
                lblStatus.Text = "Thông báo: Xóa dữ liệu thành công";
            }
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadDgvPhongBan();
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvPhongBan();
        }

        private void frmQuanLyDanhSachPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void btoChon_Click(object sender, EventArgs e)
        {
            maPhongBan = dgvPhongBan.CurrentRow.Cells["colMaPhongBan"].Value.ToString();
            this.Close();
        }

        private void grbThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
