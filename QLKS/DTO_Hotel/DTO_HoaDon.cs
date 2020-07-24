using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_HoaDon
    {
        private int _HOADON_MAHOADON;
        private int _HOADON_MAKHACHHANG;
        private int _HOADON_TRIGIA;
        private int _HOADON_TINHTRANGHOADON;
        private DateTime _HOADON_NGAYLAP;



        public int HOADON_MAHOADON { get => _HOADON_MAHOADON; set => _HOADON_MAHOADON = value; }
        public int HOADON_MAKHACHHANG { get => _HOADON_MAKHACHHANG; set => _HOADON_MAKHACHHANG = value; }
        public int HOADON_TRIGIA { get => _HOADON_TRIGIA; set => _HOADON_TRIGIA = value; }
        public DateTime HOADON_NGAYLAP { get => _HOADON_NGAYLAP; set => _HOADON_NGAYLAP = value; }
        public int HOADON_TINHTRANGHOADON { get => _HOADON_TINHTRANGHOADON; set => _HOADON_TINHTRANGHOADON = value; }


        public DTO_HoaDon(int mahoadon, int makhachhang, int trigia,DateTime ngayhoadon,int tinhtrang)
        {
            HOADON_MAHOADON = mahoadon;
            HOADON_MAKHACHHANG = makhachhang;
            HOADON_TRIGIA = trigia;
            HOADON_NGAYLAP = ngayhoadon;
            HOADON_TINHTRANGHOADON = tinhtrang;
        }

    }
}
