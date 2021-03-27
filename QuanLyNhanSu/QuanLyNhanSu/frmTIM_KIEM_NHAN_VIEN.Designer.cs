namespace QuanLyNhanSu
{
    partial class frmTIM_KIEM_NHAN_VIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTIM_KIEM_NHAN_VIEN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.ckbTheoHoVaTen = new System.Windows.Forms.CheckBox();
            this.ckbTheoMaPB = new System.Windows.Forms.CheckBox();
            this.ckbTheoMaNV = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgNhanVienKetQua = new System.Windows.Forms.DataGridView();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnXemChiTiet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaCC);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtNhapTT);
            this.groupBox1.Controls.Add(this.ckbTheoHoVaTen);
            this.groupBox1.Controls.Add(this.ckbTheoMaPB);
            this.groupBox1.Controls.Add(this.ckbTheoMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm công chức";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(609, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 31);
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
            this.txtNhapTT.Location = new System.Drawing.Point(197, 33);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(397, 26);
            this.txtNhapTT.TabIndex = 1;
            // 
            // ckbTheoHoVaTen
            // 
            this.ckbTheoHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoHoVaTen.AutoSize = true;
            this.ckbTheoHoVaTen.Location = new System.Drawing.Point(491, 83);
            this.ckbTheoHoVaTen.Name = "ckbTheoHoVaTen";
            this.ckbTheoHoVaTen.Size = new System.Drawing.Size(103, 19);
            this.ckbTheoHoVaTen.TabIndex = 4;
            this.ckbTheoHoVaTen.Text = "Theo họ và tên";
            this.ckbTheoHoVaTen.UseVisualStyleBackColor = true;
            this.ckbTheoHoVaTen.CheckedChanged += new System.EventHandler(this.ckbTheoHoVaTen_CheckedChanged);
            // 
            // ckbTheoMaPB
            // 
            this.ckbTheoMaPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoMaPB.AutoSize = true;
            this.ckbTheoMaPB.Location = new System.Drawing.Point(279, 83);
            this.ckbTheoMaPB.Name = "ckbTheoMaPB";
            this.ckbTheoMaPB.Size = new System.Drawing.Size(130, 19);
            this.ckbTheoMaPB.TabIndex = 3;
            this.ckbTheoMaPB.Text = "Theo mã phòng ban";
            this.ckbTheoMaPB.UseVisualStyleBackColor = true;
            this.ckbTheoMaPB.CheckedChanged += new System.EventHandler(this.ckbTheoMaPB_CheckedChanged);
            // 
            // ckbTheoMaNV
            // 
            this.ckbTheoMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoMaNV.AutoSize = true;
            this.ckbTheoMaNV.Location = new System.Drawing.Point(86, 83);
            this.ckbTheoMaNV.Name = "ckbTheoMaNV";
            this.ckbTheoMaNV.Size = new System.Drawing.Size(131, 19);
            this.ckbTheoMaNV.TabIndex = 2;
            this.ckbTheoMaNV.Text = "Theo mã công chức";
            this.ckbTheoMaNV.UseVisualStyleBackColor = true;
            this.ckbTheoMaNV.CheckedChanged += new System.EventHandler(this.ckbTheoMaNV_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgNhanVienKetQua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dtgNhanVienKetQua
            // 
            this.dtgNhanVienKetQua.AllowUserToAddRows = false;
            this.dtgNhanVienKetQua.AllowUserToDeleteRows = false;
            this.dtgNhanVienKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNhanVienKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgNhanVienKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colHoVaTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDanToc,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colTenPB,
            this.colTenCV});
            this.dtgNhanVienKetQua.EnableHeadersVisualStyles = false;
            this.dtgNhanVienKetQua.Location = new System.Drawing.Point(6, 16);
            this.dtgNhanVienKetQua.Name = "dtgNhanVienKetQua";
            this.dtgNhanVienKetQua.ReadOnly = true;
            this.dtgNhanVienKetQua.Size = new System.Drawing.Size(1050, 273);
            this.dtgNhanVienKetQua.TabIndex = 1;
            this.dtgNhanVienKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKetQua_Click);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MANV";
            this.colMaNhanVien.HeaderText = "Mã công chức";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Width = 95;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.DataPropertyName = "HOTENNV";
            this.colHoVaTen.HeaderText = "Họ và tên";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.ReadOnly = true;
            this.colHoVaTen.Width = 120;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NGAYSINH";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 80;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GIOITINH";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 70;
            // 
            // colDanToc
            // 
            this.colDanToc.DataPropertyName = "DANTOC";
            this.colDanToc.HeaderText = "Dân tộc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.ReadOnly = true;
            this.colDanToc.Width = 65;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "QUEQUAN";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 185;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "SODIENTHOAI";
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colTenPB
            // 
            this.colTenPB.DataPropertyName = "TENPB";
            this.colTenPB.HeaderText = "Tên phòng ban";
            this.colTenPB.Name = "colTenPB";
            this.colTenPB.ReadOnly = true;
            this.colTenPB.Width = 175;
            // 
            // colTenCV
            // 
            this.colTenCV.DataPropertyName = "TENCV";
            this.colTenCV.HeaderText = "Chức vụ";
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.ReadOnly = true;
            this.colTenCV.Width = 115;
            // 
            // txtMaCC
            // 
            this.txtMaCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCC.Location = new System.Drawing.Point(877, 33);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.ReadOnly = true;
            this.txtMaCC.Size = new System.Drawing.Size(167, 26);
            this.txtMaCC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã công chức :";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTiet.Image")));
            this.btnXemChiTiet.Location = new System.Drawing.Point(935, 65);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(109, 36);
            this.btnXemChiTiet.TabIndex = 11;
            this.btnXemChiTiet.Text = "Xem thêm";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // frmTIM_KIEM_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTIM_KIEM_NHAN_VIEN";
            this.Text = "TÌM KIẾM CÔNG CHỨC";
            this.Load += new System.EventHandler(this.frmTIM_KIEM_NHAN_VIEN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.CheckBox ckbTheoHoVaTen;
        private System.Windows.Forms.CheckBox ckbTheoMaPB;
        private System.Windows.Forms.CheckBox ckbTheoMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgNhanVienKetQua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCC;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}