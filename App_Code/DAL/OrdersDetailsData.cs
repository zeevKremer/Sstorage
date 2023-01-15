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
        public class OrdersDetailsData
        {

            public static int AddingDetailsData1(OrdersDetails OD)
            {
                string str = " insert into TorderDetails (OrderId,ProdId,Quantity)";
                str += "values( " + OD.OrderId + " , " + OD.ProdId + " , " + OD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(OrderDetailsId) from TorderDetails ";
                int TCDid = sql.ExecuteScalarInt(str);
                int SumProd = 0;
                str = " select * from Torders where OrderId = " + OD.OrderId;
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    SumProd = (int)dr["SumProd"];
                }
                SumProd++;
                str = "update Torders set SumProd =  " + SumProd + " where OrderId = " + OD.OrderId;
                sql.Close();
                SqlObject sql1 = new SqlObject();
                sql1.ExecuteNonQuery(str);
                sql1.Close();
                return TCDid;
            }
            public static int AddingDetailsData2(OrdersDetails OD)
            {
                string str = " insert into TorderDetails (OrderId,ProdId,Quantity)";
                str += "values( " + OD.OrderId + " , " + OD.ProdId + " , " + OD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(OrderDetailsId) from TorderDetails ";
                int TCDid = sql.ExecuteScalarInt(str);
                sql.Close();
                return TCDid;
            }
            public static List<OrdersDetails> GetOrdDetailsById(int id)
            {
                List<OrdersDetails> LstOD = new List<OrdersDetails>();
                string str = " select * from TorderDetails where OrderId=" + id;
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    OrdersDetails OD = new OrdersDetails();
                    OD.OrderId = (int)dr["OrderId"];
                    OD.ProdId = (int)dr["ProdId"];
                    OD.Quantity = (int)dr["Quantity"];
                    LstOD.Add(OD);
                }
                sql.Close();
                string s = "select ProdName,Barcode,ShorBarcode,Price";
                s += " from Tproducts where ProdId=";

                SqlDataReader dr1;
                for (int i = 0; i < LstOD.Count; i++)
                {
                    str = s + LstOD[i].ProdId;
                    SqlObject sql1 = new SqlObject();
                    dr1 = sql1.ExecuteReader(str);
                    while (dr1.Read())
                    {
                        LstOD[i].ProdName = (string)dr1["ProdName"];
                        LstOD[i].Barcode = (string)dr1["Barcode"];
                        LstOD[i].ShorBarcode = (string)dr1["ShorBarcode"];                        
                        LstOD[i].Price = (int)dr1["Price"];
                    }
                    sql1.Close();
                }
                

                return LstOD;
            }
            public static int check(OrdersDetails OD)
            {
                string str = "select StorageSenderId from Torders where OrderId = " + OD.OrderId;
                SqlObject sql = new SqlObject();
                int StorageId = sql.ExecuteScalarInt(str);
                str = "select StoragesLocatorId from TstoragesLocators where StorageId =" + StorageId;
                StorageId = sql.ExecuteScalarInt(str);
                str = "select Quantity from TInventorys where StoragesLocatorId = " + StorageId + " and ProdId = " + OD.ProdId;
                int qyt = sql.ExecuteScalarInt(str);
                if (OD.Quantity > qyt)
                    return 0;
                return 1;
            }

        }
    }    
}