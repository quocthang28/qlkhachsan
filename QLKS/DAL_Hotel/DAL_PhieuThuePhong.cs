using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;
namespace DAL_Hotel
{
    class DAL_PhieuThuePhong
    {
        private static DAL_PhieuThuePhong instance;

        public static DAL_PhieuThuePhong Instance
        {
            get { if (instance == null) instance = new DAL_PhieuThuePhong(); return DAL_PhieuThuePhong.instance; }
            private set { DAL_PhieuThuePhong.instance = value; }
        }

        //public List<DTO_PhieuThuePhong> layDanhSachPhongCoNguoi()
        //{
        //    List<DTO_PhieuThuePhong> listPhong = new List<DTO_PhieuThuePhong>();

        //    string query = "select MAPHIEUTHUE,NGAYLAPPHIEU,MAPHONG from dbo.PHONG,PHIEUTHUEPHONG WHERE TINHTRANG =1 AND(PHIEUTHUEPHONG.MAPHONG=PHONG.MAPHONG) ";
        //    DataTable data = DBConnect.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        DTO_PhieuThuePhong info = new DTO_PhieuThuePhong(item);
        //        listPhong.Add(info);
        //    }
        //    return listPhong;
        //}


    }
}
