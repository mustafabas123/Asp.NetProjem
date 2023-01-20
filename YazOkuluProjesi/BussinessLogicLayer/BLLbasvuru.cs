using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer2;
using EntityLayer2;

namespace BussinessLogicLayer
{
    public class BLLbasvuru
    {
        public static int BasvuruEkleBLL(EntityBasvuru2 p)
        {
            if (p.OgrenciId != null && p.DersId != null)
            {
                return DALbasvuru.BasvuruEkle(p);
            }
            return -1;
        }
        public static List<EntityBasvuru2> BasvuruListelemeBLL()
        {
            return DALbasvuru.BasvuruListeleme();
        }
        public static List<EntityBasvuru2> BasvuruListeleme()
        {
            return DALbasvuru.BasvuruListeleme2();
        }
    }
}
