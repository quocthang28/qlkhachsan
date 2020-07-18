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
    public class BUS_Account
    {
        DAL_Account dalHotel = new DAL_Account();
        public bool themDangKi(DTO_Account dk)
        {
            return dalHotel.themDangKi(dk);
        }

        public bool DangNhap(DTO_Account dn)
        {
            return dalHotel.DangNhap(dn);
        }
    }
}
