namespace QuanLyNhanSu
{
    partial class frmQUAN_LY_NHAN_SU
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quản lý công chức");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý lương");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hệ thống quản lý", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tiếp nhận hồ sơ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh sach tuyển dụng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tìm kiếm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tuyển dụng công chức", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tìm kiếm công chức");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tìm kiếm phòng ban");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tìm kiếm lương");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tìm kiếm", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Danh sách tài khoản");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tài khoản", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQUAN_LY_NHAN_SU));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvCayThuMuc = new System.Windows.Forms.TreeView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolTree = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuanLy = new System.Windows.Forms.TabControl();
            this.tabQLNhanSu = new System.Windows.Forms.TabPage();
            this.btnNgoaiNgu = new System.Windows.Forms.Button();
            this.btnTDHV = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnHoSoNhanVien = new System.Windows.Forms.Button();
            this.btnTiepNhanNhanVien = new System.Windows.Forms.Button();
            this.tabQLLuong = new System.Windows.Forms.TabPage();
            this.btnBacLuong = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.tabQuanLyTuyenDung = new System.Windows.Forms.TabPage();
            this.btnTimKiemKetQua = new System.Windows.Forms.Button();
            this.btnDanhSachTuyenDung = new System.Windows.Forms.Button();
            this.btnTiepNhanTuyenDung = new System.Windows.Forms.Button();
            this.tabTimKiem = new System.Windows.Forms.TabPage();
            this.btnTimKiemNhanVien = new System.Windows.Forms.Button();
            this.btnTimKiemPhongBan = new System.Windows.Forms.Button();
            this.btnTimKiemBacLuong = new System.Windows.Forms.Button();
            this.tabHoTro = new System.Windows.Forms.TabPage();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnTaiLieu = new System.Windows.Forms.Button();
            this.lkDangXuat = new System.Windows.Forms.LinkLabel();
            this.barHome = new System.Windows.Forms.ProgressBar();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tbQuanLy.SuspendLayout();
            this.tabQLNhanSu.SuspendLayout();
            this.tabQLLuong.SuspendLayout();
            this.tabQuanLyTuyenDung.SuspendLayout();
            this.tabTimKiem.SuspendLayout();
            this.tabHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlTaiKhoan);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(329, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 407);
            this.panel2.TabIndex = 18;
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTaiKhoan.BackColor = System.Drawing.Color.Silver;
            this.pnlTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaiKhoan.Location = new System.Drawing.Point(3, 28);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(574, 374);
            this.pnlTaiKhoan.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trvCayThuMuc);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Location = new System.Drawing.Point(4, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 407);
            this.panel1.TabIndex = 16;
            // 
            // trvCayThuMuc
            // 
            this.trvCayThuMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvCayThuMuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvCayThuMuc.FullRowSelect = true;
            this.trvCayThuMuc.HotTracking = true;
            this.trvCayThuMuc.Location = new System.Drawing.Point(3, 28);
            this.trvCayThuMuc.Name = "trvCayThuMuc";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Quản lý công chức";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Quản lý lương";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Hệ thống quản lý";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Tiếp nhận hồ sơ";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Danh sach tuyển dụng";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Tìm kiếm";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Tuyển dụng công chức";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Tìm kiếm công chức";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Tìm kiếm phòng ban";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Tìm kiếm lương";
            treeNode11.Name = "Node8";
            treeNode11.Text = "Tìm kiếm";
            treeNode12.Name = "Node13";
            treeNode12.Text = "Danh sách tài khoản";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Tài khoản";
            this.trvCayThuMuc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode11,
            treeNode13});
            this.trvCayThuMuc.Size = new System.Drawing.Size(315, 371);
            this.trvCayThuMuc.TabIndex = 9;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolTree,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(162, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTree
            // 
            this.toolTree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolTree.Name = "toolTree";
            this.toolTree.Size = new System.Drawing.Size(115, 22);
            this.toolTree.Text = "MÔ TẢ HỆ THỐNG";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ CÔNG CHỨC VÀ TIỀN LƯƠNG";
            // 
            // tbQuanLy
            // 
            this.tbQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuanLy.Controls.Add(this.tabQLNhanSu);
            this.tbQuanLy.Controls.Add(this.tabQLLuong);
            this.tbQuanLy.Controls.Add(this.tabQuanLyTuyenDung);
            this.tbQuanLy.Controls.Add(this.tabTimKiem);
            this.tbQuanLy.Controls.Add(this.tabHoTro);
            this.tbQuanLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuanLy.ItemSize = new System.Drawing.Size(160, 30);
            this.tbQuanLy.Location = new System.Drawing.Point(0, 45);
            this.tbQuanLy.Name = "tbQuanLy";
            this.tbQuanLy.SelectedIndex = 0;
            this.tbQuanLy.Size = new System.Drawing.Size(911, 122);
            this.tbQuanLy.TabIndex = 12;
            this.tbQuanLy.Tag = "";
            // 
            // tabQLNhanSu
            // 
            this.tabQLNhanSu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabQLNhanSu.Controls.Add(this.btnNgoaiNgu);
            this.tabQLNhanSu.Controls.Add(this.btnTDHV);
            this.tabQLNhanSu.Controls.Add(this.btnChucVu);
            this.tabQLNhanSu.Controls.Add(this.btnPhongBan);
            this.tabQLNhanSu.Controls.Add(this.btnHoSoNhanVien);
            this.tabQLNhanSu.Controls.Add(this.btnTiepNhanNhanVien);
            this.tabQLNhanSu.Location = new System.Drawing.Point(4, 34);
            this.tabQLNhanSu.Name = "tabQLNhanSu";
            this.tabQLNhanSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLNhanSu.Size = new System.Drawing.Size(903, 84);
            this.tabQLNhanSu.TabIndex = 1;
            this.tabQLNhanSu.Text = "Quản lý nhân sự";
            // 
            // btnNgoaiNgu
            // 
            this.btnNgoaiNgu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNgoaiNgu.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNgoaiNgu.FlatAppearance.BorderSize = 5;
            this.btnNgoaiNgu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnNgoaiNgu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnNgoaiNgu.Image = ((System.Drawing.Image)(resources.GetObject("btnNgoaiNgu.Image")));
            this.btnNgoaiNgu.Location = new System.Drawing.Point(329, 8);
            this.btnNgoaiNgu.Name = "btnNgoaiNgu";
            this.btnNgoaiNgu.Size = new System.Drawing.Size(70, 70);
            this.btnNgoaiNgu.TabIndex = 0;
            this.btnNgoaiNgu.Text = "Ngoại ngữ";
            this.btnNgoaiNgu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNgoaiNgu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNgoaiNgu.UseVisualStyleBackColor = false;
            this.btnNgoaiNgu.Click += new System.EventHandler(this.btnNgoaiNgu_Click);
            // 
            // btnTDHV
            // 
            this.btnTDHV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTDHV.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTDHV.FlatAppearance.BorderSize = 5;
            this.btnTDHV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTDHV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTDHV.Image = ((System.Drawing.Image)(resources.GetObject("btnTDHV.Image")));
            this.btnTDHV.Location = new System.Drawing.Point(405, 8);
            this.btnTDHV.Name = "btnTDHV";
            this.btnTDHV.Size = new System.Drawing.Size(70, 70);
            this.btnTDHV.TabIndex = 0;
            this.btnTDHV.Text = "Trình độ học vấn";
            this.btnTDHV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTDHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTDHV.UseVisualStyleBackColor = false;
            this.btnTDHV.Click += new System.EventHandler(this.btnTDHV_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChucVu.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnChucVu.FlatAppearance.BorderSize = 5;
            this.btnChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnChucVu.Image")));
            this.btnChucVu.Location = new System.Drawing.Point(253, 6);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(70, 70);
            this.btnChucVu.TabIndex = 0;
            this.btnChucVu.Text = "DS chức vụ";
            this.btnChucVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhongBan.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPhongBan.FlatAppearance.BorderSize = 5;
            this.btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.Image")));
            this.btnPhongBan.Location = new System.Drawing.Point(158, 6);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(70, 70);
            this.btnPhongBan.TabIndex = 0;
            this.btnPhongBan.Text = "DS phòng ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnHoSoNhanVien
            // 
            this.btnHoSoNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoSoNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnHoSoNhanVien.FlatAppearance.BorderSize = 5;
            this.btnHoSoNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHoSoNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnHoSoNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnHoSoNhanVien.Image")));
            this.btnHoSoNhanVien.Location = new System.Drawing.Point(82, 6);
            this.btnHoSoNhanVien.Name = "btnHoSoNhanVien";
            this.btnHoSoNhanVien.Size = new System.Drawing.Size(70, 70);
            this.btnHoSoNhanVien.TabIndex = 0;
            this.btnHoSoNhanVien.Text = "DS Công chức";
            this.btnHoSoNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoSoNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoSoNhanVien.UseVisualStyleBackColor = false;
            this.btnHoSoNhanVien.Click += new System.EventHandler(this.btnHoSoNhanVien_Click);
            // 
            // btnTiepNhanNhanVien
            // 
            this.btnTiepNhanNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTiepNhanNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTiepNhanNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTiepNhanNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTiepNhanNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhanNhanVien.Image")));
            this.btnTiepNhanNhanVien.Location = new System.Drawing.Point(6, 6);
            this.btnTiepNhanNhanVien.Name = "btnTiepNhanNhanVien";
            this.btnTiepNhanNhanVien.Size = new System.Drawing.Size(70, 70);
            this.btnTiepNhanNhanVien.TabIndex = 0;
            this.btnTiepNhanNhanVien.Text = "Tiếp nhận C.Chức";
            this.btnTiepNhanNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTiepNhanNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTiepNhanNhanVien.UseVisualStyleBackColor = false;
            this.btnTiepNhanNhanVien.Click += new System.EventHandler(this.btnTiepNhanNhanVien_Click);
            // 
            // tabQLLuong
            // 
            this.tabQLLuong.Controls.Add(this.btnBacLuong);
            this.tabQLLuong.Controls.Add(this.btnBangLuong);
            this.tabQLLuong.Location = new System.Drawing.Point(4, 34);
            this.tabQLLuong.Name = "tabQLLuong";
            this.tabQLLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLLuong.Size = new System.Drawing.Size(903, 84);
            this.tabQLLuong.TabIndex = 2;
            this.tabQLLuong.Text = "Quản lý tiền lương";
            this.tabQLLuong.UseVisualStyleBackColor = true;
            // 
            // btnBacLuong
            // 
            this.btnBacLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBacLuong.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnBacLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBacLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBacLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBacLuong.Image")));
            this.btnBacLuong.Location = new System.Drawing.Point(84, 6);
            this.btnBacLuong.Name = "btnBacLuong";
            this.btnBacLuong.Size = new System.Drawing.Size(70, 70);
            this.btnBacLuong.TabIndex = 0;
            this.btnBacLuong.Text = "Bậc lương";
            this.btnBacLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBacLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBacLuong.UseVisualStyleBackColor = false;
            this.btnBacLuong.Click += new System.EventHandler(this.btnBacLuong_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBangLuong.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnBangLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBangLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBangLuong.Image")));
            this.btnBangLuong.Location = new System.Drawing.Point(8, 6);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(70, 70);
            this.btnBangLuong.TabIndex = 0;
            this.btnBangLuong.Text = "Bảng lương";
            this.btnBangLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBangLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // tabQuanLyTuyenDung
            // 
            this.tabQuanLyTuyenDung.Controls.Add(this.btnTimKiemKetQua);
            this.tabQuanLyTuyenDung.Controls.Add(this.btnDanhSachTuyenDung);
            this.tabQuanLyTuyenDung.Controls.Add(this.btnTiepNhanTuyenDung);
            this.tabQuanLyTuyenDung.Location = new System.Drawing.Point(4, 34);
            this.tabQuanLyTuyenDung.Name = "tabQuanLyTuyenDung";
            this.tabQuanLyTuyenDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyTuyenDung.Size = new System.Drawing.Size(903, 84);
            this.tabQuanLyTuyenDung.TabIndex = 5;
            this.tabQuanLyTuyenDung.Text = "Quản lý tuyển dụng";
            this.tabQuanLyTuyenDung.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemKetQua
            // 
            this.btnTimKiemKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiemKetQua.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTimKiemKetQua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemKetQua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemKetQua.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemKetQua.Image")));
            this.btnTimKiemKetQua.Location = new System.Drawing.Point(160, 6);
            this.btnTimKiemKetQua.Name = "btnTimKiemKetQua";
            this.btnTimKiemKetQua.Size = new System.Drawing.Size(70, 70);
            this.btnTimKiemKetQua.TabIndex = 0;
            this.btnTimKiemKetQua.Text = "Tìm kiếm kết quả";
            this.btnTimKiemKetQua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemKetQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemKetQua.UseVisualStyleBackColor = false;
            this.btnTimKiemKetQua.Click += new System.EventHandler(this.btnTimKiemKetQua_Click);
            // 
            // btnDanhSachTuyenDung
            // 
            this.btnDanhSachTuyenDung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSachTuyenDung.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDanhSachTuyenDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDanhSachTuyenDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnDanhSachTuyenDung.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachTuyenDung.Image")));
            this.btnDanhSachTuyenDung.Location = new System.Drawing.Point(84, 6);
            this.btnDanhSachTuyenDung.Name = "btnDanhSachTuyenDung";
            this.btnDanhSachTuyenDung.Size = new System.Drawing.Size(70, 70);
            this.btnDanhSachTuyenDung.TabIndex = 0;
            this.btnDanhSachTuyenDung.Text = "Danh sách";
            this.btnDanhSachTuyenDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDanhSachTuyenDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDanhSachTuyenDung.UseVisualStyleBackColor = false;
            this.btnDanhSachTuyenDung.Click += new System.EventHandler(this.btnDanhSachTuyenDung_Click);
            // 
            // btnTiepNhanTuyenDung
            // 
            this.btnTiepNhanTuyenDung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTiepNhanTuyenDung.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTiepNhanTuyenDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTiepNhanTuyenDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTiepNhanTuyenDung.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhanTuyenDung.Image")));
            this.btnTiepNhanTuyenDung.Location = new System.Drawing.Point(8, 6);
            this.btnTiepNhanTuyenDung.Name = "btnTiepNhanTuyenDung";
            this.btnTiepNhanTuyenDung.Size = new System.Drawing.Size(70, 70);
            this.btnTiepNhanTuyenDung.TabIndex = 0;
            this.btnTiepNhanTuyenDung.Text = "Tiếp nhận hồ sơ";
            this.btnTiepNhanTuyenDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTiepNhanTuyenDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTiepNhanTuyenDung.UseVisualStyleBackColor = false;
            this.btnTiepNhanTuyenDung.Click += new System.EventHandler(this.btnTiepNhanTuyenDung_Click);
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.btnTimKiemNhanVien);
            this.tabTimKiem.Controls.Add(this.btnTimKiemPhongBan);
            this.tabTimKiem.Controls.Add(this.btnTimKiemBacLuong);
            this.tabTimKiem.Location = new System.Drawing.Point(4, 34);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiem.Size = new System.Drawing.Size(903, 84);
            this.tabTimKiem.TabIndex = 3;
            this.tabTimKiem.Text = "Tìm kiếm";
            this.tabTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemNhanVien
            // 
            this.btnTimKiemNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiemNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTimKiemNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemNhanVien.Image")));
            this.btnTimKiemNhanVien.Location = new System.Drawing.Point(8, 6);
            this.btnTimKiemNhanVien.Name = "btnTimKiemNhanVien";
            this.btnTimKiemNhanVien.Size = new System.Drawing.Size(70, 70);
            this.btnTimKiemNhanVien.TabIndex = 3;
            this.btnTimKiemNhanVien.Text = "Tìm kiếm C.Chức";
            this.btnTimKiemNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemNhanVien.UseVisualStyleBackColor = false;
            this.btnTimKiemNhanVien.Click += new System.EventHandler(this.btnTimKiemNhanVien_Click);
            // 
            // btnTimKiemPhongBan
            // 
            this.btnTimKiemPhongBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiemPhongBan.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTimKiemPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhongBan.Image")));
            this.btnTimKiemPhongBan.Location = new System.Drawing.Point(84, 6);
            this.btnTimKiemPhongBan.Name = "btnTimKiemPhongBan";
            this.btnTimKiemPhongBan.Size = new System.Drawing.Size(70, 70);
            this.btnTimKiemPhongBan.TabIndex = 2;
            this.btnTimKiemPhongBan.Text = "Tìm kiếm phòng ban";
            this.btnTimKiemPhongBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemPhongBan.UseVisualStyleBackColor = false;
            this.btnTimKiemPhongBan.Click += new System.EventHandler(this.btnTimKiemPhongBan_Click);
            // 
            // btnTimKiemBacLuong
            // 
            this.btnTimKiemBacLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiemBacLuong.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTimKiemBacLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemBacLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTimKiemBacLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemBacLuong.Image")));
            this.btnTimKiemBacLuong.Location = new System.Drawing.Point(160, 6);
            this.btnTimKiemBacLuong.Name = "btnTimKiemBacLuong";
            this.btnTimKiemBacLuong.Size = new System.Drawing.Size(70, 70);
            this.btnTimKiemBacLuong.TabIndex = 1;
            this.btnTimKiemBacLuong.Text = "Tìm kiếm lương";
            this.btnTimKiemBacLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemBacLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiemBacLuong.UseVisualStyleBackColor = false;
            this.btnTimKiemBacLuong.Click += new System.EventHandler(this.btnTimKiemBacLuong_Click);
            // 
            // tabHoTro
            // 
            this.tabHoTro.Controls.Add(this.btnTaiKhoan);
            this.tabHoTro.Controls.Add(this.btnHuongDan);
            this.tabHoTro.Controls.Add(this.btnThongTin);
            this.tabHoTro.Controls.Add(this.btnTaiLieu);
            this.tabHoTro.Location = new System.Drawing.Point(4, 34);
            this.tabHoTro.Name = "tabHoTro";
            this.tabHoTro.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoTro.Size = new System.Drawing.Size(903, 84);
            this.tabHoTro.TabIndex = 4;
            this.tabHoTro.Text = "Hỗ trợ";
            this.tabHoTro.UseVisualStyleBackColor = true;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(236, 6);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(70, 70);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuongDan.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnHuongDan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHuongDan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.Location = new System.Drawing.Point(8, 6);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(70, 70);
            this.btnHuongDan.TabIndex = 0;
            this.btnHuongDan.Text = "HD Sử dụng";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongTin.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnThongTin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThongTin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.Location = new System.Drawing.Point(84, 6);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(70, 70);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnTaiLieu
            // 
            this.btnTaiLieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiLieu.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTaiLieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTaiLieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTaiLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLieu.Image")));
            this.btnTaiLieu.Location = new System.Drawing.Point(160, 6);
            this.btnTaiLieu.Name = "btnTaiLieu";
            this.btnTaiLieu.Size = new System.Drawing.Size(70, 70);
            this.btnTaiLieu.TabIndex = 0;
            this.btnTaiLieu.Text = "Tài liệu";
            this.btnTaiLieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaiLieu.UseVisualStyleBackColor = false;
            this.btnTaiLieu.Click += new System.EventHandler(this.btnTaiLieu_Click);
            // 
            // lkDangXuat
            // 
            this.lkDangXuat.AutoSize = true;
            this.lkDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lkDangXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkDangXuat.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkDangXuat.LinkColor = System.Drawing.Color.Red;
            this.lkDangXuat.Location = new System.Drawing.Point(37, 9);
            this.lkDangXuat.MinimumSize = new System.Drawing.Size(74, 26);
            this.lkDangXuat.Name = "lkDangXuat";
            this.lkDangXuat.Size = new System.Drawing.Size(74, 26);
            this.lkDangXuat.TabIndex = 15;
            this.lkDangXuat.TabStop = true;
            this.lkDangXuat.Text = "Đăng xuất";
            this.lkDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lkDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkDangXuat_LinkClicked);
            // 
            // barHome
            // 
            this.barHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barHome.Location = new System.Drawing.Point(0, 0);
            this.barHome.Name = "barHome";
            this.barHome.Size = new System.Drawing.Size(915, 47);
            this.barHome.TabIndex = 13;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.InitialImage = null;
            this.picUser.Location = new System.Drawing.Point(5, 9);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(24, 24);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 17;
            this.picUser.TabStop = false;
            // 
            // frmQUAN_LY_NHAN_SU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lkDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barHome);
            this.Controls.Add(this.tbQuanLy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQUAN_LY_NHAN_SU";
            this.Text = "QUẢN LÝ CÔNG CHỨC VÀ LƯƠNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQUAN_LY_NHAN_SU_CLOSING);
            this.Load += new System.EventHandler(this.frmQUAN_LY_NHAN_SU_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tbQuanLy.ResumeLayout(false);
            this.tabQLNhanSu.ResumeLayout(false);
            this.tabQLLuong.ResumeLayout(false);
            this.tabQuanLyTuyenDung.ResumeLayout(false);
            this.tabTimKiem.ResumeLayout(false);
            this.tabHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripLabel toolTree;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbQuanLy;
        private System.Windows.Forms.TabPage tabQLNhanSu;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnHoSoNhanVien;
        private System.Windows.Forms.Button btnTiepNhanNhanVien;
        private System.Windows.Forms.TabPage tabQLLuong;
        private System.Windows.Forms.Button btnBacLuong;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.TabPage tabQuanLyTuyenDung;
        private System.Windows.Forms.Button btnTimKiemKetQua;
        private System.Windows.Forms.Button btnDanhSachTuyenDung;
        private System.Windows.Forms.Button btnTiepNhanTuyenDung;
        private System.Windows.Forms.TabPage tabTimKiem;
        private System.Windows.Forms.Button btnTimKiemNhanVien;
        private System.Windows.Forms.Button btnTimKiemPhongBan;
        private System.Windows.Forms.Button btnTimKiemBacLuong;
        private System.Windows.Forms.TabPage tabHoTro;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnTaiLieu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.LinkLabel lkDangXuat;
        private System.Windows.Forms.ProgressBar barHome;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnNgoaiNgu;
        private System.Windows.Forms.Button btnTDHV;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.TreeView trvCayThuMuc;
    }
}