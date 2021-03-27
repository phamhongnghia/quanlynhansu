using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_BAC_LUONG
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_BAC_LUONG()
        {
            conn = new SqlConnection(connect);
        }

        public DataTable layBACLUONG()
        {
            string sql = "select * from LUONG_NHAN_VIEN";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void themMoiBACLUONG(string bacLuong, string luongCoBan, string heSoLuong, string heSoPhuCap)
        {
            conn.Open();
            string sql = "insert into LUONG_NHAN_VIEN values (N'" + bacLuong + "','" + luongCoBan + "','" + heSoLuong + "','" + heSoPhuCap + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatBACLUONG(string bacLuong, string luongCoBan, string heSoLuong, string heSoPhuCap)
        {
            conn.Open();
            string sql = "update LUONG_NHAN_VIEN set LUONGCOBAN = '" + luongCoBan + "', HESOLUONG = '" + heSoLuong + "', HESOPHUCAP = '" + heSoPhuCap + "' where BACLUONG = N'" + bacLuong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaBACLUONG(string bacLuong)
        {
            conn.Open();
            string sql = "delete from LUONG_NHAN_VIEN where BACLUONG = N'" + bacLuong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
