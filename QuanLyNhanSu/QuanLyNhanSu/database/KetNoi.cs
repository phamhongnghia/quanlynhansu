using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=DangNhap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        public KetNoi()
        {
            conn = new SqlConnection(connect);
        }
        public DataTable layTaiKhoan(string username)
        {
            string sql = "select * from TAI_KHOAN where username = '" + username + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void taoTaiKhoan(string username, string password, string fullname,string authern)
        {
            conn.Open();
            string sql = "insert into TAI_KHOAN values('"+username+"','"+password+"',N'"+fullname+"',N'"+authern+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaTaiKhoan(string username)
        {
            conn.Open();
            string sql = "delete from TAI_KHOAN where username = '" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void capNhat(string username,string pass)
        {
            conn.Open();
            string sql = "update TAI_KHOAN set password = '" + pass + "' where username = '"+username+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
