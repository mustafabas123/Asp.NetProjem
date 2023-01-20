using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer2;

namespace DataAccessLayer2
{
    public class DALogrenci
    {
        public static int OgrenciEkle(EntityOgrenci2 parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_ogrenci (OgrenciAd,OgrenciSoyad,OgrenciFoto,OgrenciNumara,OgrenciSifre) " +
                "values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglan);
            if(komut1.Connection.State !=ConnectionState.Open) {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p4", parametre.Numara);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityOgrenci2> OgrenciListele()
        {
            List<EntityOgrenci2> degerler=new List<EntityOgrenci2>();
            SqlCommand komut2=new SqlCommand("select * from Tbl_ogrenci",Baglanti.baglan);
            if(komut2.Connection.State !=ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr=komut2.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci2 enty=new EntityOgrenci2();
                enty.Id = Convert.ToInt32(dr["OgrenciId"].ToString());
                enty.Ad = (dr["OgrenciAd"] + " " + dr["OgrenciSoyad"]).ToString(); 
                enty.Soyad = dr["OgrenciSoyad"].ToString();
                enty.Fotograf = dr["OgrenciFoto"].ToString();
                enty.Numara = dr["OgrenciNumara"].ToString();
                enty.Sifre = dr["OgrenciSifre"].ToString();
                enty.Bakiye = Convert.ToDouble(dr["OgrenciBakiye"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }
        public static List<EntityOgrenci2> OgrenciDetay(int id)
        {
            List<EntityOgrenci2> degerler=new List<EntityOgrenci2>();
            SqlCommand komut1 = new SqlCommand("select * from Tbl_ogrenci where OgrenciId=@p1",Baglanti.baglan);
            if(komut1.Connection.State !=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr=komut1.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci2 enty=new EntityOgrenci2();
                enty.Ad = dr["OgrenciAd"].ToString();
                enty.Soyad = dr["OgrenciSoyad"].ToString();
                enty.Fotograf = dr["OgrenciFoto"].ToString();
                enty.Numara = dr["OgrenciNumara"].ToString();
                enty.Sifre = dr["OgrenciSifre"].ToString();
                enty.Bakiye = Convert.ToDouble(dr["OgrenciBakiye"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int paramater)
        {
            SqlCommand komut3 = new SqlCommand("delete from Tbl_ogrenci where OgrenciId=@p1", Baglanti.baglan);
            
            if(komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", paramater);
            return komut3.ExecuteNonQuery() > 1;
        }
        public static bool OgrenciGuncelle(EntityOgrenci2 paremeter)
        {
            SqlCommand komut5 = new SqlCommand("update Tbl_ogrenci set OgrenciAd=@p1,OgrenciSoyad=@p2,OgrenciFoto=@p3,OgrenciSifre=@p4,OgrenciNumara=@p5 where OgrenciId=@p6", Baglanti.baglan);
            if(komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", paremeter.Ad);
            komut5.Parameters.AddWithValue("@p2", paremeter.Soyad);
            komut5.Parameters.AddWithValue("@p3", paremeter.Fotograf);
            komut5.Parameters.AddWithValue("@p4", paremeter.Sifre);
            komut5.Parameters.AddWithValue("@p5", paremeter.Numara);
            komut5.Parameters.AddWithValue("@p6", paremeter.Id);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
