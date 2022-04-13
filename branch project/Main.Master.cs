using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadPageMenu();
            }
                
            
        }
        void LoadPageMenu()
        {
            PageManagementBLL pbl = new PageManagementBLL();
            rptMainMenu.DataSource = pbl.PageTablosuGetir(true);
            rptMainMenu.DataBind();
        }
    }
}