using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Phong
    {
        
        private int _PHONG_MAPHONG;
        private int _PHONG_MALOAIPHONG;
        private string _PHONG_TENPHONG;
        private string _PHONG_GHICHU;

     
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
        public DTO_Phong(DataRow row)
        {
            this.PHONG_MAPHONG = (int)row["MAPHONG"];
            this.PHONG_MALOAIPHONG = (int)row["MALOAIPHONG"];
            this.PHONG_TENPHONG = (string)row["TENPHONG"];
            this.PHONG_GHICHU = (string)row["GHICHU"];
        }
    }
}
