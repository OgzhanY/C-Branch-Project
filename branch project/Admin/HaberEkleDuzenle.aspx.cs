using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;
using System.Data.SqlClient;
using System.IO;

namespace Gazi.KazanMYO.SubeProje.Admin
{
    public partial class HaberEkleDuzenle : System.Web.UI.Page
    {
        DataTable dt = null;
        public static string haberid;
        public static string habersil;
        
        // public static string haberduzenle;
        protected void Page_Load(object sender, EventArgs e)
        {
            haberid = Request.QueryString["haberid"];
            habersil = Request.QueryString["habersil"];
           // haberduzenle = Request.QueryString["haberguncelle"];

            if (!IsPostBack)
            {
                if (haberid != null)
                {
                    HaberYaz(int.Parse(haberid));

                }
                else if (habersil != null)
                {
                    HaberDelete(int.Parse(habersil));
                    Response.Redirect("hbrlist.aspx");
                }
            }

            /*if (!IsPostBack)
                HaberTablosuGetir();*/
            
        }
        void HaberTablosuGetir()
        {
            HaberBLL hbll = new HaberBLL();
            dt = hbll.HaberTablosuGetir2();
            rptHaberGoster.DataSource = dt;
            rptHaberGoster.DataBind();
        }
        void HaberYaz(int a)
        {
            HaberBLL hbll = new HaberBLL();

            HaberModel hm = hbll.GetDetail(a);
            txtHaberBaslik.Text = hm.HaberBaslik;
            CKEditorControl1.Text = hm.Icerik;
            imgResim.ImageUrl = hm.Resim;
            btnEkle.Visible = false;
            btnDuzenle.Visible = true;
            HiddenField1.Value = hm.Resim;
           
        }
        void HaberDelete(int a)
        {
            HaberBLL hbll = new HaberBLL();
            hbll.Delete(a);
        }

        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            HaberBLL hbll = new HaberBLL();
            string resim = HiddenField1.Value;
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("../Images/") + FileUpload1.FileName);
                resim = FileUpload1.FileName;
            }

            try
            {
                if (hbll.Update(new HaberModel { HaberBaslik = txtHaberBaslik.Text.Trim(), Icerik = CKEditorControl1.Text.Trim(), Resim = resim }))
                {
                    Response.Redirect("hbrlist.aspx");
                }
                else
                {
                    Console.WriteLine("<script> alert(\" Kayıt Başarılı\");</scrtipt>");
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("<script> alert(\" Veri tabanında hata Hata:{0}\");</scrtipt>", ex);
            }
            catch (Exception ex)
            {

                Console.WriteLine("<script> alert(\" hata Hata:{0}\");</scrtipt>", ex);
            }
            Response.Redirect("HaberEkleDuzenle.aspx");
        }
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            /* HaberBLL hbll = new HaberBLL();
             try
             {
                 for (int i = 0; i < Request.Files.Count; i++)
                 {
                     var file = Request.Files[i];
                     string dosyaadi = Path.GetFileName(file.FileName);
                     string klasör = "../Images/";
                     string yuklenecekyer = Server.MapPath(klasör+"/"+dosyaadi);
                     file.SaveAs(yuklenecekyer);
                     string kayityeri = dosyaadi;
                     if (hbll.Insert(new HaberModel { HaberBaslik = txtHaberBaslik.Text.Trim(), Icerik = CKEditorControl1.Text.Trim(), Resim = kayityeri }))
                     {
                         Response.Redirect("hbrlist.aspx");
                     }
                     else
                     {
                         Console.WriteLine("<script> alert(\" Kayıt Başarısız\");</scrtipt>");
                     }
                 }
             }
             catch (SqlException ex)
             {

                 Console.WriteLine("<script> alert(\" Veri tabanında hata Hata:{0}\");</scrtipt>", ex);
             }
             catch (Exception ex)
             {

                 Console.WriteLine("<script> alert(\" hata Hata:{0}\");</scrtipt>", ex);
             }*/
            
            foreach (HttpPostedFile yuklenenresim in FileUpload1.PostedFiles)
            {
               
                
                string filename = System.IO.Path.GetFileName(yuklenenresim.FileName);
                yuklenenresim.SaveAs(Server.MapPath("Resimler/" + filename));


                HaberBLL rb = new HaberBLL();
                try
                {
                    rb.Insert(new HaberModel { HaberBaslik=txtHaberBaslik.Text,Icerik=CKEditorControl1.Text,Resim = filename });


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
            Response.Redirect("hbrlist.aspx");

            /* HaberBLL hbll = new HaberBLL();
             string resim = "";
             if (FileUpload1.HasFile)
             {
                 FileUpload1.SaveAs(Server.MapPath("../Images/")+FileUpload1.FileName);
                 resim = FileUpload1.FileName;
             }

             try
             {
                 if (hbll.Insert(new HaberModel { HaberBaslik = txtHaberBaslik.Text.Trim(), Icerik = CKEditorControl1.Text.Trim(), Resim = resim }))
                 {
                     Response.Redirect("hbrlist.aspx");
                 }
                 else
                 {
                     Console.WriteLine("<script> alert(\" Kayıt Başarılı\");</scrtipt>");
                 }
             }
             catch (SqlException ex)
             {

                 Console.WriteLine("<script> alert(\" Veri tabanında hata Hata:{0}\");</scrtipt>", ex);
             }
             catch (Exception ex)
             {

                 Console.WriteLine("<script> alert(\" hata Hata:{0}\");</scrtipt>", ex);
             }
             //Response.Redirect("HaberEkleDuzenle.aspx");
             */
        }
    }
}