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
    public class DAL_LoaiPhong 
    {
        private static DAL_LoaiPhong instance;

        public static DAL_LoaiPhong Instance
        {
            get { if (instance == null) instance = new DAL_LoaiPhong(); return DAL_LoaiPhong.instance; }
            private set { DAL_LoaiPhong.instance = value; }
        }

        //Load danh sách loại phòng
        public List<DTO_LoaiPhong> loadDanhSachLoaiPhong()
        {
            List<DTO_LoaiPhong> listLoaiPhong = new List<DTO_LoaiPhong>();
            string query = "SELECT * FROM LOAIPHONG";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                DTO_LoaiPhong info = new DTO_LoaiPhong(item);
                listLoaiPhong.Add(info);
            }
            return listLoaiPhong;
        }
    }
}
