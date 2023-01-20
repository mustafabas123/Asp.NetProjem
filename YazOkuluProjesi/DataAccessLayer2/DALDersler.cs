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
    public class DALDersler
    {
        public static int DersEkle(EntityDersler2 paramater)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_dersler (DersAd,DersMaxKontenjan,DersMinKontenjan) values(@p1,@p2,@p3)", Baglanti.baglan);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", paramater.DerslerAd);
            komut1.Parameters.AddWithValue("@p2", paramater.DersMaxKontenjan);
            komut1.Parameters.AddWithValue("@p3", paramater.DersMinKontenjan);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityDersler2> DersListeleme()
        {
            List<EntityDersler2> degerler = new List<EntityDersler2>();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_dersler", Baglanti.baglan);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler2 enty = new EntityDersler2();
                enty.DerslerId = Convert.ToInt32(dr["DersId"].ToString());
                enty.DerslerAd = dr["DersAd"].ToString();
                enty.DersMinKontenjan = Convert.ToInt32(dr["DersMinKontenjan"].ToString());
                enty.DersMaxKontenjan = Convert.ToInt32(dr["DersMaxKontenjan"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }
        public static int BasvuruEkle(EntityBasvuru2 parameter)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_basvuru (OgrenciId,DersId) values (@p1,@p2)", Baglanti.baglan);
            if(komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", parameter.OgrenciId);
            komut2.Parameters.AddWithValue("@p2", parameter.DersId);
            return komut2.ExecuteNonQuery();
        }
    }
}
