using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class Surface
        {
            public int SurfaceId { get; set; }
            public int ProdId { get; set; }
            public int Quantity { get; set; }            
            public string Remarks { get; set; }
            public string LocatorName { get; set; }
            public Surface()
            {

            }
            public Surface(int SurfaceId, int ProdId, int Quantity, string Remarks, string LocatorName)
            {
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
                this.Remarks = Remarks;
                this.LocatorName = LocatorName;
            }
            public Surface(int SurfaceId, int ProdId, int Quantity, string Remarks)
            {
                this.SurfaceId = SurfaceId;
                this.ProdId = ProdId;
                this.Quantity = Quantity;
                this.Remarks = Remarks;
            }
            public Surface(int SurfaceId, int Quantity, string Remarks)
            {
                this.SurfaceId = SurfaceId;
                this.Quantity = Quantity;
                this.Remarks = Remarks;

            }
            public Surface(int SurfaceId)
            {
                this.SurfaceId = SurfaceId;                
            }
            public int isExist(Surface surface)
            {
                int surfaceid;
                surfaceid = SurfaceData.isExist(surface);

                return surfaceid;
            }
            public List<Surface> GetAllSurfaces()
            {
                List<Surface> LstSurfaces = new List<Surface>();
                LstSurfaces = SurfaceData.GetAllSurfaces();
                return LstSurfaces;
            }            
                public List<Surface> GetSurfacesById(int id)
            {
                List<Surface> LstSurfaces = new List<Surface>();
                LstSurfaces = SurfaceData.GetSurfacesById(id);
                return LstSurfaces;
            }

        }
    }    
}