using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

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
        //public List<DTO_Phong> layDanhSachPhong()
        //{
        //    List<DTO_Phong> listPhong = new List<DTO_Phong>();

        //    string query = "select * from dbo.PHONG ";
        //    DataTable data = DBConnect.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        DTO_Phong info = new DTO_Phong(item);
        //        listPhong.Add(info);
        //    }
        //    return listPhong;
        //}


        public List<DTO_Phong> layDanhSachPhongCoNguoi()
        {
            List<DTO_Phong> listPhong = new List<DTO_Phong>();

            string query = "select * from dbo.PHONG WHERE TINHTRANG = 1 ";
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
