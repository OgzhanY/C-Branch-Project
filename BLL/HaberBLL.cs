using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class HaberBLL
    {
        public bool Insert(HaberModel hb)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@HaberBaslik", hb.HaberBaslik),new SqlParameter("@Icerik",hb.Icerik), new SqlParameter("@Resim", hb.Resim) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Insert into tblHaber(HaberBaslik,Icerik,Resim) values(@HaberBaslik,@Icerik,@Resim)", p) > 0;
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
        public bool Update(HaberModel hb)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", hb.HaberID), new SqlParameter("@HaberBaslik", hb.HaberBaslik), new SqlParameter("@Icerik", hb.Icerik), new SqlParameter("@Resim", hb.Resim) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update tblHaber Set HaberBaslik=@HaberBaslik,Icerik=@Icerik,Resim=@Resim where HaberID=@id", p) > 0;
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
        public bool Delete(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Delete from tblHaber where HaberID=@id", p) > 0;
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
        public List<HaberModel> HaberGetir()
        {
            List<HaberModel> lst = new List<HaberModel>();
            Helper hlp = Helper.Ornek;
            SqlDataReader dr = hlp.ExecuteReader("Select HaberID,HaberBaslik,Icerik,Resim from tblHaber", null);
            while (dr.Read())
            {
                lst.Add(new HaberModel { HaberBaslik = dr["HaberBaslik"].ToString(), Icerik = dr["Icerik"].ToString(), HaberID = Convert.ToInt32(dr["HaberID"]),Resim = Convert.ToInt32(dr["Resim"]).ToString() });
            }
            dr.Close();
            return lst;


        }
        /*public DataTable HaberTablosuDoldur(bool IsActive)
        {

            Helper hlp = Helper.Ornek;
            SqlParameter[] p = { new SqlParameter("@IsActive", IsActive) };
            return hlp.MyDataTable("Select PageID, PageName from tblPages where IsActive=@IsActive", p);
        }*/
        public DataTable HaberTablosuGetir2()//////////////// Grid view
        {
            Helper hlp = Helper.Ornek;

            return hlp.MyDataTable("Select HaberID,HaberBaslik,Icerik,Resim from tblHaber", null);
        }
        

        public HaberModel GetDetail(int id)
        {
            HaberModel hb = null;
            Helper hlp = Helper.Ornek;
            SqlParameter[] p = { new SqlParameter("@id", id) };
            SqlDataReader dr = hlp.ExecuteReader("Select HaberID,HaberBaslik,Icerik,Resim from tblHaber where HaberID=@id", p);

            if (dr.Read())
            {
                hb = new HaberModel();
               
                hb.Resim = dr["Resim"].ToString();
                hb.HaberBaslik = dr["HaberBaslik"].ToString();
                hb.Icerik = dr["Icerik"].ToString();

                //   pmm.add(new PageManagementModel { PageName = dr["PageName"].ToString(), PageID = Convert.ToInt32(dr["PageID"]) });
            }
            dr.Close();
            return hb;
        }
    }
}
