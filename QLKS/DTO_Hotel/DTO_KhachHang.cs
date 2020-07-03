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
        private int _KHACHHANG_CMND;
        private string _KHACHHANG_DIACHI;
        private DateTime? _KHACHHANG_NGAYSINH;
        private int _KHACHHANG_SODIENTHOAI;
        private DataRow item;

        public int maKhachHang { get => _KHACHHANG_MAKHACHHANG; set => _KHACHHANG_MAKHACHHANG = value; }
        public int maLoaiKhachHang { get => _KHACHHANG_MALOAIKHACHHANG; set => _KHACHHANG_MALOAIKHACHHANG = value; }
        public string tenKhachHang { get => _KHACHHANG_TENKHACHHANG; set => _KHACHHANG_TENKHACHHANG = value; }
        public int CMND { get => _KHACHHANG_CMND; set => _KHACHHANG_CMND = value; }
        public string diaChi { get => _KHACHHANG_DIACHI; set => _KHACHHANG_DIACHI = value; }
        public DateTime? ngaySinh  { get => _KHACHHANG_NGAYSINH ; set => _KHACHHANG_NGAYSINH = value; }
        public int SDT { get => _KHACHHANG_SODIENTHOAI; set => _KHACHHANG_SODIENTHOAI = value; }




        public DTO_KhachHang(int makhachhang, int maloaikhachhang, string tenkhachhang, int cmnd, string diachi,DateTime? ngaysinh, int sdt)
        {
            maKhachHang = makhachhang;
            maLoaiKhachHang = maloaikhachhang;
            tenKhachHang = tenkhachhang;
            CMND = cmnd;
            diaChi = diachi;
            ngaySinh = ngaysinh ;
            SDT = sdt;
        }


        public DTO_KhachHang(DataRow row)
        {
            maKhachHang = (int)row["MAKHACHHANG"];
            maLoaiKhachHang = (int)row["MALOAIKHACHHANG"];
            tenKhachHang = row["TENKHACHHANG"].ToString();
            CMND = int.Parse(row["CMND"].ToString());
            diaChi = row["DIACHI"].ToString();
            SDT = (int)row["SODIENTHOAI"];
            ngaySinh = DateTime.Parse(row["NGAYSINH"].ToString());
        }
    }
}
