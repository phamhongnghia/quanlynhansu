using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_PHONG_BAN
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_PHONG_BAN()
        {
            conn = new SqlConnection(connect);
        }

        public DataTable layPB()
        {
            string sql = "select * from PHONG_BAN";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void themMoiPB(string maPB, string tenPB, string sdtPB, string diachiPB)
        {
            conn.Open();
            string sql = "insert into PHONG_BAN values ('"+maPB+"',N'"+tenPB+"','"+sdtPB+"',N'"+diachiPB+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatPB(string maPB, string sdtPB, string diachiPB)
        {
            conn.Open();
            string sql = "update PHONG_BAN set SODIENTHOAI = '" + sdtPB + "', DIACHI = N'"+ diachiPB +"' where MAPB = '" + maPB + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaPB(string maPB)
        {
            conn.Open();
            string sql = "delete from PHONG_BAN where MAPB = '" + maPB + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
