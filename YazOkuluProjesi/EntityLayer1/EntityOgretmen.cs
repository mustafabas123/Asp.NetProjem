using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
    internal class EntityOgretmen
    {
        private int ogretmenid;
        public int Ogretmenid
        {
            get { return ogretmenid; }
            set { ogretmenid = value; }

        }
        private string ogretmenAdSoyad;
        public string OgretmenAdSoyad
        {
            get { return ogretmenAdSoyad; }
            set { ogretmenAdSoyad = value; }
        }
        private int brans;
        public int Brans
        {
            get { return brans; }
            set
            {
                brans = value;
            }   
        }

    }
}
