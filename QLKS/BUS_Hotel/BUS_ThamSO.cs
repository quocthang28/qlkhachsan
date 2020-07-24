using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
namespace BUS_Hotel
{
    public class BUS_ThamSo
    {
        private static BUS_ThamSo instance;

        public static BUS_ThamSo Instance
        {
            get { if (instance == null) instance = new BUS_ThamSo(); return BUS_ThamSo.instance; }
            private set { BUS_ThamSo.instance = value; }
        }

        public bool ThayDoiHeSo(float heso)
        {
            return DAL_ThamSo.Instance.ThayDoiHeSo(heso);
        }
        public bool ThayDoiPhuThu(float heso)
        {
            return DAL_ThamSo.Instance.ThayDoiHeSo(heso);
        }
        public bool ThayDoiSoNguoiToiDaTrongPhong(int songuoitoidatrongphong)
        {
            return DAL_ThamSo.Instance.ThayDoiHeSo(songuoitoidatrongphong);
        }
    }
}
