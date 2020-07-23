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
    public class DAL_LoaiKhachHang
    {
        private static DAL_LoaiKhachHang instance;

        public static DAL_LoaiKhachHang Instance
        {
            get { if (instance == null) instance = new DAL_LoaiKhachHang(); return DAL_LoaiKhachHang.instance; }
            private set { DAL_LoaiKhachHang.instance = value; }
        }

        //Load danh sách loại khách hàng
        public List<DTO_LoaiKhachHang> loadDanhSachLoaiKhachHang()
        {
            List<DTO_LoaiKhachHang> listLoaiKhachHang = new List<DTO_LoaiKhachHang>();
            string query = "SELECT * FROM LOAIKHACHHANG";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_LoaiKhachHang info = new DTO_LoaiKhachHang(item);
                listLoaiKhachHang.Add(info);
            }
            return listLoaiKhachHang;
        }

    }
}
