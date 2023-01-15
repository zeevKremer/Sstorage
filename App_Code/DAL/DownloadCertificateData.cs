using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.BLL;
using Sstorage.admin;
using Sstorage.DAL;
using System.Data.SqlClient;


namespace Sstorage
{
    namespace DAL
    {
        public class DownloadCertificateData
        {
            public static int OpenDownloadCertificate(DownloadCertificate downloadCertificate)
            {
                int id = 0;
                string str1 = " insert into TtransferCertificate (UserIdOpen,StorageSenderId,StorageGeterId)";
                str1 += "values(" + downloadCertificate.UserId + " , " + downloadCertificate.StorageSenderId + " , " + downloadCertificate.StorageGeterId + " )";
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
                    str2 += "#";
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

        }
    }    
}