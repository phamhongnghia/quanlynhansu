namespace QuanLyNhanSu
{
    partial class frmTIM_KIEM_LUONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTIM_KIEM_LUONG));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgKetQuaLuong = new System.Windows.Forms.DataGridView();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongHuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.ckbTheoHoVaTen = new System.Windows.Forms.CheckBox();
            this.ckbTheoMaPB = new System.Windows.Forms.CheckBox();
            this.ckbTheoMaNV = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKetQuaLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgKetQuaLuong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dtgKetQuaLuong
            // 
            this.dtgKetQuaLuong.AllowUserToAddRows = false;
            this.dtgKetQuaLuong.AllowUserToDeleteRows = false;
            this.dtgKetQuaLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgKetQuaLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgKetQuaLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colHoVaTen,
            this.colTenPB,
            this.colTenCV,
            this.colBacLuong,
            this.colLuongCoBan,
            this.colPhuCap,
            this.colLuongHuong});
            this.dtgKetQuaLuong.EnableHeadersVisualStyles = false;
            this.dtgKetQuaLuong.Location = new System.Drawing.Point(6, 16);
            this.dtgKetQuaLuong.Name = "dtgKetQuaLuong";
            this.dtgKetQuaLuong.ReadOnly = true;
            this.dtgKetQuaLuong.Size = new System.Drawing.Size(963, 279);
            this.dtgKetQuaLuong.TabIndex = 1;
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
            this.colHoVaTen.Width = 150;
            // 
            // colTenPB
            // 
            this.colTenPB.DataPropertyName = "TENPB";
            this.colTenPB.HeaderText = "Phòng ban";
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
            // 
            // colBacLuong
            // 
            this.colBacLuong.DataPropertyName = "BACLUONG";
            this.colBacLuong.HeaderText = "Bậc lương";
            this.colBacLuong.Name = "colBacLuong";
            this.colBacLuong.ReadOnly = true;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.DataPropertyName = "LUONGCOBAN";
            this.colLuongCoBan.HeaderText = "Lương cơ bản";
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.ReadOnly = true;
            // 
            // colPhuCap
            // 
            this.colPhuCap.DataPropertyName = "LUONGPHUCAP";
            this.colPhuCap.HeaderText = "Phụ cấp";
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.ReadOnly = true;
            // 
            // colLuongHuong
            // 
            this.colLuongHuong.DataPropertyName = "TIENLUONG";
            this.colLuongHuong.HeaderText = "Lương hưởng";
            this.colLuongHuong.Name = "colLuongHuong";
            this.colLuongHuong.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtNhapTT);
            this.groupBox1.Controls.Add(this.ckbTheoHoVaTen);
            this.groupBox1.Controls.Add(this.ckbTheoMaPB);
            this.groupBox1.Controls.Add(this.ckbTheoMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm công chức";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(609, 32);
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
            this.txtNhapTT.Location = new System.Drawing.Point(184, 34);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(397, 26);
            this.txtNhapTT.TabIndex = 1;
            // 
            // ckbTheoHoVaTen
            // 
            this.ckbTheoHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTheoHoVaTen.AutoSize = true;
            this.ckbTheoHoVaTen.Location = new System.Drawing.Point(478, 84);
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
            this.ckbTheoMaPB.Location = new System.Drawing.Point(275, 84);
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
            this.ckbTheoMaNV.Location = new System.Drawing.Point(84, 84);
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
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin : ";
            // 
            // frmTIM_KIEM_LUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTIM_KIEM_LUONG";
            this.Text = "TÌM KIẾM LƯƠNG";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKetQuaLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgKetQuaLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.CheckBox ckbTheoHoVaTen;
        private System.Windows.Forms.CheckBox ckbTheoMaPB;
        private System.Windows.Forms.CheckBox ckbTheoMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongHuong;
    }
}