using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;

        static readonly Helper ornek = new Helper();

        public static Helper Ornek
        {
            get
            {
                return ornek;
            }
        }

        private Helper()
        {

        }

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
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

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            using (cmd = new SqlCommand(cmdtext, cn))
            {
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }


        public DataTable MyDataTable(string cmdtext, SqlParameter[] p)
        {
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }
    }
}
