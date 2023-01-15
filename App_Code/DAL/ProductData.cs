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
        public class ProductData
        {
            public static Product GetProduct(int Pid)
            {
                Product product = new Product();                
                return product;
            }
            public static List<Product> GetAllProduct()
            {
                List<Product> LstProducts = new List<Product>();
                string str = " select* from Tproducts ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {                   
                    Product product = new Product();
                    product.ProdId = (int)dr1["ProdId"];
                    product.Barcode = (string)dr1["Barcode"];
                    product.ShorBarcode = (string)dr1["ShorBarcode"];
                    product.CatId = (int)dr1["CatId"];
                    product.SupplierId = (int)dr1["SupplierId"];
                    product.ProdName = (string)dr1["ProdName"];
                    product.ProdDesc = (string)dr1["ProdDesc"];
                    product.Price = (int)dr1["Price"];
                    //if (dr1["PicName"] != null)
                    //    product.PicName = (string)dr1["PicName"];
                    //if (dr1["Weight"] != null)
                    //    product.Weight = (string)dr1["Weight"];
                    //if (dr1["QuantityUnitsPeck"] != null)
                    //    product.QuantityUnitsPeck = (int)dr1["QuantityUnitsPeck"];
                    //product.QuantityUnitsBox = (int)dr1["QuantityUnitsBox"];
                    LstProducts.Add(product);
                }
                sql.Close();
                return LstProducts;
            }

            public static int isExist(Product Prod)
            {
                int Exist = 0;
                string str = " select * from Tproducts where ProdName=N'";
                str += "" + Prod.ProdName + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    Exist = 1;

                }
                sql.Close();
                return Exist;
            }
            public static void AddProduct(Product Prod)
            {
                string str = "insert into  Tproducts (ProdName, ProdDesc, CatId, SupplierId, Barcode, ShorBarcode, Price )";
                str += "values(N'" + Prod.ProdName + "'" + ",N'" + Prod.ProdDesc + "','" + Prod.CatId + "','" + Prod.SupplierId + "','" + Prod.Barcode + "','" + Prod.ShorBarcode + "','" + Prod.Price + "')";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);                
                str = "select max(ProdId) from Tproducts";
                int id = sql.ExecuteScalarInt(str);
                string str2 = "";
                str = "select StoragesLocatorId from TstoragesLocators where StorageId >1";
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    str2 += "insert into TInventorys (ProdId,StoragesLocatorId,quantity) values ( " + id + " , ";
                    str2 += "" + (int)dr1["StoragesLocatorId"] + " , 0 ); ";
                    
                }
                str2 += "insert into TInventorys (ProdId,StoragesLocatorId,quantity) values ( " + id + " , ";
                str2 += "" + 400 + " , 0 ); ";
                sql.Close();
                SqlObject sql2 = new SqlObject();
                sql2.ExecuteNonQuery(str2);
                sql2.Close();
            }
            public static void UpProduct(Product Prod)
            {
                string str = "update  Tproducts set ProdName =N'" + Prod.ProdName + "' , ProdDesc =N'" + Prod.ProdDesc + "' , CatId ='" + Prod.CatId + "' , SupplierId ='" + Prod.SupplierId + "' , Barcode ='" + Prod.Barcode + "' , ShorBarcode ='" + Prod.ShorBarcode + "' , Price ='" + Prod.Price + "'";
                str += " where ProdId=" + Prod.ProdId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
        }
    }    
}