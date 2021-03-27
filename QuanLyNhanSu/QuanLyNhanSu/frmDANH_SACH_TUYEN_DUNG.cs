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
using QuanLyNhanSu.databasetuyendung;

namespace QuanLyNhanSu
{
    public partial class frmDANH_SACH_TUYEN_DUNG : Form
    {
        KetNoi_TUYEN_DUNG kn = new KetNoi_TUYEN_DUNG();
        DataSet ds = null;
        public frmDANH_SACH_TUYEN_DUNG()
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

        void loadDSTD()
        {
            ds = kn.layHOSO();
            dtgDanhSachTuyenDung.DataSource = ds.Tables[0];
            dtgDanhSachTuyenDung.Refresh();
        }

        private void frmDANH_SACH_TUYEN_DUNG_Load(object sender, EventArgs e)
        {
            loadDSTD();
            if(taikhoanDN == "Công chức")
            {
                txtKetQua.Enabled = false;
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }

        private void dtgDanhSach(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgDanhSachTuyenDung.CurrentCell.RowIndex;
            txtMaHoSo.Text = dtgDanhSachTuyenDung.Rows[index].Cells[0].Value.ToString();
            txtHoVaTen.Text = dtgDanhSachTuyenDung.Rows[index].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoSo.Text))
            {
                MessageBox.Show("Không thể xóa !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kn.xoaHOSO(txtMaHoSo.Text);
                    MessageBox.Show("Đã xóa !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadDSTD();
                    txtMaHoSo.Clear();
                }
                else
                {
                    btnXoa.Focus();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maHOSO = txtMaHoSo.Text;
            string ketQUA = txtKetQua.Text;
            if (string.IsNullOrEmpty(maHOSO))
            {
                MessageBox.Show("Không thể cập nhật !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetQua.Focus();
            }else if (string.IsNullOrEmpty(ketQUA))
            {
                MessageBox.Show("Không thể cập nhật !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetQua.Focus();
            }
            else
            {
                kn.capNhatKetQua(maHOSO, ketQUA);
                MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDSTD();
                txtKetQua.Clear();
            }
        }
    }
}
