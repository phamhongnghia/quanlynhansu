using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_TRINH_DO_HOC_VAN
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_TRINH_DO_HOC_VAN()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet layTDHV()
        {
            string sql = "select * from TRINH_DO_HOC_VAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable layMATDHV()
        {
            string sql = "select * from TRINH_DO_HOC_VAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void themMoiTDHV(string maTDHV, string tenTDHV, string chuyenNganh)
        {
            conn.Open();
            string sql = "insert into TRINH_DO_HOC_VAN values (N'" + maTDHV + "',N'" + tenTDHV + "',N'" + chuyenNganh + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNhatTDHV(string maTDHV, string tenTDHV, string chuyenNganh)
        {
            conn.Open();
            string sql = "update TRINH_DO_HOC_VAN set TENTDHV = N'" + tenTDHV + "', CHUYENNGANH = N'" + chuyenNganh + "' where MATDHV = N'" + maTDHV + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaTDHV(string maTDHV)
        {
            conn.Open();
            string sql = "delete from TRINH_DO_HOC_VAN where MATDHV = N'" + maTDHV + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
