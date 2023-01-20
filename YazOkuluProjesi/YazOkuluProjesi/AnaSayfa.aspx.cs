using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer2;
using EntityLayer2;
using BussinessLogicLayer;

namespace YazOkuluProjesi
{
    public partial class AnaSayfa1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void temizle()
        {
            TxtOgrenciAd.Text = " ";
            TxtOgrenciFoto.Text = " ";
            TxtOgrenciNumara.Text = " ";
            TxtOgrenciSifre.Text = " ";
            TxtOgrenciSoyad.Text = " ";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci2 entity= new EntityOgrenci2();
            entity.Ad = TxtOgrenciAd.Text;
            entity.Soyad = TxtOgrenciSoyad.Text;
            entity.Numara = TxtOgrenciNumara.Text;
            entity.Sifre= TxtOgrenciSifre.Text;
            entity.Fotograf= TxtOgrenciFoto.Text;
            BLLogrenci.OgrenciEkleBLL(entity);
            temizle();
        }
    }
}