﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_ChiTietHoaDon
    {
        private static BUS_ChiTietHoaDon instance;

        public static BUS_ChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new BUS_ChiTietHoaDon(); return BUS_ChiTietHoaDon.instance; }
            private set { BUS_ChiTietHoaDon.instance = value; }
        }

      

        public void ThemChiTietHoaDon(int mahd, int maphong)
        {
            DAL_ChiTietHoaDon.Instance.ThemChiTietHoaDon(mahd, maphong);
        }

        public List<DTO_ChiTietHoaDon> layDanhSachChiTietHoaDon(int makh)
        {
            return DAL_ChiTietHoaDon.Instance.layDanhSachChiTietHoaDonTheoKhachHang(makh);
        }






    }
}