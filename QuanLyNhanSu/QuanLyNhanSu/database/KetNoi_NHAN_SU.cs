using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.database
{
    class KetNoi_NHAN_SU
    {
        string connect = @"Data Source=DESKTOP-T8KM098;Initial Catalog=QuanLyNhanSuVaLuong;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        public KetNoi_NHAN_SU()
        {
            conn = new SqlConnection(connect);
        }

        public DataSet layDSNS()
        {
            string sql = "select MANV,HOTENNV,NGAYSINH,GIOITINH,DANTOC,QUEQUAN,SODIENTHOAI from NHAN_VIEN";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet layDS()
        {
            string sql = "select MANV,HOTENNV,NGAYSINH,GIOITINH,DANTOC,QUEQUAN,nv.SODIENTHOAI,nv.MAPB,pb.TENPB,nv.MACV,cv.TENCV,nv.MATDHV,nv.MANN,nv.BACLUONG from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV";
            //string sql = "select * from NHAN_VIEN";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        public DataTable layXEMTHEM(string maNV)
        {
            string sql = "select MANV,HOTENNV,GIOITINH,nv.SODIENTHOAI,pb.TENPB,cv.TENCV,tdhv.TENTDHV,tdhv.CHUYENNGANH,nn.TENNN,nn.TRINHDO,lg.BACLUONG,((lg.LUONGCOBAN*lg.HESOLUONG)+(lg.HESOPHUCAP*150000))'TIENLUONG' from NHAN_VIEN nv join PHONG_BAN pb on nv.MAPB = pb.MAPB join CHUC_VU cv on nv.MACV = cv.MACV join TRINH_DO_HOC_VAN tdhv on nv.MATDHV = tdhv.MATDHV join NGOAI_NGU nn on nv.MANN = nn.MANN join LUONG_NHAN_VIEN lg on nv.BACLUONG = lg.BACLUONG where MANV = '" + maNV + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void themMOICONGCHUC(string maNV, string hotenNV, string ngaySinh, string gioiTinh, string danToc, string queQuan, string soDT, string maPB, string maCV, string maTDHV, string maNN, string bacLuong)
        {
            conn.Open();
            string sql = "insert into NHAN_VIEN values ('" + maNV + "',N'" + hotenNV + "','" + ngaySinh.ToString() + "',N'" + gioiTinh + "',N'" + danToc + "',N'" + queQuan + "',N'" + soDT + "',N'" + maPB + "',N'" + maCV + "',N'" + maTDHV + "',N'"+maNN+"',N'"+bacLuong+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capNHATCONGCHUC(string maNV, string queQuan, string soDT, string maPB, string maCV, string maTDHV, string maNN, string bacLuong)
        {
            conn.Open();
            string sql = "update NHAN_VIEN set QUEQUAN = N'" + queQuan + "',SODIENTHOAI = N'" + soDT + "',MAPB = N'" + maPB + "',MACV = N'" + maCV + "',MATDHV = N'" + maTDHV + "',MANN = '" + maNN + "',BACLUONG = N'" + bacLuong + "' where MANV = '"+maNV+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaCONGCHUC(string maNV)
        {
            conn.Open();
            string sql = "delete from NHAN_VIEN where MANV = '" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
