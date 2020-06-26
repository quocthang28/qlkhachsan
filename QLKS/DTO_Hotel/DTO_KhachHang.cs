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
        private string _KHACHHANG_MALOAIKHACHHANG;
        private string _KHACHHANG_TENKHACHHANG;
        private string _KHACHHANG_CMND;
        private string _KHACHHANG_DIACHI;
        private string _KHACHHANG_PHONENUMBER;
        private string _KHACHHANG_NGAYSINH;

        public int KHACHHANG_MAKHACHHANG { get => _KHACHHANG_MAKHACHHANG; set => _KHACHHANG_MAKHACHHANG = value; }
        public string KHACHHANG_MALOAIKHACHHANG { get => _KHACHHANG_MALOAIKHACHHANG; set => _KHACHHANG_MALOAIKHACHHANG = value; }
        public string KHACHHANG_TENKHACHHANG { get => _KHACHHANG_TENKHACHHANG; set => _KHACHHANG_TENKHACHHANG = value; }
        public string KHACHHANG_CMND { get => _KHACHHANG_CMND; set => _KHACHHANG_CMND = value; }
        public string KHACHHANG_DIACHI { get => _KHACHHANG_DIACHI; set => _KHACHHANG_DIACHI = value; }
        public string KHACHHANG_PHONENUMBER { get => _KHACHHANG_PHONENUMBER; set => _KHACHHANG_PHONENUMBER = value; }
        public string KHACHHANG_NGAYSINH { get => _KHACHHANG_NGAYSINH; set => _KHACHHANG_NGAYSINH = value; }

        public DTO_KhachHang(int makhachhang, string maloaikhachhang, string tenkhachhang, string cmnd, string diachi, string sdt, string ngaysinh)
        {
            this.KHACHHANG_MAKHACHHANG = makhachhang;
            this.KHACHHANG_MALOAIKHACHHANG = maloaikhachhang;
            this.KHACHHANG_TENKHACHHANG = tenkhachhang;
            this.KHACHHANG_CMND = cmnd;
            this.KHACHHANG_DIACHI = diachi;
            this.KHACHHANG_PHONENUMBER = sdt;
            this.KHACHHANG_NGAYSINH = ngaysinh;
        }
    }
}
