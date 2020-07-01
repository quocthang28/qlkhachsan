using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class DAL_Phong
    {
        public List<DTO_Phong> getPhongList(string tenlp)
        {
            string query = string.Format("SELECT * FROM dbo.PHONG JOIN dbo.LOAIPHONG ON PHONG.MALOAIPHONG = LOAIPHONG.MALOAIPHONG AND LOAIPHONG.TENLOAIPHONG = N'{0}'", tenlp);
            List<DTO_Phong> list = new List<DTO_Phong>();
            DataTable dt = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_Phong phong = new DTO_Phong(item);
                list.Add(phong);
            }
            return list;
        }

        public bool addPhong(DTO_Phong phong)
        {
            string query = string.Format("INSERT INTO dbo.Phong (MALOAIPHONG, TENPHONG, GHICHU, TINHTRANG) VALUES (N'{0}', N'{1}', N'{2}', {3})", phong.PHONG_MALOAIPHONG, phong.PHONG_TENPHONG, phong.PHONG_GHICHU, phong.PHONG_TINHTRANG);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool checkTrungTenPhong(string tenphong)
        {
            string query = string.Format("SELECT * FROM dbo.Phong WHERE TENPHONG = N'{0}'", tenphong);
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }
    }
}
