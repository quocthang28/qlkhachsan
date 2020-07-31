using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_Hotel;
using DAL_Hotel;
using System.Data;

//using System.Data;
//using DAL_Hotel;
//using DTO_Hotel;


namespace BUS_Hotel
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance
        {
            get { if (instance == null) instance = new BUS_KhachHang(); return BUS_KhachHang.instance; }
            private set { BUS_KhachHang.instance = value; }
        }
        public List<DTO_KhachHang> layDanhSachTenKhach()
        {
            return DAL_KhachHang.InstanceKH.layDanhSachTenKhachHang();
        }

        public DataTable layThongTinKhach(int makh)
        {
            return DAL_KhachHang.InstanceKH.layThongTinKhach(makh);
        }
        DAL_KhachHang dalHotel = new DAL_KhachHang();
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return dalHotel.themKhachHang(kh);
        }
        public string loadMaKhachHang(string a)
        {
            return dalHotel.loadMaKhachHang(a);
        }
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalHotel.suaKhachHang(kh);
        }
        public bool xoaKhachHang(int a)
        {
            return dalHotel.xoaKhachHang(a);
        }
    }
}

