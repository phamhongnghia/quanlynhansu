using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.database;

namespace QuanLyNhanSu
{
    public partial class frmDANH_SACH_PHONG_BAN : Form
    {
        KetNoi_PHONG_BAN kn = new KetNoi_PHONG_BAN();
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        public frmDANH_SACH_PHONG_BAN()
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
        void loadPHONG_BAN()
        {
            conn = new SqlConnection(connect);
            string sql = "select * from PHONG_BAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgPhongBan.DataSource = ds.Tables[0];
            dtgPhongBan.Refresh();
        }

        private void frmDANH_SACH_PHONG_BAN_Load(object sender, EventArgs e)
        {
            loadPHONG_BAN();
            if(taikhoanDN == "Công chức")
            {
                btnTaiLai.Enabled = false;
                btnThemMoi.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            loadPHONG_BAN();
            txtMaPhongBan.Clear();
            txtMaPhongBan.ReadOnly = false;
            txtTenPhongBan.ReadOnly = false;
            txtTenPhongBan.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPhongBan.Text;
            string tenPB = txtTenPhongBan.Text;
            string sdtPB = txtSoDienThoai.Text;
            string diachiPB = txtDiaChi.Text;
            if(txtMaPhongBan.ReadOnly == false && txtTenPhongBan.ReadOnly == false)
            {
                if(string.IsNullOrEmpty(txtMaPhongBan.Text) || string.IsNullOrEmpty(txtTenPhongBan.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Không có dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhongBan.Focus();
                }
                else { 
                    kn.themMoiPB(maPB, tenPB, sdtPB, diachiPB);
                    MessageBox.Show("Thêm mới thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadPHONG_BAN();
                    txtMaPhongBan.Clear();
                    txtTenPhongBan.Clear();
                    txtSoDienThoai.Clear();
                    txtDiaChi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPhongBan.Text;
            string sdtPB = txtSoDienThoai.Text;
            string diachiPB = txtDiaChi.Text;
            if(string.IsNullOrEmpty(sdtPB) || string.IsNullOrEmpty(diachiPB))
            {
                MessageBox.Show("Thiếu thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kn.capNhatPB(maPB, sdtPB, diachiPB);
                MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadPHONG_BAN();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPhongBan.Text;
            if (string.IsNullOrEmpty(txtMaPhongBan.Text) || string.IsNullOrEmpty(txtTenPhongBan.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Không thể xóa !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kn.xoaPB(maPB);
                    loadPHONG_BAN();
                    txtMaPhongBan.Clear();
                    txtTenPhongBan.Clear();
                    txtSoDienThoai.Clear();
                    txtDiaChi.Clear();
                }
                else
                {
                    txtSoDienThoai.Focus();
                }
            }
        }

        private void dtgPHONGBAN(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgPhongBan.CurrentCell.RowIndex;
            txtMaPhongBan.Text = dtgPhongBan.Rows[index].Cells[0].Value.ToString();
            txtMaPhongBan.ReadOnly = true;
            txtTenPhongBan.Text = dtgPhongBan.Rows[index].Cells[1].Value.ToString();
            txtTenPhongBan.ReadOnly = true;
            txtSoDienThoai.Text = dtgPhongBan.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dtgPhongBan.Rows[index].Cells[3].Value.ToString();
        }
        
    }
}
