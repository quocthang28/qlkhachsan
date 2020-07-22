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
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspThemKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER, Convert.ToDateTime(kh.KHACHHANG_NGAYSINH) });
                return result > 0;
                //string query = string.Format("INSERT INTO KHACHHANG(MALOAIKHACHHANG,TENKHACHHANG,CMND,DIACHI,SODIENTHOAI,NGAYSINH) VALUES({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER, kh.KHACHHANG_NGAYSINH);
                //int result = DBConnect.Instance.ExecuteNonQuery(query);
                //return result > 0;

        }

        //Sửa thông tin khách hàng
        public bool suaKhachHang(DTO_KhachHang kh)
        {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuaKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH , @MAKHACHHANG", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_PHONENUMBER, Convert.ToDateTime(kh.KHACHHANG_NGAYSINH), kh.KHACHHANG_MAKHACHHANG });
                return result > 0;
        }

        //Xóa khách hàng
        public bool xoaKhachHang(int a)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspXoaKhachHang @MAKHACHHANG", new object[] { a });
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
    }
}
