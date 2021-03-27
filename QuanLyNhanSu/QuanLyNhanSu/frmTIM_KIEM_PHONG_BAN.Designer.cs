namespace QuanLyNhanSu
{
    partial class frmTIM_KIEM_PHONG_BAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTIM_KIEM_PHONG_BAN));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPhongBanKetQua = new System.Windows.Forms.DataGridView();
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbTheoMaPB = new System.Windows.Forms.CheckBox();
            this.ckbTenPB = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBanKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgPhongBanKetQua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 210);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dtgPhongBanKetQua
            // 
            this.dtgPhongBanKetQua.AllowUserToAddRows = false;
            this.dtgPhongBanKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPhongBanKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPhongBanKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colSoDienThoai,
            this.colDiaChi});
            this.dtgPhongBanKetQua.EnableHeadersVisualStyles = false;
            this.dtgPhongBanKetQua.Location = new System.Drawing.Point(6, 16);
            this.dtgPhongBanKetQua.Name = "dtgPhongBanKetQua";
            this.dtgPhongBanKetQua.Size = new System.Drawing.Size(618, 188);
            this.dtgPhongBanKetQua.TabIndex = 1;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.DataPropertyName = "MAPB";
            this.colMaPhongBan.HeaderText = "Mã phòng ban";
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.ReadOnly = true;
            this.colMaPhongBan.Width = 95;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.DataPropertyName = "TENPB";
            this.colTenPhongBan.HeaderText = "Tên phòng ban";
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.ReadOnly = true;
            this.colTenPhongBan.Width = 180;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "SODIENTHOAI";
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            this.colSoDienThoai.Width = 110;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DIACHI";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 190;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtNhapTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbTheoMaPB);
            this.groupBox1.Controls.Add(this.ckbTenPB);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phòng ban";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(423, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 31);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNhapTT
            // 
            this.txtNhapTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhapTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTT.Location = new System.Drawing.Point(224, 33);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(193, 26);
            this.txtNhapTT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin : ";
            // 
            // ckbTheoMaPB
            // 
            this.ckbTheoMaPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoMaPB.AutoSize = true;
            this.ckbTheoMaPB.Location = new System.Drawing.Point(169, 82);
            this.ckbTheoMaPB.Name = "ckbTheoMaPB";
            this.ckbTheoMaPB.Size = new System.Drawing.Size(130, 19);
            this.ckbTheoMaPB.TabIndex = 2;
            this.ckbTheoMaPB.Text = "Theo mã phòng ban";
            this.ckbTheoMaPB.UseVisualStyleBackColor = true;
            this.ckbTheoMaPB.CheckedChanged += new System.EventHandler(this.ckbTheoMaPB_CheckedChanged);
            // 
            // ckbTenPB
            // 
            this.ckbTenPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTenPB.AutoSize = true;
            this.ckbTenPB.Location = new System.Drawing.Point(335, 82);
            this.ckbTenPB.Name = "ckbTenPB";
            this.ckbTenPB.Size = new System.Drawing.Size(131, 19);
            this.ckbTenPB.TabIndex = 3;
            this.ckbTenPB.Text = "Theo tên phòng ban";
            this.ckbTenPB.UseVisualStyleBackColor = true;
            this.ckbTenPB.CheckedChanged += new System.EventHandler(this.ckbTenPB_CheckedChanged);
            // 
            // frmTIM_KIEM_PHONG_BAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTIM_KIEM_PHONG_BAN";
            this.Text = "TÌM KIẾM PHÒNG BAN";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBanKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPhongBanKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbTheoMaPB;
        private System.Windows.Forms.CheckBox ckbTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}