using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_LUONG_NHAN_SU
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_LUONG_NHAN_SU()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet layDSLUONG()
        {
            string sql = "select nv.MANV,nv.HOTENNV,pb.TENPB,cv.TENCV,lg.BACLUONG,lg.LUONGCOBAN,(lg.HESOPHUCAP*150000)'LUONGPHUCAP',((lg.LUONGCOBAN*lg.HESOLUONG)+(lg.HESOPHUCAP*150000))'TIENLUONG' from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV join LUONG_NHAN_VIEN lg on nv.BACLUONG = lg.BACLUONG";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }
    }
}
