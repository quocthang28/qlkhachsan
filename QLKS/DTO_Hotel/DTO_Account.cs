using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Account
    {
        private int _DANGKI_ID;
        private string _DANGKI_TK;
        private string _DANGKI_MK;
        private string _DANGKI_NAME;
        private string _DANGKI_EMAIL;
        private string _DANGKI_PHONENUMBER;
        private string _DANGKI_DIACHI;
        private int _DANGKI_ISADMIN;
        //public int DANGKI_ID
        //{
        //    get
        //    {
        //        return _DANGKI_ID;
        //    }
        //    set
        //    {
        //        _DANGKI_ID = value;
        //    }
        //}
        public string DANGKI_TK
        {
            get
            {
                return _DANGKI_TK;
            }
            set
            {
                _DANGKI_TK = value;
            }
        }
        public string DANGKI_MK
        {
            get
            {
                return _DANGKI_MK;
            }
            set
            {
                _DANGKI_MK = value;
            }
        }
        public string DANGKI_NAME
        {
            get
            {
                return _DANGKI_NAME;
            }
            set
            {
                _DANGKI_NAME = value;
            }
        }
        public string DANGKI_EMAIL
        {
            get
            {
                return _DANGKI_EMAIL;
            }
            set
            {
                _DANGKI_EMAIL = value;
            }
        }
        public string DANGKI_PHONENUMBER
        {
            get
            {
                return _DANGKI_PHONENUMBER;
            }
            set
            {
                _DANGKI_PHONENUMBER = value;
            }
        }
        public string DANGKI_DIACHI
        {
            get
            {
                return _DANGKI_DIACHI;
            }
            set
            {
                _DANGKI_DIACHI = value;
            }
        }

        public int DANGKI_ID { get => _DANGKI_ID; set => _DANGKI_ID = value; }
        public int DANGKI_ISADMIN { get => _DANGKI_ISADMIN; set => _DANGKI_ISADMIN = value; }

        public DTO_Account(string tk, string mk, int isAd, string name = null, string email = null, string phonenumber = null, string diachi = null) // for dang ki
        {

            this.DANGKI_TK = tk;
            this.DANGKI_MK = mk;
            this.DANGKI_NAME = name;
            this.DANGKI_EMAIL = email;
            this.DANGKI_PHONENUMBER = phonenumber;
            this.DANGKI_DIACHI = diachi;
            this.DANGKI_ISADMIN = isAd;
        }

        public DTO_Account(string tk, string mk, int isAd) // for dang ki
        {
            this.DANGKI_TK = tk;
            this.DANGKI_MK = mk;
            this.DANGKI_ISADMIN = isAd;
        }

        public DTO_Account(string tk, string mk) // for dang nhap
        {
            this.DANGKI_TK = tk;
            this.DANGKI_MK = mk;
        }

        public DTO_Account(DataRow row)
        {
            this.DANGKI_NAME = row["HOTEN"].ToString();
        }
    }
}
