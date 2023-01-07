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
    public class AkademikBirimlerBL
    {
        Helper a = Helper.Ornek;
        public bool AkademikBirimEkle(AkademikBirimlerModel abm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", abm.Ad)};
               
                return a.ExecuteNonQuery("Insert into AkademikBirimler values(@Ad)", p) > 0;
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
        public bool AkademikBirimGuncelle(AkademikBirimlerModel abm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@AkademikBirimID", abm.AkademikBirimID), new SqlParameter("@Ad", abm.Ad)  };

                return a.ExecuteNonQuery("Update AkademikBirimler set Ad=@Ad where AkademikBirimID=@AkademikBirimID", p) > 0;
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
        public bool AkademikBirimSil(AkademikBirimlerModel abm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", abm.Ad) };

                return a.ExecuteNonQuery("Delete from AkademikBirimler where Ad=@Ad", p) > 0;
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

        public DataTable AkademikBirimlerTablosuGetir()
        {
            return a.MyDataTable("Select AkademikBirimID,Ad from AkademikBirimler", null);
        }
    }
}
