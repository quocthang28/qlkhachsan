using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Hotel;
using MySql.Data.MySqlClient;

namespace DAL_Hotel
{
    public class DAL_ChiTietPhieuThue: DBConnect
    {

        //Load mã chi tiết phiếu thuê phòng
        public string loadMaChiTietPhieuThue(int a, int b)
        {
            con.Open();
            //string mpt = "select MACHITIETPHIEUTHUE FROM CHITIETPHIEUTHUEPHONG WHERE MAPHIEUTHUE='" + a + "' AND MAKHACHHANG ='" + b + "'";
            //SqlCommand cmd = new SqlCommand(mpt, con);
            SqlCommand cmd = new SqlCommand("uspLoadmctpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUTHUE", a);
            cmd.Parameters.AddWithValue("@MAKHACHHANG", b);
            int t = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToString(t);

        }

        //Lập chi tiết phiếu thuê
        public bool lapctphieuthue(DTO_ChiTietPhieuThuePhong ctpt)
        {

            try
            {

                int result = DBConnect.Instance.ExecuteNonQuery("exec uspLapctPhieuThue @MAPHIEUTHUE , @MAKHACHHANG", new object[] { ctpt.CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE, ctpt.CHITIETPHIEUTHUEPHONG_MAKHACHHANG });
                return result > 0;
                
            }
            catch (Exception e)
            {

            }
            finally
            {
               
            }
            return false;
        }

        //Xóa chi tiết phiếu thuê
        public bool xoactphieuthue(int a)
        {

            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspXoactPhieuThue @MACHITIETPHIEUTHUE", new object[] { a });
                return result > 0;
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
