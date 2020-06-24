using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_PhieuThuePhong
    {
        private int _PHIEUTHUEPHONG_MAPHIEUTHUE;
        private DateTime _PHIEUTHUEPHONG_NGAYLAPPHIEU;
        private int _PHIEUTHUEPHONG_MAPHONG;

        public int PHIEUTHUEPHONG_MAPHIEUTHUE { get => _PHIEUTHUEPHONG_MAPHIEUTHUE; set => _PHIEUTHUEPHONG_MAPHIEUTHUE = value; }
        public DateTime PHIEUTHUEPHONG_NGAYLAPPHIEU { get => _PHIEUTHUEPHONG_NGAYLAPPHIEU; set => _PHIEUTHUEPHONG_NGAYLAPPHIEU = value; }
        public int PHIEUTHUEPHONG_MAPHONG { get => _PHIEUTHUEPHONG_MAPHONG; set => _PHIEUTHUEPHONG_MAPHONG = value; }

        public DTO_PhieuThuePhong(int maphieuthue, DateTime ngaylapphieu, int maphong)
        {
            PHIEUTHUEPHONG_MAPHIEUTHUE = maphieuthue;
            PHIEUTHUEPHONG_NGAYLAPPHIEU = ngaylapphieu;
            PHIEUTHUEPHONG_MAPHONG = maphong;
        }
    }
}
