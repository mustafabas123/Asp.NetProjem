using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
    internal class EntityBasvuru 
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

    }
}
