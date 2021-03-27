namespace QuanLyNhanSu
{
    partial class frmTAI_KHOAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTAI_KHOAN));
            this.label2 = new System.Windows.Forms.Label();
            this.dtgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTruyCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Name = "label2";
            // 
            // dtgTaiKhoan
            // 
            this.dtgTaiKhoan.AllowUserToAddRows = false;
            this.dtgTaiKhoan.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dtgTaiKhoan, "dtgTaiKhoan");
            this.dtgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colusername,
            this.colpassword,
            this.colHoVaTen,
            this.colTruyCap});
            this.dtgTaiKhoan.EnableHeadersVisualStyles = false;
            this.dtgTaiKhoan.Name = "dtgTaiKhoan";
            this.dtgTaiKhoan.ReadOnly = true;
            this.dtgTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTaiKhoan_CellClick);
            this.dtgTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTaiKhoan_CellContentClick);
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtHoVaTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRepass);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtHoVaTen
            // 
            resources.ApplyResources(this.txtHoVaTen, "txtHoVaTen");
            this.txtHoVaTen.ForeColor = System.Drawing.Color.Red;
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtusername
            // 
            resources.ApplyResources(this.txtusername, "txtusername");
            this.txtusername.ForeColor = System.Drawing.Color.Red;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtRepass
            // 
            resources.ApplyResources(this.txtRepass, "txtRepass");
            this.txtRepass.Name = "txtRepass";
            // 
            // txtpass
            // 
            resources.ApplyResources(this.txtpass, "txtpass");
            this.txtpass.Name = "txtpass";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCapNhat
            // 
            resources.ApplyResources(this.btnCapNhat, "btnCapNhat");
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // colusername
            // 
            this.colusername.DataPropertyName = "username";
            resources.ApplyResources(this.colusername, "colusername");
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            this.colusername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colpassword
            // 
            this.colpassword.DataPropertyName = "password";
            resources.ApplyResources(this.colpassword, "colpassword");
            this.colpassword.Name = "colpassword";
            this.colpassword.ReadOnly = true;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.DataPropertyName = "fullname";
            resources.ApplyResources(this.colHoVaTen, "colHoVaTen");
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.ReadOnly = true;
            // 
            // colTruyCap
            // 
            this.colTruyCap.DataPropertyName = "authern";
            resources.ApplyResources(this.colTruyCap, "colTruyCap");
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.ReadOnly = true;
            // 
            // frmTAI_KHOAN
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgTaiKhoan);
            this.Controls.Add(this.label2);
            this.Name = "frmTAI_KHOAN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmTAI_KHOAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgTaiKhoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTruyCap;
    }
}