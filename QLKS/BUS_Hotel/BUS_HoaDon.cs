using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;

namespace BUS_Hotel
{
    public class BUS_HoaDon
    {
        private static BUS_HoaDon instance;

        public static BUS_HoaDon Instance
        {
            get { if (instance == null) instance = new BUS_HoaDon(); return BUS_HoaDon.instance; }
            private set { BUS_HoaDon.instance = value; }
        }

        public bool themHoaDon(int makh)
        {
            
            return DAL_HoaDon.Instance.themHoaDon(makh);
            
        }

        public int GetMaxIDBill()
        {
            return DAL_HoaDon.Instance.GetMaxIDBill();
        }


    }
}
