namespace BTL_QuanyNhanSu
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mni_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_TaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_QuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NhatKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_QuanLyNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_QuanLyPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_QuanLyChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_HeThong,
            this.mni_QuanLy,
            this.mni_NguoiDung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mni_HeThong
            // 
            this.mni_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_TaoTaiKhoan,
            this.mni_QuanLyTaiKhoan,
            this.mni_NhatKy});
            this.mni_HeThong.Name = "mni_HeThong";
            this.mni_HeThong.Size = new System.Drawing.Size(69, 20);
            this.mni_HeThong.Text = "Hệ thống";
            // 
            // mni_TaoTaiKhoan
            // 
            this.mni_TaoTaiKhoan.Name = "mni_TaoTaiKhoan";
            this.mni_TaoTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.mni_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.mni_TaoTaiKhoan.Click += new System.EventHandler(this.mni_TaoTaiKhoan_Click);
            // 
            // mni_QuanLyTaiKhoan
            // 
            this.mni_QuanLyTaiKhoan.Name = "mni_QuanLyTaiKhoan";
            this.mni_QuanLyTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.mni_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.mni_QuanLyTaiKhoan.Click += new System.EventHandler(this.mni_QuanLyTaiKhoan_Click);
            // 
            // mni_NhatKy
            // 
            this.mni_NhatKy.Name = "mni_NhatKy";
            this.mni_NhatKy.Size = new System.Drawing.Size(167, 22);
            this.mni_NhatKy.Text = "Nhật ký";
            this.mni_NhatKy.Click += new System.EventHandler(this.mni_NhatKy_Click);
            // 
            // mni_QuanLy
            // 
            this.mni_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_QuanLyNhanSu,
            this.mni_QuanLyPhongBan,
            this.mni_QuanLyChucVu});
            this.mni_QuanLy.Name = "mni_QuanLy";
            this.mni_QuanLy.Size = new System.Drawing.Size(60, 20);
            this.mni_QuanLy.Text = "Quản lý";
            this.mni_QuanLy.Click += new System.EventHandler(this.mni_QuanLy_Click);
            // 
            // mni_QuanLyNhanSu
            // 
            this.mni_QuanLyNhanSu.Name = "mni_QuanLyNhanSu";
            this.mni_QuanLyNhanSu.Size = new System.Drawing.Size(176, 22);
            this.mni_QuanLyNhanSu.Text = "Quản lý nhân sự";
            this.mni_QuanLyNhanSu.Click += new System.EventHandler(this.mni_QuanLyNhanSu_Click);
            // 
            // mni_QuanLyPhongBan
            // 
            this.mni_QuanLyPhongBan.Name = "mni_QuanLyPhongBan";
            this.mni_QuanLyPhongBan.Size = new System.Drawing.Size(176, 22);
            this.mni_QuanLyPhongBan.Text = "Quản lý phòng ban";
            this.mni_QuanLyPhongBan.Click += new System.EventHandler(this.mni_QuanLyPhongBan_Click);
            // 
            // mni_QuanLyChucVu
            // 
            this.mni_QuanLyChucVu.Name = "mni_QuanLyChucVu";
            this.mni_QuanLyChucVu.Size = new System.Drawing.Size(176, 22);
            this.mni_QuanLyChucVu.Text = "Quản lý chức vụ";
            this.mni_QuanLyChucVu.Click += new System.EventHandler(this.mni_QuanLyChucVu_Click);
            // 
            // mni_NguoiDung
            // 
            this.mni_NguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_DoiMatKhau,
            this.mni_DangXuat});
            this.mni_NguoiDung.Name = "mni_NguoiDung";
            this.mni_NguoiDung.Size = new System.Drawing.Size(83, 20);
            this.mni_NguoiDung.Text = "Người dùng";
            // 
            // mni_DoiMatKhau
            // 
            this.mni_DoiMatKhau.Name = "mni_DoiMatKhau";
            this.mni_DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.mni_DoiMatKhau.Text = "Đổi mật khẩu";
            this.mni_DoiMatKhau.Click += new System.EventHandler(this.mni_DoiMatKhau_Click);
            // 
            // mni_DangXuat
            // 
            this.mni_DangXuat.Name = "mni_DangXuat";
            this.mni_DangXuat.Size = new System.Drawing.Size(145, 22);
            this.mni_DangXuat.Text = "Đăng xuất";
            this.mni_DangXuat.Click += new System.EventHandler(this.mni_DangXuat_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mni_HeThong;
        private ToolStripMenuItem mni_QuanLy;
        private ToolStripMenuItem mni_NguoiDung;
        private ToolStripMenuItem mni_DoiMatKhau;
        private ToolStripMenuItem mni_TaoTaiKhoan;
        private ToolStripMenuItem mni_QuanLyTaiKhoan;
        private ToolStripMenuItem mni_QuanLyNhanSu;
        private ToolStripMenuItem mni_QuanLyPhongBan;
        private ToolStripMenuItem mni_NhatKy;
        private ToolStripMenuItem mni_QuanLyChucVu;
        private ToolStripMenuItem mni_DangXuat;
    }
}