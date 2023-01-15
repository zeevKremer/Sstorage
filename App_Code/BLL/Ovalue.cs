using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class Ovalue
        {

            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public int ProdId { get; set; }
            public string ProdName { get; set; }
            public string Quantity { get; set; }
            public string Pack { get; set; }
            public string SenderLocatorName { get; set; }
            public string GeterLocatorName { get; set; }
            public string Price { get; set; }
            public Ovalue(string Barcode, string ShorBarcode, int ProdId, string ProdName, string Quantity, string Pack, string SenderLocatorName, string GeterLocatorName, string Price)
            {
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.ProdId = ProdId;
                this.ProdName = ProdName;
                this.Quantity = Quantity;
                this.Pack = Pack;
                this.SenderLocatorName = SenderLocatorName;
                this.GeterLocatorName = GeterLocatorName;
                this.Price = Price;

            }
            public Ovalue()
            {

            }

        }
    }   
}