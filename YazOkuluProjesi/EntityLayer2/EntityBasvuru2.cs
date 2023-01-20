using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer2
{
    public class EntityBasvuru2
    {
        private int basvuruId;
        public int BasvuruId
        {
            get { return basvuruId; }
            set
            {
                basvuruId = value;
            }
        }
        private int ogrenciId;
        public int OgrenciId
        {
            get { return ogrenciId; }
            set
            {
                ogrenciId = value;
            }
        }
        private int dersId;
        public int DersId
        {
            get { return dersId; }
            set { dersId = value; }
        }
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        private string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private string dersAd;
        public string DersAd
        {
            get { return dersAd; }
            set
            {
                dersAd = value;
            }
        }
    }
}
