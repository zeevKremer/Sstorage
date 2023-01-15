using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class OrdersDetails
        {
            public int OrderDetailsId { get; set; }
            public int OrderId { get; set; }
            public string ProdName { get; set; }
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }           
            public string StoragesLocatorSender { get; set; }
            public string StoragesLocatorGeter { get; set; }
            public int Price { get; set; }            
            public int ProdId { get; set; }
            public int Quantity { get; set; }
            public OrdersDetails(int OrderDetailsId, int OrderId, string ProdName, string Barcode, string ShorBarcode, string StoragesLocatorSender, string StoragesLocatorGeter, int Price, int ProdId, int Quantity)
            {
                this.OrderDetailsId = OrderDetailsId;
                this.OrderId = OrderId;
                this.ProdName = ProdName;
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;            
                this.StoragesLocatorSender = StoragesLocatorSender;
                this.StoragesLocatorGeter = StoragesLocatorGeter;
                this.Price = Price;              
                this.ProdId = ProdId;
                this.Quantity = Quantity;
            }
            public OrdersDetails()
            {
                
            }
            
            public int AddingDetails1(OrdersDetails OD)
            {
                int ODid = OrdersDetailsData.AddingDetailsData1(OD);
                return ODid;
            }
            public int AddingDetails2(OrdersDetails OD)
            {
                int ODid = OrdersDetailsData.AddingDetailsData2(OD);
                return ODid;
            }
            public static List<OrdersDetails> GetCertDetailsById(int id)
            {
                List<OrdersDetails> LstOD = new List<OrdersDetails>();
                LstOD = OrdersDetailsData.GetOrdDetailsById(id);
                return LstOD;
            }

        }
    }   
}