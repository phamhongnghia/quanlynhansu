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
    public partial class frmTRINH_DO_HOC_VAN : Form
    {
        KetNoi_TRINH_DO_HOC_VAN kn = new KetNoi_TRINH_DO_HOC_VAN();
        DataSet ds = null;

        private string taikhoanDN;
        public string TaikhoanDN
        {
            get { return taikhoanDN; }
            set { taikhoanDN = value; }
        }

        public frmTRINH_DO_HOC_VAN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadTDHV()
        {
            ds = kn.layTDHV();
            dtgTrinhDoHocVan.DataSource = ds.Tables[0];
            dtgTrinhDoHocVan.Refresh();
        }

        private void frmTRINH_DO_HOC_VAN_Load(object sender, EventArgs e)
        {
            loadTDHV();
            if (taikhoanDN == "Công chức")
            {
                btnThemMoi.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void dtgTDHV(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgTrinhDoHocVan.CurrentCell.RowIndex;
            txtMaTrinhDo.Text = dtgTrinhDoHocVan.Rows[index].Cells[0].Value.ToString();
            txtTenTrinhDo.Text = dtgTrinhDoHocVan.Rows[index].Cells[1].Value.ToString();
            txtChuyenNganh.Text = dtgTrinhDoHocVan.Rows[index].Cells[2].Value.ToString();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from TRINH_DO_HOC_VAN where MATDHV = N'" + txtMaTrinhDo.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtMaTrinhDo.Text) || string.IsNullOrEmpty(txtTenTrinhDo.Text) || string.IsNullOrEmpty(txtChuyenNganh.Text))
            {
                MessageBox.Show("Bạn chưa điền thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTrinhDo.Focus();
            }
            else if (rd.Read())
            {
                MessageBox.Show("Mã trình độ học vấn đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTrinhDo.Focus();

            }
            else
            {
                kn.themMoiTDHV(txtMaTrinhDo.Text, txtTenTrinhDo.Text, txtChuyenNganh.Text);
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadTDHV();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            kn.capNhatTDHV(txtMaTrinhDo.Text, txtTenTrinhDo.Text, txtChuyenNganh.Text);
            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            loadTDHV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.xoaTDHV(txtMaTrinhDo.Text);
                loadTDHV();
            }
        }
    }
}
