using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            

            Giris(txtPassword.Text.Trim());
        }//ödev: kullanıcı girşini table den yapıpcaksın ve session u kapatmayı yapcaksın.
        void Giris(string gir)
        {
            try
            {
                LoginBLL lb = new LoginBLL();
                LoginModel lm = lb.LoginGetir(gir);
                
                if (txtUsername.Text == lm.LoginName && txtPassword.Text == lm.LoginPassword)
                {
                    Session["yonet"] = "1";
                    Response.Redirect("default.aspx");
                }
                else
                    Console.WriteLine("<script> alert('Yanlış giriş'); </script>");


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}