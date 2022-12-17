namespace BTL_QuanyNhanSu.HeThong
{
    partial class FormQuanLyTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Active = new System.Windows.Forms.CheckBox();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_ThayDoiQuyen = new System.Windows.Forms.Button();
            this.button_KhoaTaiKhoan = new System.Windows.Forms.Button();
            this.button_MoTaiKhoan = new System.Windows.Forms.Button();
            this.treeView_PhanQuyen = new System.Windows.Forms.TreeView();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Active);
            this.groupBox1.Controls.Add(this.textBox_TenDangNhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // checkBox_Active
            // 
            this.checkBox_Active.AutoSize = true;
            this.checkBox_Active.Location = new System.Drawing.Point(324, 31);
            this.checkBox_Active.Name = "checkBox_Active";
            this.checkBox_Active.Size = new System.Drawing.Size(140, 24);
            this.checkBox_Active.TabIndex = 2;
            this.checkBox_Active.Text = "Đang hoạt động";
            this.checkBox_Active.UseVisualStyleBackColor = true;
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(130, 29);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(125, 27);
            this.textBox_TenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.AllowUserToAddRows = false;
            this.dgv_TaiKhoan.AllowUserToDeleteRows = false;
            this.dgv_TaiKhoan.AllowUserToResizeColumns = false;
            this.dgv_TaiKhoan.AllowUserToResizeRows = false;
            this.dgv_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.TrangThai});
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(12, 151);
            this.dgv_TaiKhoan.MultiSelect = false;
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowHeadersWidth = 51;
            this.dgv_TaiKhoan.RowTemplate.Height = 29;
            this.dgv_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(470, 347);
            this.dgv_TaiKhoan.TabIndex = 1;
            this.dgv_TaiKhoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_RowEnter);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(12, 95);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(113, 50);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_ThayDoiQuyen
            // 
            this.button_ThayDoiQuyen.Location = new System.Drawing.Point(131, 95);
            this.button_ThayDoiQuyen.Name = "button_ThayDoiQuyen";
            this.button_ThayDoiQuyen.Size = new System.Drawing.Size(113, 50);
            this.button_ThayDoiQuyen.TabIndex = 3;
            this.button_ThayDoiQuyen.Text = "Thay đổi quyền";
            this.button_ThayDoiQuyen.UseVisualStyleBackColor = true;
            this.button_ThayDoiQuyen.Click += new System.EventHandler(this.button_ThayDoiQuyen_Click);
            // 
            // button_KhoaTaiKhoan
            // 
            this.button_KhoaTaiKhoan.Location = new System.Drawing.Point(250, 95);
            this.button_KhoaTaiKhoan.Name = "button_KhoaTaiKhoan";
            this.button_KhoaTaiKhoan.Size = new System.Drawing.Size(113, 50);
            this.button_KhoaTaiKhoan.TabIndex = 4;
            this.button_KhoaTaiKhoan.Text = "Khóa tài khoản";
            this.button_KhoaTaiKhoan.UseVisualStyleBackColor = true;
            this.button_KhoaTaiKhoan.Click += new System.EventHandler(this.button_KhoaTaiKhoan_Click);
            // 
            // button_MoTaiKhoan
            // 
            this.button_MoTaiKhoan.Location = new System.Drawing.Point(369, 95);
            this.button_MoTaiKhoan.Name = "button_MoTaiKhoan";
            this.button_MoTaiKhoan.Size = new System.Drawing.Size(113, 50);
            this.button_MoTaiKhoan.TabIndex = 5;
            this.button_MoTaiKhoan.Text = "Mở tài khoản";
            this.button_MoTaiKhoan.UseVisualStyleBackColor = true;
            this.button_MoTaiKhoan.Click += new System.EventHandler(this.button_MoTaiKhoan_Click);
            // 
            // treeView_PhanQuyen
            // 
            this.treeView_PhanQuyen.Location = new System.Drawing.Point(488, 151);
            this.treeView_PhanQuyen.Name = "treeView_PhanQuyen";
            this.treeView_PhanQuyen.Size = new System.Drawing.Size(300, 347);
            this.treeView_PhanQuyen.TabIndex = 6;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenDangNhap";
            this.TenTaiKhoan.HeaderText = "Tên đăng nhập";
            this.TenTaiKhoan.MinimumWidth = 6;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 104;
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.treeView_PhanQuyen);
            this.Controls.Add(this.dgv_TaiKhoan);
            this.Controls.Add(this.button_MoTaiKhoan);
            this.Controls.Add(this.button_KhoaTaiKhoan);
            this.Controls.Add(this.button_ThayDoiQuyen);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox_Active;
        private TextBox textBox_TenDangNhap;
        private Label label1;
        private DataGridView dgv_TaiKhoan;
        private Button button_TimKiem;
        private Button button_ThayDoiQuyen;
        private Button button_KhoaTaiKhoan;
        private Button button_MoTaiKhoan;
        private TreeView treeView_PhanQuyen;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn TrangThai;
    }
}