using Sstorage.BLL;
using Sstorage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sstorage
{
    namespace admin
    {
        public partial class SurfacesMap : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    User a = (User)Session["user"];
                    if (a != null)
                    {
                        if (a.Rid > 1)
                            Response.Redirect("login.aspx");
                        else
                        {
                            LtlUserDitels.Text = "" + a.Name;
                        }
                    }
                    else
                        Response.Redirect("login.aspx");
                    FillData();
                }
            }
            public void FillData()
            {
                List<Surface>LstSurfaces = new List<Surface>();
                Surface surfac = new Surface();
                LstSurfaces = surfac.GetAllSurfaces();
                List<Product> LstProducts = new List<Product>();
                Product product = new Product();
                LstProducts = product.GetAllProduct();
                string StrSurfaces = "$*";
                string ProdName = "";
                for(int i=0;i< LstSurfaces.Count;i++)
                {
                    ProdName = "";
                    for (int j=0;j< LstProducts.Count;j++)
                    {
                        if (LstProducts[j].ProdId == LstSurfaces[i].ProdId)
                            ProdName = LstProducts[j].ProdName;
                    }
                    StrSurfaces += LstSurfaces[i].LocatorName + "*" + LstSurfaces[i].SurfaceId + "*" + ProdName + "*" + LstSurfaces[i].Quantity + "#*";
                }
                int size = StrSurfaces.Length;
                StrSurfaces = StrSurfaces.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "func3(" + "'" + StrSurfaces + "'" + ")", true);
            }
        }
    }
}