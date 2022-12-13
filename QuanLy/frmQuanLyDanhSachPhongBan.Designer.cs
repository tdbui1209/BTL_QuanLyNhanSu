namespace BTL_QuanyNhanSu.QuanLy
{
    partial class frmQuanLyDanhSachPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDanhSachPhongBan));
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.tboTenPhongBan = new System.Windows.Forms.TextBox();
            this.tboMaPhongBan = new System.Windows.Forms.TextBox();
            this.chbTenPhongBan = new System.Windows.Forms.CheckBox();
            this.chbMaPhongBan = new System.Windows.Forms.CheckBox();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.btoThem = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eprMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.stsMessage = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprMessage)).BeginInit();
            this.stsMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH SÁCH PHÒNG BAN";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.Controls.Add(this.tboTenPhongBan);
            this.grbThongTin.Controls.Add(this.tboMaPhongBan);
            this.grbThongTin.Controls.Add(this.chbTenPhongBan);
            this.grbThongTin.Controls.Add(this.chbMaPhongBan);
            this.grbThongTin.Location = new System.Drawing.Point(12, 51);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(914, 109);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin phòng ban";
            // 
            // tboTenPhongBan
            // 
            this.tboTenPhongBan.Location = new System.Drawing.Point(149, 67);
            this.tboTenPhongBan.Name = "tboTenPhongBan";
            this.tboTenPhongBan.Size = new System.Drawing.Size(368, 25);
            this.tboTenPhongBan.TabIndex = 1;
            // 
            // tboMaPhongBan
            // 
            this.tboMaPhongBan.Location = new System.Drawing.Point(149, 32);
            this.tboMaPhongBan.Name = "tboMaPhongBan";
            this.tboMaPhongBan.Size = new System.Drawing.Size(149, 25);
            this.tboMaPhongBan.TabIndex = 1;
            // 
            // chbTenPhongBan
            // 
            this.chbTenPhongBan.AutoSize = true;
            this.chbTenPhongBan.Checked = true;
            this.chbTenPhongBan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenPhongBan.Location = new System.Drawing.Point(6, 71);
            this.chbTenPhongBan.Name = "chbTenPhongBan";
            this.chbTenPhongBan.Size = new System.Drawing.Size(124, 21);
            this.chbTenPhongBan.TabIndex = 0;
            this.chbTenPhongBan.Text = "Tên phòng ban";
            this.chbTenPhongBan.UseVisualStyleBackColor = true;
            // 
            // chbMaPhongBan
            // 
            this.chbMaPhongBan.AutoSize = true;
            this.chbMaPhongBan.Checked = true;
            this.chbMaPhongBan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaPhongBan.Location = new System.Drawing.Point(6, 34);
            this.chbMaPhongBan.Name = "chbMaPhongBan";
            this.chbMaPhongBan.Size = new System.Drawing.Size(118, 21);
            this.chbMaPhongBan.TabIndex = 0;
            this.chbMaPhongBan.Text = "Mã phòng ban";
            this.chbMaPhongBan.UseVisualStyleBackColor = true;
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(18, 176);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(87, 21);
            this.chbTimKiem.TabIndex = 0;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.Location = new System.Drawing.Point(111, 168);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(100, 35);
            this.btoThem.TabIndex = 2;
            this.btoThem.Text = "Thêm";
            this.btoThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoThem.UseVisualStyleBackColor = true;
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.Location = new System.Drawing.Point(217, 168);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(100, 35);
            this.btoSua.TabIndex = 2;
            this.btoSua.Text = "Sửa";
            this.btoSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoSua.UseVisualStyleBackColor = true;
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.Location = new System.Drawing.Point(323, 168);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(100, 35);
            this.btoXoa.TabIndex = 2;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoXoa.UseVisualStyleBackColor = true;
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.Location = new System.Drawing.Point(429, 168);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btoTimKiem.TabIndex = 2;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btoTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AllowUserToResizeColumns = false;
            this.dgvPhongBan.AllowUserToResizeRows = false;
            this.dgvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan});
            this.dgvPhongBan.Location = new System.Drawing.Point(12, 222);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowTemplate.Height = 25;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(914, 289);
            this.dgvPhongBan.TabIndex = 3;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.DataPropertyName = "MaPhongBan";
            this.colMaPhongBan.HeaderText = "Mã phòng ban";
            this.colMaPhongBan.MinimumWidth = 8;
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.Width = 200;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenPhongBan.DataPropertyName = "TenPhongBan";
            this.colTenPhongBan.HeaderText = "Tên phòng ban";
            this.colTenPhongBan.MinimumWidth = 8;
            this.colTenPhongBan.Name = "colTenPhongBan";
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
            // frmQuanLyDanhSachPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 545);
            this.Controls.Add(this.stsMessage);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.btoThem);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbTimKiem);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmQuanLyDanhSachPhongBan";
            this.Text = "QUẢN LÝ DANH SÁCH PHÒNG BAN";
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprMessage)).EndInit();
            this.stsMessage.ResumeLayout(false);
            this.stsMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox grbThongTin;
        private TextBox tboTenPhongBan;
        private TextBox tboMaPhongBan;
        private CheckBox chbTenPhongBan;
        private CheckBox chbMaPhongBan;
        private CheckBox chbTimKiem;
        private Button btoThem;
        private Button btoSua;
        private Button btoXoa;
        private Button btoTimKiem;
        private DataGridView dgvPhongBan;
        private DataGridViewTextBoxColumn colMaPhongBan;
        private DataGridViewTextBoxColumn colTenPhongBan;
        private ErrorProvider eprMessage;
        private StatusStrip stsMessage;
        private ToolStripStatusLabel lblStatus;
    }
}