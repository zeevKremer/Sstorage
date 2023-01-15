using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Sstorage.BLL;
using Sstorage.DAL;

namespace Sstorage
{
    namespace admin
    {
        public class Global : System.Web.HttpApplication
        {

            protected void Application_Start(object sender, EventArgs e)
            {
                SqlObject sql = new SqlObject();
                string str1 = " select LocatorName from TstoragesLocators ", str20 = "#";
                SqlDataReader dr1 = sql.ExecuteReader(str1);
                while (dr1.Read())
                {
                    str20 += (string)dr1["LocatorName"];
                    str20 += "#";
                }
                sql.Close();
                Application["LocatorNames"] = str20;

                List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                StoragesLocators SL = new StoragesLocators();
                LstStoragesLocators = SL.GetAllLocators();
                Application["StoragesLocators"] = LstStoragesLocators;

                List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                LstStoragesLocatorsProducts = SLP.GetAllSLP();
                Application["StoragesLocatorsProducts"] = LstStoragesLocatorsProducts;

                List<Inventorys> LstInventorys = new List<Inventorys>();
                Inventorys Inventorys = new Inventorys();
                LstInventorys = Inventorys.GetAllLocators();
                Application["Inventorys"] = LstInventorys;
                List<Surface> LstSurfaces = new List<Surface>();
                Surface Surf = new Surface();
                LstSurfaces = Surf.GetAllSurfaces();
                Application["Surfaces"] = LstSurfaces;

                List<SurfacesLocators> LstSurfacesLocators = new List<SurfacesLocators>();
                SurfacesLocators SurfLocator = new SurfacesLocators();
                LstSurfacesLocators = SurfLocator.GetAllSurfacesLocators();
                Application["SurfacesLocators"] = LstSurfacesLocators;

                List<Product> LstProducts = new List<Product>();
                Product product = new Product();
                LstProducts = product.GetAllProduct();
                Application["Products"] = LstProducts;
                
            }

            protected void Session_Start(object sender, EventArgs e)
            {

            }

            protected void Application_BeginRequest(object sender, EventArgs e)
            {

            }

            protected void Application_AuthenticateRequest(object sender, EventArgs e)
            {

            }

            protected void Application_Error(object sender, EventArgs e)
            {

            }

            protected void Session_End(object sender, EventArgs e)
            {

            }

            protected void Application_End(object sender, EventArgs e)
            {

            }
        }
    }
    
}