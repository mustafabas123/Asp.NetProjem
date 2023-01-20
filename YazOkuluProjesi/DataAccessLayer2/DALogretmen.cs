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
    public class DALogretmen
    {
        public static int OgretmenEkle(EntityOgretmen2 paramaters)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_ogretmen (OgretmenAdSoyad,OgretmenBrans) values(@p1,@p2)", Baglanti.baglan);
            if(komut1.Connection.State !=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", paramaters.OgretmenAdSoyad);
            komut1.Parameters.AddWithValue("@p2", paramaters.Brans);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityOgretmen2> OgretmenListele()
        {
            List<EntityOgretmen2> degerler = new List<EntityOgretmen2>();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_ogretmen", Baglanti.baglan);
            if(komut2.Connection.State !=ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen2 enty = new EntityOgretmen2();
                enty.Ogretmenid = Convert.ToInt32(dr["OgretmenId"].ToString());
                enty.OgretmenAdSoyad = dr["OgretmenAdSoyad"].ToString();
                enty.Brans = Convert.ToInt32(dr["OgretmenBrans"].ToString());
                degerler.Add(enty);
            }
            dr.Close();
            return degerler;
        }
    }
}
