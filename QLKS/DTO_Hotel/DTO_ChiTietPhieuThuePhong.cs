using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ChiTietPhieuThuePhong
    {
        private int _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE;
        private int _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE;
        private int _CHITIETPHIEUTHUEPHONG_MAKHACHHANG;

        public int CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = value; }
        public int CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = value; }
        public int CHITIETPHIEUTHUEPHONG_MAKHACHHANG { get => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG; set => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG = value; }

        public DTO_ChiTietPhieuThuePhong(int machitietphieuthue, int maphieuthue, int makhachhang)
        {
            this.CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = machitietphieuthue;
            this.CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = maphieuthue;
            this.CHITIETPHIEUTHUEPHONG_MAKHACHHANG = makhachhang;
        }

        public DTO_ChiTietPhieuThuePhong(DataRow row)
        {
            CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = (int)row["MACHITIETPHIEUTHUE"];
            CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = (int)row["MAPHIEUTHUE"];
            CHITIETPHIEUTHUEPHONG_MAKHACHHANG = (int)row["MAKHACHHANG"];
        }
    }
}
