using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoiNGOAI_NGU
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoiNGOAI_NGU()
        {
            conn = new SqlConnection(connect);
        }

        public DataTable layNN()
        {
            string sql = "select * from NGOAI_NGU";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void themMoiNN(string maNN, string tenNN, string trinhDo)
        {
            conn.Open();
            string sql = "insert into NGOAI_NGU values (N'" + maNN + "',N'" + tenNN + "','" + trinhDo + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatNN(string maNN, string tenNN, string trinhDo)
        {
            conn.Open();
            string sql = "update NGOAI_NGU set TENNN = N'" + tenNN + "', TRINHDO = N'" + trinhDo + "' where MANN = N'" + maNN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaNN(string maNN)
        {
            conn.Open();
            string sql = "delete from NGOAI_NGU where MANN = N'" + maNN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
