using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogicLayer;
using EntityLayer2;

namespace YazOkuluProjesi
{
    public partial class BasvuruListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityBasvuru2> listeleme=BLLbasvuru.BasvuruListeleme();
            Repeater1.DataSource= listeleme;
            Repeater1.DataBind();
        }
    }
}