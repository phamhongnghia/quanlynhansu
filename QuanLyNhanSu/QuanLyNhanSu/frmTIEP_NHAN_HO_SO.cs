using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhanSu.databasetuyendung;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmTIEP_NHAN_HO_SO : Form
    {
        KetNoi_TUYEN_DUNG kn = new KetNoi_TUYEN_DUNG();
        DataSet ds = null;
        DataTable dtTDHV = null;
        DataTable dtNN = null;
        public frmTIEP_NHAN_HO_SO()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadTDHV()
        {
            dtTDHV = kn.layTDHV();
            cmbTDHV.DataSource = null;
            cmbTDHV.DataSource = dtTDHV;
            cmbTDHV.ValueMember = "MATDHV";
            cmbTDHV.DisplayMember = "MATDHV";
        }

        void loadDSTD()
        {
            ds = kn.layDSTD();
            dtgDanhSachTuyenDung.DataSource = ds.Tables[0];
            dtgDanhSachTuyenDung.Refresh();
        }

        void loadNN()
        {
            dtNN = kn.layNN();
            cmbNgoaiNgu.DataSource = null;
            cmbNgoaiNgu.DataSource = dtNN;
            cmbNgoaiNgu.ValueMember = "MANN";
            cmbNgoaiNgu.DisplayMember = "MANN";
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNam.Checked == true)
            {
                ckbNu.Checked = false;
            }
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNu.Checked == true)
            {
                ckbNam.Checked = false;
            }
        }

        private void frmTIEP_NHAN_HO_SO_Load(object sender, EventArgs e)
        {
            loadTDHV();
            loadNN();
            loadDSTD();
            txtMaHoSo.Focus();
        }

        private void cmbTDHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maTDHV = cmbTDHV.SelectedIndex;
            if (maTDHV > -1)
            {
                DataRow dr = dtTDHV.Rows[maTDHV];
                txtCNTDHV.Text = dr[2].ToString();
            }
        }

        private void cmbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNN = cmbNgoaiNgu.SelectedIndex;
            if (maNN > -1)
            {
                DataRow dr = dtNN.Rows[maNN];
                txtTenNN.Text = dr[1].ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maHoSo = txtMaHoSo.Text;
            string hoVaTen = txtHoVaTen.Text;
            string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
            string gioiTinh = null;
            if(ckbNam.Checked == true)
            {
                gioiTinh = "Nam";
            }else if(ckbNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string danToc = txtDanToc.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string maTDHV = cmbTDHV.SelectedValue.ToString();
            string maNN = cmbNgoaiNgu.SelectedValue.ToString();
            string ketQua = "Đợi kết quả";

            //Kiểm tra nhập

            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyTuyenDung;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from HO_SO_TUYEN_DUNG where MAHOSO = '" + txtMaHoSo.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();

            if (string.IsNullOrEmpty(maHoSo) || string.IsNullOrEmpty(hoVaTen) || string.IsNullOrEmpty(danToc) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Không có dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rd.Read())
            {
                MessageBox.Show("Mã hồ sơ đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoSo.Focus();
                txtMaHoSo.SelectAll();
            }else
            {
                kn.themMoiHoSo(maHoSo, hoVaTen, ngaySinh, gioiTinh, danToc, diaChi, soDienThoai, maTDHV, maNN, ketQua);
                MessageBox.Show("Đã thêm hồ sơ thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHoSo.Clear();
                txtHoVaTen.Clear();
                txtDanToc.Clear();
                txtDiaChi.Clear();
                txtSoDienThoai.Clear();
                ckbNam.Checked = false;
                ckbNu.Checked = false;
                loadDSTD();
                txtMaHoSo.Text = "MS-";
            }
        }

    }
}
