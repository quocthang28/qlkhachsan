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
    public class DAL_ThamSo
    {

        private static DAL_ThamSo instance;

        public static DAL_ThamSo Instance
        {
            get { if (instance == null) instance = new DAL_ThamSo(); return DAL_ThamSo.instance; }
            private set { DAL_ThamSo.instance = value; }
        }

        public bool ThayDoiHeSo(float heso)
        {
            string query = "update thamso set giatrithamso=" + heso + "where mathamso =2";
            return (int)DBConnect.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ThayDoiPhuThu(float phuthu)
        {
            string query = "update thamso set giatrithamso=" + phuthu + "where mathamso =1";
            return (int)DBConnect.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ThayDoiSoNguoiToiDaTrongPhong(int songuoitoidatrongphong)
        {
            string query = "update thamso set giatrithamso=" + songuoitoidatrongphong + "where mathamso =3";
            return (int)DBConnect.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
