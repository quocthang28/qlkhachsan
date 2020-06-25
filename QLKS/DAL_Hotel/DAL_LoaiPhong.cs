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
        public List<DTO_LoaiPhong> showLoaiPhong()
        {
            //string query = "SELECT MALOAIPHONG AS " + "'Mã Loại Phòng', " + "TENLOAIPHONG AS " + "'Tên loại phòng', " + "DONGIA AS " +"'Đơn giá', " + "GHICHU AS " + "'Ghi chú'" + " FROM dbo.LOAIPHONG";
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
        
        public bool checkMALOAIPHONG(string maloaiphong)
        {
            string query = "SELECT * FROM dbo.LOAIPHONG WHERE MALOAIPHONG = " + "'" + maloaiphong + "'";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }

        public bool themLoaiPhong(DTO_LoaiPhong lp)
        {
            string query = string.Format("INSERT INTO dbo.LOAIPHONG (MALOAIPHONG, TENLOAIPHONG, DONGIA, GHICHU) VALUES (N'{0}', N'{1}', {2}, N'{3}')", lp.LOAIPHONG_MALOAIPHONG, lp.LOAIPHONG_TENLOAIPHONG, lp.LOAIPHONG_DONGIA, lp.LOAIPHONG_GHICHU);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
