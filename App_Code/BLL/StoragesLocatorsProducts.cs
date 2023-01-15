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
        public class StoragesLocatorsProducts
        {
            public int StoragesLocatorsProductsId { get; set; }
            public int StoragesLocatorId { get; set; }
            public int ProdId { get; set; }
            public int Maximum { get; set; }
            public int Minimum { get; set; }

            public StoragesLocatorsProducts()
            {

            }
            public StoragesLocatorsProducts(int StoragesLocatorsProductsId, int StoragesLocatorId, int ProdId, int Maximum, int Minimum)
            {
                this.StoragesLocatorsProductsId = StoragesLocatorsProductsId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.ProdId = ProdId;
                this.Maximum = Maximum;
                this.Minimum = Minimum;
            }
            public StoragesLocatorsProducts(int StoragesLocatorId, int ProdId, int Maximum, int Minimum)
            {
                this.StoragesLocatorId = StoragesLocatorId;
                this.ProdId = ProdId;
                this.Maximum = Maximum;
                this.Minimum = Minimum;
            }

            public List<StoragesLocatorsProducts> GetAllSLP()
            {
                List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                LstStoragesLocatorsProducts = StoragesLocatorsProductsData.GetAllSLP();
                return LstStoragesLocatorsProducts;
            }

        }
    }    
}