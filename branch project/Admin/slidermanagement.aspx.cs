using BLL;
using MODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
       
        DataTable dt = null;
        public static string pageekle;
        public static string pagesil;
        protected void Page_Load(object sender, EventArgs e)
        {
          
                

            pageekle = Request.QueryString["pageekle"];
            pagesil = Request.QueryString["pagesil"];
            if (!IsPostBack)
            {
                ResimGetir();
                if (pageekle != null)
                {
                    ResimUpdate(int.Parse(pageekle));
                    Response.Redirect("slidermanagement.aspx");

                }
                else if (pagesil != null)
                {
                    ResimDelete(int.Parse(pagesil));
                    Response.Redirect("slidermanagement.aspx");
                }
            }
        }
      //  string uzanti = "";
       // string resimad = "";
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
           

        }
        void ResimDelete(int a)
        {
            ResimBLL pm = new ResimBLL();
            pm.Delete(a);
        }
        void ResimUpdate(int a)
        {
            ResimBLL pm = new ResimBLL();
            pm.Update(a);
        }
        void ResimGetir()
        {
            ResimBLL pb = new ResimBLL();

            dt = pb.ResimleriGetir();
            grdResim.DataSource = dt;
            grdResim.DataBind();
        }

        protected void btnYukle_Click(object sender, EventArgs e)
        {

            Random rdn = new Random();
            foreach (HttpPostedFile yuklenenresim in fuResim.PostedFiles)
            {
                string filename = rdn.Next(1,1000)+System.IO.Path.GetFileName(yuklenenresim.FileName);
                yuklenenresim.SaveAs(Server.MapPath("Resimler/" + filename));

                ResimBLL rb = new ResimBLL();
                try
                {
                    rb.Insert(new ResimModel { ResimYol = filename });
                   

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
            Response.Redirect("slidermanagement.aspx");


            /*
            if (fuResim.HasFile)
            {

                uzanti = Path.GetExtension(fuResim.PostedFile.FileName); // resim uzantısını çekiyoruz
                resimad = "_SedatResim_" + DateTime.Now.Day + uzanti;// resmin adını aldık bugünün tarihini ekledik ve uzantısını ekleyerek yeni isim verdik

                foreach(HttpPostedFile yuklenenresim in fuResim.PostedFiles)
                {
                    yuklenenresim.SaveAs(Server.MapPath("Resimler/sahte" + uzanti));
                }
              
               

                int donusturme = 640;

                Bitmap bmp = new Bitmap(Server.MapPath("Resimler/sahte" + uzanti));
                using (Bitmap Orjinalresim = bmp)
                {
                    double ResYukseklik = Orjinalresim.Height;
                    double ResGenislik = Orjinalresim.Width;// resim genişliğini alıyor
                    double oran = 0;

                    if (ResGenislik >= donusturme) // resim genişğişi donusturmaden büyükse yeniden boyutlandırıyor
                    {
                        oran = ResGenislik / ResYukseklik;
                        ResGenislik = donusturme;
                        ResYukseklik = donusturme / oran;

                        Size yenidegerler = new Size(Convert.ToInt32(ResGenislik), Convert.ToInt32(ResYukseklik));

                        Bitmap yeniresim = new Bitmap(Orjinalresim, yenidegerler);
                        yeniresim.Save(Server.MapPath("Resimler/" + resimad));


                        yeniresim.Dispose();
                        Orjinalresim.Dispose();
                        bmp.Dispose();

                    }
                    else // değilse direk resimler klasörüne atıyor
                    {
                        fuResim.SaveAs(Server.MapPath("Resimler/" + resimad));
                    }
                    FileInfo figecici = new FileInfo(Server.MapPath("Resimler/" + uzanti));

                    figecici.Delete();
                } 
            }
           */

            /*
                ResimBLL rb = new ResimBLL();
                try
                {
                    if (rb.Insert(new ResimModel { ResimAd = resimad, ResimYol = resimad }))
                    {

                    }

                }
                catch (Exception ex)
                {

                    throw ex;

                }
                */

        }
    }
}