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
    public class DAL_LapPhieuThue : DBConnect
    {
        //Hiển thị thông tin phiếu thuê phòng lên datagridview
        public DataTable getPhieuthue(int id)
        {
            con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT KH.TENKHACHHANG as [Tên khách hàng], LKH.TENLOAIKHACHHANG as [Loại khách hàng],KH.NGAYSINH as [Ngày sinh], KH.CMND , KH.SODIENTHOAI as[SĐT], KH.DIACHI as [Địa chỉ],LP.TENLOAIPHONG as [Loại phòng], P.TENPHONG as [Tên phòng], PTP.NGAYLAPPHIEU as [Ngày lập phiếu] FROM KHACHHANG KH, LOAIKHACHHANG LKH, PHIEUTHUEPHONG PTP, CHITIETPHIEUTHUEPHONG CTPT, LOAIPHONG LP, PHONG P WHERE KH.MALOAIKHACHHANG = LKH.MALOAIKHACHHANG AND KH.MAKHACHHANG = CTPT.MAKHACHHANG AND CTPT.MAPHIEUTHUE = PTP.MAPHIEUTHUE AND LP.MALOAIPHONG = P.MALOAIPHONG AND P.MAPHONG = PTP.MAPHONG", con);
            SqlCommand cmd = new SqlCommand("uspGetPhieuThue", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHONG", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            con.Close();
            return dtThanhvien;
        }

            
        //Load mã phiếu thuê phòng 
        public string loadMaPhieuThue( int b)
        {
            try
            {
                con.Open();
                //string mpt = "select MAPHIEUTHUE FROM PHIEUTHUEPHONG WHERE NGAYLAPPHIEU='" + a + "' AND MAPHONG ='" + b + "'";
                //SqlCommand cmd = new SqlCommand(mpt, con);
                SqlCommand cmd = new SqlCommand("uspLoadmpt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAPHONG", b);
                int t = (int)cmd.ExecuteScalar();

                
                return Convert.ToString(t);
            }
            catch(Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return null;


        }

        //Load mã phòng
        public string loadMaPhong(int mpt)
        {
            try
            {
                con.Open();
                string mp = "select MAPHONG FROM PHIEUTHUEPHONG WHERE MAPHIEUTHUE='" + mpt + "'";
                SqlCommand cmd = new SqlCommand(mp, con);
                int t = (int)cmd.ExecuteScalar();
             
                return Convert.ToString(t);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return null;

            
        }
        //Thêm phiếu thuê phòng
        public bool lapPhieuThue(DTO_PhieuThuePhong pt)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspLapPhieuThue @NGAYLAPPHIEU , @MAPHONG", new object[] { Convert.ToDateTime(pt.PHIEUTHUEPHONG_NGAYLAPPHIEU), pt.PHIEUTHUEPHONG_MAPHONG });
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

        //Sửa phiếu thuê phòng
        public bool suaPhieuThue(int a, int b)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuaPhieuThue @MAPHONG , @MAPHIEUTHUE", new object[] { a , b });
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

        //Xóa phiếu thuê phòng 
        public bool xoaPhieuThue(int a)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspXoaPhieuThue @MAPHIEUTHUE", new object[] { a });
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
