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
    public class DALbasvuru
    {
        public static int BasvuruEkle(EntityBasvuru2 paramater)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_basvuru (OgrenciId,DersId) values(@p1,@p2)", Baglanti.baglan);
            if(komut1.Connection.State  != ConnectionState.Open) { 
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", paramater.OgrenciId);
            komut1.Parameters.AddWithValue("@p2", paramater.DersId);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityBasvuru2> BasvuruListeleme()
        {
            List<EntityBasvuru2> degerler=new List<EntityBasvuru2>();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_basvuru", Baglanti.baglan);
            if(komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr=komut2.ExecuteReader();
            while(dr.Read())
            {
                EntityBasvuru2 enty = new EntityBasvuru2();
                enty.BasvuruId = Convert.ToInt32(dr["BasvuruId"].ToString());
                enty.OgrenciId = Convert.ToInt32(dr["OgrenciId"].ToString()) ;
                enty.DersId = Convert.ToInt32(dr["DersId"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }
        public static List<EntityBasvuru2> BasvuruListeleme2()
        {
            List<EntityBasvuru2> degerler=new List<EntityBasvuru2>();
            SqlCommand komut3=new SqlCommand("select Tbl_ogrenci.OgrenciAd ,Tbl_ogrenci.OgrenciSoyad , " +
                "Tbl_dersler.DersAd from Tbl_basvuru inner join Tbl_ogrenci on Tbl_basvuru.OgrenciId=Tbl_ogrenci.OgrenciId " +
                "inner join Tbl_dersler on Tbl_basvuru.DersId=Tbl_dersler.DersId",Baglanti.baglan);
            if(komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            SqlDataReader dr=komut3.ExecuteReader();
            while(dr.Read())
            {
                EntityBasvuru2 enty=new EntityBasvuru2();
                enty.Ad = dr["OgrenciAd"].ToString();
                enty.Soyad= dr["OgrenciSoyad"].ToString();
                enty.DersAd= dr["DersAd"].ToString();
                degerler.Add(enty);
            }
            dr.Close() ;
            return degerler;
        }
    }
}
