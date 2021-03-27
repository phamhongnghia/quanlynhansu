using System;
using QuanLyNhanSu.database;
using System.Windows.Forms;
using QuanLyNhanSu.Properties;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhanSu
{
    public partial class frmQUAN_LY_NHAN_SU : Form
    {
        KetNoi kn = new KetNoi();
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string taikhoan;
        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        private string authern;
        public string Authern
        {
            get { return authern; }
            set { authern = value; }
        }
        public frmQUAN_LY_NHAN_SU()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        public void frmQUAN_LY_NHAN_SU_Load(object sender, EventArgs e)
        {
            if(authern == "Công chức")
            {
                btnTiepNhanNhanVien.Enabled = false;

                btnTiepNhanTuyenDung.Enabled = false;

                btnTaiKhoan.Enabled = false;
            }else if(authern == "Quản trị")
            {
                lkDangXuat.Text = username;
                trvCayThuMuc.ExpandAll();
            }
            lkDangXuat.Text = username;
            trvCayThuMuc.ExpandAll();
        }

        //Tab QUẢN LÝ NHÂN SỰ

        private void btnTiepNhanNhanVien_Click(object sender, EventArgs e)
        {
            frmTHEM_MOI_NHAN_VIEN frmTHEM_MOI_NHAN_VIEN = new frmTHEM_MOI_NHAN_VIEN();
            frmTHEM_MOI_NHAN_VIEN.Show();
        }

        private void btnHoSoNhanVien_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            frmDANH_SACH_NHAN_SU frmDANH_SACH_NHAN_SU = new frmDANH_SACH_NHAN_SU();
            dt = kn.layTaiKhoan(taikhoan);
            frmDANH_SACH_NHAN_SU.TaikhoanDN = dt.Rows[0][3].ToString();
            frmDANH_SACH_NHAN_SU.Show();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            frmDANH_SACH_PHONG_BAN frmDANH_SACH_PHONG_BAN = new frmDANH_SACH_PHONG_BAN();
            dt = kn.layTaiKhoan(taikhoan);
            frmDANH_SACH_PHONG_BAN.TaikhoanDN = dt.Rows[0][3].ToString();
            frmDANH_SACH_PHONG_BAN.Show();
        }

        //Danh mục khác

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.layTaiKhoan(taikhoan);
            frmCHUC_VU frmCHUC_VU = new frmCHUC_VU();
            frmCHUC_VU.TaikhoanDN = dt.Rows[0][3].ToString();
            frmCHUC_VU.Show();
        }

        private void btnTDHV_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.layTaiKhoan(taikhoan);
            frmTRINH_DO_HOC_VAN frmTRINH_DO_HOC_VAN = new frmTRINH_DO_HOC_VAN();
            frmTRINH_DO_HOC_VAN.TaikhoanDN = dt.Rows[0][3].ToString();
            frmTRINH_DO_HOC_VAN.Show();
        }

        private void btnNgoaiNgu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.layTaiKhoan(taikhoan);
            frmNGOAI_NGU frmNGOAI_NGU = new frmNGOAI_NGU();
            frmNGOAI_NGU.TaikhoanDN = dt.Rows[0][3].ToString();
            frmNGOAI_NGU.Show();
        }


        //Tab QUẢN LÝ TIỀN LƯƠNG

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            frmBANG_LUONG_NHAN_VIEN frmBANG_LUONG_NHAN_VIEN = new frmBANG_LUONG_NHAN_VIEN();
            frmBANG_LUONG_NHAN_VIEN.Show();
        }

        private void btnBacLuong_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.layTaiKhoan(taikhoan);
            frmBAC_LUONG frmBAC_LUONG = new frmBAC_LUONG();
            frmBAC_LUONG.TaikhoanDN = dt.Rows[0][3].ToString();
            frmBAC_LUONG.Show();
        }
       


        //Tab QUẢN LÝ TUYỂN DỤNG

        private void btnTiepNhanTuyenDung_Click(object sender, EventArgs e)
        {
            frmTIEP_NHAN_HO_SO frmTIEP_NHAN_HO_SO = new frmTIEP_NHAN_HO_SO();
            frmTIEP_NHAN_HO_SO.Show();
        }

        private void btnDanhSachTuyenDung_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.layTaiKhoan(taikhoan);
            frmDANH_SACH_TUYEN_DUNG frmDANH_SACH_TUYEN_DUNG = new frmDANH_SACH_TUYEN_DUNG();
            frmDANH_SACH_TUYEN_DUNG.TaikhoanDN = dt.Rows[0][3].ToString();
            frmDANH_SACH_TUYEN_DUNG.Show();
        }

        private void btnTimKiemKetQua_Click(object sender, EventArgs e)
        {
            frmTIM_KIEM_TUYEN_DUNG frmTIM_KIEM_TUYEN_DUNG = new frmTIM_KIEM_TUYEN_DUNG();
            frmTIM_KIEM_TUYEN_DUNG.Show();
        }


        //Tab TÌM KIẾM

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            frmTIM_KIEM_NHAN_VIEN frmTIM_KIEM_NHAN_VIEN = new frmTIM_KIEM_NHAN_VIEN();
            frmTIM_KIEM_NHAN_VIEN.Show();
        }

        private void btnTimKiemPhongBan_Click(object sender, EventArgs e)
        {
            frmTIM_KIEM_PHONG_BAN frmTIM_KIEM_PHONG_BAN = new frmTIM_KIEM_PHONG_BAN();
            frmTIM_KIEM_PHONG_BAN.Show();
        }

        private void btnTimKiemBacLuong_Click(object sender, EventArgs e)
        {
            frmTIM_KIEM_LUONG frmTIM_KIEM_LUONG = new frmTIM_KIEM_LUONG();
            frmTIM_KIEM_LUONG.Show();
        }


        //Tab HỖ TRỢ

        private void btnHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmTHONG_TIN frmTHONG_TIN = new frmTHONG_TIN();
            frmTHONG_TIN.Show();
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            frmTAI_LIEU frmTAI_LIEU = new frmTAI_LIEU();
            frmTAI_LIEU.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTAO_TAI_KHOAN frmTAO_TAI_KHOAN = new frmTAO_TAI_KHOAN();
            frmTAO_TAI_KHOAN.Show();
        }


        //Đăng xuất

        private void lkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất ?","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                frmDANG_NHAP frmDANG_NHAP = new frmDANG_NHAP();
                frmDANG_NHAP.Show();
                this.Hide();
            }
            
        }

        // Xử lý đóng form
        
        private void frmQUAN_LY_NHAN_SU_CLOSING(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ?","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

    }
}
