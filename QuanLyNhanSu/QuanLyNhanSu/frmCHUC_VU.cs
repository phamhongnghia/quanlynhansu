using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.database;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmCHUC_VU : Form
    {
        KetNoi_CHUC_VU kn = new KetNoi_CHUC_VU();
        DataTable dtCV = new DataTable();
        public frmCHUC_VU()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private string taikhoanDN;
        public string TaikhoanDN
        {
            get { return taikhoanDN; }
            set { taikhoanDN = value; }
        }

        void loadCV()
        {
            dtCV = kn.layCHUC_VU();
            lstTenChucVu.DataSource = dtCV;
            lstTenChucVu.ValueMember = "MACV";
            lstTenChucVu.DisplayMember = "TENCV";
        }

        private void frmCHUC_VU_Load(object sender, EventArgs e)
        {
            loadCV();
            if(taikhoanDN == "Công chức")
            {
                btnThemMoi.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            txtMaChucVu.Clear();
            txtTenChucVu.Clear();
        }

        private void lstTenChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstTenChucVu.SelectedIndex;
            if(index > -1)
            {
                txtMaChucVu.Text = dtCV.Rows[index][0].ToString();
                txtTenChucVu.Text = dtCV.Rows[index][1].ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            //Kiểm tra đăng nhập.

            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from CHUC_VU where MACV = N'" + txtMaChucVu.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtMaChucVu.Text) || string.IsNullOrEmpty(txtTenChucVu.Text))
            {
                MessageBox.Show("Bạn chưa điền thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
            }
            else if (rd.Read())
            {
                MessageBox.Show("Mã chức vụ đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();

            }else
            {
                kn.themMoiCV(txtMaChucVu.Text, txtTenChucVu.Text);
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadCV();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            kn.capNhatCV(txtMaChucVu.Text,txtTenChucVu.Text);
            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            loadCV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa ?","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.xoaCV(txtMaChucVu.Text);
                loadCV();
            }
        }
    }
}
