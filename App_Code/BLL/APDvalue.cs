using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {

        public class APDvalue
        {
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public int ProdId { get; set; }
            public string ProdName { get; set; }
            public string Quantity { get; set; }
            public string Pack { get; set; }
            public string SupplierName { get; set; }            
            public string Price { get; set; }

            public APDvalue(string Barcode, string ShorBarcode, int ProdId, string ProdName, string Quantity, string Pack, string SupplierName, string Price)
            {
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.ProdId = ProdId;
                this.ProdName = ProdName;
                this.Quantity = Quantity;
                this.Pack = Pack;
                this.SupplierName = SupplierName;                
                this.Price = Price;

            }
            public APDvalue()
            {

            }
        }
    }   
}