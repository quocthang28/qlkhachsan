using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Phong
    {
        private int _PHONG_ID;
        private int _PHONG_MAPHONG;
        private int _PHONG_MALOAIPHONG;
        private string _PHONG_TENPHONG;
        private string _PHONG_GHICHU;

        public int PHONG_ID { get => _PHONG_ID; set => _PHONG_ID = value; }
        public int PHONG_MALOAIPHONG { get => _PHONG_MALOAIPHONG; set => _PHONG_MALOAIPHONG = value; }
        public string PHONG_TENPHONG { get => _PHONG_TENPHONG; set => _PHONG_TENPHONG = value; }
        public string PHONG_GHICHU { get => _PHONG_GHICHU; set => _PHONG_GHICHU = value; }
        public int PHONG_MAPHONG { get => _PHONG_MAPHONG; set => _PHONG_MAPHONG = value; }

        public DTO_Phong(int maloaiphong, string tenphong, string ghichu)
        {
            PHONG_MALOAIPHONG = maloaiphong;
            PHONG_TENPHONG = tenphong;
            PHONG_GHICHU = ghichu;
        } 
    }
}
