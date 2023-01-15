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
        public  class TransferCertificateData
        {

            public static int OpenTransferCertificate(TransferCertificate transferCertificate)
            {
                int id = 0;
                string str1 = " insert into TtransferCertificate (UserIdOpen,StorageSenderId,StorageGeterId,SumProd)";
                       str1 += "values("+ transferCertificate.UserId+" , "+ transferCertificate.StorageSenderId+" , "+ transferCertificate.StorageGeterId+" , " + 0 + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str1);
                string str2 = " select max(TransferCertificateId) from TtransferCertificate";
                id = sql.ExecuteScalarInt(str2);
                sql.Close();
                return id;
            }

            public static string[] PullingProduct()
            {
                string[] rez = new string[2];
                string str = " select* from Tsurfaces as t1 ";
                str += " inner join TsurfacesLocators on t1.SurfaceId = TsurfacesLocators.SurfaceId ";
                str += " inner join TstoragesLocators on TsurfacesLocators.StoragesLocatorId = TstoragesLocators.StoragesLocatorId ";
                str += " where t1.ProdId = ( select min(ProdId) from TproductsForDownload where IsPull = 0 ) ";                                                                               
                string str2 = "";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);                                
                while (dr1.Read())
                {                    
                    str2 += (string)dr1["LocatorName"];
                    str2 +="#";
                }
                sql.Close();
                SqlObject sql1 = new SqlObject();
                string str1 = " select Barcode,ShorBarcode,ProdName,ProdDesc,PicName from Tproducts where ProdId =( ";
                str1 += " select min(ProdId) from TproductsForDownload where IsPull = 0 ) ";
                string str3 = "";
                SqlDataReader dr2 = sql1.ExecuteReader(str1);
                while (dr2.Read())
                {
                    str3 += (string)dr2["ProdName"]; 
                     str3 += ",";
                    str3 += (string)dr2["ShorBarcode"];
                    str3 += ",";
                    str3 += (string)dr2["Barcode"];
                    str3 += ",";
                    str3 += (string)dr2["ProdDesc"];
                    str3 += ",";
                    str3 += (string)dr2["PicName"];                   
                    str3 += "-";
                }
                sql1.Close();
                string str4 = "update TproductsForDownload set IsPull = 1 where ProdId = ( select min(ProdId) from TproductsForDownload where IsPull = 0 )";
                SqlObject sql2 = new SqlObject();
                sql2.ExecuteNonQuery(str4);
                sql2.Close();
                rez[0] = str2;
                rez[1] = str3;
                return rez;
            }
            public static int Pull()
            {
                int Pid = 1;
                string str1 = "select min(ProdId) from TproductsForDownload where IsPull = 0";
                SqlObject sql1 = new SqlObject();
                Pid = sql1.ExecuteScalarInt(str1);
                sql1.Close();
                string str2 = "update TproductsForDownload set IsPull = 1 where ProdId = ( select min(ProdId) from TproductsForDownload where IsPull = 0 )";
                SqlObject sql2 = new SqlObject();
                sql2.ExecuteNonQuery(str2);
                sql2.Close();
                return Pid;
            }

            public static List<TransferCertificate> GetAllCertificats()
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();                
                string str = " select * from TtransferCertificate ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    TransferCertificate TC = new TransferCertificate();
                    TC.CertificateId = (int)dr["TransferCertificateId"];
                    TC.UserId = (int)dr["UserIdOpen"];
                    TC.StorageSenderId = (int)dr["StorageSenderId"];
                    TC.StorageGeterId = (int)dr["StorageGeterId"];
                    TC.SumProd = (int)dr["SumProd"];
                    TC.Status = (string)dr["Status"];
                    TC.Date = (DateTime)dr["AddingDate"];
                    LstTC.Add(TC);
                }
                sql.Close();
                return LstTC;
            }

            public static List<TransferCertificate> GetTenCertificats()
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                string str = " select top 5 * from TtransferCertificate order by TransferCertificateId desc";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    TransferCertificate TC = new TransferCertificate();
                    TC.CertificateId = (int)dr["TransferCertificateId"];
                    TC.UserId = (int)dr["UserIdOpen"];
                    TC.StorageSenderId = (int)dr["StorageSenderId"];
                    TC.StorageGeterId = (int)dr["StorageGeterId"];
                    TC.SumProd = (int)dr["SumProd"];
                    TC.Status = (string)dr["Status"];
                    TC.Date = (DateTime)dr["AddingDate"];
                    LstTC.Add(TC);
                }
                sql.Close();
                return LstTC;
            }
            public static TransferCertificate GetCertificatById(int id)
            {
                TransferCertificate TC = new TransferCertificate();
                string str = " select  * from TtransferCertificate  where  TransferCertificateId  = '" + id + "'  ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    
                    TC.CertificateId = (int)dr["TransferCertificateId"];
                    TC.UserId = (int)dr["UserIdOpen"];
                    TC.StorageSenderId = (int)dr["StorageSenderId"];
                    TC.StorageGeterId = (int)dr["StorageGeterId"];
                    TC.SumProd = (int)dr["SumProd"];
                    TC.Status = (string)dr["Status"];
                    TC.Date = (DateTime)dr["AddingDate"];
                    
                }
                sql.Close();
                return TC;
            }
            public static void CloseCertificatById(int id)
            {
                string str = " update TtransferCertificate set Status = N'" +"סגור" + "' where TransferCertificateId = " + id ;                
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);                
                sql.Close();
            }
            public static void ChangeStatus(int id)
            {
                string str = " update TtransferCertificate set Status = N'" + "בליקוט" + "' where TransferCertificateId = " + id;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void UpInventory(List<TCDvalue> LstTCD, int StorageSenderId, int StorageGeterId)
            {
                int StoragesLocatorsId1, StoragesLocatorsId2, Quantity1, Quantity2,i;
                string str1, str2, str3, str4, str5, str6;
                SqlObject sql = new SqlObject();
                for (i=0;i<LstTCD.Count; i++)
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
                    str3 = "select  Quantity from TInventorys where StoragesLocatorId = " + StoragesLocatorsId1 + " and ProdId = "+LstTCD[i].ProdId + "and Quantity > 0";
                    str4 = "select  Quantity from TInventorys where StoragesLocatorId = " + StoragesLocatorsId2 + " and ProdId = "+LstTCD[i].ProdId + "and Quantity > 0";
                    Quantity1 = sql.ExecuteScalarInt(str3);
                    Quantity2 = sql.ExecuteScalarInt(str4);
                    Quantity1 -= Convert.ToInt32(LstTCD[i].Quantity);
                    Quantity2 += Convert.ToInt32(LstTCD[i].Quantity);
                    str5 = " update TInventorys set Quantity = " + Quantity1 + " where StoragesLocatorId = " + StoragesLocatorsId1 + " and ProdId = "+LstTCD[i].ProdId;
                    str6 = " update TInventorys set Quantity = " + Quantity2 + " where StoragesLocatorId = " + StoragesLocatorsId2 + " and ProdId = "+LstTCD[i].ProdId;
                    sql.ExecuteNonQuery(str5);
                    sql.ExecuteNonQuery(str6);
                }                
                sql.Close();                                             
                                
            }
            public static List<TransferCertificate> GetCertificatsByColumnName(string ColumnName, int value)
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                string str = " select  * from TtransferCertificate  where " + ColumnName + " = '" + value + "' order by TransferCertificateId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    TransferCertificate TC = new TransferCertificate();
                    TC.CertificateId = (int)dr["TransferCertificateId"];
                    TC.UserId = (int)dr["UserIdOpen"];
                    TC.StorageSenderId = (int)dr["StorageSenderId"];
                    TC.StorageGeterId = (int)dr["StorageGeterId"];
                    TC.SumProd = (int)dr["SumProd"];
                    TC.Status = (string)dr["Status"];
                    TC.Date = (DateTime)dr["AddingDate"];
                    LstTC.Add(TC);
                }
                sql.Close();
                return LstTC;
            }
            public static List<TransferCertificate> GetCertificatsByColumnName(string ColumnName, string value)
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                string str = " select  * from TtransferCertificate  where " + ColumnName + " = N'" + value + "' order by TransferCertificateId desc ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    TransferCertificate TC = new TransferCertificate();
                    TC.CertificateId = (int)dr["TransferCertificateId"];
                    TC.UserId = (int)dr["UserIdOpen"];
                    TC.StorageSenderId = (int)dr["StorageSenderId"];
                    TC.StorageGeterId = (int)dr["StorageGeterId"];
                    TC.SumProd = (int)dr["SumProd"];
                    TC.Status = (string)dr["Status"];
                    TC.Date = (DateTime)dr["AddingDate"];
                    LstTC.Add(TC);
                }
                sql.Close();
                return LstTC;
            }
            public static int isExist(int StorageSenderId, int StorageGeterId)
            {
                int isExist = 0;
                string str = " select TransferCertificateId from TtransferCertificate where StorageSenderId =" + StorageSenderId;
                str += " and StorageGeterId="+ StorageGeterId + " and Status=N'"+"טיוטא"+"' ";
                SqlObject Sql = new SqlObject();
                SqlDataReader dr = Sql.ExecuteReader(str);
                while (dr.Read())
                {
                    isExist = (int)dr["TransferCertificateId"];
                }                
                Sql.Close();
                return isExist;
            }
        }
    }    
}