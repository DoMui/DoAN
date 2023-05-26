namespace Đồ_án
{
    partial class GUI_NhaCC
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
            this.btnThoatNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.grbTKNCC = new System.Windows.Forms.GroupBox();
            this.rdoTenNCC = new System.Windows.Forms.RadioButton();
            this.rdoMaNCC = new System.Windows.Forms.RadioButton();
            this.btnTKNCC = new System.Windows.Forms.Button();
            this.txtTKNCC = new System.Windows.Forms.TextBox();
            this.lblTKNCC = new System.Windows.Forms.Label();
            this.grbTTNCC = new System.Windows.Forms.GroupBox();
            this.txtDCNCC = new System.Windows.Forms.TextBox();
            this.lblDiaChiNCC = new System.Windows.Forms.Label();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.lblSDTNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.grbTKNCC.SuspendLayout();
            this.grbTTNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoatNCC
            // 
            this.btnThoatNCC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoatNCC.Location = new System.Drawing.Point(892, 571);
            this.btnThoatNCC.Name = "btnThoatNCC";
            this.btnThoatNCC.Size = new System.Drawing.Size(107, 56);
            this.btnThoatNCC.TabIndex = 15;
            this.btnThoatNCC.Text = "Thoát";
            this.btnThoatNCC.UseVisualStyleBackColor = false;
            this.btnThoatNCC.Click += new System.EventHandler(this.btnThoatNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoaNCC.Location = new System.Drawing.Point(461, 571);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(107, 56);
            this.btnXoaNCC.TabIndex = 13;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSuaNCC.Location = new System.Drawing.Point(246, 571);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(107, 56);
            this.btnSuaNCC.TabIndex = 12;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = false;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThemNCC.Location = new System.Drawing.Point(29, 571);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(107, 56);
            this.btnThemNCC.TabIndex = 11;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(12, 299);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 62;
            this.dgvNCC.RowTemplate.Height = 28;
            this.dgvNCC.Size = new System.Drawing.Size(987, 254);
            this.dgvNCC.TabIndex = 10;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // grbTKNCC
            // 
            this.grbTKNCC.BackColor = System.Drawing.Color.Lavender;
            this.grbTKNCC.Controls.Add(this.rdoTenNCC);
            this.grbTKNCC.Controls.Add(this.rdoMaNCC);
            this.grbTKNCC.Controls.Add(this.btnTKNCC);
            this.grbTKNCC.Controls.Add(this.txtTKNCC);
            this.grbTKNCC.Controls.Add(this.lblTKNCC);
            this.grbTKNCC.Location = new System.Drawing.Point(642, 12);
            this.grbTKNCC.Name = "grbTKNCC";
            this.grbTKNCC.Size = new System.Drawing.Size(357, 265);
            this.grbTKNCC.TabIndex = 9;
            this.grbTKNCC.TabStop = false;
            this.grbTKNCC.Text = "Tìm kiếm nhà cung cấp";
            // 
            // rdoTenNCC
            // 
            this.rdoTenNCC.AutoSize = true;
            this.rdoTenNCC.Location = new System.Drawing.Point(190, 115);
            this.rdoTenNCC.Name = "rdoTenNCC";
            this.rdoTenNCC.Size = new System.Drawing.Size(161, 24);
            this.rdoTenNCC.TabIndex = 6;
            this.rdoTenNCC.TabStop = true;
            this.rdoTenNCC.Text = "Tên nhà cung cấp";
            this.rdoTenNCC.UseVisualStyleBackColor = true;
            // 
            // rdoMaNCC
            // 
            this.rdoMaNCC.AutoSize = true;
            this.rdoMaNCC.Location = new System.Drawing.Point(10, 115);
            this.rdoMaNCC.Name = "rdoMaNCC";
            this.rdoMaNCC.Size = new System.Drawing.Size(156, 24);
            this.rdoMaNCC.TabIndex = 5;
            this.rdoMaNCC.TabStop = true;
            this.rdoMaNCC.Text = "Mã nhà cung cấp";
            this.rdoMaNCC.UseVisualStyleBackColor = true;
            // 
            // btnTKNCC
            // 
            this.btnTKNCC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKNCC.Location = new System.Drawing.Point(34, 189);
            this.btnTKNCC.Name = "btnTKNCC";
            this.btnTKNCC.Size = new System.Drawing.Size(283, 50);
            this.btnTKNCC.TabIndex = 4;
            this.btnTKNCC.Text = "Tìm kiếm";
            this.btnTKNCC.UseVisualStyleBackColor = false;
            this.btnTKNCC.Click += new System.EventHandler(this.btnTKNCC_Click);
            // 
            // txtTKNCC
            // 
            this.txtTKNCC.Location = new System.Drawing.Point(153, 42);
            this.txtTKNCC.Name = "txtTKNCC";
            this.txtTKNCC.Size = new System.Drawing.Size(164, 26);
            this.txtTKNCC.TabIndex = 1;
            // 
            // lblTKNCC
            // 
            this.lblTKNCC.AutoSize = true;
            this.lblTKNCC.Location = new System.Drawing.Point(49, 45);
            this.lblTKNCC.Name = "lblTKNCC";
            this.lblTKNCC.Size = new System.Drawing.Size(71, 20);
            this.lblTKNCC.TabIndex = 0;
            this.lblTKNCC.Text = "Tìm kiếm";
            this.lblTKNCC.Click += new System.EventHandler(this.lblTKNCC_Click);
            // 
            // grbTTNCC
            // 
            this.grbTTNCC.BackColor = System.Drawing.Color.Lavender;
            this.grbTTNCC.Controls.Add(this.txtDCNCC);
            this.grbTTNCC.Controls.Add(this.lblDiaChiNCC);
            this.grbTTNCC.Controls.Add(this.txtSDTNCC);
            this.grbTTNCC.Controls.Add(this.lblSDTNCC);
            this.grbTTNCC.Controls.Add(this.txtTenNCC);
            this.grbTTNCC.Controls.Add(this.lblTenNCC);
            this.grbTTNCC.Controls.Add(this.txtMaNCC);
            this.grbTTNCC.Controls.Add(this.lblMaNCC);
            this.grbTTNCC.Location = new System.Drawing.Point(12, 12);
            this.grbTTNCC.Name = "grbTTNCC";
            this.grbTTNCC.Size = new System.Drawing.Size(602, 265);
            this.grbTTNCC.TabIndex = 8;
            this.grbTTNCC.TabStop = false;
            this.grbTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // txtDCNCC
            // 
            this.txtDCNCC.Location = new System.Drawing.Point(212, 216);
            this.txtDCNCC.Name = "txtDCNCC";
            this.txtDCNCC.Size = new System.Drawing.Size(344, 26);
            this.txtDCNCC.TabIndex = 7;
            // 
            // lblDiaChiNCC
            // 
            this.lblDiaChiNCC.AutoSize = true;
            this.lblDiaChiNCC.Location = new System.Drawing.Point(29, 219);
            this.lblDiaChiNCC.Name = "lblDiaChiNCC";
            this.lblDiaChiNCC.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChiNCC.TabIndex = 6;
            this.lblDiaChiNCC.Text = "Địa chỉ";
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(212, 160);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(344, 26);
            this.txtSDTNCC.TabIndex = 5;
            // 
            // lblSDTNCC
            // 
            this.lblSDTNCC.AutoSize = true;
            this.lblSDTNCC.Location = new System.Drawing.Point(29, 163);
            this.lblSDTNCC.Name = "lblSDTNCC";
            this.lblSDTNCC.Size = new System.Drawing.Size(102, 20);
            this.lblSDTNCC.TabIndex = 4;
            this.lblSDTNCC.Text = "Số điện thoại";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(212, 102);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(344, 26);
            this.txtTenNCC.TabIndex = 3;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(29, 105);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(136, 20);
            this.lblTenNCC.TabIndex = 2;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(212, 42);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(344, 26);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(29, 45);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(131, 20);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // GUI_NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1014, 647);
            this.Controls.Add(this.btnThoatNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.grbTKNCC);
            this.Controls.Add(this.grbTTNCC);
            this.Name = "GUI_NhaCC";
            this.Text = "GUI_NhaCC";
            this.Load += new System.EventHandler(this.GUI_NhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.grbTKNCC.ResumeLayout(false);
            this.grbTKNCC.PerformLayout();
            this.grbTTNCC.ResumeLayout(false);
            this.grbTTNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoatNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.GroupBox grbTKNCC;
        private System.Windows.Forms.Button btnTKNCC;
        private System.Windows.Forms.TextBox txtTKNCC;
        private System.Windows.Forms.Label lblTKNCC;
        private System.Windows.Forms.GroupBox grbTTNCC;
        private System.Windows.Forms.TextBox txtDCNCC;
        private System.Windows.Forms.Label lblDiaChiNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label lblSDTNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.RadioButton rdoTenNCC;
        private System.Windows.Forms.RadioButton rdoMaNCC;
    }
}