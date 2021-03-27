using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmDANG_NHAP : Form
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=DangNhap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public frmDANG_NHAP()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from TAI_KHOAN where username = '"+txtuser.Text+"' and password = '"+txtpass.Text+"'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read() == true)
            {
                this.Hide();
                frmQUAN_LY_NHAN_SU main = new frmQUAN_LY_NHAN_SU();
                main.Taikhoan = dt.Rows[0][0].ToString();
                main.Username = dt.Rows[0][2].ToString();
                main.Authern = dt.Rows[0][3].ToString();
                //main.Username = txtuser.Text;
                main.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpass.Text = "";
                txtuser.Focus();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDANG_NHAP_CLOSING(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
