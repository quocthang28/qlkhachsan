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
    public class BUS_ChiTietPhieuThue
    {
         DAL_ChiTietPhieuThue dalHotel = new DAL_ChiTietPhieuThue();
        public bool lapctphieuthue(DTO_ChiTietPhieuThuePhong ctpt)
        {
            return dalHotel.lapctphieuthue(ctpt);
        }
        public string loadMaChiTietPhieuThue(int a, int b)
        {
            return dalHotel.loadMaChiTietPhieuThue(a, b);
        }
        public bool xoactphieuthue(int a)
        {
            return dalHotel.xoactphieuthue(a);
        }
    }
}
