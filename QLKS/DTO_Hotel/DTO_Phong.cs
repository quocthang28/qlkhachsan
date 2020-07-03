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
        private int _PHONG_MAPHONG;
        private string _PHONG_MALOAIPHONG;
        private string _PHONG_TENPHONG;
        private string _PHONG_GHICHU;
        private int _PHONG_CONTRONG;
        public int PHONG_ID { get => _PHONG_ID; set => _PHONG_ID = value; }
        public string PHONG_MALOAIPHONG { get => _PHONG_MALOAIPHONG; set => _PHONG_MALOAIPHONG = value; }
        public string PHONG_TENPHONG { get => _PHONG_TENPHONG; set => _PHONG_TENPHONG = value; }
        public string PHONG_GHICHU { get => _PHONG_GHICHU; set => _PHONG_GHICHU = value; }
        public int PHONG_MAPHONG { get => _PHONG_MAPHONG; set => _PHONG_MAPHONG = value; }
        public int PHONG_CONTRONG { get => _PHONG_CONTRONG; set => _PHONG_CONTRONG = value; }

        public DTO_Phong(string maloaiphong, string tenphong, string ghichu, int maphong, int controng)
        {
            PHONG_MALOAIPHONG = maloaiphong;
            PHONG_TENPHONG = tenphong;
            PHONG_GHICHU = ghichu;
            PHONG_MAPHONG = maphong;
            PHONG_CONTRONG = controng;
        }

        public DTO_Phong(DataRow row)
        {
            PHONG_MAPHONG = (int)row["MAPHONG"];
            PHONG_MALOAIPHONG = row["MALOAIPHONG"].ToString();
            PHONG_TENPHONG = (row["TENPHONG"]).ToString();
            PHONG_GHICHU = row["GHICHU"].ToString();
            PHONG_CONTRONG = (int)row["TINHTRANG"];
        }
    }
}
