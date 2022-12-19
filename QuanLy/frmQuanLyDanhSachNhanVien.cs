using BTL_QuanyNhanSu;
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
    public partial class frmQuanLyDanhSachNhanVien : Form
    {
        private void loadCbbQueQuan()
        {
            cbbQueQuan.DataSource = Database.Query("SELECT * FROM TinhThanh", new Dictionary<string, object>());
        }
        private void loadCbbDanToc()
        {
            cbbDanToc.DataSource = Database.Query("SELECT * FROM DanToc", new Dictionary<string, object>());
        }
        private void loadCbbTonGiao()
        {
            cbbTonGiao.DataSource = Database.Query("SELECT * FROM TonGiao", new Dictionary<string, object>());
        }
        private void loadCbbTinhThanh()
        {
            cbbTinhThanh.DataSource = Database.Query("SELECT * FROM TinhThanh", new Dictionary<string, object>());
        }
        private void loadCbbPhongBan()
        {
            cbbPhongBan.DataSource = Database.Query("SELECT * FROM PhongBan", new Dictionary<string, object>());
        }
        private void loadCbbChucVu()
        {
            cbbChucVu.DataSource = Database.Query("SELECT * FROM ChucVu", new Dictionary<string, object>());
        }

        private void loadDgvNhanVien()
        {
            string strQuery = "SELECT * FROM dbo.ufTimKiemNhanVien(@maNhanVien,@ho,@ten,@gioiTinh,@ngaySinhTu,@ngaySinhDen,@dienThoai,@tenQueQuan,@tenDanToc,@tenTonGiao,@diaChi,@tenTinhThanh,@tenChucVu,@tenPhongBan,@email)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaNhanVien.Checked )
                parameters.Add("@maNhanVien", int.Parse(tboMaNhanVien.Text));
            else
                parameters.Add("@maNhanVien", 0);
            if (chbHo.Checked)
                parameters.Add("@ho", tboHo.Text);
            else
                parameters.Add("@ho", "");
            if (chbTen.Checked)
                parameters.Add("@ten", tboTen.Text);
            else
                parameters.Add("@ten", "");
            if (chbNam.Checked && chbNu.Checked)
                parameters.Add("@gioiTinh", "");
            else if (chbNam.Checked)
                parameters.Add("@gioiTinh", "Nam");
            else
                parameters.Add("@gioiTinh", "Nữ");
            if (chbNgaySinhTu.Checked)
                parameters.Add("@ngaySinhTu", dtpNgaySinhTu.Value);
            else
                parameters.Add("@ngaySinhTu", DateTime.Parse("1900-1-1"));
            if (chbNgaySinhDen.Checked)
                parameters.Add("@ngaySinhDen", dtpNgaySinhDen.Value);
            else
                parameters.Add("@ngaySinhDen", DateTime.Parse("1900-1-1"));
            if (chbDienThoai.Checked)
                parameters.Add("@dienThoai", tboDienThoai.Text);
            else
                parameters.Add("@dienThoai", "");
            if (chbQueQuan.Checked)
                parameters.Add("@tenQueQuan", cbbQueQuan.Text);
            else
                parameters.Add("@tenQueQuan", "");
            if (chbDanToc.Checked)
                parameters.Add("@tenDanToc", cbbDanToc.Text);
            else
                parameters.Add("@tenDanToc", "");
            if (chbTonGiao.Checked)
                parameters.Add("@tenTonGiao", cbbTonGiao.Text);
            else
                parameters.Add("@tenTonGiao", "");
            if (chbDiaChi.Checked)
                parameters.Add("@diaChi", tboDiaChi.Text);
            else
                parameters.Add("@diaChi", "");
            if (chbTinhThanh.Checked)
                parameters.Add("@tenTinhThanh", cbbTinhThanh.Text);
            else
                parameters.Add("@tenTinhThanh", "");
            if (chbChucVu.Checked)
                parameters.Add("@tenChucVu", cbbChucVu.Text);
            else
                parameters.Add("@tenChucVu", "");
            if (chbPhongBan.Checked)
                parameters.Add("@tenPhongBan", cbbPhongBan.Text);
            else
                parameters.Add("@tenPhongBan", "");
            if (chbEmail.Checked)
                parameters.Add("@email", tboEmail.Text);
            else
                parameters.Add("@email", "");
            dgvNhanVien.DataSource = Database.Query(strQuery, parameters);
        }
        public frmQuanLyDanhSachNhanVien()
        {
            InitializeComponent();
            loadCbbQueQuan();
            loadCbbDanToc();
            loadCbbTonGiao();
            loadCbbTinhThanh();
            loadCbbPhongBan();
            loadCbbChucVu();
            loadDgvNhanVien();
        }

        private void chbMaNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaNhanVien.Enabled = chbMaNhanVien.Checked;
        }

        private void chbNgaySinhTu_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhTu.Enabled = chbNgaySinhTu.Checked;
        }

        private void chbHo_CheckedChanged(object sender, EventArgs e)
        {
            tboHo.Enabled = chbHo.Checked;
        }

        private void chbTen_CheckedChanged(object sender, EventArgs e)
        {
            tboTen.Enabled = chbTen.Checked;
        }

        private void dtpNgaySinhDen_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinhDen.Enabled = chbNgaySinhDen.Checked;
        }

        private void chbDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            tboDienThoai.Enabled = chbDienThoai.Checked;
        }

        private void chbQueQuan_CheckedChanged(object sender, EventArgs e)
        {
            cbbQueQuan.Enabled = chbQueQuan.Checked;
        }

        private void chbDanToc_CheckedChanged(object sender, EventArgs e)
        {
            cbbDanToc.Enabled = chbDanToc.Checked;
        }

        private void chbTonGiao_CheckedChanged(object sender, EventArgs e)
        {
            cbbTonGiao.Enabled = chbTonGiao.Checked;
        }

        private void cbbDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaChi.Enabled = chbDiaChi.Checked;
        }

        private void chbTinhThanh_CheckedChanged(object sender, EventArgs e)
        {
            cbbTinhThanh.Enabled = chbTinhThanh.Checked;
        }

        private void chbChucVu_CheckedChanged(object sender, EventArgs e)
        {
            cbbChucVu.Enabled = chbChucVu.Checked;
        }

        private void chbPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            cbbPhongBan.Enabled = chbPhongBan.Checked;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tboEmail.Enabled = chbEmail.Checked;
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien form = new frmThemNhanVien();
            form.ShowDialog();
        }

        private void chbHienThiNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colNgaySinh"].Visible = chbHienThiNgaySinh.Checked;
        }

        private void chbHienThiQueQuan_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colQueQuan"].Visible = chbHienThiQueQuan.Checked;
        }

        private void chbHienThiDanToc_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colDanToc"].Visible = chbHienThiDanToc.Checked;
        }

        private void chbHienThiTonGiao_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colTonGiao"].Visible = chbHienThiTonGiao.Checked;
        }

        private void chbHienThiGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colGioiTinh"].Visible = chbHienThiGioiTinh.Checked;
        }

        private void chbHienThiDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colDiaChi"].Visible = chbHienThiDiaChi.Checked;
        }

        private void chbHienThiTinhThanh_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colTinhThanh"].Visible = chbHienThiTinhThanh.Checked;
        }

        private void chbHienThiDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colDienThoai"].Visible = chbHienThiDienThoai.Checked;
        }

        private void chbHienThiEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colEmail"].Visible = chbHienThiEmail.Checked;
        }

        private void chbHienThiChucVu_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colChucVu"].Visible = chbHienThiChucVu.Checked;
        }

        private void chbHienThiPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Columns["colPhongBan"].Visible = chbHienThiPhongBan.Checked;
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            trvTrinhDo.Nodes.Clear();
            //Lấy ra mã nhân viên ở dòng được chọn
            int maNhanVien = (int)dgvNhanVien.Rows[e.RowIndex].Cells["colMaNhanVien"].Value;
            //Dựa vào mã nhân viên lấy được sẽ lấy ra tất cả các ngoại ngữ ứng với nhân viên đó
            string strQuery = "SELECT TenNgoaiNgu"
                + " FROM NgoaiNguNhanVien INNER JOIN NgoaiNgu ON NgoaiNguNhanVien.MaNgoaiNgu=NgoaiNgu.MaNgoaiNgu"
                + " WHERE MaNhanVien=@maNhanVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNhanVien", maNhanVien);
            DataTable ngoaiNgus = Database.Query(strQuery, parameters);
            //Đem các ngoại ngữ đó đẩy vào tree view
            trvTrinhDo.Nodes.Add("Trình độ ngoại ngữ");
            for (int i = 0; i < ngoaiNgus.Rows.Count; i++)
                trvTrinhDo.Nodes[0].Nodes.Add(ngoaiNgus.Rows[i]["TenNgoaiNgu"].ToString());
            trvTrinhDo.Nodes[0].Expand();
            //Dựa vào mã nhân viên lấy được sẽ lấy ra tất cả các chuyên môn ứng với nhân viên đó
            //strQuery = "SELECT TenChuyenMon"
            //    + " FROM ChuyenMonNhanVien INNER JOIN ChuyenMon ON ChuyenMonNhanVien.MaChuyenMon=ChuyenMon.MaChuyenMon"
            //    + " WHERE MaNhanVien=@maNhanVien";
            //DataTable chuyenMons = BTL_QuanyNhanSu.Database.Query(strQuery, parameters);
            //trvTrinhDo.Nodes.Add("Trình độ chuyên môn");
            //for (int i = 0; i < chuyenMons.Rows.Count; i++)
            //    trvTrinhDo.Nodes[1].Nodes.Add(chuyenMons.Rows[i]["TenChuyenMon"].ToString());
            //trvTrinhDo.Nodes[1].Expand();
        }

        private void chbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNam.Checked == false && chbNu.Checked == false)
                chbNu.Checked = true;
        }

        private void chbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNam.Checked == false && chbNu.Checked == false)
                chbNam.Checked = true;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvNhanVien();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLyDanhSachNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Lấy ra mã nhân viên của dòng đang chọn
            int maNhanVien = (int)dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value;
            //Truyền mã nhân viên lấy được vào Form sửa nhân viên
            frmSuaNhanVien form = new frmSuaNhanVien(maNhanVien);
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "EXEC spXoaNhanVien @maNhanVien";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString());
                MessageBox.Show(dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString());
                Database.Execute(strCommand, parameters);
                loadDgvNhanVien();
            }
        }
    }
}
