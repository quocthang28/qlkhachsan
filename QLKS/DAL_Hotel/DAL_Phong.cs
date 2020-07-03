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
    public class DAL_Phong
    {
        private static DAL_Phong instance;

        public static DAL_Phong Instance
        {
            get { if (instance == null) instance = new DAL_Phong(); return DAL_Phong.instance; }
            private set { DAL_Phong.instance = value; }
        }


        //Load danh sách phòng theo loại phòng
        public List<DTO_Phong> loadDanhSachPhongTheoLoaiPhong(int a)
        {
            List<DTO_Phong> listPhong = new List<DTO_Phong>();
            string query = "SELECT * FROM PHONG WHERE MALOAIPHONG="+a;
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Phong info = new DTO_Phong(item);
                listPhong.Add(info);
            }
            return listPhong;
        }

    }
}
