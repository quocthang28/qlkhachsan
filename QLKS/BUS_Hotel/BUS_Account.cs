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
        DAL_Account dalAccount = new DAL_Account();

        //public bool themDangKi(DTO_Account dk)
        //{
        //    return dalHotel.themDangKi(dk);
        //}

        public bool DangNhap(DTO_Account dn)
        {
            return dalAccount.DangNhap(dn);
        }

        public bool DangKi(DTO_Account dk)
        {
            return dalAccount.DangKi(dk);
        }

        public bool checkISADMIN(string tk)
        {
            return dalAccount.checkISADMIN(tk);
        }

        public List<DTO_Account> getName()
        {
            return dalAccount.getName();
        }

        public DataTable getAccountInfo(string ten)
        {
            return dalAccount.getAccountInfo(ten);
        }
    }
}
