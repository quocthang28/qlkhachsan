using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_PhieuThuePhong
    {
        private int _PHIEUTHUEPHONG_MAPHIEUTHUE;
        private string _PHIEUTHUEPHONG_NGAYLAPPHIEU;
        private string _PHIEUTHUEPHONG_MAPHONG;

        public int PHIEUTHUEPHONG_MAPHIEUTHUE { get => _PHIEUTHUEPHONG_MAPHIEUTHUE; set => _PHIEUTHUEPHONG_MAPHIEUTHUE = value; }
        public string PHIEUTHUEPHONG_NGAYLAPPHIEU { get => _PHIEUTHUEPHONG_NGAYLAPPHIEU; set => _PHIEUTHUEPHONG_NGAYLAPPHIEU = value; }
        public string PHIEUTHUEPHONG_MAPHONG { get => _PHIEUTHUEPHONG_MAPHONG; set => _PHIEUTHUEPHONG_MAPHONG = value; }
        
        public DTO_PhieuThuePhong(int maphieuthue, string ngaylapphieu, string maphong)
        {
            this.PHIEUTHUEPHONG_MAPHIEUTHUE = maphieuthue;
            this.PHIEUTHUEPHONG_NGAYLAPPHIEU = ngaylapphieu;
            this.PHIEUTHUEPHONG_MAPHONG = maphong;
        }

       
        
    }
}
