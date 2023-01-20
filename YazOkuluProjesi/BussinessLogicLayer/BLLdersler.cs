using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer2;
using EntityLayer2;

namespace BussinessLogicLayer
{
    public class BLLdersler
    {
        public static int DersEkleBLL(EntityDersler2 p)
        {
            if(p.DerslerAd !=null && p.DersMinKontenjan !=null && p.DersMaxKontenjan != null)
            {
                return DALDersler.DersEkle(p);
            }
            return -1;
        }
        public static List<EntityDersler2> DersleriListeleBLL()
        {
            return DALDersler.DersListeleme();
        }
        
        public static int BasvuruEkle(EntityBasvuru2 p)
        {
            if(p.BasvuruId !=null && p.DersId != null)
            {
                return DALDersler.BasvuruEkle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
