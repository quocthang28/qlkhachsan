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
        private int _PHONG_ID;
        private string _PHONG_MAPHONG;
        private string _PHONG_MALOAIPHONG;
        private string _PHONG_TENPHONG;
        private string _PHONG_GHICHU;
        private int _PHONG_TINHTRANG;
        public int PHONG_ID { get => _PHONG_ID; set => _PHONG_ID = value; }
        public string PHONG_MALOAIPHONG { get => _PHONG_MALOAIPHONG; set => _PHONG_MALOAIPHONG = value; }
        public string PHONG_TENPHONG { get => _PHONG_TENPHONG; set => _PHONG_TENPHONG = value; }
        public string PHONG_GHICHU { get => _PHONG_GHICHU; set => _PHONG_GHICHU = value; }
        public string PHONG_MAPHONG { get => _PHONG_MAPHONG; set => _PHONG_MAPHONG = value; }
        public int PHONG_TINHTRANG { get => _PHONG_TINHTRANG; set => _PHONG_TINHTRANG = value; }

        public DTO_Phong(string maloaiphong, string tenphong, string ghichu, int tinhtrang)
        {
            PHONG_MALOAIPHONG = maloaiphong;
            PHONG_TENPHONG = tenphong;
            PHONG_GHICHU = ghichu;
            PHONG_TINHTRANG = tinhtrang;
        } 

        public DTO_Phong(DataRow row)
        {
            PHONG_ID = Int32.Parse(row["MAPHONG"].ToString());
            PHONG_MALOAIPHONG = row["MALOAIPHONG"].ToString();
            PHONG_TENPHONG = row["TENPHONG"].ToString();
            PHONG_GHICHU = row["GHICHU"].ToString();
            PHONG_MAPHONG = row["MAPHONG"].ToString();
            PHONG_TINHTRANG = (int)row["TINHTRANG"];
        }
    }
}
