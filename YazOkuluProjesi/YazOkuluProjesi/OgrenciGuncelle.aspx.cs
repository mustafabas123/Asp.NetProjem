using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer2;
using DataAccessLayer2;
using BussinessLogicLayer;

namespace YazOkuluProjesi
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrenciId"].ToString());
            TxtOgrenciId.Text= x.ToString();
            TxtOgrenciId.Enabled= false;
            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci2> OgrenciListesi = BLLogrenci.OgrenciDetay(x);
                TxtOgrenciAd.Text = OgrenciListesi[0].Ad.ToString();
                TxtOgrenciSoyad.Text = OgrenciListesi[0].Soyad.ToString();
                TxtOgrenciFoto.Text = OgrenciListesi[0].Fotograf.ToString();
                TxtOgrenciNumara.Text = OgrenciListesi[0].Numara.ToString();
                TxtOgrenciSifre.Text = OgrenciListesi[0].Sifre.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci2 enty = new EntityOgrenci2();
            enty.Id = Convert.ToInt32(TxtOgrenciId.Text);
            enty.Ad = TxtOgrenciAd.Text;
            enty.Soyad = TxtOgrenciSoyad.Text;
            enty.Numara = TxtOgrenciNumara.Text;
            enty.Sifre = TxtOgrenciSifre.Text;
            enty.Fotograf = TxtOgrenciFoto.Text;
            BLLogrenci.OgrenciGuncelleBLL(enty);
            Response.Redirect("OgrenciListesi.aspx");//Güncelleme gercekleştikten sonra yönlendirilcek sayfayı belirtiyoruz
        }
    }
}