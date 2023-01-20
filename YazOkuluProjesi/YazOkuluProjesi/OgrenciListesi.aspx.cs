using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer2;
using BussinessLogicLayer;
using EntityLayer2;

namespace YazOkuluProjesi
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci2> OgrListeleme = BLLogrenci.OgrenciListe();
            Repeater1.DataSource = OgrListeleme;
            Repeater1.DataBind();
        }
    }
}