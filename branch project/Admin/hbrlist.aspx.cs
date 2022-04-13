using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class hbrlist : System.Web.UI.Page
    {
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                HaberTablosuGetir();
        }
        void HaberTablosuGetir()
        {
            HaberBLL pb = new HaberBLL();

            dt = pb.HaberTablosuGetir2();
            grdHaber.DataSource = dt;
            grdHaber.DataBind();
        }
    }
}