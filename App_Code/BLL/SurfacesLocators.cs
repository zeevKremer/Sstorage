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
        public class SurfacesLocators
        {
            public int SurfacesLocatorId { get; set; }
            public int SurfaceId { get; set; }
            public int StoragesLocatorId { get; set; }
            public string StoragesLocatorIdHistory { get; set; }
            public SurfacesLocators()
            {

            }
            public SurfacesLocators(int SurfacesLocatorId, int SurfaceId, int StoragesLocatorId, string StoragesLocatorIdHistory)
            {
                this.SurfacesLocatorId = SurfacesLocatorId;
                this.SurfaceId = SurfaceId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.StoragesLocatorIdHistory = StoragesLocatorIdHistory;
            }
            public SurfacesLocators(int SurfaceId, int StoragesLocatorId, string StoragesLocatorIdHistory)
            {
                this.SurfaceId = SurfaceId;
                this.StoragesLocatorId = StoragesLocatorId;
                this.StoragesLocatorIdHistory = StoragesLocatorIdHistory;
            }

            public List<SurfacesLocators> GetAllSurfacesLocators()
            {
                List<SurfacesLocators> LstSurfacesLocators = new List<SurfacesLocators>();
                LstSurfacesLocators = SurfacesLocatorsData.GetAllSurfacesLocators();
                return LstSurfacesLocators;
            }
        }
    }    
}