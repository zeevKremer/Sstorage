using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.admin;
using Sstorage.BLL;
namespace Sstorage
{
    namespace DAL
    {
        public class DownloadCertificateDetailsData
        {
            public static int WritheProdInDCDetailsData(DownloadCertificateDetails DCD)
            {
                int id = 0;
                string str1 = " insert into TtransferCertificateDetails (TransferCertificateId,ProdId)";
                str1 += "values(" + DCD.DownloadCertificateId + " , " + DCD.ProdId + " )";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str1);
                string str2 = " select max(TransferCertificateDetailsId) from TtransferCertificateDetails where TransferCertificateId = ";
                str2 += "" + DCD.DownloadCertificateId + " and ProdId = " + DCD.ProdId ;
                id = sql.ExecuteScalarInt(str2);
                sql.Close();
                return id;
            }
            public void WritheQuantityInDCDetailsData(DownloadCertificateDetails DCD)
            {//  כמות מקורית של המשטח  ,  מיקום של המשטח  ,  מיקום המוצר בליקוט
                string str = " update TtransferCertificateDetails set SurfaceId=" + DCD.SurfaceId + " , Quantity=" + DCD.Quantity + " where ";
                str += " TransferCertificateDetailsId =" + DCD.DownloadCertificateDetailsId + " ; ";                
                str += " update Tinventorys set Quantity = 50 where StoragesLocatorId = 14 ;  ";
                str += " update Tinventorys set Quantity = 60 where StoragesLocatorId = 24 ;  ";
                str += " update Tsurfaces set Quantity = 60 where SurfaceId = " + DCD.SurfaceId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
            }
        }
    }    
}