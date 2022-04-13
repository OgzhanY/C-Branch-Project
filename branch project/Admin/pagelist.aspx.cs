using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{      public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                SayfaTablosuGetir();
        }
        void SayfaTablosuGetir()
        {
            PageManagementBLL pb = new PageManagementBLL();

                    dt = pb.PageTablosuGetir2();
                    grdPages.DataSource = dt;
                     grdPages.DataBind();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
  }
