namespace BTL_QuanyNhanSu.QuanLy
{
    partial class frmQuanLyDanhSachChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDanhSachChucVu));
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.tboTenChucVu = new System.Windows.Forms.TextBox();
            this.tboMaChucVu = new System.Windows.Forms.TextBox();
            this.chbTenChucVu = new System.Windows.Forms.CheckBox();
            this.chbMaChucVu = new System.Windows.Forms.CheckBox();
            this.btoThem = new System.Windows.Forms.Button();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.colMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eprMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.stsMessage = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprMessage)).BeginInit();
            this.stsMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH SÁCH CHỨC VỤ";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.Controls.Add(this.tboTenChucVu);
            this.grbThongTin.Controls.Add(this.tboMaChucVu);
            this.grbThongTin.Controls.Add(this.chbTenChucVu);
            this.grbThongTin.Controls.Add(this.chbMaChucVu);
            this.grbThongTin.Location = new System.Drawing.Point(12, 48);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(914, 114);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chức vụ";
            // 
            // tboTenChucVu
            // 
            this.tboTenChucVu.Location = new System.Drawing.Point(124, 67);
            this.tboTenChucVu.Name = "tboTenChucVu";
            this.tboTenChucVu.Size = new System.Drawing.Size(387, 25);
            this.tboTenChucVu.TabIndex = 1;
            // 
            // tboMaChucVu
            // 
            this.tboMaChucVu.Location = new System.Drawing.Point(124, 31);
            this.tboMaChucVu.Name = "tboMaChucVu";
            this.tboMaChucVu.Size = new System.Drawing.Size(153, 25);
            this.tboMaChucVu.TabIndex = 1;
            // 
            // chbTenChucVu
            // 
            this.chbTenChucVu.AutoSize = true;
            this.chbTenChucVu.Location = new System.Drawing.Point(6, 69);
            this.chbTenChucVu.Name = "chbTenChucVu";
            this.chbTenChucVu.Size = new System.Drawing.Size(109, 21);
            this.chbTenChucVu.TabIndex = 0;
            this.chbTenChucVu.Text = "Tên chức vụ";
            this.chbTenChucVu.UseVisualStyleBackColor = true;
            // 
            // chbMaChucVu
            // 
            this.chbMaChucVu.AutoSize = true;
            this.chbMaChucVu.Location = new System.Drawing.Point(6, 33);
            this.chbMaChucVu.Name = "chbMaChucVu";
            this.chbMaChucVu.Size = new System.Drawing.Size(103, 21);
            this.chbMaChucVu.TabIndex = 0;
            this.chbMaChucVu.Text = "Mã chức vụ";
            this.chbMaChucVu.UseVisualStyleBackColor = true;
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.Location = new System.Drawing.Point(105, 168);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(100, 35);
            this.btoThem.TabIndex = 2;
            this.btoThem.Text = "Thêm";
            this.btoThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(12, 177);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(87, 21);
            this.chbTimKiem.TabIndex = 0;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            this.chbTimKiem.Click += new System.EventHandler(this.chbTimKiem_CheckedChanged);
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.Location = new System.Drawing.Point(211, 169);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(100, 35);
            this.btoSua.TabIndex = 2;
            this.btoSua.Text = "Sửa";
            this.btoSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.Location = new System.Drawing.Point(317, 169);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(100, 35);
            this.btoXoa.TabIndex = 2;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.Location = new System.Drawing.Point(423, 169);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btoTimKiem.TabIndex = 2;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.AllowUserToResizeColumns = false;
            this.dgvChucVu.AllowUserToResizeRows = false;
            this.dgvChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucVu,
            this.colTenChucVu});
            this.dgvChucVu.Location = new System.Drawing.Point(12, 219);
            this.dgvChucVu.MultiSelect = false;
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowTemplate.Height = 25;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(914, 296);
            this.dgvChucVu.TabIndex = 3;
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.DataPropertyName = "MaChucVu";
            this.colMaChucVu.HeaderText = "Mã chức vụ";
            this.colMaChucVu.MinimumWidth = 8;
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.ReadOnly = true;
            this.colMaChucVu.Width = 200;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucVu.DataPropertyName = "TenChucVu";
            this.colTenChucVu.HeaderText = "Tên chức vụ";
            this.colTenChucVu.MinimumWidth = 8;
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.ReadOnly = true;
            // 
            // eprMessage
            // 
            this.eprMessage.ContainerControl = this;
            // 
            // stsMessage
            // 
            this.stsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsMessage.Location = new System.Drawing.Point(0, 523);
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(938, 22);
            this.stsMessage.TabIndex = 4;
            this.stsMessage.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // frmQuanLyDanhSachChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 545);
            this.Controls.Add(this.stsMessage);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.btoThem);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.chbTimKiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmQuanLyDanhSachChucVu";
            this.Text = "frmQuanLyDanhSachChucVu";
            this.Load += new System.EventHandler(this.frmQuanLyDanhSachChucVu_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprMessage)).EndInit();
            this.stsMessage.ResumeLayout(false);
            this.stsMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox grbThongTin;
        private CheckBox chbTenChucVu;
        private CheckBox chbMaChucVu;
        private TextBox tboTenChucVu;
        private TextBox tboMaChucVu;
        private Button btoThem;
        private CheckBox chbTimKiem;
        private Button btoSua;
        private Button btoXoa;
        private Button btoTimKiem;
        private DataGridView dgvChucVu;
        private DataGridViewTextBoxColumn colMaChucVu;
        private DataGridViewTextBoxColumn colTenChucVu;
        private ErrorProvider eprMessage;
        private StatusStrip stsMessage;
        private ToolStripStatusLabel lblStatus;
    }
}