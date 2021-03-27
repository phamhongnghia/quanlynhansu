using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.datasearch
{
    class TimKiemNhanSu
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public TimKiemNhanSu()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet timKiemMANV(string maNV)
        {
            string sql = "select MANV,HOTENNV,NGAYSINH,GIOITINH,DANTOC,QUEQUAN,nv.SODIENTHOAI,pb.TENPB,cv.TENCV from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV where MANV = N'" + maNV + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet timKiemTENNV(string tenNV)
        {
            string sql = "select MANV,HOTENNV,NGAYSINH,GIOITINH,DANTOC,QUEQUAN,nv.SODIENTHOAI,pb.TENPB,cv.TENCV from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV where HOTENNV = N'" + tenNV + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet timKiemMAPB(string maPB)
        {
            string sql = "select MANV,HOTENNV,NGAYSINH,GIOITINH,DANTOC,QUEQUAN,nv.SODIENTHOAI,pb.TENPB,cv.TENCV from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV where nv.MAPB = N'" + maPB + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }
    }
}
