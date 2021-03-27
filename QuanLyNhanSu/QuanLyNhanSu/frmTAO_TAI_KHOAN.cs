using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.database;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmTAO_TAI_KHOAN : Form
    {
        KetNoi kn = new KetNoi();
        public frmTAO_TAI_KHOAN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;
            string fullname = txtfullname.Text;
            string capquyen = null;
            if(checkBox1.Checked == true)
            {
                capquyen = "Quản trị";
            }else if(checkBox2.Checked == true)
            {
                capquyen = "Công chức";
            }

            //Kiểm tra đăng nhập.

            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=DangNhap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from TAI_KHOAN where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtuser.Focus();
            }
            else if (rd.Read())
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                txtuser.SelectAll();
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn quyền truy cập !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                checkBox1.Focus();
            }
            else
            {
                kn.taoTaiKhoan(username, password, fullname,capquyen);
                MessageBox.Show("Đã tạo thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Clear();
                txtpass.Clear();
                txtfullname.Clear();
                txtuser.Focus();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            conn.Close();
        }

        private void btnXemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTAI_KHOAN frmTAI_KHOAN = new frmTAI_KHOAN();
            frmTAI_KHOAN.Show();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbTaoTaiKhoan_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
