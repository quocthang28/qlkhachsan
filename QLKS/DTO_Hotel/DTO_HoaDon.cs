using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_HoaDon
    {
        private int _HOADON_MAHOADON;
        private int _HOADON_MAKHACHHANG;
        private int _HOADON_THANHTIEN;

        public int HOADON_MAHOADON { get => _HOADON_MAHOADON; set => _HOADON_MAHOADON = value; }
        public int HOADON_MAKHACHHANG { get => _HOADON_MAKHACHHANG; set => _HOADON_MAKHACHHANG = value; }
        public int HOADON_THANHTIEN { get => _HOADON_THANHTIEN; set => _HOADON_THANHTIEN = value; }

        public DTO_HoaDon(int mahoadon, int makhachhang, int thanhtien)
        {
            HOADON_MAHOADON = mahoadon;
            HOADON_MAKHACHHANG = makhachhang;
            HOADON_THANHTIEN = thanhtien;
        }
    }
}
