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
    public class DAL_LapPhieuThue : DBConnect
    {
        public DataTable getPhieuthue()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PTP.MAPHIEUTHUE,KH.MAKHACHHANG, KH.TENKHACHHANG, LKH.TENLOAIKHACHHANG,KH.NGAYSINH, KH.CMND, KH.SODIENTHOAI, KH.DIACHI,LP.TENLOAIPHONG, P.TENPHONG, PTP.NGAYLAPPHIEU FROM KHACHHANG KH, LOAIKHACHHANG LKH, PHIEUTHUEPHONG PTP, CHITIETPHIEUTHUEPHONG CTPT, LOAIPHONG LP, PHONG P WHERE KH.MALOAIKHACHHANG = LKH.MALOAIKHACHHANG AND KH.MAKHACHHANG = CTPT.MAKHACHHANG AND CTPT.MAPHIEUTHUE = PTP.MAPHIEUTHUE AND LP.MALOAIPHONG = P.MALOAIPHONG AND P.MAPHONG = PTP.MAPHONG", con);
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
        public string loadmpt(string a, int b)
        {
            con.Open();
            string mpt = "select MAPHIEUTHUE FROM PHIEUTHUEPHONG WHERE NGAYLAPPHIEU='" + a + "' AND MAPHONG ='" + b + "'";
            SqlCommand cmd = new SqlCommand(mpt, con);
            int t = (int)cmd.ExecuteScalar();
            con.Close();
            return Convert.ToString(t);

        }
        
        public bool lapPhieuThue(DTO_PhieuThuePhong pt)
        {
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO PHIEUTHUEPHONG(NGAYLAPPHIEU,MAPHONG) VALUES('{0}','{1}')", pt.PHIEUTHUEPHONG_NGAYLAPPHIEU,pt.PHIEUTHUEPHONG_MAPHONG);
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

        public bool suaPhieuThue(DTO_PhieuThuePhong pt)
        {
            try
            {
                con.Open();
                string SQL = string.Format("UPDATE PHIEUTHUEPHONG SET NGAYLAPPHIEU= '{0}',MAPHONG = {1} WHERE MAPHIEUTHUE = {2} ",pt.PHIEUTHUEPHONG_NGAYLAPPHIEU,pt.PHIEUTHUEPHONG_MAPHONG,pt.PHIEUTHUEPHONG_MAPHIEUTHUE);
               
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
        public bool xoaPhieuThue(int a)
        {
            try
            {
                con.Open();
                string SQL = string.Format("DELETE FROM PHIEUTHUEPHONG  WHERE MAPHIEUTHUE = {0} ",  a);

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
