using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class DAL_LoaiPhong
    {
        public List<DTO_LoaiPhong> getLoaiPhongList()
        {
            string query = "SELECT * FROM dbo.LOAIPHONG";
            List<DTO_LoaiPhong> list = new List<DTO_LoaiPhong>();
            DataTable dt = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_LoaiPhong loaiPhong = new DTO_LoaiPhong(item);
                list.Add(loaiPhong);
            }
            return list;
        }


        public bool checkMaLoaiPhong(string maloaiphong)
        {
            string query = "SELECT * FROM dbo.LOAIPHONG WHERE MALOAIPHONG = " + "'" + maloaiphong + "'";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }

        public bool checkPhongByMALOAIPHONG(string maloaiphong)
        {
            string query = string.Format("SELECT * FROM dbo.PHONG WHERE MALOAIPHONG = N'{0}'", maloaiphong);
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }

        public bool themLoaiPhong(DTO_LoaiPhong lp)
        {
            string query = string.Format("INSERT INTO dbo.LOAIPHONG (MALOAIPHONG, TENLOAIPHONG, DONGIA, GHICHU) VALUES (N'{0}', N'{1}', {2}, N'{3}')", lp.LOAIPHONG_MALOAIPHONG, lp.LOAIPHONG_TENLOAIPHONG, lp.LOAIPHONG_DONGIA, lp.LOAIPHONG_GHICHU);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaLoaiPhong(string tenlp, int dongia, string ghichu, string malp)
        {
            string query = string.Format("UPDATE dbo.LOAIPHONG SET TENLOAIPHONG = N'{0}', DONGIA = {1}, GHICHU = N'{2}' WHERE MALOAIPHONG = N'{3}'", tenlp, dongia, ghichu, malp);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaLoaiPhong(string malp)
        {
            string query = string.Format("DELETE FROM dbo.LoaiPhong WHERE MALOAIPHONG = N'{0}'", malp);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
