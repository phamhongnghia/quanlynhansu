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
using QuanLyNhanSu.datasearch;

namespace QuanLyNhanSu
{
    public partial class frmTIM_KIEM_LUONG : Form
    {
        TimKiemLuong tk = new TimKiemLuong();
        DataSet ds = new DataSet();

        public frmTIM_KIEM_LUONG()
        {
            InitializeComponent();
            CenterToScreen();
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
            }
            else
            {
                if (ckbTheoMaNV.Checked == false && ckbTheoHoVaTen.Checked == false && ckbTheoMaPB.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn phương thức tìm kiếm !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ckbTheoMaNV.Checked == true)
                    {
                        ds = tk.timKiemLUONGMANV(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.ClearSelection();
                        }
                        else
                        {
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.Refresh();
                        }
                    }
                    else if (ckbTheoHoVaTen.Checked == true)
                    {
                        ds = tk.timKiemLUONGTENNV(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.ClearSelection();
                        }
                        else
                        {
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.Refresh();
                        }
                    }
                    else if (ckbTheoMaPB.Checked == true)
                    {
                        ds = tk.timKiemLUONGMAPB(nhapTT);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.ClearSelection();
                        }
                        else
                        {
                            dtgKetQuaLuong.DataSource = ds.Tables[0];
                            dtgKetQuaLuong.Refresh();
                        }
                    }
                }
            }
        }
    }
}
