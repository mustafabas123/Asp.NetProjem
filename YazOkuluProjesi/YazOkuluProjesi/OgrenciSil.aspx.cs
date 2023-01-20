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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrenciId"]);
            Response.Write(x);
            EntityOgrenci2 ent=new EntityOgrenci2();
            ent.Id = x;
            BLLogrenci.OgrenciSilBLL(ent.Id);
            Response.Redirect("OgrenciListesi.aspx");//silme işlemi gerçekleiştikten sonra yönlendirilecek sayfayı belirttik
        }
    }
}