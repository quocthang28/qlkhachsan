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
        private static DAL_HoaDon instance;

        public static DAL_HoaDon Instance
        {
            get { if (instance == null) instance = new DAL_HoaDon(); return DAL_HoaDon.instance; }
            private set { DAL_HoaDon.instance = value; }
        }


        public bool themHoaDon(int makh) // them hoa don
        {
                string query = "EXEC USP_InsertBill @makh";
                return DBConnect.Instance.ExecuteNonQuery(query, new object[] { makh }) > 0;   
        }

        public int GetMaxIDBill()    // lay hoa don vua tao
        {
            return (int)DBConnect.Instance.ExecuteScalar("SELECT MAX(MAHOADON) FROM HOADON");
        }

        public int getUnCheckIDBillByIDCustomer(int makh)
        {
            string query = "select MAHOADON from HOADON WHERE TINHTRANGHOADON=0 AND MAKHACHHANG= "+makh;
            if(DBConnect.Instance.ExecuteScalar(query) ==null )
            {
                return -1;
            }
            return (int)DBConnect.Instance.ExecuteScalar(query);
        }


        public bool ThanhToanHoaDon(int mahd, int trigia)  //thanh toan hoa don
        {
            string query = "USP_thanhToanHoaDon @mahd , @trigia " ;
            int a= DBConnect.Instance.ExecuteNonQuery(query, new object[] { mahd, trigia });
            return a > 0;
        }


    }
}
