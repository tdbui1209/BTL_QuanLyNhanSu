namespace BTL_QuanyNhanSu.HeThong
{
    partial class FormTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_QuanLyNhanSu = new System.Windows.Forms.CheckBox();
            this.checkBox_QuanLyPhongBan = new System.Windows.Forms.CheckBox();
            this.checkBox_QuanLy = new System.Windows.Forms.CheckBox();
            this.checkBox_HeThong = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.button_Tao = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_NhapLaiMatKhau);
            this.groupBox1.Controls.Add(this.textBox_MatKhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_TenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_QuanLyNhanSu);
            this.groupBox2.Controls.Add(this.checkBox_QuanLyPhongBan);
            this.groupBox2.Controls.Add(this.checkBox_QuanLy);
            this.groupBox2.Controls.Add(this.checkBox_HeThong);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền tài khoản";
            // 
            // checkBox_QuanLyNhanSu
            // 
            this.checkBox_QuanLyNhanSu.AutoSize = true;
            this.checkBox_QuanLyNhanSu.Location = new System.Drawing.Point(146, 86);
            this.checkBox_QuanLyNhanSu.Name = "checkBox_QuanLyNhanSu";
            this.checkBox_QuanLyNhanSu.Size = new System.Drawing.Size(136, 24);
            this.checkBox_QuanLyNhanSu.TabIndex = 6;
            this.checkBox_QuanLyNhanSu.Text = "Quản lý nhân sự";
            this.checkBox_QuanLyNhanSu.UseVisualStyleBackColor = true;
            // 
            // checkBox_QuanLyPhongBan
            // 
            this.checkBox_QuanLyPhongBan.AutoSize = true;
            this.checkBox_QuanLyPhongBan.Location = new System.Drawing.Point(146, 56);
            this.checkBox_QuanLyPhongBan.Name = "checkBox_QuanLyPhongBan";
            this.checkBox_QuanLyPhongBan.Size = new System.Drawing.Size(157, 24);
            this.checkBox_QuanLyPhongBan.TabIndex = 5;
            this.checkBox_QuanLyPhongBan.Text = "Quản lý phòng ban";
            this.checkBox_QuanLyPhongBan.UseVisualStyleBackColor = true;
            // 
            // checkBox_QuanLy
            // 
            this.checkBox_QuanLy.AutoSize = true;
            this.checkBox_QuanLy.Location = new System.Drawing.Point(130, 26);
            this.checkBox_QuanLy.Name = "checkBox_QuanLy";
            this.checkBox_QuanLy.Size = new System.Drawing.Size(81, 24);
            this.checkBox_QuanLy.TabIndex = 4;
            this.checkBox_QuanLy.Text = "Quản lý";
            this.checkBox_QuanLy.UseVisualStyleBackColor = true;
            this.checkBox_QuanLy.CheckedChanged += new System.EventHandler(this.checkBox_QuanLy_CheckedChanged);
            // 
            // checkBox_HeThong
            // 
            this.checkBox_HeThong.AutoSize = true;
            this.checkBox_HeThong.Location = new System.Drawing.Point(6, 26);
            this.checkBox_HeThong.Name = "checkBox_HeThong";
            this.checkBox_HeThong.Size = new System.Drawing.Size(93, 24);
            this.checkBox_HeThong.TabIndex = 3;
            this.checkBox_HeThong.Text = "Hệ thống";
            this.checkBox_HeThong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // textBox_NhapLaiMatKhau
            // 
            this.textBox_NhapLaiMatKhau.Location = new System.Drawing.Point(161, 97);
            this.textBox_NhapLaiMatKhau.Name = "textBox_NhapLaiMatKhau";
            this.textBox_NhapLaiMatKhau.Size = new System.Drawing.Size(159, 27);
            this.textBox_NhapLaiMatKhau.TabIndex = 3;
            this.textBox_NhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(161, 64);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(159, 27);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(161, 31);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(159, 27);
            this.textBox_TenDangNhap.TabIndex = 0;
            // 
            // button_Tao
            // 
            this.button_Tao.Location = new System.Drawing.Point(136, 301);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(105, 43);
            this.button_Tao.TabIndex = 7;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.UseVisualStyleBackColor = true;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(366, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttStrip
            // 
            this.sttStrip.Name = "sttStrip";
            this.sttStrip.Size = new System.Drawing.Size(84, 20);
            this.sttStrip.Text = "Thông báo:";
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "Tạo tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox_NhapLaiMatKhau;
        private TextBox textBox_MatKhau;
        private Label label1;
        private TextBox textBox_TenDangNhap;
        private Button button_Tao;
        private GroupBox groupBox2;
        private CheckBox checkBox_QuanLy;
        private CheckBox checkBox_HeThong;
        private CheckBox checkBox_QuanLyNhanSu;
        private CheckBox checkBox_QuanLyPhongBan;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sttStrip;
    }
}