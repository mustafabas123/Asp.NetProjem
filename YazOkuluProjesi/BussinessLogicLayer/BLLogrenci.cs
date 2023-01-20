using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer2;
using DataAccessLayer2;


namespace BussinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci2 p)
        {
            if(p.Ad !=null && p.Soyad !=null && p.Numara !=null && p.Sifre !=null && p.Fotograf !=null)
            {
                return DALogrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci2> OgrenciListe()
        {
            return DALogrenci.OgrenciListele();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if(p != null)
            {
                return DALogrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci2> OgrenciDetay(int id)
        {
            return DALogrenci.OgrenciDetay(id);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci2 p)
        {
            if (p.Ad != null && p.Ad !="" && p.Soyad != null && p.Soyad !="" && p.Numara != null && p.Numara != "" && p.Sifre != null && p.Sifre != "" && p.Fotograf != null && p.Fotograf != "" && p.Id >0)
            {
                return DALogrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
