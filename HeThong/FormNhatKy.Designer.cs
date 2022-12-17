namespace BTL_QuanyNhanSu.HeThong
{
    partial class FormNhatKy
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
            this.dgv_NhatKy = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NhatKy
            // 
            this.dgv_NhatKy.AllowUserToAddRows = false;
            this.dgv_NhatKy.AllowUserToDeleteRows = false;
            this.dgv_NhatKy.AllowUserToResizeColumns = false;
            this.dgv_NhatKy.AllowUserToResizeRows = false;
            this.dgv_NhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NguoiSua,
            this.ThoiDiem,
            this.NoiDung});
            this.dgv_NhatKy.Location = new System.Drawing.Point(12, 153);
            this.dgv_NhatKy.Name = "dgv_NhatKy";
            this.dgv_NhatKy.RowHeadersWidth = 51;
            this.dgv_NhatKy.RowTemplate.Height = 29;
            this.dgv_NhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhatKy.Size = new System.Drawing.Size(913, 346);
            this.dgv_NhatKy.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "MaNhatKy";
            this.ID.FillWeight = 21.39037F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 53;
            // 
            // NguoiSua
            // 
            this.NguoiSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NguoiSua.DataPropertyName = "TenDangNhap";
            this.NguoiSua.FillWeight = 126.2032F;
            this.NguoiSua.HeaderText = "Người sửa";
            this.NguoiSua.MinimumWidth = 6;
            this.NguoiSua.Name = "NguoiSua";
            this.NguoiSua.Width = 107;
            // 
            // ThoiDiem
            // 
            this.ThoiDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ThoiDiem.DataPropertyName = "ThoiDiem";
            this.ThoiDiem.FillWeight = 126.2032F;
            this.ThoiDiem.HeaderText = "Thời điểm";
            this.ThoiDiem.MinimumWidth = 6;
            this.ThoiDiem.Name = "ThoiDiem";
            this.ThoiDiem.Width = 105;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.FillWeight = 126.2032F;
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            // 
            // FormNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 511);
            this.Controls.Add(this.dgv_NhatKy);
            this.Name = "FormNhatKy";
            this.Text = "Nhật ký";
            this.Load += new System.EventHandler(this.FormNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_NhatKy;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NguoiSua;
        private DataGridViewTextBoxColumn ThoiDiem;
        private DataGridViewTextBoxColumn NoiDung;
    }
}