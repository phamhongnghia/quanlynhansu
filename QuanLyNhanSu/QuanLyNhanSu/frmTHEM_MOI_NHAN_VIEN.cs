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
    public partial class frmTHEM_MOI_NHAN_VIEN : Form
    {
        KetNoi_NHAN_SU kn = new KetNoi_NHAN_SU();
        KetNoi_PHONG_BAN knPB = new KetNoi_PHONG_BAN();
        KetNoi_CHUC_VU knCV = new KetNoi_CHUC_VU();
        KetNoi_TRINH_DO_HOC_VAN knTDHV = new KetNoi_TRINH_DO_HOC_VAN();
        KetNoiNGOAI_NGU knNN = new KetNoiNGOAI_NGU();
        KetNoi_BAC_LUONG knBACLUONG = new KetNoi_BAC_LUONG();
        DataTable dtLAYPB = new DataTable();
        DataTable dtLAYCV = new DataTable();
        DataTable dtLAYTDHV = new DataTable();
        DataTable dtLAYNN = new DataTable();
        DataTable dtLAYBACLUONG = new DataTable();
        DataSet dsDSTHEMMOI = new DataSet();

        public frmTHEM_MOI_NHAN_VIEN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadCMBPB()
        {
            dtLAYPB = knPB.layPB();
            cmbMaPhongBan.DataSource = null ;
            cmbMaPhongBan.DataSource = dtLAYPB;
            cmbMaPhongBan.ValueMember = "MAPB";
            cmbMaPhongBan.DisplayMember = "MAPB";
        }

        void loadCV()
        {
            dtLAYCV = knCV.layCHUC_VU();
            cmbMaChucVu.DataSource = null;
            cmbMaChucVu.DataSource = dtLAYCV;
            cmbMaChucVu.ValueMember = "MACV";
            cmbMaChucVu.DisplayMember = "MACV";
        }

        void loadTDHV()
        {
            dtLAYTDHV = knTDHV.layMATDHV();
            cmbMaTDHV.DataSource = null;
            cmbMaTDHV.DataSource = dtLAYTDHV;
            cmbMaTDHV.ValueMember = "MATDHV";
            cmbMaTDHV.DisplayMember = "MATDHV";
        }

        void loadMANN()
        {
            dtLAYNN = knNN.layNN();
            cmbMaNN.DataSource = null;
            cmbMaNN.DataSource = dtLAYNN;
            cmbMaNN.ValueMember = "MANN";
            cmbMaNN.DisplayMember = "MANN";
        }

        void loadBACLUONG()
        {
            dtLAYBACLUONG = knBACLUONG.layBACLUONG();
            cmbBacLuong.DataSource = null;
            cmbBacLuong.DataSource = dtLAYBACLUONG;
            cmbBacLuong.ValueMember = "BACLUONG";
            cmbBacLuong.DisplayMember = "BACLUONG";
        }

        void loadDSTHEMMOI()
        {
            dsDSTHEMMOI = kn.layDSNS();
            dtgNhanVien.DataSource = dsDSTHEMMOI.Tables[0];
            dtgNhanVien.Refresh();
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
            if (ckbNu.Checked == true)
            {
                ckbNam.Checked = false;
            }
        }

        private void frmTHEM_MOI_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            loadCMBPB();
            loadCV();
            loadTDHV();
            loadMANN();
            loadBACLUONG();
            loadDSTHEMMOI();
        }

        private void cmbMaPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maPB = cmbMaPhongBan.SelectedIndex;
            if (maPB > -1)
            {
                DataRow dr = dtLAYPB.Rows[maPB];
                txtTenPB.Text = dr[1].ToString();
            }
        }

        private void cmbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maCV = cmbMaChucVu.SelectedIndex;
            if(maCV > -1)
            {
                DataRow dr = dtLAYCV.Rows[maCV];
                txtTenCV.Text = dr[1].ToString();
            }
        }

        private void cmbMaTDHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maTDHV = cmbMaTDHV.SelectedIndex;
            if (maTDHV > -1)
            {
                DataRow dr = dtLAYTDHV.Rows[maTDHV];
                txtChuyenNganh.Text = dr[2].ToString();
            }
        }

        private void cmbMaNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNN = cmbMaNN.SelectedIndex;
            if (maNN > -1)
            {
                DataRow dr = dtLAYNN.Rows[maNN];
                txtTenNN.Text = dr[1].ToString();
            }
        }

        private void cmbBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Kiểm tra nhập dữ liệu
        
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Khai báo
            string maNV = txtMaNV.Text;
            string hoTenNV = txtHoTen.Text;
            string ngaySinh = dtpNSinh.Value.ToShortDateString();
            string gioiTinh = null;
            if(ckbNam.Checked == true)
            {
                gioiTinh = "Nam";
            }else if (ckbNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string danToc = txtDToc.Text;
            string queQuan = txtQQuan.Text;
            string soDT = txtSDT.Text;
            string maPB = cmbMaPhongBan.SelectedValue.ToString();
            string maCV = cmbMaChucVu.SelectedValue.ToString();
            string maTDHV = cmbMaTDHV.SelectedValue.ToString();
            string maNN = cmbMaNN.SelectedValue.ToString();
            string bacLuong = cmbBacLuong.SelectedValue.ToString();

            string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = null;
            conn = new SqlConnection(connect);
            conn.Open();
            string sql = "select * from NHAN_VIEN where MANV = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDToc.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtQQuan.Text))
            {
                MessageBox.Show("Không đủ dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
            }
            else if(rd.Read())
            {
                MessageBox.Show("Mã nhân viên đã tồn tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.SelectAll();
            }
            else
            {
                kn.themMOICONGCHUC(maNV, hoTenNV, ngaySinh, gioiTinh, danToc, queQuan, soDT, maPB, maCV, maTDHV, maNN, bacLuong);
                txtHoTen.Clear();
                ckbNam.Checked = false;
                ckbNu.Checked = false;
                txtDToc.Clear();
                txtSDT.Clear();
                txtQQuan.Clear();
                loadDSTHEMMOI();
                txtMaNV.Text = "MSCC-";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDToc.Clear();
            ckbNam.Checked = false;
            ckbNu.Checked = false;
            txtQQuan.Clear();
            txtSDT.Clear();
        }
    }
}
