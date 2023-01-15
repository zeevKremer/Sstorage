using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{ 
    namespace BLL
    {
        public class AbsorptionProducts
        {

            public int AbsorptionProductsId { get; set; }
            public int UserIdOpen { get; set; }
            public string UserName { get; set; }
            public int SupplierId { get; set; }
            public string SupplieName { get; set; }            
            public string Status { get; set; }
            public string ShippingCertificatePicName { get; set; }
            public string QuantityProper { get; set; }
            public int SumProd { get; set; }
            public DateTime Date { get; set; }
            public AbsorptionProducts()
            {

            }
            public AbsorptionProducts(int AbsorptionProductsId, int UserIdOpen, string UserName, int SupplierId, string SupplieName, string Status, string ShippingCertificatePicName, string QuantityProper, int SumProd, DateTime Date)
            {
                this.AbsorptionProductsId = AbsorptionProductsId;
                this.UserIdOpen= UserIdOpen;
                this.UserName = UserName;               
                this.SupplierId= SupplierId;
                this.SupplieName = SupplieName;
                this.Status= Status;
                this.ShippingCertificatePicName= ShippingCertificatePicName;
                this.QuantityProper= QuantityProper;
                this.SumProd = SumProd;
                this.Date = Date;
            }
            public List<AbsorptionProducts> GetAllCertificats()
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                LstAP = AbsorptionProductsData.GetAllCertificats();
                return LstAP;
            }
            public List<AbsorptionProducts> GetTenCertificats()
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                LstAP = AbsorptionProductsData.GetTenCertificats();
                return LstAP;
            }
            public List<AbsorptionProducts> GetCertificatsByColumnName(string ColumnName, int value)
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                LstAP = AbsorptionProductsData.GetCertificatsByColumnName(ColumnName, value);
                return LstAP;
            }
            public List<AbsorptionProducts> GetCertificatsByColumnName(string ColumnName, string value)
            {
                List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                LstAP = AbsorptionProductsData.GetCertificatsByColumnName(ColumnName, value);
                return LstAP;
            }

            public int OpenAbsorptionProducts(AbsorptionProducts absorptionProducts)
            {
                int id;
                id = AbsorptionProductsData.OpenAbsorptionProducts(absorptionProducts);
                return id;
            }           
            public static int isExist(int SupplierId)
            {
                int id;
                id = AbsorptionProductsData.isExist(SupplierId);
                return id;
            }
            public static void CloseCertificatById(int id)
            {
                AbsorptionProductsData.CloseCertificatById(id);
            }
            public static AbsorptionProducts GetCertificatById(int id)
            {
                AbsorptionProducts AP = new AbsorptionProducts();
                AP = AbsorptionProductsData.GetCertificatById(id);
                return AP;
            }
        }
    }    
}