using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.admin;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public  class DownloadCertificateDetails
        {
            public int DownloadCertificateDetailsId { get; set; }
            public int DownloadCertificateId { get; set; }
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public string ProdName { get; set; }
            public string[] SurfaceValue { get; set; }                       
            public int QuantityUnitsPeck { get; set; }
            public string LocatorName { get; set; }
            public int SurfaceId { get; set; }            
            public int ProdId { get; set; }
            public int Quantity { get; set; }
            public DownloadCertificateDetails()
            {

            }
            public DownloadCertificateDetails(int DownloadCertificateDetailsId, int DownloadCertificateId, string Barcode, string ShorBarcode, string ProdName, string[] SurfaceValue, int QuantityUnitsPeck, string LocatorName, int SurfaceId, int ProdId, int Quantity)
            {
                this.DownloadCertificateDetailsId = DownloadCertificateDetailsId;
                this.DownloadCertificateId = DownloadCertificateId;
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.ProdName = ProdName;
                this.SurfaceValue = SurfaceValue;
                this.QuantityUnitsPeck = QuantityUnitsPeck;
                this.LocatorName = LocatorName;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public DownloadCertificateDetails(int DownloadCertificateDetailsId, int DownloadCertificateId, int SurfaceId, int ProdId, int Quantity)
            {
                this.DownloadCertificateDetailsId = DownloadCertificateDetailsId;
                this.DownloadCertificateId = DownloadCertificateId;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public DownloadCertificateDetails(int TransferCertificateId, int SurfaceId, int Quantity)
            {
                this.DownloadCertificateId = TransferCertificateId;
                this.SurfaceId = SurfaceId;                
                this.Quantity = Quantity;
            }

            public int WritheProdInDCDetails(DownloadCertificateDetails DCD)
            {                
                int id = DownloadCertificateDetailsData.WritheProdInDCDetailsData(DCD);
                return id;
            }

            public void WritheQuantityInDCDetails(DownloadCertificateDetails DCD)
            {
                DownloadCertificateDetailsData DCDD = new DownloadCertificateDetailsData();
                DCDD.WritheQuantityInDCDetailsData(DCD);
            }


        }
    }
    
}