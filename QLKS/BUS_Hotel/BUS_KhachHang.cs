using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;
using DAL_Hotel;

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
            return DAL_KhachHang.Instance.layDanhSachTenKhachHang();
        }

        public string layDiaChiKhach(int makh)
        {
            return DAL_KhachHang.Instance.layDiaChiKhach(makh);
        }
    }
}
