using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    class DTO_ChiTietPhieuThuePhong
    {
        private int _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE;
        private int _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE;
        private int _CHITIETPHIEUTHUEPHONG_MAKHACHHANG;

        public int CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = value; }
        public int CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = value; }
        public int CHITIETPHIEUTHUEPHONG_MAKHACHHANG { get => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG; set => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG = value; }

        public DTO_ChiTietPhieuThuePhong(int machitietphieuthue, int maphieuthue, int makhachhang)
        {
            CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = machitietphieuthue;
            CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = maphieuthue;
            CHITIETPHIEUTHUEPHONG_MAKHACHHANG = makhachhang;
        }
    }
}
