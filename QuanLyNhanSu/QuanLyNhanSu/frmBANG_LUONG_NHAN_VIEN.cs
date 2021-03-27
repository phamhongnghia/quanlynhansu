using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.database;

namespace QuanLyNhanSu
{
    public partial class frmBANG_LUONG_NHAN_VIEN : Form
    {
        KetNoi_LUONG_NHAN_SU knLUONG = new KetNoi_LUONG_NHAN_SU();
        DataSet ds = new DataSet();
        public frmBANG_LUONG_NHAN_VIEN()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void loadDSLUONG()
        {
            ds = knLUONG.layDSLUONG();
            dtgLuongNhanSu.DataSource = ds.Tables[0];
            dtgLuongNhanSu.Refresh();
        }

        private void frmBANG_LUONG_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            loadDSLUONG();
        }

        private void dtgBANG_LUONG_NHAN_VIEN(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgLuongNhanSu.CurrentCell.RowIndex;
            txtMaNV.Text = dtgLuongNhanSu.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dtgLuongNhanSu.Rows[index].Cells[1].Value.ToString();
            txtTenPhongBan.Text = dtgLuongNhanSu.Rows[index].Cells[2].Value.ToString();
            txtTenChucVu.Text = dtgLuongNhanSu.Rows[index].Cells[3].Value.ToString();
            txtTienLuong.Text = dtgLuongNhanSu.Rows[index].Cells[7].Value.ToString();
        }
    }
}
