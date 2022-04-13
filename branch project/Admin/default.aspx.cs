using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Session["yonet"]!=null&&Session["yonet"].ToString()=="1"))
            {
                Response.Redirect("login.aspx"); // session oluşturulmadıysa login sayfasında gönderdik
            }
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            //Session.Abandon();
            Session.Remove("yonet");
          
            // Response.Redirect("login.aspx");
        }
    }
}