using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.BLL;
using Sstorage.admin;
using System.Data.SqlClient;

namespace Sstorage
{
    namespace DAL
    {

        public class TtransferCertificateDetailsData
        {
            public void WritheInTCDetailsData(DownloadCertificateDetails TCD)
            {
                string str = " insert into TtransferCertificateDetails (TransferCertificateId,SurfaceId,Quantity)";
                str += "values( " + TCD.DownloadCertificateId + " , " + TCD.SurfaceId + " , " + TCD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public void WritheQuantityInDCDetailsData(TtransferCertificateDetails DCD)
            {//  כמות מקורית של המשטח  ,  מיקום של המשטח  ,  מיקום המוצר בליקוט
                string str = " update TtransferCertificateDetails set SurfaceId=" + DCD.SurfaceId + " , Quantity=" + DCD.Quantity + " where ";
                str += " TransferCertificateDetailsId =" + DCD.CertificateDetailsId + " ; ";
                str += " update Tinventorys set Quantity = 50 where StoragesLocatorId = 14 ;  ";
                str += " update Tinventorys set Quantity = 60 where StoragesLocatorId = 24 ;  ";
                str += " update Tsurfaces set Quantity = 60 where SurfaceId = " + DCD.SurfaceId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
            }
            public static int AddingDetailsData1(TtransferCertificateDetails TCD)
            {
                string str = " insert into TtransferCertificateDetails (TransferCertificateId,ProdId,Quantity)";
                str += "values( " + TCD.CertificateId + " , " + TCD.ProdId + " , " + TCD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(TransferCertificateDetailsId) from TtransferCertificateDetails ";
                int TCDid = sql.ExecuteScalarInt(str);
                int SumProd = 0;
                str = " select * from TtransferCertificate where TransferCertificateId = " + TCD.CertificateId;
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    SumProd = (int)dr["SumProd"];
                }
                SumProd++;
                str = "update TtransferCertificate set SumProd =  " + SumProd + " where TransferCertificateId = " + TCD.CertificateId;
                sql.Close();
                SqlObject sql1 = new SqlObject();
                sql1.ExecuteNonQuery(str);
                sql1.Close();
                return TCDid;
            }
            public static int AddingDetailsData2(TtransferCertificateDetails TCD)
            {
                string str = " insert into TtransferCertificateDetails (TransferCertificateId,ProdId,Quantity)";
                str += "values( " + TCD.CertificateId + " , " + TCD.ProdId + " , " + TCD.Quantity + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = " select max(TransferCertificateDetailsId) from TtransferCertificateDetails ";
                int TCDid = sql.ExecuteScalarInt(str);
                sql.Close();
                return TCDid;
            }
            public static List<TtransferCertificateDetails> GetCertDetailsById(int id)
            {
                List<TtransferCertificateDetails> LstTCD = new List<TtransferCertificateDetails>();
                string str = " select * from TtransferCertificateDetails where TransferCertificateId=" + id;
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    TtransferCertificateDetails TCD = new TtransferCertificateDetails();
                    TCD.CertificateId = (int)dr["TransferCertificateId"];
                    TCD.ProdId = (int)dr["ProdId"];
                    TCD.Quantity = (int)dr["Quantity"];
                    LstTCD.Add(TCD);
                }
                sql.Close();
                string s = "select ProdName,Barcode,ShorBarcode,QuantityUnitsPeck,Price";
                s += " from Tproducts where ProdId=";

                SqlDataReader dr1;
                for (int i = 0; i < LstTCD.Count; i++)
                {
                    str = s + LstTCD[i].ProdId;
                    SqlObject sql1 = new SqlObject();
                    dr1 = sql1.ExecuteReader(str);
                    while (dr1.Read())
                    {
                        LstTCD[i].ProdName = (string)dr1["ProdName"];
                        LstTCD[i].Barcode = (string)dr1["Barcode"];
                        LstTCD[i].ShorBarcode = (string)dr1["ShorBarcode"];
                        LstTCD[i].QuantityUnitsPeck = 0;/* (int)dr1["QuantityUnitsPeck"];*/
                        LstTCD[i].Price = (int)dr1["Price"];
                    }
                    sql1.Close();
                }
                //str = "select LocatorName from TstoragesLocators where ";
                //for (int i=0;i<LstTCD.Count;i++)
                //{

                //}

                return LstTCD;
            }
            public static int check(TtransferCertificateDetails TCD)
            {
                string str = "select StorageSenderId from TtransferCertificate where TransferCertificateId = " + TCD.CertificateId;
                SqlObject sql = new SqlObject();
                int StorageId = sql.ExecuteScalarInt(str);
                str = "select StoragesLocatorId from TstoragesLocators where StorageId =" + StorageId;
                StorageId = sql.ExecuteScalarInt(str);
                str = "select Quantity from TInventorys where StoragesLocatorId = " + StorageId + " and ProdId = " + TCD.ProdId;
                int qyt = sql.ExecuteScalarInt(str);
                if (TCD.Quantity > qyt)
                    return 0;
                return 1;
            }
        }

    }
}