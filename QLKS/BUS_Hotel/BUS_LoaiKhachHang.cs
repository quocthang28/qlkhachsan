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
    public class BUS_LoaiKhachHang
    {
        private static BUS_LoaiKhachHang instance;

        public static BUS_LoaiKhachHang Instance
        {
            get { if (instance == null) instance = new BUS_LoaiKhachHang(); return BUS_LoaiKhachHang.instance; }
            private set { BUS_LoaiKhachHang.instance = value; }
        }

        public List<DTO_LoaiKhachHang> loadDanhSachLoaiKhachHang()
        {
            return DAL_LoaiKhachHang.Instance.loadDanhSachLoaiKhachHang();
        }
    }
}
