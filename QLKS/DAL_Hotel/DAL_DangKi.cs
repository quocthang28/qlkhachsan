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
    public class DAL_DangKi : DBConnect
    {
        
        public bool themDangKi(DTO_DangKi dk)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("THEM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TV_NAME", dk.DANGKI_NAME));
                cmd.Parameters.Add(new SqlParameter("@TV_PHONE", dk.DANGKI_PHONENUMBER));
                cmd.Parameters.Add(new SqlParameter("@TV_EMAIL", dk.DANGKI_EMAIL));

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

            //con2.Open();
            //string query = "INSERT INTO USER(USERNAME,PASSWORD) VALUES(@USERNAME,@PASSWORD)";

            //MySqlCommand cmd = new MySqlCommand(query, con2);
            //cmd.Parameters.AddWithValue("@USERNAME", dk.DANGKI_TK);
            //cmd.Parameters.AddWithValue("@PASSWORD", dk.DANGKI_MK);

            //if (cmd.ExecuteNonQuery() ==1)
            //       return true;
            //return false;
            //try
            //{
            //    con.Open();
            //    string SQL = string.Format("INSERT INTO DANGKI(TENDANGNHAP,MATKHAU,HOTEN,EMAIL,SODIENTHOAI,DIACHI) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", dk.DANGKI_TK, dk.DANGKI_MK, dk.DANGKI_NAME, dk.DANGKI_EMAIL, dk.DANGKI_PHONENUMBER, dk.DANGKI_DIACHI);
            //    SqlCommand cmd = new SqlCommand(SQL, con);

            //    if (cmd.ExecuteNonQuery() > 0)
            //        return true;
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}
            //return false;


        }
        public bool DangNhap(DTO_DangKi dn)
        {
            //try
            //{
            //    con.Open();
            //    string SQL = string.Format("SELECT TENDANGNHAP, MATKHAU FROM DANGKI WHERE TENDANGNHAP = '{0}' AND MATKHAU = '{1}'", dn.DANGKI_TK, dn.DANGKI_MK);
            //    SqlCommand cmd = new SqlCommand(SQL, con);
            //    SqlDataReader data = cmd.ExecuteReader();
            //    if (data.Read() == true)
            //    {
            //        return true;
            //    }

            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}
            return false;
        }



    }

}
