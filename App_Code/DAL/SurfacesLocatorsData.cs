using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Sstorage.admin;
using Sstorage.BLL;

namespace Sstorage
{
    namespace DAL
    {
        public class SurfacesLocatorsData
        {
            public static List<SurfacesLocators> GetAllSurfacesLocators()
            {
                List<SurfacesLocators> LstSurfacesLocators = new List<SurfacesLocators>();
                string str = " select * from TsurfacesLocators ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    SurfacesLocators SurfLocator = new SurfacesLocators();
                    SurfLocator.SurfacesLocatorId = (int)dr1["SurfacesLocatorId"];
                    SurfLocator.SurfaceId = (int)dr1["SurfaceId"];
                    SurfLocator.StoragesLocatorId = (int)dr1["StoragesLocatorId"];
                    SurfLocator.StoragesLocatorIdHistory = (string)dr1["StoragesLocatorIdHistory"];
                    LstSurfacesLocators.Add(SurfLocator);
                }
                sql.Close();
                return LstSurfacesLocators;
            }
        }
    }    
}