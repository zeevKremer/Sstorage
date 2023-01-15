using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Sstorage.BLL;


namespace Sstorage
{
    namespace DAL
    {
        public class SurfaceData
        {
            public static int isExist( Surface  surface)
            {
                int surfaceid = 0;
                string str = " select * from TsurfacesLocators where SurfaceId = " + surface.SurfaceId;               
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    surfaceid = (int)dr["SurfaceId"];

                }
                sql.Close();
                return surfaceid;
            }

            public static List<Surface> GetAllSurfaces()
            {
                List<Surface> LstSurfaces = new List<Surface>();
                string str = " select* from Tsurfaces ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    Surface Surf = new Surface();
                    Surf.SurfaceId = (int)dr1["SurfaceId"];
                    Surf.ProdId = (int)dr1["ProdId"];
                    Surf.Quantity = (int)dr1["Quantity"];
                    //if(dr1["Remarks"]!= null)
                    //    Surf.Remarks = (string)dr1["Remarks"];
                    if (dr1["LocatorName"] != null)
                        Surf.LocatorName = (string)dr1["LocatorName"];
                    LstSurfaces.Add(Surf);
                }
                sql.Close();
                return LstSurfaces;
            }
            public static List<Surface> GetSurfacesById(int id)
            {
                List<Surface> LstSurfaces = new List<Surface>();
                string str = " select* from Tsurfaces where ProdId="+id;
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    Surface Surf = new Surface();
                    Surf.SurfaceId = (int)dr1["SurfaceId"];
                    Surf.ProdId = (int)dr1["ProdId"];
                    Surf.Quantity = (int)dr1["Quantity"];
                    if (dr1["Remarks"] != null)
                        Surf.Remarks = (string)dr1["Remarks"];
                    if (dr1["LocatorName"] != null)
                        Surf.LocatorName = (string)dr1["LocatorName"];
                    LstSurfaces.Add(Surf);
                }
                sql.Close();
                return LstSurfaces;
            }
        }
    }    
}