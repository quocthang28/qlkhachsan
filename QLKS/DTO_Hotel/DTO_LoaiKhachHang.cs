using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_LoaiKhachHang
    {
        private int _LOAIKHACHHANG_MALOAIKHACHHANG;
        private string _LOAIKHACHHANG_TENLOAIKHACHHANG;

        public int LOAIKHACHHANG_MALOAIKHACHHANG { get => _LOAIKHACHHANG_MALOAIKHACHHANG; set => _LOAIKHACHHANG_MALOAIKHACHHANG = value; }

        public string LOAIKHACHHANG_TENLOAIKHACHHANG { get => _LOAIKHACHHANG_TENLOAIKHACHHANG; set => _LOAIKHACHHANG_TENLOAIKHACHHANG = value; }

        public DTO_LoaiKhachHang(int maloaikhachhang, string tenloaikhachhang)
        {
            LOAIKHACHHANG_MALOAIKHACHHANG = maloaikhachhang;
            LOAIKHACHHANG_TENLOAIKHACHHANG = tenloaikhachhang;
        }
    }
}
