using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_BCDT
    {
        private int _BCDT_ID;
        private int _BCDT_MONTH;
        private int _BCDT_TDT;

        public int BCDT_ID { get => _BCDT_ID; set => _BCDT_ID = value; }
        public int BCDT_MONTH { get => _BCDT_MONTH; set => _BCDT_MONTH = value; }
        public int BCDT_TDT { get => _BCDT_TDT; set => _BCDT_TDT = value; }

        public DTO_BCDT(int month, int tdt)
        {
            this.BCDT_MONTH = month;
            this.BCDT_TDT = tdt;
        }
    }
}
