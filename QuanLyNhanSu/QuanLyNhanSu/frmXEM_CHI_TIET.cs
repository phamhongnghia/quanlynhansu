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
    public partial class frmXEM_CHI_TIET : Form
    {
        KetNoi_NHAN_SU kn = new KetNoi_NHAN_SU();
        DataTable dt = new DataTable();

        private string manv;
        public string maNVXEMTHEM
        {
            get { return manv; }
            set { manv = value; }
        }

        public frmXEM_CHI_TIET()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmXEM_CHI_TIET_Load(object sender, EventArgs e)
        {
            dt = kn.layXEMTHEM(manv);
            txtMaNhanVien.Text = manv;
            txtHoVaTen.Text = dt.Rows[0][0].ToString();
            txtHoVaTen.Text = dt.Rows[0][1].ToString();
            if(dt.Rows[0][2].ToString() == "Nam")
            {
                ckbNam.Checked = true;
            }else if(dt.Rows[0][2].ToString() == "Nữ")
            {
                ckbNu.Checked = true;
            }
            txtSDT.Text = dt.Rows[0][3].ToString();
            txtPhongBan.Text = dt.Rows[0][4].ToString();
            txtChucVu.Text = dt.Rows[0][5].ToString();
            txtTenTrinhDo.Text = dt.Rows[0][6].ToString();
            txtChuyenNganh.Text = dt.Rows[0][7].ToString();
            txtTenNN.Text = dt.Rows[0][8].ToString();
            txtTrinhDoNgoaiNgu.Text = dt.Rows[0][9].ToString();
            txtBacLuong.Text = dt.Rows[0][10].ToString();
            txtLuong.Text = dt.Rows[0][11].ToString();
        }
    }
}
