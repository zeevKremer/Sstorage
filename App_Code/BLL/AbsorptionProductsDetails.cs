using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class AbsorptionProductsDetails
        {

            public int AbsorptionProductsDetailsId { get; set; }
            public int AbsorptionProductId { get; set; }
            public string ProdName { get; set; }
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public int QuantityUnitsPeck { get; set; }
            public int SupId { get; set; }
            public string SupplierName { get; set; }           
            public int Price { get; set; }
            public int SurfaceId { get; set; }
            public int ProdId { get; set; }
            public int Quantity { get; set; }

            public AbsorptionProductsDetails(int AbsorptionProductsDetailsId, int AbsorptionProductId, string ProdName, string Barcode, string ShorBarcode, int QuantityUnitsPeck, int SupId, string SupplierName, int Price, int SurfaceId, int ProdId, int Quantity)
            {
                this.AbsorptionProductsDetailsId = AbsorptionProductsDetailsId;
                this.AbsorptionProductId = AbsorptionProductId;
                this.ProdName = ProdName;
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.QuantityUnitsPeck = QuantityUnitsPeck;
                this.SupId = SupId;
                this.SupplierName = SupplierName;               
                this.Price = Price;
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public AbsorptionProductsDetails()
            {
                
            }

            public int AddingDetails1(AbsorptionProductsDetails APD)
            {
                int APDid = AbsorptionProductsDetailsData.AddingDetailsData1(APD);
                return APDid; 
            }
            public int AddingDetails2(AbsorptionProductsDetails APD)
            {
                int APDid = AbsorptionProductsDetailsData.AddingDetailsData2(APD);
                return APDid;
            }
            public static List<AbsorptionProductsDetails> GetCertDetailsById(int id)
            {
                List<AbsorptionProductsDetails> LstAPD = new List<AbsorptionProductsDetails>();
                LstAPD = AbsorptionProductsDetailsData.GetCertDetailsById(id);
                return LstAPD;
            }

        }
    }    
}