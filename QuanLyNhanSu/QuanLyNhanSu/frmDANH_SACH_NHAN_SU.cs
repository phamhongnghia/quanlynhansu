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
using QuanLyNhanSu.database;

namespace QuanLyNhanSu
{
    public partial class frmDANH_SACH_NHAN_SU : Form
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
        DataTable dtXEMTHEM = new DataTable();
        DataSet dsDSNS = new DataSet();

        public frmDANH_SACH_NHAN_SU()
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

        void loadCMBPB()
        {
            dtLAYPB = knPB.layPB();
            cmbMaPhongBan.DataSource = null;
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

        void loadDSNS()
        {
            dsDSNS = kn.layDS();
            dtgNhanVien.DataSource = dsDSNS.Tables[0];
            dtgNhanVien.Refresh();
        }

        private void frmDANH_SACH_NHAN_SU_Load(object sender, EventArgs e)
        {
            loadCMBPB();
            loadCV();
            loadTDHV();
            loadMANN();
            loadBACLUONG();
            loadDSNS();
            if(taikhoanDN == "Công chức")
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        //CHỨC NĂNG

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string queQuan = txtQQuan.Text;
            string soDT = txtSDT.Text;
            string maPB = cmbMaPhongBan.SelectedValue.ToString();
            string maCV = cmbMaChucVu.SelectedValue.ToString();
            string maTDHV = cmbMaTDHV.SelectedValue.ToString();
            string maNN = cmbMaNN.SelectedValue.ToString();
            string bacLuong = cmbBacLuong.SelectedValue.ToString();
            if(string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Không thể cập nhật !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kn.capNHATCONGCHUC(maNV,queQuan,soDT,maPB,maCV,maTDHV,maNN,bacLuong);
                MessageBox.Show("Đã cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDSNS();
                cmbMaPhongBan.Enabled = false;
                cmbMaChucVu.Enabled = false;
                cmbMaTDHV.Enabled = false;
                cmbMaNN.Enabled = false;
                cmbBacLuong.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Không thể xóa !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn xóa !","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    kn.xoaCONGCHUC(maNV);
                    MessageBox.Show("Đã xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadDSNS();
                    loadCMBPB();
                    loadCV();
                    loadTDHV();
                    loadMANN();
                    loadBACLUONG();
                    txtMaNhanVien.Clear();
                    txtTenNhanVien.Clear();
                    txtDToc.Clear();
                    txtQQuan.Clear();
                    ckbNam.Checked = false;
                    ckbNu.Checked = false;
                    txtSDT.Clear();
                    cmbMaPhongBan.Enabled = false;
                    cmbMaChucVu.Enabled = false;
                    cmbMaTDHV.Enabled = false;
                    cmbMaNN.Enabled = false;
                    cmbBacLuong.Enabled = false;
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            dtXEMTHEM = kn.layXEMTHEM(maNV);
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Mời bạn chọn một công chức viên !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else
            {
                frmXEM_CHI_TIET frmXEM_CHI_TIET = new frmXEM_CHI_TIET();
                frmXEM_CHI_TIET.maNVXEMTHEM = dtXEMTHEM.Rows[0][0].ToString();
                frmXEM_CHI_TIET.Show();
            }
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

        private void dtgDSCONG_CHUC(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgNhanVien.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dtgNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtgNhanVien.Rows[index].Cells[1].Value.ToString();
            dtpNSinh.Value = DateTime.Parse(dtgNhanVien.Rows[index].Cells[2].Value.ToString());
            if(dtgNhanVien.Rows[index].Cells[3].Value.ToString() == "Nam")
            {
                ckbNam.Checked = true;
            }else if(dtgNhanVien.Rows[index].Cells[3].Value.ToString() == "Nữ")
            {
                ckbNu.Checked = true;
            }
            txtDToc.Text = dtgNhanVien.Rows[index].Cells[4].Value.ToString();
            txtQQuan.Text = dtgNhanVien.Rows[index].Cells[5].Value.ToString();
            txtSDT.Text = dtgNhanVien.Rows[index].Cells[6].Value.ToString();
            cmbMaPhongBan.Text = dtgNhanVien.Rows[index].Cells[7].Value.ToString();
            cmbMaPhongBan.Enabled = true;
            cmbMaChucVu.Text = dtgNhanVien.Rows[index].Cells[9].Value.ToString();
            cmbMaChucVu.Enabled = true;
            cmbMaTDHV.Text = dtgNhanVien.Rows[index].Cells[11].Value.ToString();
            cmbMaTDHV.Enabled = true;
            cmbMaNN.Text = dtgNhanVien.Rows[index].Cells[12].Value.ToString();
            cmbMaNN.Enabled = true;
            cmbBacLuong.Text = dtgNhanVien.Rows[index].Cells[13].Value.ToString();
            cmbBacLuong.Enabled = true;

            // load textbox

            int maPB = cmbMaPhongBan.SelectedIndex;
            if(maPB > -1)
            {
                DataRow dr = dtLAYPB.Rows[maPB];
                txtTenPB.Text = dr[1].ToString();
            }

            int maCV = cmbMaChucVu.SelectedIndex;
            if (maCV > -1)
            {
                DataRow dr = dtLAYCV.Rows[maCV];
                txtTenCV.Text = dr[1].ToString();
            }

            int maTDHV = cmbMaTDHV.SelectedIndex;
            if (maTDHV > -1)
            {
                DataRow dr = dtLAYTDHV.Rows[maTDHV];
                txtChuyenNganh.Text = dr[2].ToString();
            }

            int maNN = cmbMaNN.SelectedIndex;
            if (maNN > -1)
            {
                DataRow dr = dtLAYNN.Rows[maNN];
                txtTenNN.Text = dr[1].ToString();
            }
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
            if (maCV > -1)
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
    }
}
