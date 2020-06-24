using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_KhachHang
    {
        private int _KHACHHANG_MAKHACHHANG;
        private int _KHACHHANG_MALOAIKHACHHANG;
        private string _KHACHHANG_TENKHACHHANG;
        private int _KHACHHANG_CMND;
        private string _KHACHHANG_DIACHI;

        public int KHACHHANG_MAKHACHHANG { get => _KHACHHANG_MAKHACHHANG; set => _KHACHHANG_MAKHACHHANG = value; }
        public int KHACHHANG_MALOAIKHACHHANG { get => _KHACHHANG_MALOAIKHACHHANG; set => _KHACHHANG_MALOAIKHACHHANG = value; }
        public string KHACHHANG_TENKHACHHANG { get => _KHACHHANG_TENKHACHHANG; set => _KHACHHANG_TENKHACHHANG = value; }
        public int KHACHHANG_CMND { get => _KHACHHANG_CMND; set => _KHACHHANG_CMND = value; }
        public string KHACHHANG_DIACHI { get => _KHACHHANG_DIACHI; set => _KHACHHANG_DIACHI = value; }

        public DTO_KhachHang(int makhachhang, int maloaikhachhang, string tenkhachhang, int cmnd, string diachi)
        {
            KHACHHANG_MAKHACHHANG = makhachhang;
            KHACHHANG_MALOAIKHACHHANG = maloaikhachhang;
            KHACHHANG_TENKHACHHANG = tenkhachhang;
            KHACHHANG_CMND = cmnd;
            KHACHHANG_DIACHI = diachi;
        }
    }
}
