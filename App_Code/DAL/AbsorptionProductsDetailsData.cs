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
        public class AbsorptionProductsDetailsData
        {

            public static int AddingDetailsData1(AbsorptionProductsDetails APD)
            {
                string str = " insert into TabsorptionProductsDetails (AbsorptionProductId,ProdId,Quantity)";
                str += "values( " + APD.AbsorptionProductId + " , " + APD.ProdId + " , " + APD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(AbsorptionProductDetailsId) from TabsorptionProductsDetails ";
                int TCDid = sql.ExecuteScalarInt(str);
                int SumProd = 0;
                str = " select * from TabsorptionProducts where AbsorptionProductId = " + APD.AbsorptionProductId;
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    SumProd = (int)dr["SumProd"];
                }
                SumProd++;
                str = "update TabsorptionProducts set SumProd =  " + SumProd + " where AbsorptionProductId = " + APD.AbsorptionProductId;
                sql.Close();
                SqlObject sql1 = new SqlObject();
                sql1.ExecuteNonQuery(str);
                sql1.Close();
                return TCDid;
            }
            public static int AddingDetailsData2(AbsorptionProductsDetails APD)
            {
                string str = " insert into TabsorptionProductsDetails (AbsorptionProductId,ProdId,Quantity)";
                str += "values( " + APD.AbsorptionProductId + " , " + APD.ProdId + " , " + APD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(AbsorptionProductDetailsId) from TabsorptionProductsDetails ";
                int APDid = sql.ExecuteScalarInt(str);
                sql.Close();
                return APDid;
            }
            public static List<AbsorptionProductsDetails> GetCertDetailsById(int id)
            {
                List<AbsorptionProductsDetails> LstAPD = new List<AbsorptionProductsDetails>();
                string str = " select * from TabsorptionProductsDetails where AbsorptionProductId=" + id;
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    AbsorptionProductsDetails APD = new AbsorptionProductsDetails();
                    APD.AbsorptionProductId = (int)dr["AbsorptionProductId"];
                    APD.ProdId = (int)dr["ProdId"];
                    APD.Quantity = (int)dr["Quantity"];
                    LstAPD.Add(APD);
                }
                sql.Close();
                string s = "select ProdName,Barcode,ShorBarcode,QuantityUnitsPeck,Price";
                s += " from Tproducts where ProdId=";

                SqlDataReader dr1;
                for (int i = 0; i < LstAPD.Count; i++)
                {
                    str = s + LstAPD[i].ProdId;
                    SqlObject sql1 = new SqlObject();
                    dr1 = sql1.ExecuteReader(str);
                    while (dr1.Read())
                    {
                        LstAPD[i].ProdName = (string)dr1["ProdName"];
                        LstAPD[i].Barcode = (string)dr1["Barcode"];
                        LstAPD[i].ShorBarcode = (string)dr1["ShorBarcode"];
                        LstAPD[i].QuantityUnitsPeck = 0;
                        LstAPD[i].Price = (int)dr1["Price"];
                    }
                    sql1.Close();
                }                
                return LstAPD;
            }
        }
    }    
}