using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["pageid"]; // kolleksiyondur 
            if(!IsPostBack)
            {
                PageGetir(int.Parse(id));
            }

        }
        void PageGetir(int a)
        {
            PageManagementBLL pm = new PageManagementBLL();
           
            PageManagementModel pmm = pm.GetDetail(a);

            litPagename.Text ="Bu literal ismidir:"+ pmm.PageName +"<br>";
            litIcerik.Text ="Bu site içeriğidir: "+ pmm.PageContent + "<br>";
            ckEditor.Text = pmm.PageContent;
            Page.Title = pmm.Title;
            Page.MetaDescription = pmm.Desription;
            Page.MetaKeywords = pmm.Keywords;


        }
       
    }
}