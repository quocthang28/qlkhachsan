using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Data;
>>>>>>> QUYNHDEPTRAI
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_Phong
    {
<<<<<<< HEAD
        DAL_Phong dalPhong = new DAL_Phong();
        public List<DTO_Phong> getPhongList(string tenlp)
        {
            return dalPhong.getPhongList(tenlp);
        }

        public bool addPhong(DTO_Phong phong)
        {
            return dalPhong.addPhong(phong);
        }

        public bool suaPhong(DTO_Phong phong, string map)
        {
            return dalPhong.suaPhong(phong, map);
        }

        public bool xoaPhong(DTO_Phong phong, string map)
        {
            return dalPhong.xoaPhong(phong, map);
        }

        public bool checkTrungTenPhong(string tenphong)
        {
            return dalPhong.checkTrungTenPhong(tenphong);
        }
        
        public bool checkTinhTrangPhong(string idPhong)
        {
            return dalPhong.checkTinhTrangPhong(idPhong);
=======
        private static BUS_Phong instance;

        public static BUS_Phong Instance
        {
            get { if (instance == null) instance = new BUS_Phong(); return BUS_Phong.instance; }
            private set { BUS_Phong.instance = value; }
        }

        
        public List<DTO_Phong> loadDanhSachPhongTheoLoaiPhong(int a)
        {
            return DAL_Phong.Instance.loadDanhSachPhongTheoLoaiPhong(a);
>>>>>>> QUYNHDEPTRAI
        }
    }
}
