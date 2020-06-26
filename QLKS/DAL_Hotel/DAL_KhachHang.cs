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
    public class DAL_KhachHang: DBConnect
    {
        public string loadmkh(string a)
        {
            con.Open();
            string mkh = "select MAKHACHHANG FROM KHACHHANG WHERE CMND='" + a + "'";
            SqlCommand cmd = new SqlCommand(mkh, con);
            int t = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToString(t);
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO KHACHHANG(MALOAIKHACHHANG,TENKHACHHANG,CMND,DIACHI,SODIENTHOAI,NGAYSINH) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER,kh.KHACHHANG_NGAYSINH);
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

        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                con.Open();
                string SQL = string.Format("UPDATE KHACHHANG SET MALOAIKHACHHANG= {0},TENKHACHHANG = '{1}', CMND = {2},DIACHI = '{3}', SODIENTHOAI = {4}, NGAYSINH = '{5}' WHERE MAKHACHHANG = {6} ", kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER, kh.KHACHHANG_NGAYSINH, kh.KHACHHANG_MAKHACHHANG);

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
        public bool xoaKhachHang(int a)
        {
            try
            {
                con.Open();
                string SQL = string.Format("DELETE FROM KHACHHANG WHERE MAKHACHHANG = {0} ",a);

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
