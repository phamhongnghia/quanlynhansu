using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.datasearch;
using QuanLyNhanSu.database;
using System.Data;

namespace QuanLyNhanSu
{
    public partial class frmTIM_KIEM_NHAN_VIEN : Form
    {
        TimKiemNhanSu tk = new TimKiemNhanSu();
        KetNoi_NHAN_SU kn = new KetNoi_NHAN_SU();
        DataSet ds = new DataSet();
        DataTable dtXEMTHEM = new DataTable();
        public frmTIM_KIEM_NHAN_VIEN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmTIM_KIEM_NHAN_VIEN_Load(object sender, EventArgs e)
        {
           
        }

        private void ckbTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTheoMaNV.Checked == true)
            {
                ckbTheoMaPB.Checked = false;
                ckbTheoHoVaTen.Checked = false;
            }
        }

        private void ckbTheoMaPB_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTheoMaPB.Checked == true)
            {
                ckbTheoMaNV.Checked = false;
                ckbTheoHoVaTen.Checked = false;
            }
        }

        private void ckbTheoHoVaTen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTheoHoVaTen.Checked == true)
            {
                ckbTheoMaNV.Checked = false;
                ckbTheoMaPB.Checked = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string nhapTT = txtNhapTT.Text;
            if (string.IsNullOrEmpty(nhapTT))
            {
                MessageBox.Show("Bạn chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapTT.Focus();
            } else
            {
                if (ckbTheoMaNV.Checked == false && ckbTheoHoVaTen.Checked == false && ckbTheoMaPB.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn phương thức tìm kiếm !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(ckbTheoMaNV.Checked == true)
                    {
                        ds = tk.timKiemMANV(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.ClearSelection();
                            txtMaCC.Clear();
                        }
                        else
                        {
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.Refresh();
                        }
                    }else if(ckbTheoHoVaTen.Checked == true)
                    {
                        ds = tk.timKiemTENNV(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.ClearSelection();
                            txtMaCC.Clear();
                        }
                        else
                        {
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.Refresh();
                        }
                    }else if(ckbTheoMaPB.Checked == true)
                    {
                        ds = tk.timKiemMAPB(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.ClearSelection();
                            txtMaCC.Clear();
                        }
                        else
                        {
                            dtgNhanVienKetQua.DataSource = ds.Tables[0];
                            dtgNhanVienKetQua.Refresh();
                        }
                    }
                }
            }
        }

        private void dtgKetQua_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgNhanVienKetQua.CurrentCell.RowIndex;
            txtMaCC.Text = dtgNhanVienKetQua.Rows[index].Cells[0].Value.ToString();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maNV = txtMaCC.Text;
            dtXEMTHEM = kn.layXEMTHEM(maNV);
            if (string.IsNullOrEmpty(txtMaCC.Text))
            {
                MessageBox.Show("Không có kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                frmXEM_CHI_TIET frmXEM_CHI_TIET = new frmXEM_CHI_TIET();
                frmXEM_CHI_TIET.maNVXEMTHEM = dtXEMTHEM.Rows[0][0].ToString();
                frmXEM_CHI_TIET.Show();
            }
        }
    }
}
