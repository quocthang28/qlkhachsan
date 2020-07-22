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
        private static DAL_ChiTietPhieuThue instance;

        public static DAL_ChiTietPhieuThue Instance
        {
            get { if (instance == null) instance = new DAL_ChiTietPhieuThue(); return DAL_ChiTietPhieuThue.instance; }
            private set { DAL_ChiTietPhieuThue.instance = value; }
        }

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
            catch (Exception)
            {

            }
            finally
            {
               
            }
            return false;
        }

        //Sửa chi tiết phiếu thuê
        public bool suactphieuthue(DTO_ChiTietPhieuThuePhong ctpt)
        {

            try
            {

                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuactPhieuThue @MAPHIEUTHUE , @MACHITIETPHIEUTHUE", new object[] { ctpt.CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE, ctpt.CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE });
                return result > 0;

            }
            catch (Exception)
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
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }

        //Dem chi tiet phieu thue
        public int countctphieuthue(int mpt)
        {

            try
            {
                string query = string.Format("SELECT COUNT(*) FROM CHITIETPHIEUTHUEPHONG WHERE MAPHIEUTHUE = {0}", mpt);
                int result =(int)DBConnect.Instance.ExecuteScalar(query);
                return result;

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return 0;
        }
    }
}
