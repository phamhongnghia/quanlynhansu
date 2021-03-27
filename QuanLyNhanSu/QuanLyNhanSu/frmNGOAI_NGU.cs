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
    public partial class frmNGOAI_NGU : Form
    {
        KetNoiNGOAI_NGU kn = new KetNoiNGOAI_NGU();
        DataTable dtNN = new DataTable();
        public frmNGOAI_NGU()
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

        void loadNN()
        {
            dtNN = kn.layNN();
            lstNN.DataSource = dtNN;
            lstNN.ValueMember = "MANN";
            lstNN.DisplayMember = "MANN";
        }

        private void frmNGOAI_NGU_Load(object sender, EventArgs e)
        {
            loadNN();
            txtMaNN.Clear();
            txtTenNgoaiNgu.Clear();
            txtTrinhDo.Clear();
            if(taikhoanDN == "Công chức")
            {
                btnThemMoi.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void lstNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstNN.SelectedIndex;
            if( index > -1)
            {
                txtMaNN.Text = dtNN.Rows[index][0].ToString();
                txtTenNgoaiNgu.Text = dtNN.Rows[index][1].ToString();
                txtTrinhDo.Text = dtNN.Rows[index][2].ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from NGOAI_NGU where MANN = N'" + txtMaNN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtMaNN.Text) || string.IsNullOrEmpty(txtTenNgoaiNgu.Text) || string.IsNullOrEmpty(txtTrinhDo.Text))
            {
                MessageBox.Show("Bạn chưa điền thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNN.Focus();
            }
            else if (rd.Read())
            {
                MessageBox.Show("Mã ngoại ngữ đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNN.Focus();

            }
            else
            {
                kn.themMoiNN(txtMaNN.Text, txtTenNgoaiNgu.Text,txtTrinhDo.Text);
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadNN();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            kn.capNhatNN(txtMaNN.Text, txtTenNgoaiNgu.Text,txtTrinhDo.Text);
            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            loadNN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.xoaNN(txtMaNN.Text);
                loadNN();
            }
        }
    }
}
