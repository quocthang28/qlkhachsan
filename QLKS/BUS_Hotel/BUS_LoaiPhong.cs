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
        DAL_LoaiPhong dalLoaiPhong = new DAL_LoaiPhong();

        public bool checkMaLoaiPhong(string maloaiphong)
        {
            return dalLoaiPhong.checkMALOAIPHONG(maloaiphong);
        }

        public bool themLoaiPhong(DTO_LoaiPhong lp)
        {
            return dalLoaiPhong.themLoaiPhong(lp);
        }

        public List<DTO_LoaiPhong> showLoaiPhong()
        {
            return dalLoaiPhong.showLoaiPhong();
        }


    }
}
