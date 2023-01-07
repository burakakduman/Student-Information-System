using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GirisBL
    {
        Helper a = Helper.Ornek;

       
        public OgretimElemanlariModel OgretimElemaniGiris(int SicilNo, string Sifre)
        {
            OgretimElemanlariModel oe;
            try
            {
                SqlParameter[] p = { new SqlParameter("@SicilNo", SicilNo),new SqlParameter("@Sifre",Sifre) };
                SqlDataReader dr = a.ExecuteReader("Select * from OgretimElemanlari where SicilNo=@SicilNo and Sifre=@Sifre", p);
                if (dr.Read())
                {
                    oe = new OgretimElemanlariModel();
                    oe.SicilNo = Convert.ToInt32( dr["SicilNo"]);
                    oe.Sifre = dr["Sifre"].ToString();
                   
                }
                else
                {
                    oe = null;
                }
                dr.Close();
                return oe;
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

        public OgrencilerModel OgrenciGiris(int No, string Sifre)
        {
            OgrencilerModel om;
            try
            {
                SqlParameter[] p = { new SqlParameter("@No", No), new SqlParameter("@Sifre", Sifre) };
                SqlDataReader dr = a.ExecuteReader("Select * from Ogrenciler where OgrenciNo=@OgrenciNo and Sifre=@Sifre", p);
                if (dr.Read())
                {
                    om = new OgrencilerModel();
                    om.No = Convert.ToInt32(dr["No"]);
                    om.Sifre = dr["Sifre"].ToString();

                }
                else
                {
                    om = null;
                }
                dr.Close();
                return om;
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
