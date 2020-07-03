using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;


namespace DAL_Hotel
{
    public class DAL_ChiTietHoaDon
    {
        private static DAL_ChiTietHoaDon instance;

        public static DAL_ChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new DAL_ChiTietHoaDon(); return DAL_ChiTietHoaDon.instance; }
            private set { DAL_ChiTietHoaDon.instance = value; }
        }

        public List<DTO_ChiTietHoaDon> layDanhSachChiTietHoaDonTheoKhachHang(int makh)
        {
            List<DTO_ChiTietHoaDon> listChiTietHoaDon = new List<DTO_ChiTietHoaDon>();
            DataTable data = DBConnect.Instance.ExecuteQuery("SELECT CHITIETHOADON.MACHITIETHOADON,CHITIETHOADON.MAHOADON, CHITIETHOADON.MAPHONG, CHITIETHOADON.SONGAY, CHITIETHOADON.DONGIA, CHITIETHOADON.THANHTIEN   FROM CHITIETHOADON,KHACHHANG,HOADON WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG) AND (HOADON.MAHOADON=CHITIETHOADON.MAHOADON) AND (HOADON.TINHTRANGHOADON=0) AND KHACHHANG.MAKHACHHANG = " + makh );

            foreach (DataRow item in data.Rows)
            {
                DTO_ChiTietHoaDon info = new DTO_ChiTietHoaDon(item);
                listChiTietHoaDon.Add(info);    
            }
            return listChiTietHoaDon;
        }





      



        //HAM` THEM CHI TIET HOA DON VAO HOA' DON
        public void ThemChiTietHoaDon(int mahd, int maphong)
        {

            string query = "USP_addChiTietHoaDon @mahd , @maphong";
            DBConnect.Instance.ExecuteNonQuery(query, new object[] { mahd, maphong }) ;
        }



        //HAM` XOA CHI TIET HOA DON KHOI HOA' DON
        public void XoaChiTietHoaDon(int macthd, int mahd)
        {
            string query = "";
            DBConnect.Instance.ExecuteNonQuery(query);
        }

    

    }
}
