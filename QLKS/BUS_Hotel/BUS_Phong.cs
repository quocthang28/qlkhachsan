using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;
using DAL_Hotel;

namespace BUS_Hotel
{
    public class BUS_Phong
    {
        private static BUS_Phong instance;

        public static BUS_Phong Instance
        {
            get { if (instance == null) instance = new BUS_Phong(); return BUS_Phong.instance; }
            private set { BUS_Phong.instance = value; }
        }
        public List<DTO_Phong> layDanhSachPhongCoNguoi()
        {
            return DAL_Phong.Instance.layDanhSachPhongCoNguoi();
        }
    }
}
