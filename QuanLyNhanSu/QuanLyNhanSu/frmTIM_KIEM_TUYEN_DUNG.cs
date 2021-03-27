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

namespace QuanLyNhanSu
{
    public partial class frmTIM_KIEM_TUYEN_DUNG : Form
    {
        TimKiemTuyenDung kn = new TimKiemTuyenDung();
        DataSet ds = null;
        public frmTIM_KIEM_TUYEN_DUNG()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ckbTheoMaHoSo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTheoMaHoSo.Checked == true)
            {
                ckbTheoHoVaTen.Checked = false;
            }
        }

        private void ckbTheoHoVaTen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTheoHoVaTen.Checked == true)
            {
                ckbTheoMaHoSo.Checked = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (ckbTheoMaHoSo.Checked == false && ckbTheoHoVaTen.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn cách thức !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ckbTheoMaHoSo.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNhapTT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds = kn.tKiemMAHOSO(txtNhapTT.Text);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtgNhanVienKetQua.DataSource = ds.Tables[0];
                        dtgNhanVienKetQua.ClearSelection();
                    }
                    else
                    {
                        dtgNhanVienKetQua.DataSource = ds.Tables[0];
                        dtgNhanVienKetQua.Refresh();
                    }
                }
            }
            else if (ckbTheoHoVaTen.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNhapTT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds = kn.tKiemTen(txtNhapTT.Text);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtgNhanVienKetQua.DataSource = ds.Tables[0];
                        dtgNhanVienKetQua.ClearSelection();
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
}
