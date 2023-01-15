using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;
using Sstorage.admin;

namespace Sstorage
{ 
    namespace BLL
    {
        public class TtransferCertificateDetails
        {
            public int CertificateDetailsId { get; set; }
            public int CertificateId { get; set; }
            public string ProdName { get; set; }
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public int QuantityUnitsPeck { get; set; }
            public string StoragesLocatorSender { get; set; }
            public string StoragesLocatorGeter { get; set; }
            public int Price { get; set; }
            public int SurfaceId { get; set; }
            public int ProdId { get; set; }
            public int Quantity { get; set; }
            public TtransferCertificateDetails(int CertificateDetailsId, int CertificateId, string ProdName, string Barcode, string ShorBarcode, int QuantityUnitsPeck, string StoragesLocatorSender, string StoragesLocatorGeter, int Price, int SurfaceId, int ProdId, int Quantity)
            {
                this.CertificateDetailsId = CertificateDetailsId;
                this.CertificateId = CertificateId;
                this.ProdName = ProdName;
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.QuantityUnitsPeck = QuantityUnitsPeck;
                this.StoragesLocatorSender = StoragesLocatorSender;
                this.StoragesLocatorGeter = StoragesLocatorGeter;
                this.Price = Price;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public TtransferCertificateDetails(int CertificateDetailsId, int CertificateId, int SurfaceId, int ProdId, int Quantity)
            {
                this.CertificateDetailsId = CertificateDetailsId;
                this.CertificateId = CertificateId;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public TtransferCertificateDetails(int CertificateId, int SurfaceId, int ProdId, int Quantity)
            {                
                this.CertificateId = CertificateId;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public TtransferCertificateDetails()
            {
                this.CertificateDetailsId = CertificateDetailsId;
                this.CertificateId = CertificateId;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public int AddingDetails1(TtransferCertificateDetails TCD)
            {
                int TCDid = TtransferCertificateDetailsData.AddingDetailsData1(TCD);
                return TCDid;
            }
            public int AddingDetails2(TtransferCertificateDetails TCD)
            {
                int TCDid = TtransferCertificateDetailsData.AddingDetailsData2(TCD);
                return TCDid;
            }
            public static List<TtransferCertificateDetails> GetCertDetailsById(int id)
            {                                                     
                List<TtransferCertificateDetails> LstTCD = new List<TtransferCertificateDetails>();
                LstTCD = TtransferCertificateDetailsData.GetCertDetailsById(id);
                return LstTCD;
            }
        }
    }    
}