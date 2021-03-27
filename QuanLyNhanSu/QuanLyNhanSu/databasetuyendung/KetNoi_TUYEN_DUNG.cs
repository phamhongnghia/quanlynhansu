using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.databasetuyendung
{
    class KetNoi_TUYEN_DUNG
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyTuyenDung;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_TUYEN_DUNG()
        {
            conn = new SqlConnection(connect);
        }

        public DataTable layTDHV()
        {
            string sql = "select * from TRINH_DO_HOC_VAN";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public DataTable layNN()
        {
            string sql = "select * from NGOAI_" +
                "NGU";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        
        public DataSet layHOSO()
        {
            string sql = "select MAHOSO,HOVATEN,NGAYSINH,GIOITINH,DANTOC,DIACHI,SODIENTHOAI,KETQUA from HO_SO_TUYEN_DUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet layDSTD()
        {
            string sql = "select MAHOSO,HOVATEN,NGAYSINH,GIOITINH,DANTOC,DIACHI,SODIENTHOAI" +
                " from HO_SO_TUYEN_DUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void themMoiHoSo(string maHoSo, string hoVaTen, string ngaySinh, string gioiTinh, string danToc, string diaChi, string soDienThoai, string maTDHV, string maNN, string ketQua)
        {
            conn.Open();
            string sql = "insert into HO_SO_TUYEN_DUNG values ('" + maHoSo + "',N'" + hoVaTen + "','" + ngaySinh.ToString() + "',N'" + gioiTinh + "',N'" + danToc + "',N'" + diaChi + "','" + soDienThoai + "',N'" + maTDHV + "','" + maNN + "',N'" + ketQua + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatKetQua(string maHoSO,string ketQua)
        {
            conn.Open();
            string sql = "update HO_SO_TUYEN_DUNG set KETQUA = N'" + ketQua + "' where MAHOSO = '" + maHoSO + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaHOSO(string maHOSO)
        {
            conn.Open();
            string sql = "delete from HO_SO_TUYEN_DUNG where MAHOSO = '" + maHOSO + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
