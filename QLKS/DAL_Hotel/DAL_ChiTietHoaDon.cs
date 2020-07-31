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

        public DataTable layDanhSachChiTietHoaDonTheoKhachHang(int makh)
        {
            List<DTO_ChiTietHoaDon> listChiTietHoaDon = new List<DTO_ChiTietHoaDon>();
            DataTable data = DBConnect.Instance.ExecuteQuery("SELECT CHITIETHOADON.MACHITIETHOADON AS'MÃ CHI TIẾT HÓA ĐƠN', CHITIETHOADON.MAHOADON AS'MÃ HÓA ĐƠN', PHONG.TENPHONG AS 'TÊN PHÒNG', CHITIETHOADON.SONGAY AS 'SỐ NGÀY', " +
                "CHITIETHOADON.DONGIA AS'ĐƠN GIÁ', CHITIETHOADON.PHUTHU AS'PHỤ THU'," +
                "  CHITIETHOADON.HESO AS 'HỆ SỐ',CHITIETHOADON.THANHTIEN AS 'THÀNH TIỀN'"  +
                "  FROM CHITIETHOADON,KHACHHANG,HOADON,PHONG WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG)" +
                " AND (HOADON.MAHOADON=CHITIETHOADON.MAHOADON) AND (PHONG.MAPHONG=CHITIETHOADON.MAPHONG) AND (HOADON.TINHTRANGHOADON=0) AND KHACHHANG.MAKHACHHANG = " + makh );

            return data;
            //foreach (DataRow item in data.Rows)
            //{
            //    DTO_ChiTietHoaDon info = new DTO_ChiTietHoaDon(item);
            //    listChiTietHoaDon.Add(info);    
            //}
            //return listChiTietHoaDon;
        }


        //HAM` THEM CHI TIET HOA DON VAO HOA' DON
        public bool ThemChiTietHoaDon(int mahd, int maphong)
        {
            string query = "USP_addChiTietHoaDon @mahd , @maphong";
            return DBConnect.Instance.ExecuteNonQuery(query, new object[] { mahd, maphong }) > 0;
        }



        //HAM` XOA CHI TIET HOA DON KHOI HOA' DON
        public bool XoaChiTietHoaDon(int macthd, int mahd)
        {
            string query = "delete from CHITIETHOADON where MACHITIETHOADON="+macthd+" AND MAHOADON="+mahd;
            return DBConnect.Instance.ExecuteNonQuery(query) > 0;
        }

        public void updateChiTietHoaDon(int maphong)
        {
            string query = "USP_updateChiTietHoaDon @maphong";
            DBConnect.Instance.ExecuteNonQuery(query,new object[] { maphong });
        }

        //public bool kiemTraTonTaiChiTietHoaDon(int maphong)
        //{
        //    string query = "select machitiethoadon from chitiethoadon,phong where chitiethoadon.maphong=phong.maphong and phong.maphong=" + maphong;
        //    if (DBConnect.InstanceKH.ExecuteScalar(query) == null) return false;
        //    return true;
        //}

    }
}
