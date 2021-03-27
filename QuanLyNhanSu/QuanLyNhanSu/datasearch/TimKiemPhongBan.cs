using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.datasearch
{
    class TimKiemPhongBan
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public TimKiemPhongBan()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet tKiemPB(string maPB)
        {
            string sql = "select * from PHONG_BAN where MAPB = '" + maPB + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public DataSet tKiemTenPB(string tenPB)
        {
            string sql = "select * from PHONG_BAN where TENPB = N'" + tenPB + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
}
