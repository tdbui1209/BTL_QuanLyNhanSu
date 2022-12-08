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
            this.mni_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_ThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // mni_HeThong
            // 
            this.mni_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_TaoTaiKhoan,
            this.mni_QuanLyTaiKhoan});
            this.mni_HeThong.Name = "mni_HeThong";
            this.mni_HeThong.Size = new System.Drawing.Size(69, 20);
            this.mni_HeThong.Text = "Hệ thống";
            // 
            // mni_TaoTaiKhoan
            // 
            this.mni_TaoTaiKhoan.Name = "mni_TaoTaiKhoan";
            this.mni_TaoTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mni_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.mni_TaoTaiKhoan.Click += new System.EventHandler(this.mni_TaoTaiKhoan_Click);
            // 
            // mni_QuanLyTaiKhoan
            // 
            this.mni_QuanLyTaiKhoan.Name = "mni_QuanLyTaiKhoan";
            this.mni_QuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mni_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mni_QuanLy
            // 
            this.mni_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýNhânSựToolStripMenuItem});
            this.mni_QuanLy.Name = "mni_QuanLy";
            this.mni_QuanLy.Size = new System.Drawing.Size(60, 20);
            this.mni_QuanLy.Text = "Quản lý";
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản lý phòng ban";
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản lý nhân sự";
            // 
            // mni_NguoiDung
            // 
            this.mni_NguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_ThongTinCaNhan,
            this.mni_DoiMatKhau});
            this.mni_NguoiDung.Name = "mni_NguoiDung";
            this.mni_NguoiDung.Size = new System.Drawing.Size(83, 20);
            this.mni_NguoiDung.Text = "Người dùng";
            // 
            // mni_ThongTinCaNhan
            // 
            this.mni_ThongTinCaNhan.Name = "mni_ThongTinCaNhan";
            this.mni_ThongTinCaNhan.Size = new System.Drawing.Size(180, 22);
            this.mni_ThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // mni_DoiMatKhau
            // 
            this.mni_DoiMatKhau.Name = "mni_DoiMatKhau";
            this.mni_DoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.mni_DoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Quản lý nhân sự";
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
        private ToolStripMenuItem mni_ThongTinCaNhan;
        private ToolStripMenuItem mni_DoiMatKhau;
        private ToolStripMenuItem mni_TaoTaiKhoan;
        private ToolStripMenuItem mni_QuanLyTaiKhoan;
        private ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
    }
}