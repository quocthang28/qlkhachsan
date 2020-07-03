﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ChiTietHoaDon
    {
        private int _CHITIETHOADON_MACHITIETHOADON;
        private int _CHITIETHOADON_MAHOADON;
        private int _CHITIETHOADON_MAPHONG;
        private int _CHITIETHOADON_SONGAY;
        private int _CHITIETHOADON_DONGIA;
        private int _CHITIETHOADON_THANHTIEN;

        public int CHITIETHOADON_MACHITIETHOADON { get => _CHITIETHOADON_MACHITIETHOADON; set => _CHITIETHOADON_MACHITIETHOADON = value; }
        public int CHITIETHOADON_MAHOADON { get => _CHITIETHOADON_MAHOADON; set => _CHITIETHOADON_MAHOADON = value; }
        public int CHITIETHOADON_MAPHONG { get => _CHITIETHOADON_MAPHONG; set => _CHITIETHOADON_MAPHONG = value; }
        public int CHITIETHOADON_SONGAY { get => _CHITIETHOADON_SONGAY; set => _CHITIETHOADON_SONGAY = value; }
        public int CHITIETHOADON_DONGIA { get => _CHITIETHOADON_DONGIA; set => _CHITIETHOADON_DONGIA = value; }

        public int CHITIETHOADON_THANHTIEN { get => _CHITIETHOADON_THANHTIEN; set => _CHITIETHOADON_THANHTIEN = value; }

        public DTO_ChiTietHoaDon(int machitiethoadon, int mahoadon, int maphong, int songay, int dongia, int thanhtien)
        {
            CHITIETHOADON_MACHITIETHOADON = machitiethoadon;
            CHITIETHOADON_MAHOADON = mahoadon;
            CHITIETHOADON_MAPHONG = maphong;
            CHITIETHOADON_SONGAY = songay;
            CHITIETHOADON_DONGIA = dongia;
            CHITIETHOADON_THANHTIEN = thanhtien;
        }
        public DTO_ChiTietHoaDon(DataRow row)
        {
            this.CHITIETHOADON_MACHITIETHOADON = (int)row["MACHITIETHOADON"];
            this.CHITIETHOADON_MAHOADON = (int)row["MAHOADON"];
            this.CHITIETHOADON_MAPHONG = (int)row["MAPHONG"];
            this.CHITIETHOADON_DONGIA = (int)row["DONGIA"];
            this.CHITIETHOADON_SONGAY = (int)(Convert.ToInt32(row["SONGAY"]));
            this.CHITIETHOADON_THANHTIEN = (int)row["THANHTIEN"];
        }


    }
}
