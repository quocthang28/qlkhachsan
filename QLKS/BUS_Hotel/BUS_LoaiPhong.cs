using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

    }
}
