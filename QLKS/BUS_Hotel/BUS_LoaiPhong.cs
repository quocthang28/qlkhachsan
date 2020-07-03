using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{

    public class BUS_LoaiPhong
    {

        private static BUS_LoaiPhong instance;

        public static BUS_LoaiPhong Instance
        {
            get { if (instance == null) instance = new BUS_LoaiPhong(); return BUS_LoaiPhong.instance; }
            private set { BUS_LoaiPhong.instance = value; }
        }

        public List<DTO_LoaiPhong> LoadDanhSachLoaiPhong()
        {
            return DAL_LoaiPhong.Instance.loadDanhSachLoaiPhong();
        }
        /// <summary>
        /// /
        /// </summary>
        DAL_LoaiPhong dalLoaiPhong = new DAL_LoaiPhong();

        public bool checkMaLoaiPhong(string maloaiphong)
        {
            return dalLoaiPhong.checkMaLoaiPhong(maloaiphong);
        }

        public bool checkPhongByMALOAIPHONG(string maloaiphong)
        {
            return dalLoaiPhong.checkPhongByMALOAIPHONG(maloaiphong);
        }

        public bool themLoaiPhong(DTO_LoaiPhong lp)
        {
            return dalLoaiPhong.themLoaiPhong(lp);
        }

        public bool suaLoaiPhong(string tenlp, int dongia, string ghichu, string malp)
        {
            return dalLoaiPhong.suaLoaiPhong(tenlp, dongia, ghichu, malp);
        }

        public bool xoaLoaiPhong(string malp)
        {
            return dalLoaiPhong.xoaLoaiPhong(malp);
        }
        public List<DTO_LoaiPhong> getLoaiPhongList()
        {
            return dalLoaiPhong.getLoaiPhongList();
        }

    }
}
