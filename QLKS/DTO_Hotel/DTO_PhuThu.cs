using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_PhuThu
    {
        private int _PHUTHU_ID;
        private string _PHUTHU_NAME;
        private string _PHUTHU_TYLE;
        private string _PHUTHU_GHICHU;

        public int PHUTHU_ID { get => _PHUTHU_ID; set => _PHUTHU_ID = value; }
        public string PHUTHU_NAME { get => _PHUTHU_NAME; set => _PHUTHU_NAME = value; }
        public string PHUTHU_TYLE { get => _PHUTHU_TYLE; set => _PHUTHU_TYLE = value; }
        public string PHUTHU_GHICHU { get => _PHUTHU_GHICHU; set => _PHUTHU_GHICHU = value; }

        public DTO_PhuThu(string name, string tyle, string ghichu)
        {
            this.PHUTHU_NAME = name;
            this.PHUTHU_TYLE = tyle;
            this._PHUTHU_GHICHU = ghichu;
        }
    }
}
