using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ThamSo
    {
        private int _THAMSO_MATHAMSO;
        private string _THAMSO_TENTHAMSO;
        private float _THAMSO_GIATRITHAMSO;
        private string _THAMSO_GHICHU;

        public int THAMSO_MATHAMSO { get => _THAMSO_MATHAMSO; set => _THAMSO_MATHAMSO = value; }
        public string THAMSO_TENTHAMSO { get => _THAMSO_TENTHAMSO; set => _THAMSO_TENTHAMSO = value; }
        public float THAMSO_GIATRITHAMSO { get => _THAMSO_GIATRITHAMSO; set => _THAMSO_GIATRITHAMSO = value; }
        public string THAMSO_GHICHU { get => _THAMSO_GHICHU; set => _THAMSO_GHICHU = value; }

        public DTO_ThamSo(int mathamso, string tenthamso, float giatrithamso, string ghichu)
        {
            this.THAMSO_MATHAMSO = mathamso;
            this.THAMSO_TENTHAMSO = tenthamso;
            this.THAMSO_GIATRITHAMSO = giatrithamso;
            this.THAMSO_GHICHU = ghichu;
        }


    }
}
