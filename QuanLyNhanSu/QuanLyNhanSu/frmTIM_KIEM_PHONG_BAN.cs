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
using QuanLyNhanSu.datasearch;

namespace QuanLyNhanSu
{
    public partial class frmTIM_KIEM_PHONG_BAN : Form
    {
        TimKiemPhongBan kn = new TimKiemPhongBan();
        DataSet ds = new DataSet();
        public frmTIM_KIEM_PHONG_BAN()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void loadTKMPB()
        {
        }

        private void ckbTheoMaPB_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTheoMaPB.Checked == true)
            {
                ckbTenPB.Checked = false;
            }
        }

        private void ckbTenPB_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTenPB.Checked == true)
            {
                ckbTheoMaPB.Checked = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(ckbTheoMaPB.Checked == false && ckbTenPB.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn cách thức !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(ckbTheoMaPB.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNhapTT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds = kn.tKiemPB(txtNhapTT.Text);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dtgPhongBanKetQua.DataSource = ds.Tables[0];
                        dtgPhongBanKetQua.Refresh();
                    }
                }
            }else if(ckbTenPB.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNhapTT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds = kn.tKiemTenPB(txtNhapTT.Text);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dtgPhongBanKetQua.DataSource = ds.Tables[0];
                        dtgPhongBanKetQua.Refresh();
                    }
                }
            }
        }
    }
}
