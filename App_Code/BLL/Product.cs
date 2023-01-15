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
        public class Product
        {
            public int ProdId { get; set; }
            public string Barcode { get; set; }
            public string ShorBarcode { get; set; }
            public int CatId { get; set; }
            public int SupplierId { get; set; }
            public string ProdName { get; set; }
            public string ProdDesc { get; set; }
            public float Price { get; set; }
            public string PicName { get; set; }
            public string Weight { get; set; }
            public int QuantityUnitsPeck { get; set; }
            public int QuantityUnitsBox { get; set; }

           public Product()
            {

            }
            public Product(int ProdId , string Barcode , string ShorBarcode , int CatId , int SupplierId , string ProdName , string ProdDesc , float Price , string PicName , string Weight , int QuantityUnitsPeck , int QuantityUnitsBox)
            {
                this.ProdId = ProdId;
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.CatId = CatId;
                this.SupplierId = SupplierId;
                this.ProdName = ProdName;
                this.ProdDesc = ProdDesc;
                this.Price = Price;
                this.PicName = PicName;
                this.Weight = Weight;
                this.QuantityUnitsPeck = QuantityUnitsPeck;
                this.QuantityUnitsBox = QuantityUnitsBox;
            }
            public  Product(string Barcode, string ShorBarcode, int CatId, int SupplierId, string ProdName, string ProdDesc, float Price, string PicName, string Weight, int QuantityUnitsPeck, int QuantityUnitsBox)
            {               
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.CatId = CatId;
                this.SupplierId = SupplierId;
                this.ProdName = ProdName;
                this.ProdDesc = ProdDesc;
                this.Price = Price;
                this.PicName = PicName;
                this.Weight = Weight;
                this.QuantityUnitsPeck = QuantityUnitsPeck;
                this.QuantityUnitsBox = QuantityUnitsBox;
            }
            public Product(string Barcode, string ShorBarcode, int CatId, int SupplierId, string ProdName, string ProdDesc, float Price )
            {
                this.Barcode = Barcode;
                this.ShorBarcode = ShorBarcode;
                this.CatId = CatId;
                this.SupplierId = SupplierId;
                this.ProdName = ProdName;
                this.ProdDesc = ProdDesc;
                this.Price = Price;               
            }
            public Product GetProduct(int Pid)
            {
                Product product = new Product();
                product = ProductData.GetProduct(Pid);
                return product;
            }
            public  List<Product>  GetAllProduct()
            {
                List<Product> LstProducts = new List<Product>();
                LstProducts = ProductData.GetAllProduct();
                return LstProducts;
            }
            public void AddProduct(Product Prod)
            {
                ProductData.AddProduct(Prod);
            }
            public void UpProduct(Product Prod)
            {
                ProductData.UpProduct(Prod);
            }
        }
    }    
}