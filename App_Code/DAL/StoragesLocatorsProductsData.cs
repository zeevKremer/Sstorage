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
        public class StoragesLocatorsProductsData
        {
            public static List<StoragesLocatorsProducts> GetAllSLP()
            {
                List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                string str = " select* from TstoragesLocatorsProducts ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                    SLP.StoragesLocatorsProductsId = (int)dr1["StoragesLocatorsProductsId"];
                    SLP.StoragesLocatorId = (int)dr1["StoragesLocatorId"];
                    SLP.ProdId = (int)dr1["ProdId"];
                    SLP.Maximum = (int)dr1["Maximum"];
                    SLP.Minimum = (int)dr1["Minimum"];
                    LstStoragesLocatorsProducts.Add(SLP);
                }
                sql.Close();
                return LstStoragesLocatorsProducts;
            }
        }
    }    
}