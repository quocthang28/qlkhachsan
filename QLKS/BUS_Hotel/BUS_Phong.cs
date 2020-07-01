using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_Phong
    {
        DAL_Phong dalPhong = new DAL_Phong();
        public List<DTO_Phong> getPhongList(string tenlp)
        {
            return dalPhong.getPhongList(tenlp);
        }

        public bool addPhong(DTO_Phong phong)
        {
            return dalPhong.addPhong(phong);
        }

        public bool checkTrungTenPhong(string tenphong)
        {
            return dalPhong.checkTrungTenPhong(tenphong);
        }
    }
}
