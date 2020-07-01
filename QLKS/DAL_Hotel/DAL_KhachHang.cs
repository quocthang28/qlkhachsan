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

        //Load mã khách hàng
        public string loadMaKhachHang(string a)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("uspLoadmkh", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CMND", a);
            int t = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToString(t);
        }

        //Thêm Khách hàng
        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspThemKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER,kh.KHACHHANG_NGAYSINH });
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

        //Sửa thông tin khách hàng
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuaKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH , @MAKHACHHANG", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER, kh.KHACHHANG_NGAYSINH, kh.KHACHHANG_MAKHACHHANG });
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

        //Xóa khách hàng
        public bool xoaKhachHang(int a)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspXoaKhachHang @MAKHACHHANG", new object[] { a });
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
    }
}
