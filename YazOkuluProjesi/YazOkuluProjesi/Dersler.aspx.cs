using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogicLayer;
using DataAccessLayer2;
using EntityLayer2;

namespace YazOkuluProjesi
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler2> enty = BLLdersler.DersleriListeleBLL();
                DropDownList1.DataSource = BLLdersler.DersleriListeleBLL();
                DropDownList1.DataTextField = "DerslerAd";
                DropDownList1.DataValueField = "DerslerId";
                DropDownList1.DataBind();

                List<EntityOgrenci2> enty2 = BLLogrenci.OgrenciListe();
                DropDownList2.DataSource = BLLogrenci.OgrenciListe();
                DropDownList2.DataTextField = "Ad";
                DropDownList2.DataValueField = "Id";
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuru2 enty=new EntityBasvuru2();
            enty.OgrenciId = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
            enty.DersId=Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            BLLdersler.BasvuruEkle(enty);
            Response.Redirect("Dersler.aspx");
        }
    }
}