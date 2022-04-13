using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;

        static readonly Helper ornek = new Helper();
        private Helper()
        {

        }
        public static Helper Ornek
        {
            get { return ornek; }
        }

        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdText, SqlParameter[] p)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdText, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
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

        public SqlDataReader ExecuteReader(string cmdText, SqlParameter[] p)
        {
            cn = new SqlConnection(cstr);
            using (cmd = new SqlCommand(cmdText, cn))
            {
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }

                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public DataTable MyDataTable(string cmdText, SqlParameter[] p)
        {
            using (cn = new SqlConnection(cstr))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdText, cn);
                DataTable dt = new DataTable();
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }
                da.Fill(dt);
                return dt;
            }
        }

    }
}

