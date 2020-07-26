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

        private static DAL_KhachHang instance;
        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
        }

        //Load mã khách hàng
        public string loadMaKhachHang(string a)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspLoadmkh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMND", a);
                int t = (int)cmd.ExecuteScalar();
                
                return Convert.ToString(t);
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return null;
           
        }

        public List<DTO_KhachHang> getKHList()
        {
            string query = "SELECT * FROM KHACHHANG";
            List<DTO_KhachHang> list = new List<DTO_KhachHang>();
            DataTable dt = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_KhachHang kh = new DTO_KhachHang(item);
                list.Add(kh);
            }
            return list;
        }

        //Thêm Khách hàng
        public bool themKhachHang(DTO_KhachHang kh)
        {
                
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspThemKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_SODIENTHOAI, Convert.ToDateTime(kh.KHACHHANG_NGAYSINH) });
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

        //Sửa thông tin khách hàng
        public bool suaKhachHang(DTO_KhachHang kh)
        {
                
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuaKhachHang @MALOAIKHACHHANG , @TENKHACHHANG , @CMND , @DIACHI , @SODIENTHOAI , @NGAYSINH , @MAKHACHHANG", new object[] { kh.KHACHHANG_MALOAIKHACHHANG, kh.KHACHHANG_TENKHACHHANG, kh.KHACHHANG_CMND, kh.KHACHHANG_DIACHI, kh.KHACHHANG_SODIENTHOAI, Convert.ToDateTime(kh.KHACHHANG_NGAYSINH), kh.KHACHHANG_MAKHACHHANG });
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

        public List<DTO_KhachHang> layDanhSachTenKhachHang()
        {
            List<DTO_KhachHang> listTenKhachHang = new List<DTO_KhachHang>();

            string query = "select * from dbo.KHACHHANG ";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_KhachHang info = new DTO_KhachHang(item);
                listTenKhachHang.Add(info);
            }
            return listTenKhachHang;
        }

        public DataTable layThongTinKhach(int makh)
        {
            string query = "select * from dbo.KHACHHANG WHERE MAKHACHHANG = " + makh;
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            return data;
        }


    }
}
