﻿using System;
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
        public DataTable getPhieuthue()
        {
            con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT KH.TENKHACHHANG as [Tên khách hàng], LKH.TENLOAIKHACHHANG as [Loại khách hàng],KH.NGAYSINH as [Ngày sinh], KH.CMND , KH.SODIENTHOAI as[SĐT], KH.DIACHI as [Địa chỉ],LP.TENLOAIPHONG as [Loại phòng], P.TENPHONG as [Tên phòng], PTP.NGAYLAPPHIEU as [Ngày lập phiếu] FROM KHACHHANG KH, LOAIKHACHHANG LKH, PHIEUTHUEPHONG PTP, CHITIETPHIEUTHUEPHONG CTPT, LOAIPHONG LP, PHONG P WHERE KH.MALOAIKHACHHANG = LKH.MALOAIKHACHHANG AND KH.MAKHACHHANG = CTPT.MAKHACHHANG AND CTPT.MAPHIEUTHUE = PTP.MAPHIEUTHUE AND LP.MALOAIPHONG = P.MALOAIPHONG AND P.MAPHONG = PTP.MAPHONG", con);
            SqlCommand cmd = new SqlCommand("uspGetPhieuThue", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            con.Close();
            return dtThanhvien;
        }

            
        //Load mã phiếu thuê phòng 
        public string loadMaPhieuThue(string a, int b)
        {
            con.Open();
            //string mpt = "select MAPHIEUTHUE FROM PHIEUTHUEPHONG WHERE NGAYLAPPHIEU='" + a + "' AND MAPHONG ='" + b + "'";
            //SqlCommand cmd = new SqlCommand(mpt, con);
            SqlCommand cmd = new SqlCommand("uspLoadmpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NGAYLAPPHIEU",Convert.ToDateTime( a));
            cmd.Parameters.AddWithValue("@MAPHONG", b);
            int t = (int)cmd.ExecuteScalar();
            
            con.Close();
            return Convert.ToString(t);

        }
        
        //Thêm phiếu thuê phòng
        public bool lapPhieuThue(DTO_PhieuThuePhong pt)
        {
            try
            {
                //string SQL = string.Format("INSERT INTO PHIEUTHUEPHONG(NGAYLAPPHIEU,MAPHONG) VALUES('{0}','{1}')", pt.PHIEUTHUEPHONG_NGAYLAPPHIEU,pt.PHIEUTHUEPHONG_MAPHONG);
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspLapPhieuThue @NGAYLAPPHIEU , @MAPHONG", new object[] { pt.PHIEUTHUEPHONG_NGAYLAPPHIEU,pt.PHIEUTHUEPHONG_MAPHONG });
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

        //Sửa phiếu thuê phòng
        public bool suaPhieuThue(DTO_PhieuThuePhong pt)
        {
            try
            {
                int result = DBConnect.Instance.ExecuteNonQuery("exec uspSuaPhieuThue @NGAYLAPPHIEU , @MAPHONG , @MAPHIEUTHUE", new object[] { pt.PHIEUTHUEPHONG_NGAYLAPPHIEU, pt.PHIEUTHUEPHONG_MAPHONG, pt.PHIEUTHUEPHONG_MAPHIEUTHUE });
                return result > 0;
                //con.Open();
                //string SQL = string.Format("UPDATE PHIEUTHUEPHONG SET NGAYLAPPHIEU= '{0}',MAPHONG = {1} WHERE MAPHIEUTHUE = {2} ",pt.PHIEUTHUEPHONG_NGAYLAPPHIEU,pt.PHIEUTHUEPHONG_MAPHONG,pt.PHIEUTHUEPHONG_MAPHIEUTHUE);
               
                //SqlCommand cmd = new SqlCommand(SQL, con);

                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;
            }
            catch (Exception e)
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
                //con.Open();
                //string SQL = string.Format("DELETE FROM PHIEUTHUEPHONG  WHERE MAPHIEUTHUE = {0} ",  a);

                //SqlCommand cmd = new SqlCommand(SQL, con);

                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;
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