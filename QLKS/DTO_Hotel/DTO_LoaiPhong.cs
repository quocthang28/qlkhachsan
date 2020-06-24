using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_LoaiPhong
    {
        private int _LOAIPHONG_MALOAIPHONG;
        private string _LOAIPHONG_TENLOAIPHONG;
        private int _LOAIPHONG_DONGIA;

        public int LOAIPHONG_MALOAIPHONG { get => _LOAIPHONG_MALOAIPHONG; set => _LOAIPHONG_MALOAIPHONG = value; }
        public string LOAIPHONG_TENLOAIPHONG { get => _LOAIPHONG_TENLOAIPHONG; set => _LOAIPHONG_TENLOAIPHONG = value; }
        public int LOAIPHONG_DONGIA { get => _LOAIPHONG_DONGIA; set => _LOAIPHONG_DONGIA = value; }

        public DTO_LoaiPhong(int maloaiphong, string tenloaiphong, int dongia)
        {
            LOAIPHONG_MALOAIPHONG = maloaiphong;
            LOAIPHONG_TENLOAIPHONG = tenloaiphong;
            LOAIPHONG_DONGIA = dongia;
        }
    }
}
