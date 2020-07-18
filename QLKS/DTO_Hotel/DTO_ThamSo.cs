using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ThamSo
    {
        private int _THAMSO_SOLUONGKHACHTOIDA;

        public int THAMSO_SOLUONGKHACHTOIDA { get => _THAMSO_SOLUONGKHACHTOIDA; set => _THAMSO_SOLUONGKHACHTOIDA = value; }

        public DTO_ThamSo(int soluongkhachtoida)
        {
            THAMSO_SOLUONGKHACHTOIDA = soluongkhachtoida;
        }
    }
}
