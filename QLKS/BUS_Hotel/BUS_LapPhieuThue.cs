﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_LapPhieuThue
    {
        DAL_LapPhieuThue dalHotel = new DAL_LapPhieuThue();
        public DataTable getPhieuthue(int id)
        {
            return dalHotel.getPhieuthue(id);
        }
    
        public bool lapPhieuThue(DTO_PhieuThuePhong pt)
        {
            return dalHotel.lapPhieuThue(pt);
        }
        
        public string loadMaPhieuThue(string a , int b)
        {
            return dalHotel.loadMaPhieuThue(a,b);
        }

        public string loadMaPhong(int mpt)
        {
            return dalHotel.loadMaPhong(mpt);
        }
        public bool suaPhieuThue(DTO_PhieuThuePhong pt)
        {
            return dalHotel.suaPhieuThue(pt);
        }
        public bool xoaPhieuThue(int a)
        {
            return dalHotel.xoaPhieuThue(a);
        }
        

    }
}
