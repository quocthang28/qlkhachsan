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
    public class DAL_PhuThu : DBConnect
    {
        public DataTable getPhuThu()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHUTHU", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            con.Close();
            return dtThanhvien;
        }
        public DataTable loadData(string sql)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            con.Close();
            return dt;
        }

        public bool editPhuThu(DTO_PhuThu pt)
        {
            try
            {
                con.Open();
                string SQL = string.Format("UPDATE PHUTHU SET TYLE= {0} WHERE MAPHUTHU = {1} ", pt.PHUTHU_TYLE, pt.PHUTHU_NAME);

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
