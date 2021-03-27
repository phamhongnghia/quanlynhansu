using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.datasearch
{
    class TimKiemLuong
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public TimKiemLuong()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet timKiemLUONGMANV(string maNV)
        {
            string sql = "select nv.MANV,nv.HOTENNV,pb.TENPB,cv.TENCV,lg.BACLUONG,lg.LUONGCOBAN,(lg.HESOPHUCAP*150000)'LUONGPHUCAP',((lg.LUONGCOBAN*lg.HESOLUONG)+(lg.HESOPHUCAP*150000))'TIENLUONG' from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV join LUONG_NHAN_VIEN lg on nv.BACLUONG = lg.BACLUONG where nv.MANV = '"+maNV+"'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet timKiemLUONGTENNV(string tenNV)
        {
            string sql = "select nv.MANV,nv.HOTENNV,pb.TENPB,cv.TENCV,lg.BACLUONG,lg.LUONGCOBAN,(lg.HESOPHUCAP*150000)'LUONGPHUCAP',((lg.LUONGCOBAN*lg.HESOLUONG)+(lg.HESOPHUCAP*150000))'TIENLUONG' from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV join LUONG_NHAN_VIEN lg on nv.BACLUONG = lg.BACLUONG where nv.HOTENNV = N'" + tenNV + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet timKiemLUONGMAPB(string maPB)
        {
            string sql = "select nv.MANV,nv.HOTENNV,pb.TENPB,cv.TENCV,lg.BACLUONG,lg.LUONGCOBAN,(lg.HESOPHUCAP*150000)'LUONGPHUCAP',((lg.LUONGCOBAN*lg.HESOLUONG)+(lg.HESOPHUCAP*150000))'TIENLUONG' from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV join LUONG_NHAN_VIEN lg on nv.BACLUONG = lg.BACLUONG where nv.MAPB = '" + maPB + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }
    }
}
