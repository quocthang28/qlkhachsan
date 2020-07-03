using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
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

        public string layDiaChiKhach(int makh)
        {
            string diachi;
            string query = "select DIACHI from dbo.KHACHHANG WHERE MAKHACHHANG = "+ makh;
            diachi = (DBConnect.Instance.ExecuteScalar(query)).ToString();
            return diachi;
        }

    }
}
