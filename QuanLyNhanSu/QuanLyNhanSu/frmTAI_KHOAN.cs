using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.database;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmTAI_KHOAN : Form
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=DangNhap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        KetNoi kn = new KetNoi();
        public frmTAI_KHOAN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadTaiKhoan()
        {
            conn = new SqlConnection(connect);
            string sql = "select * from TAI_KHOAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgTaiKhoan.DataSource = ds.Tables[0];
            dtgTaiKhoan.Refresh();
        }

        private void frmTAI_KHOAN_Load(object sender, EventArgs e)
        {
            loadTaiKhoan();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int index = dtgTaiKhoan.CurrentCell.RowIndex;
            if (string.IsNullOrEmpty(txtusername.Text)){
                MessageBox.Show("Mời chọn một username !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtRepass.Clear();
            }
            else
            {
                if (index > -1)
                {
                    if (string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtRepass.Text))
                    {
                        MessageBox.Show("Không được bỏ trống mật khẩu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtpass.Text.CompareTo(txtRepass.Text) == 0)
                        {
                            string username = txtusername.Text;
                            string newpass = txtRepass.Text;
                            kn.capNhat(username, newpass);
                            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            loadTaiKhoan();
                            txtpass.Clear();
                            txtRepass.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại mật khẩu không đúng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtgTaiKhoan.CurrentCell.RowIndex;
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Mời chọn một username !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(index > -1)
            {
                if(MessageBox.Show("Bạn có muốn xóa tài khoản ?","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string username = dtgTaiKhoan.Rows[index].Cells[0].Value.ToString();
                    kn.xoaTaiKhoan(username);
                    MessageBox.Show("Đã xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadTaiKhoan();
                    txtusername.Clear();
                } 
             }
        }

        private void dtgTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dtgTaiKhoan.CurrentCell.RowIndex;
            //txtusername.Text = dtgTaiKhoan.Rows[index].Cells[0].Value.ToString();
        }

        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgTaiKhoan.CurrentCell.RowIndex;
            txtusername.Text = dtgTaiKhoan.Rows[index].Cells[0].Value.ToString();
            txtHoVaTen.Text = dtgTaiKhoan.Rows[index].Cells[2].Value.ToString();
        }
    }
}