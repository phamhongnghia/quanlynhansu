using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_CHUC_VU
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_CHUC_VU()
        {
            conn = new SqlConnection(connect);
        }

        public DataTable layCHUC_VU()
        {
            string sql = "select * from CHUC_VU";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;

        }

        public void themMoiCV(string maCV, string tenCV)
        {
            conn.Open();
            string sql = "insert into CHUC_VU values (N'" + maCV + "',N'" + tenCV + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatCV(string maCV, string tenCV)
        {
            conn.Open();
            string sql = "update CHUC_VU set TENCV = N'" + tenCV + "' where MACV = N'" + maCV + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaCV(string maCV)
        {
            conn.Open();
            string sql = "delete from CHUC_VU where MACV = N'" + maCV + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
