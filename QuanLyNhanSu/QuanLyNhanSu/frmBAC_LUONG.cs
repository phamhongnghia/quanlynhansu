using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.database;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmBAC_LUONG : Form
    {
        KetNoi_BAC_LUONG kn = new KetNoi_BAC_LUONG();
        DataTable dtBACLUONG = new DataTable();

        private string taikhoanDN;
        public string TaikhoanDN
        {
            get { return taikhoanDN; }
            set { taikhoanDN = value; }
        }

        public frmBAC_LUONG()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadBACLUONG()
        {
            dtBACLUONG = kn.layBACLUONG();
            lstTenBacLuong.DataSource = dtBACLUONG;
            lstTenBacLuong.ValueMember = "BACLUONG";
            lstTenBacLuong.DisplayMember = "BACLUONG";
        }

        private void frmBAC_LUONG_Load(object sender, EventArgs e)
        {
            loadBACLUONG();
            txtBacLuong.Clear();
            txtHeSoLuong.Clear();
            txtLuongCoBan.Clear();
            txtHeSoPhuCap.Clear();
            if(taikhoanDN == "Công chức")
            {
                btnThemMoi.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void lstTenBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstTenBacLuong.SelectedIndex;
            if(index > -1)
            {
                txtBacLuong.Text = dtBACLUONG.Rows[index][0].ToString();
                txtLuongCoBan.Text = dtBACLUONG.Rows[index][1].ToString();
                //string.Format("{0:0,0 vnđ}", txtLuongCoBan.Text);
                txtHeSoLuong.Text = dtBACLUONG.Rows[index][2].ToString();
                txtHeSoPhuCap.Text = dtBACLUONG.Rows[index][3].ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Kiểm tra đăng nhập.

            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from LUONG_NHAN_VIEN where BACLUONG = N'" + txtBacLuong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtBacLuong.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text) || string.IsNullOrEmpty(txtHeSoLuong.Text) || string.IsNullOrEmpty(txtHeSoPhuCap.Text))
            {
                MessageBox.Show("Bạn chưa điền thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBacLuong.Focus();
            }
            else if (rd.Read())
            {
                MessageBox.Show("Mã bậc lương đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBacLuong.Focus();

            }
            else
            {
                int luongCoBan = int.Parse(txtLuongCoBan.Text);
                int heSoLuong = int.Parse(txtHeSoLuong.Text);
                int heSoPhuCap = int.Parse(txtHeSoPhuCap.Text);
                kn.themMoiBACLUONG(txtBacLuong.Text, luongCoBan.ToString(), heSoLuong.ToString(), heSoPhuCap.ToString());
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadBACLUONG();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int luongCoBan = int.Parse(txtLuongCoBan.Text);
            int heSoLuong = int.Parse(txtHeSoLuong.Text);
            int heSoPhuCap = int.Parse(txtHeSoPhuCap.Text);
            kn.capNhatBACLUONG(txtBacLuong.Text,luongCoBan.ToString(), heSoLuong.ToString(),heSoPhuCap.ToString());
            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            loadBACLUONG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.xoaBACLUONG(txtBacLuong.Text);
                loadBACLUONG();
            }
        }
    }
}
