using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
    internal class EntityDersler
    {
        private int derslerId;
        public int DerslerId
        {
            get { return derslerId; }
            set { derslerId = value; }
        }
        private string dersAd;
        public string DerslerAd
        {
            get { return dersAd; }
            set
            {
                dersAd = value;
            }
        }
        private int dersMaxKontenjan;
        public int DersMaxKontenjan
        {
            get { return dersMaxKontenjan; }
            set
            {
                dersMaxKontenjan = value;
            }
        }
        private int dersMinKontenjan;
        public int DersMinKontenjan
        {
            get { return dersMinKontenjan; }
            set
            {
                dersMinKontenjan = value;
            }
        }
    }
}
