using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Sstorage.admin;
using Sstorage.DAL;

namespace Sstorage
{ namespace BLL
    {
        public class Inventorys
        {
            public int InventoryId { get; set; }
            public int ProdId { get; set; }
            public string StorageName { get; set; }
            public int StoragesLocatorId { get; set; }
            public string LocatorName { get; set; }
            public int Quantity { get; set; }           
            public Inventorys()
            {

            }
            public Inventorys(int InventoryId, int ProdId, string StorageName, int StoragesLocatorId, string LocatorName, int Quantity)
            {
                this.InventoryId = InventoryId;
                this.ProdId = ProdId;
                this.StorageName = StorageName;
                this.StoragesLocatorId = StoragesLocatorId;
                this.LocatorName = LocatorName;
                this.Quantity = Quantity;

            }
            public Inventorys(int InventoryId, int ProdId, int StoragesLocatorId, string LocatorName, int Quantity)
            {
                this.InventoryId = InventoryId;
                this.ProdId = ProdId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.LocatorName = LocatorName;
                this.Quantity = Quantity;

            }
            public Inventorys(int InventoryId, int ProdId, int StoragesLocatorId, int Quantity)
            {
                this.InventoryId = InventoryId;
                this.ProdId = ProdId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.Quantity = Quantity;

            }
            public Inventorys(int ProdId, int StoragesLocatorId, int Quantity)
            {
                this.ProdId = ProdId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.Quantity = Quantity;
            }
            public List<Inventorys> GetAllLocators()
            {
                List<Inventorys> LstInventorys = new List<Inventorys>();
                LstInventorys = InventorysData.GetAllInventorys();
                return LstInventorys;
            }
            public List<Inventorys> GetInventorysByPid(Product Prod)
            {
                List<Inventorys> LstInvt = new List<Inventorys>();
                LstInvt = InventorysData.GetInventorysByPid(Prod);
                return LstInvt;
            }
        }
    }    
}