using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ChiTietPhieuThuePhong
    {
        private int _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE;
        private string _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE;
        private string _CHITIETPHIEUTHUEPHONG_MAKHACHHANG;

        public int CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MACHITIETPHIEUTHUE = value; }
        public string CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE { get => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE; set => _CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = value; }
        public string CHITIETPHIEUTHUEPHONG_MAKHACHHANG { get => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG; set => _CHITIETPHIEUTHUEPHONG_MAKHACHHANG = value; }

        public DTO_ChiTietPhieuThuePhong( string maphieuthue, string makhachhang)
        {
          
            this.CHITIETPHIEUTHUEPHONG_MAPHIEUTHUE = maphieuthue;
            this.CHITIETPHIEUTHUEPHONG_MAKHACHHANG = makhachhang;
        }
    }
}
