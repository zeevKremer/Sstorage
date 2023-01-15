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
        public class OrdersData
        {

            public static int isExist(int StorageSenderId, int StorageGeterId)
            {
                int isExist = 0;
                string str = " select OrderId from Torders where StorageSenderId =" + StorageSenderId;
                str += " and StorageGeterId=" + StorageGeterId + " and Status=N'" + "טיוטא" + "' ";
                SqlObject Sql = new SqlObject();
                SqlDataReader dr = Sql.ExecuteReader(str);
                while (dr.Read())
                {
                    isExist = (int)dr["OrderId"];
                }
                Sql.Close();
                return isExist;
            }

            public static int OpenOrder(Orders order)
            {
                int id = 0;
                string str1 = " insert into Torders (UserId,StorageSenderId,StorageGeterId,SumProd)";
                str1 += "values(" + order.UserId + " , " + order.StorageSenderId + " , " + order.StorageGeterId + " , " + 0 + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str1);
                string str2 = " select max(OrderId) from Torders";
                id = sql.ExecuteScalarInt(str2);
                sql.Close();
                return id;
            }

            public static List<Orders> GetAllOrders()
            {
                List<Orders> LstORD = new List<Orders>();
                string str = " select * from Torders ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Orders ORD = new Orders();
                    ORD.OrderId = (int)dr["OrderId"];
                    ORD.UserId = (int)dr["UserId"];
                    ORD.StorageSenderId = (int)dr["StorageSenderId"];
                    ORD.StorageGeterId = (int)dr["StorageGeterId"];
                    ORD.SumProd = (int)dr["SumProd"];
                    ORD.Status = (string)dr["Status"];
                    ORD.Date = (DateTime)dr["AddingDate"];
                    LstORD.Add(ORD);
                }
                sql.Close();
                return LstORD;
            }
            public static List<Orders> GetTenOrders()
            {
                List<Orders> LstORD = new List<Orders>();
                string str = " select top 5 * from Torders   order by OrderId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Orders ORD = new Orders();
                    ORD.OrderId = (int)dr["OrderId"];
                    ORD.UserId = (int)dr["UserId"];
                    ORD.StorageSenderId = (int)dr["StorageSenderId"];
                    ORD.StorageGeterId = (int)dr["StorageGeterId"];
                    ORD.SumProd = (int)dr["SumProd"];
                    ORD.Status = (string)dr["Status"];
                    ORD.Date = (DateTime)dr["AddingDate"];
                    LstORD.Add(ORD);
                }
                sql.Close();
                return LstORD;
            }
            public static Orders GetOrderById(int id)
            {
                Orders ORD = new Orders();
                string str = " select  * from Torders where OrderId = '" + id + "'";              
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {                    
                    ORD.OrderId = (int)dr["OrderId"];
                    ORD.UserId = (int)dr["UserId"];
                    ORD.StorageSenderId = (int)dr["StorageSenderId"];
                    ORD.StorageGeterId = (int)dr["StorageGeterId"];
                    ORD.SumProd = (int)dr["SumProd"];
                    ORD.Status = (string)dr["Status"];
                    ORD.Date = (DateTime)dr["AddingDate"];                   
                }
                sql.Close();
                return ORD;
            }

            public static void CloseOrderById(int id)
            {
                string str = " update Torders set Status = N'" + "סגור" + "' where OrderId = " + id;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void ChangeStatus(int id)
            {
                string str = " update Torders set Status = N'" + "בליקוט" + "' where OrderId = " + id;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void UpInventory(List<Ovalue> LstORD, int StorageSenderId, int StorageGeterId)
            {
                int StoragesLocatorsId1, StoragesLocatorsId2, Quantity1, Quantity2, i;
                string str1, str2, str3, str4, str5, str6;
                SqlObject sql = new SqlObject();
                for (i = 0; i < LstORD.Count; i++)
                {
                    str1 = "select StoragesLocatorId from TstoragesLocators where StorageId = " + StorageSenderId;
                    str2 = "select StoragesLocatorId from TstoragesLocators where StorageId = " + StorageGeterId;
                    if (StorageSenderId == 1)
                        StoragesLocatorsId1 = 1;
                    else
                        StoragesLocatorsId1 = sql.ExecuteScalarInt(str1);
                    if (StorageGeterId == 1)
                        StoragesLocatorsId2 = 1;
                    else
                        StoragesLocatorsId2 = sql.ExecuteScalarInt(str2);
                    str3 = "select  Quantity from TInventorys where StoragesLocatorId = " + StoragesLocatorsId1 + " and ProdId = " + LstORD[i].ProdId + "and Quantity > 0";
                    str4 = "select  Quantity from TInventorys where StoragesLocatorId = " + StoragesLocatorsId2 + " and ProdId = " + LstORD[i].ProdId + "and Quantity > 0";
                    Quantity1 = sql.ExecuteScalarInt(str3);
                    Quantity2 = sql.ExecuteScalarInt(str4);
                    Quantity1 -= Convert.ToInt32(LstORD[i].Quantity);
                    Quantity2 += Convert.ToInt32(LstORD[i].Quantity);
                    str5 = " update TInventorys set Quantity = " + Quantity1 + " where StoragesLocatorId = " + StoragesLocatorsId1 + " and ProdId = " + LstORD[i].ProdId;
                    str6 = " update TInventorys set Quantity = " + Quantity2 + " where StoragesLocatorId = " + StoragesLocatorsId2 + " and ProdId = " + LstORD[i].ProdId;
                    sql.ExecuteNonQuery(str5);
                    sql.ExecuteNonQuery(str6);
                }
                sql.Close();

            }

            public static List<Orders> GetOrderByColumnName(string ColumnName, int value)
            {
                List<Orders> LstORD = new List<Orders>();
                string str = " select  * from Torders  where " + ColumnName + " = '" + value + "' order by OrderId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Orders ORD = new Orders();
                    ORD.OrderId = (int)dr["OrderId"];
                    ORD.UserId = (int)dr["UserId"];
                    ORD.StorageSenderId = (int)dr["StorageSenderId"];
                    ORD.StorageGeterId = (int)dr["StorageGeterId"];
                    ORD.SumProd = (int)dr["SumProd"];
                    ORD.Status = (string)dr["Status"];
                    ORD.Date = (DateTime)dr["AddingDate"];
                    LstORD.Add(ORD);
                }
                sql.Close();
                return LstORD;
            }
            public static List<Orders> GetOrderByColumnName(string ColumnName, string value)
            {                                
                List<Orders> LstORD = new List<Orders>();
                string str = " select  * from Torders  where " + ColumnName + " = N'" + value + "' order by OrderId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Orders ORD = new Orders();
                    ORD.OrderId = (int)dr["OrderId"];
                    ORD.UserId = (int)dr["UserId"];
                    ORD.StorageSenderId = (int)dr["StorageSenderId"];
                    ORD.StorageGeterId = (int)dr["StorageGeterId"];
                    ORD.SumProd = (int)dr["SumProd"];
                    ORD.Status = (string)dr["Status"];
                    ORD.Date = (DateTime)dr["AddingDate"];
                    LstORD.Add(ORD);
                }
                sql.Close();
                return LstORD;
            }
        }
    }    
}