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
        public string loadmctpt(int a, int b)
        {
            con.Open();
            string mpt = "select MACHITIETPHIEUTHUE FROM CHITIETPHIEUTHUEPHONG WHERE MAPHIEUTHUE='" + a + "' AND MAKHACHHANG ='" + b + "'";
            SqlCommand cmd = new SqlCommand(mpt, con);
            int t = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToString(t);

        }
        public bool lapctphieuthue(DTO_ChiTietPhieuThuePhong ctpt)
        {

            try
            {
                con.Open();

                string SQL = string.Format("INSERT INTO CHITIETPHIEUTHUEPHONG(MAPHIEUTHUE,MAKHACHHANG) VALUES('{0}','{1}')", ctpt.CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE, ctpt.CHITIETPHIEUTHUEPHONG_MAKHACHHANG);
                SqlCommand cmd = new SqlCommand(SQL, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
        public bool xoactphieuthue(int a)
        {

            try
            {
                con.Open();

                string SQL = string.Format("DELETE FROM CHITIETPHIEUTHUEPHONG WHERE MACHITIETPHIEUTHUE = {0}", a);
                SqlCommand cmd = new SqlCommand(SQL, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
