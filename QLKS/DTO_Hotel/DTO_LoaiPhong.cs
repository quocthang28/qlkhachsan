using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_LoaiPhong
    {
        private string _LOAIPHONG_MALOAIPHONG;
        private string _LOAIPHONG_TENLOAIPHONG;
        private int _LOAIPHONG_DONGIA;
        private string _LOAIPHONG_GHICHU;
        public string LOAIPHONG_MALOAIPHONG { get => _LOAIPHONG_MALOAIPHONG; set => _LOAIPHONG_MALOAIPHONG = value; }
        public string LOAIPHONG_TENLOAIPHONG { get => _LOAIPHONG_TENLOAIPHONG; set => _LOAIPHONG_TENLOAIPHONG = value; }
        public int LOAIPHONG_DONGIA { get => _LOAIPHONG_DONGIA; set => _LOAIPHONG_DONGIA = value; }
        public string LOAIPHONG_GHICHU { get => _LOAIPHONG_GHICHU; set => _LOAIPHONG_GHICHU = value; }

        public DTO_LoaiPhong(string maloaiphong, string tenloaiphong, int dongia, string ghichu)
        {
            LOAIPHONG_MALOAIPHONG = maloaiphong;
            LOAIPHONG_TENLOAIPHONG = tenloaiphong;
            LOAIPHONG_DONGIA = dongia;
            LOAIPHONG_GHICHU = ghichu;
        }
        public DTO_LoaiPhong(DataRow row)
        {
            LOAIPHONG_MALOAIPHONG = row["MALOAIPHONG"].ToString();
            LOAIPHONG_TENLOAIPHONG = row["TENLOAIPHONG"].ToString();
            LOAIPHONG_DONGIA = Int32.Parse(row["DONGIA"].ToString());
            LOAIPHONG_GHICHU = row["GHICHU"].ToString();
        }
        
    }
}
