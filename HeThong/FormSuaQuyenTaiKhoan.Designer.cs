namespace BTL_QuanyNhanSu.HeThong
{
    partial class FormSuaQuyenTaiKhoan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_QuanLyChucVu = new System.Windows.Forms.CheckBox();
            this.checkBox_QuanLyNhanSu = new System.Windows.Forms.CheckBox();
            this.checkBox_QuanLyPhongBan = new System.Windows.Forms.CheckBox();
            this.checkBox_QuanLy = new System.Windows.Forms.CheckBox();
            this.checkBox_HeThong = new System.Windows.Forms.CheckBox();
            this.button_Sua = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_QuanLyChucVu);
            this.groupBox2.Controls.Add(this.checkBox_QuanLyNhanSu);
            this.groupBox2.Controls.Add(this.checkBox_QuanLyPhongBan);
            this.groupBox2.Controls.Add(this.checkBox_QuanLy);
            this.groupBox2.Controls.Add(this.checkBox_HeThong);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền tài khoản";
            // 
            // checkBox_QuanLyChucVu
            // 
            this.checkBox_QuanLyChucVu.AutoSize = true;
            this.checkBox_QuanLyChucVu.Location = new System.Drawing.Point(146, 114);
            this.checkBox_QuanLyChucVu.Name = "checkBox_QuanLyChucVu";
            this.checkBox_QuanLyChucVu.Size = new System.Drawing.Size(135, 24);
            this.checkBox_QuanLyChucVu.TabIndex = 7;
            this.checkBox_QuanLyChucVu.Text = "Quản lý chức vụ";
            this.checkBox_QuanLyChucVu.UseVisualStyleBackColor = true;
            this.checkBox_QuanLyChucVu.CheckedChanged += new System.EventHandler(this.checkBox_QuanLyChucVu_CheckedChanged);
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
            this.checkBox_QuanLyNhanSu.CheckedChanged += new System.EventHandler(this.checkBox_QuanLyNhanSu_CheckedChanged);
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
            this.checkBox_QuanLyPhongBan.CheckedChanged += new System.EventHandler(this.checkBox_QuanLyPhongBan_CheckedChanged);
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
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(125, 162);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(111, 53);
            this.button_Sua.TabIndex = 6;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // FormSuaQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 223);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormSuaQuyenTaiKhoan";
            this.Text = "Sửa quyền tài khoản";
            this.Load += new System.EventHandler(this.FormSuaQuyenTaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox checkBox_QuanLyNhanSu;
        private CheckBox checkBox_QuanLyPhongBan;
        private CheckBox checkBox_QuanLy;
        private CheckBox checkBox_HeThong;
        private Button button_Sua;
        private CheckBox checkBox_QuanLyChucVu;
    }
}