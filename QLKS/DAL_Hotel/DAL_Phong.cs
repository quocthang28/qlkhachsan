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
    public class DAL_Phong
    {
        private static DAL_Phong instance;

        public static DAL_Phong Instance
        {
            get { if (instance == null) instance = new DAL_Phong(); return DAL_Phong.instance; }
            private set { DAL_Phong.instance = value; }
        }


        //Load danh sách phòng theo loại phòng
        public List<DTO_Phong> loadDanhSachPhongTheoLoaiPhong(string a)
        {
            List<DTO_Phong> listPhong = new List<DTO_Phong>();
            string query = "SELECT * FROM PHONG WHERE MALOAIPHONG='"+a+"'";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Phong info = new DTO_Phong(item);
                listPhong.Add(info);
            }
            return listPhong;
        }

        public List<DTO_Phong> getPhongList(string tenlp)
        {
            string query = string.Format("SELECT * FROM dbo.PHONG JOIN dbo.LOAIPHONG ON PHONG.MALOAIPHONG = LOAIPHONG.MALOAIPHONG AND LOAIPHONG.TENLOAIPHONG = N'{0}'", tenlp);
            List<DTO_Phong> list = new List<DTO_Phong>();
            DataTable dt = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_Phong phong = new DTO_Phong(item);
                list.Add(phong);
            }
            return list;
        }

        public bool addPhong(DTO_Phong phong)
        {
            string query = string.Format("INSERT INTO dbo.Phong (MALOAIPHONG, TENPHONG, GHICHU, TINHTRANG) VALUES (N'{0}', N'{1}', N'{2}', {3})", phong.PHONG_MALOAIPHONG, phong.PHONG_TENPHONG, phong.PHONG_GHICHU, phong.PHONG_TINHTRANG);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaPhong(DTO_Phong phong, string map)
        {
            string query = string.Format("UPDATE dbo.PHONG SET TENPHONG = N'{0}', GHICHU = N'{1}' WHERE MAPHONG = '{2}'", phong.PHONG_TENPHONG, phong.PHONG_GHICHU, map);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaPhong(DTO_Phong phong, string map)
        {
            string query = string.Format("DELETE FROM dbo.PHONG WHERE MAPHONG = N'{0}'", map);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool checkTrungTenPhong(string tenphong)
        {
            string query = string.Format("SELECT * FROM dbo.Phong WHERE TENPHONG = N'{0}'", tenphong);
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }

        public bool checkTinhTrangPhong(string idPhong)
        {
            string query = string.Format("SELECT * FROM dbo.Phong WHERE MAPHONG = {0} AND TINHTRANG = 1", idPhong);
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }


        public List<DTO_Phong> layDanhSachPhongCoNguoi()
        {
            string query = string.Format("SELECT * FROM PHONG WHERE TINHTRANGPHONG=1");
            List<DTO_Phong> list = new List<DTO_Phong>();
            DataTable dt = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_Phong phong = new DTO_Phong(item);
                list.Add(phong);
            }
            return list;
        }

    }
}
