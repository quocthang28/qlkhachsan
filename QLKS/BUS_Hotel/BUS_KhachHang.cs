﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DTO_Hotel;
using DAL_Hotel;
=======
using System.Data;
using DAL_Hotel;
using DTO_Hotel;
>>>>>>> master

namespace BUS_Hotel
{
    public class BUS_KhachHang
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> master
        }
    }
}
