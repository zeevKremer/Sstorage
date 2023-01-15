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
        public class StoragesLocators
        {
            public int StoragesLocatorId { get; set; }
            public int StorageId { get; set; }
            public string LocatorName { get; set; }

            public StoragesLocators()
            {

            }
            public StoragesLocators(int StoragesLocatorId, int StorageId, string LocatorName)
            {
                this.StoragesLocatorId = StoragesLocatorId;
                this.StorageId = StorageId;
                this.LocatorName = LocatorName;

            }
            public StoragesLocators(int StorageId, string LocatorName)
            {
                this.StorageId = StorageId;
                this.LocatorName = LocatorName;
            }
            public List<StoragesLocators> GetAllLocators()
            {
                List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                LstStoragesLocators = StoragesLocatorsData.GetAllLocators();
                return LstStoragesLocators;
            }
        }
    }    
}