using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer2;
using EntityLayer2;

namespace BussinessLogicLayer
{
    public class BLLogretmen
    {
        public static int OgretmenEkleBLL(EntityOgretmen2 p)
        {
            if(p.OgretmenAdSoyad !=null && p.Brans != null)
            {
                return DALogretmen.OgretmenEkle(p);
            }
            return -1;
        }
        public static List<EntityOgretmen2> OgretmenListelemeBLL()
        {
            return DALogretmen.OgretmenListele();
        }
    }
}
