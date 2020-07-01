using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_KhachHang
    {
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
