using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class DAL_HoaDon
    {


        DAL_HoaDon dalPhong = new DAL_HoaDon();


        public bool themHoaDon(int makh) // them hoa don
        {
            string query = "EXEC USP_InsertBill @makh";
            int a= DBConnect.Instance.ExecuteNonQuery(query, new object[] { makh });
            return a > 0;
        }

        public int GetMaxIDBill()    // lay hoa don vua tao
        {
            return (int)DBConnect.Instance.ExecuteScalar("SELECT MAX(MAHOADON) FROM HOADON");
        }

        public bool UpdateRoomPrice(int mahd)     // cap nhat tri gia hoa don
        {
            string query = "USP_UpdateBill_RoomPrice @mahd";
            return DBConnect.Instance.ExecuteNonQuery(query, new object[] { mahd }) > 0;
        }

        public void ThanhToanHoaDon(int mahd)  //thanh toan hoa don
        {
            string query = "update HOADON set NGAYLAPHOADON = GETDATE()  where MAHOADON= " + mahd;
            DBConnect.Instance.ExecuteNonQuery(query);
        }


    }
}
