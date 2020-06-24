using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ChiTietBaoCaoDoanhThu
    {
        private int _CHITIETBAOCAODOANHTHU_MACTBCDT;
        private int _CHITIETBAOCAODOANHTHU_MABCDT;
        private int _CHITIETBAOCAODOANHTHU_MALOAIPHONG;
        private int _CHITIETBAOCAODOANHTHU_DOANHTHU;
        private int _CHITIETBAOCAODOANHTHU_TYLE;

        public int CHITIETBAOCAODOANHTHU_MACTBCDT { get => _CHITIETBAOCAODOANHTHU_MACTBCDT; set => _CHITIETBAOCAODOANHTHU_MACTBCDT = value; }
        public int CHITIETBAOCAODOANHTHU_MABCDT { get => _CHITIETBAOCAODOANHTHU_MABCDT; set => _CHITIETBAOCAODOANHTHU_MABCDT = value; }
        public int CHITIETBAOCAODOANHTHU_MALOAIPHONG { get => _CHITIETBAOCAODOANHTHU_MALOAIPHONG; set => _CHITIETBAOCAODOANHTHU_MALOAIPHONG = value; }
        public int CHITIETBAOCAODOANHTHU_DOANHTHU { get => _CHITIETBAOCAODOANHTHU_DOANHTHU; set => _CHITIETBAOCAODOANHTHU_DOANHTHU = value; }
        public int CHITIETBAOCAODOANHTHU_TYLE { get => _CHITIETBAOCAODOANHTHU_TYLE; set => _CHITIETBAOCAODOANHTHU_TYLE = value; }

        public DTO_ChiTietBaoCaoDoanhThu(int mactbcdt, int mabcdt, int maloaiphong, int doanhthu, int tyle)
        {
            CHITIETBAOCAODOANHTHU_MACTBCDT = mactbcdt;
            CHITIETBAOCAODOANHTHU_MABCDT = mabcdt;
            CHITIETBAOCAODOANHTHU_MALOAIPHONG = maloaiphong;
            CHITIETBAOCAODOANHTHU_DOANHTHU = doanhthu;
            CHITIETBAOCAODOANHTHU_TYLE = tyle;
        }
    }
}
