using System;
using System.Collections.Generic;
using System.Data;
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
        private string _KHACHHANG_CMND;
        private string _KHACHHANG_DIACHI;
        private string _KHACHHANG_NGAYSINH;
        private string _KHACHHANG_SODIENTHOAI;


        public int KHACHHANG_MAKHACHHANG { get => _KHACHHANG_MAKHACHHANG; set => _KHACHHANG_MAKHACHHANG = value; }
        public int KHACHHANG_MALOAIKHACHHANG { get => _KHACHHANG_MALOAIKHACHHANG; set => _KHACHHANG_MALOAIKHACHHANG = value; }
        public string KHACHHANG_TENKHACHHANG { get => _KHACHHANG_TENKHACHHANG; set => _KHACHHANG_TENKHACHHANG = value; }
        public string KHACHHANG_CMND { get => _KHACHHANG_CMND; set => _KHACHHANG_CMND = value; }
        public string KHACHHANG_DIACHI { get => _KHACHHANG_DIACHI; set => _KHACHHANG_DIACHI = value; }
        public string KHACHHANG_NGAYSINH { get => _KHACHHANG_NGAYSINH ; set => _KHACHHANG_NGAYSINH = value; }
        public string KHACHHANG_SODIENTHOAI { get => _KHACHHANG_SODIENTHOAI; set => _KHACHHANG_SODIENTHOAI = value; }




        public DTO_KhachHang(int makhachhang, int maloaikhachhang, string tenkhachhang, string cmnd, string diachi,string sdt, string ngaysinh)
        {
            KHACHHANG_MAKHACHHANG = makhachhang;
            KHACHHANG_MALOAIKHACHHANG = maloaikhachhang;
            KHACHHANG_TENKHACHHANG = tenkhachhang;
            KHACHHANG_CMND = cmnd;
            KHACHHANG_DIACHI = diachi;
            KHACHHANG_NGAYSINH = ngaysinh ;
            KHACHHANG_SODIENTHOAI = sdt;
        }


        public DTO_KhachHang(DataRow row)
        {
            KHACHHANG_MAKHACHHANG = (int)row["MAKHACHHANG"];
            KHACHHANG_MALOAIKHACHHANG = (int)row["MALOAIKHACHHANG"];
            KHACHHANG_TENKHACHHANG = row["TENKHACHHANG"].ToString();
            KHACHHANG_CMND = (row["CMND"].ToString().ToString());
            KHACHHANG_DIACHI = row["DIACHI"].ToString();
            KHACHHANG_SODIENTHOAI = row["SODIENTHOAI"].ToString();
            KHACHHANG_NGAYSINH = row["NGAYSINH"].ToString();
        }

        public DTO_KhachHang(DataRow row)
        {
            KHACHHANG_MAKHACHHANG = (int)row["MAKHACHHANG"];
            KHACHHANG_MALOAIKHACHHANG = (int)row["MALOAIKHACHHANG"];
            KHACHHANG_TENKHACHHANG = row["TENKHACHHANG"].ToString();
            KHACHHANG_CMND = row["CMND"].ToString();
            KHACHHANG_DIACHI = row["DIACHI"].ToString();
            KHACHHANG_PHONENUMBER = row["SODIENTHOAI"].ToString();
            KHACHHANG_NGAYSINH = row["NGAYSINH"].ToString();
        }
    }
}
