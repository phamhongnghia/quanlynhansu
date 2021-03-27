using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhanSu.datasearch
{
    class TimKiemTuyenDung
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyTuyenDung;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public TimKiemTuyenDung()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet tKiemMAHOSO(string maHOSO)
        {
            string sql = "select MAHOSO,HOVATEN,NGAYSINH,GIOITINH,DANTOC,DIACHI,SODIENTHOAI,KETQUA from HO_SO_TUYEN_DUNG where MAHOSO = '" + maHOSO + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataSet tKiemTen(string ten)
        {
            string sql = "select MAHOSO,HOVATEN,NGAYSINH,GIOITINH,DANTOC,DIACHI,SODIENTHOAI,KETQUA from HO_SO_TUYEN_DUNG where HOVATEN = N'" + ten + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
