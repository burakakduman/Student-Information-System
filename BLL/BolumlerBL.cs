using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BolumlerBL
    {
        Helper a = Helper.Ornek;
        public bool BolumEkle(BolumlerModel bm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@BolumID",bm.BolumAd),new SqlParameter("@AkademikBirimID",bm.AkademikBirimID) };

                return a.ExecuteNonQuery("Insert into Bolumler values(@BolumAd,@AkademikBirimID)", p) > 0;
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

        public List<AkademikBirimlerModel> BolumListesiDoldur()
        {
            List<AkademikBirimlerModel> lst = new List<AkademikBirimlerModel>();
            
            SqlDataReader dr = a.ExecuteReader("Select AkademikBirimID,Ad from AkademikBirimler", null);
            while (dr.Read())
            {
                lst.Add(new AkademikBirimlerModel { AkademikBirimID = Convert.ToInt32( dr["AkademikBirimID"]), Ad = Convert.ToString(dr["Ad"]) });
            }
            dr.Close();
            return lst;
        }
    }
}
