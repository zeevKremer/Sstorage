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
        public class AbsorptionProductsData
        {

            public static List<AbsorptionProducts> GetAllCertificats()
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                string str = " select * from TabsorptionProducts ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    AbsorptionProducts AP = new AbsorptionProducts();
                    AP.AbsorptionProductsId = (int)dr["AbsorptionProductsId"];
                    AP.UserIdOpen = (int)dr["UserIdOpen"];
                    AP.SupplierId = (int)dr["SupplierId"];                    
                    AP.Status = (string)dr["Status"];
                    AP.ShippingCertificatePicName = (string)dr["ShippingCertificatePicName"];
                    AP.QuantityProper = (string)dr["QuantityProper"];
                    AP.Date = (DateTime)dr["AddingDate"];
                    LstAP.Add(AP);
                }
                sql.Close();
                return LstAP;
            }

            public static List<AbsorptionProducts> GetTenCertificats()
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                string str = " select top 5 * from TabsorptionProducts order by AbsorptionProductId desc";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    AbsorptionProducts AP = new AbsorptionProducts();
                    AP.AbsorptionProductsId = (int)dr["AbsorptionProductId"];
                    AP.UserIdOpen = (int)dr["UserIdOpen"];
                    AP.SupplierId = (int)dr["SupplierId"];                    
                    AP.Status = (string)dr["Status"];
                    AP.ShippingCertificatePicName = (string)dr["ShippingCertificatePicName"];
                    AP.QuantityProper = (string)dr["QuantityProper"];
                    AP.SumProd = (int)dr["SumProd"];
                    AP.Date = (DateTime)dr["AddingDate"];
                    LstAP.Add(AP);
                }
                sql.Close();
                return LstAP;
            }
            public static List<AbsorptionProducts> GetCertificatsByColumnName(string ColumnName, int value)
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                string str = " select  * from TabsorptionProducts  where " + ColumnName + " = '" + value + "' order by AbsorptionProductId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    AbsorptionProducts AP = new AbsorptionProducts();
                    AP.AbsorptionProductsId = (int)dr["AbsorptionProductId"];
                    AP.UserIdOpen = (int)dr["UserIdOpen"];
                    AP.SupplierId = (int)dr["SupplierId"];               
                    AP.Status = (string)dr["Status"];
                    AP.ShippingCertificatePicName = (string)dr["ShippingCertificatePicName"];
                    AP.QuantityProper = (string)dr["QuantityProper"];
                    AP.Date = (DateTime)dr["AddingDate"];
                    LstAP.Add(AP);
                }
                sql.Close();
                return LstAP;
            }
            public static List<AbsorptionProducts> GetCertificatsByColumnName(string ColumnName, string value)
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                string str = " select  * from TabsorptionProducts  where " + ColumnName + " = N'" + value + "' order by AbsorptionProductId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    AbsorptionProducts AP = new AbsorptionProducts();
                    AP.AbsorptionProductsId = (int)dr["AbsorptionProductId"];
                    AP.UserIdOpen = (int)dr["UserIdOpen"];
                    AP.SupplierId = (int)dr["SupplierId"];                    
                    AP.Status = (string)dr["Status"];
                    AP.ShippingCertificatePicName = (string)dr["ShippingCertificatePicName"];
                    AP.QuantityProper = (string)dr["QuantityProper"];
                    AP.Date = (DateTime)dr["AddingDate"];
                    LstAP.Add(AP);
                }
                sql.Close();
                return LstAP;
            }

            public static int OpenAbsorptionProducts(AbsorptionProducts absorptionProducts)
            {

                int id = 0;
                string str1 = " insert into TabsorptionProducts (UserIdOpen,SupplierId)";
                str1 += "values(" + absorptionProducts.UserIdOpen + " , " + absorptionProducts.SupplierId + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str1);
                string str2 = " select max(AbsorptionProductId) from TabsorptionProducts";
                id = sql.ExecuteScalarInt(str2);
                sql.Close();
                return id;               
            }
            public static int isExist(int SupplierId)
            {
                int isExist = 0;
                string str = " select AbsorptionProductId from TabsorptionProducts where SupplierId =" + SupplierId;
                str += " and Status=N'" + "טיוטא" + "' ";
                SqlObject Sql = new SqlObject();
                SqlDataReader dr = Sql.ExecuteReader(str);
                while (dr.Read())
                {
                    isExist = (int)dr["AbsorptionProductId"];
                }
                Sql.Close();
                return isExist;
            }
            public static void ChangeStatus(int id)
            {
                string str = " update TabsorptionProducts set Status = N'" + "בליקוט" + "' where AbsorptionProductId = " + id;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void CloseCertificatById(int id)
            {
                string str = " update TabsorptionProducts set Status = N'" + "סגור" + "' where AbsorptionProductId = " + id;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void UpInventory(List<APDvalue> LstAPD)
            {                
                string str1,str2;
                int Quantity;
                SqlObject sql = new SqlObject();
                for (int i = 0; i < LstAPD.Count; i++)
                {
                    str1 = "select  Quantity from TInventorys where StoragesLocatorId = " + 541 ;
                    str1 += " and ProdId = " + LstAPD[i].ProdId;
                    Quantity = sql.ExecuteScalarInt(str1);        
                    Quantity += Convert.ToInt32(LstAPD[i].Quantity);                  
                    str2 = " update TInventorys set Quantity = " + Quantity + " where StoragesLocatorId = " + 541 + " and ProdId = " + LstAPD[i].ProdId;                    
                    sql.ExecuteNonQuery(str2);                    
                }
                sql.Close();

            }
            public static AbsorptionProducts GetCertificatById(int id)
            {
                AbsorptionProducts AP = new AbsorptionProducts();
                string str = " select  * from TabsorptionProducts  where  AbsorptionProductId  = '" + id + "'  ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {

                    AP.AbsorptionProductsId = (int)dr["AbsorptionProductId"];
                    AP.UserIdOpen = (int)dr["UserIdOpen"];
                    AP.SupplierId = (int)dr["SupplierId"];                    
                    AP.SumProd = (int)dr["SumProd"];
                    AP.Status = (string)dr["Status"];
                    AP.Date = (DateTime)dr["AddingDate"];

                }
                sql.Close();
                return AP;
            }
        }
    }    
}