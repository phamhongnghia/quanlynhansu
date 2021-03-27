namespace QuanLyNhanSu
{
    partial class frmTIM_KIEM_TUYEN_DUNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTIM_KIEM_TUYEN_DUNG));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgNhanVienKetQua = new System.Windows.Forms.DataGridView();
            this.colMaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.ckbTheoHoVaTen = new System.Windows.Forms.CheckBox();
            this.ckbTheoMaHoSo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgNhanVienKetQua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 229);
            this.groupBox2.TabIndex = 5;
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
            this.colMaHoSo,
            this.colHoVaTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDanToc,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colKetQua});
            this.dtgNhanVienKetQua.EnableHeadersVisualStyles = false;
            this.dtgNhanVienKetQua.Location = new System.Drawing.Point(6, 16);
            this.dtgNhanVienKetQua.Name = "dtgNhanVienKetQua";
            this.dtgNhanVienKetQua.ReadOnly = true;
            this.dtgNhanVienKetQua.Size = new System.Drawing.Size(888, 207);
            this.dtgNhanVienKetQua.TabIndex = 1;
            // 
            // colMaHoSo
            // 
            this.colMaHoSo.DataPropertyName = "MAHOSO";
            this.colMaHoSo.HeaderText = "Mã hồ sơ";
            this.colMaHoSo.Name = "colMaHoSo";
            this.colMaHoSo.ReadOnly = true;
            this.colMaHoSo.Width = 75;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.DataPropertyName = "HOVATEN";
            this.colHoVaTen.HeaderText = "Họ và tên";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.ReadOnly = true;
            this.colHoVaTen.Width = 130;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NGAYSINH";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GIOITINH";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 75;
            // 
            // colDanToc
            // 
            this.colDanToc.DataPropertyName = "DANTOC";
            this.colDanToc.HeaderText = "Dân tộc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.ReadOnly = true;
            this.colDanToc.Width = 75;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DIACHI";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 200;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "SODIENTHOAI";
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KETQUA";
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.ReadOnly = true;
            this.colKetQua.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtNhapTT);
            this.groupBox1.Controls.Add(this.ckbTheoHoVaTen);
            this.groupBox1.Controls.Add(this.ckbTheoMaHoSo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm kết quả tuyển dụng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(460, 23);
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
            this.txtNhapTT.Location = new System.Drawing.Point(143, 26);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(311, 26);
            this.txtNhapTT.TabIndex = 1;
            // 
            // ckbTheoHoVaTen
            // 
            this.ckbTheoHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoHoVaTen.AutoSize = true;
            this.ckbTheoHoVaTen.Location = new System.Drawing.Point(279, 68);
            this.ckbTheoHoVaTen.Name = "ckbTheoHoVaTen";
            this.ckbTheoHoVaTen.Size = new System.Drawing.Size(103, 19);
            this.ckbTheoHoVaTen.TabIndex = 4;
            this.ckbTheoHoVaTen.Text = "Theo họ và tên";
            this.ckbTheoHoVaTen.UseVisualStyleBackColor = true;
            this.ckbTheoHoVaTen.CheckedChanged += new System.EventHandler(this.ckbTheoHoVaTen_CheckedChanged);
            // 
            // ckbTheoMaHoSo
            // 
            this.ckbTheoMaHoSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoMaHoSo.AutoSize = true;
            this.ckbTheoMaHoSo.Location = new System.Drawing.Point(143, 68);
            this.ckbTheoMaHoSo.Name = "ckbTheoMaHoSo";
            this.ckbTheoMaHoSo.Size = new System.Drawing.Size(104, 19);
            this.ckbTheoMaHoSo.TabIndex = 2;
            this.ckbTheoMaHoSo.Text = "Theo mã hồ sơ";
            this.ckbTheoMaHoSo.UseVisualStyleBackColor = true;
            this.ckbTheoMaHoSo.CheckedChanged += new System.EventHandler(this.ckbTheoMaHoSo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin : ";
            // 
            // frmTIM_KIEM_TUYEN_DUNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTIM_KIEM_TUYEN_DUNG";
            this.Text = "TÌM KIẾM TUYỂN DỤNG";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgNhanVienKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.CheckBox ckbTheoHoVaTen;
        private System.Windows.Forms.CheckBox ckbTheoMaHoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
    }
}