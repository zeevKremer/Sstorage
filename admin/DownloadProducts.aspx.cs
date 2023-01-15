using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sstorage.BLL;
using Sstorage.DAL;

namespace Sstorage
{
    namespace admin
    {
        public partial class DownloadProducts : System.Web.UI.Page
        {
            User a = new User();
            int Pid;
            int id;
            int[] DownloadDitels = new int[3];            
            List<DownloadCertificateDetails> LstDCD = new List<DownloadCertificateDetails>();
            DownloadCertificate DC = new DownloadCertificate();
            DownloadCertificateDetails DCD = new DownloadCertificateDetails();
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    a = (User)Session["user"];
                    if (a != null)
                    {
                        if (a.Rid > 1)
                            Response.Redirect("login.aspx");
                        else
                        {
                            LtlUserDitels.Text = "" + a.Name;
                        }
                        OpenCertificate();
                    }
                    else
                        Response.Redirect("login.aspx");



                    //List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                    //StoragesLocators SL = new StoragesLocators();
                    //LstStoragesLocators = SL.GetAllLocators();
                    //Application["StoragesLocators"] = LstStoragesLocators;

                    //List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                    //StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                    //LstStoragesLocatorsProducts = SLP.GetAllSLP();
                    //Application["StoragesLocatorsProducts"] = LstStoragesLocatorsProducts;

                    //List<Inventorys> LstInventorys = new List<Inventorys>();
                    //Inventorys Inventorys = new Inventorys();
                    //LstInventorys = Inventorys.GetAllLocators();
                    //Application["Inventorys"] = LstInventorys;

                    //List<Surface> LstSurfaces = new List<Surface>();
                    //Surface Surf = new Surface();
                    //LstSurfaces = Surf.GetAllSurfaces();
                    //Application["Surfaces"] = LstSurfaces;

                    //List<SurfacesLocators> LstSurfacesLocators = new List<SurfacesLocators>();
                    //SurfacesLocators SurfLocator = new SurfacesLocators();
                    //LstSurfacesLocators = SurfLocator.GetAllSurfacesLocators();
                    //Application["SurfacesLocators"] = LstSurfacesLocators;

                    //List<Product> LstProducts = new List<Product>();
                    //Product product = new Product();
                    //LstProducts = product.GetAllProduct();
                    //Application["Products"] = LstProducts;

                }

                DateTime date = DateTime.Today;
                string date1 = Convert.ToString(date);
                LtlDate.Text = date1.Substring(0, 10);
                LtlStorageSender.Text = "מרלו" + '"' + "ג-רזרבות";
                LtlStorageGeter.Text = "מרלו" + '"' + "ג-ליקוט";
                LtlStatus.Text = "בליקוט";
            }            
            protected void OpenCertificate()
            {

                int StorageSenderId = 4;
                int StorageGeterId = 3;
                a = (User)Session["user"];
                DC.UserId = a.Uid;
                DC.StorageSenderId = StorageSenderId;
                DC.StorageGeterId = StorageGeterId;
                DateTime date = DateTime.Now;
                DC.Date = date;
                id = DC.OpenDownloadCertificate(DC);
                DC.CertificateId = id;
                DCD.DownloadCertificateId = id;                
                Session["DownloadCertificate"] = DC;
                Session["DownloadCertificateDetails"] = DCD;
                LiCertificateDitels.Text = "     תעודה מספר      " + id + "        זמן פתיחת התעודה       " + DC.Date;
            }

            protected void DdlActions_TextChanged1(object sender, EventArgs e)
            {
                if (DropDownList1.SelectedIndex == 2)
                    Response.Redirect("SurfacesLocatorUpdate.aspx");
            }



            //protected void BtnLocatorName_Click(object sender, EventArgs e)
            //{
            //    List<StoragesLocators> SL = new List<StoragesLocators>();
            //    SL = (List<StoragesLocators>)Application["StoragesLocators"];
            //    int size = SL.Count;
            //    string h = "";
            //    for (int i = 0; i < size; i++)
            //    {
            //        h += "<br />";
            //        h += "" + SL[i].LocatorName;
            //    }
            //    b.Text = h;
            //}

            protected void BtnDownloadOk_Click(object sender, EventArgs e)
            {
                // DownloadDitels[1] =Convert.ToInt32(Request["select1"]);
                DownloadCertificate downloadCertificate = (DownloadCertificate)Session["DownloadCertificate"];
                //DCD.DownloadCertificateDetailsId = (int)Session["DownloadCertificateDetailsId"];
                //DCD.DownloadCertificateId = downloadCertificate.CertificateId;
                //DCD.ProdId = (int)Session["Pid"];
                DCD = (DownloadCertificateDetails)Session["DownloadCertificateDetails"];
                DCD.SurfaceId = (DdlSurfaceId.SelectedIndex - 1);
                DCD.Quantity =Convert.ToInt32( TexQuantity.Text);                
                DCD.WritheQuantityInDCDetails(DCD);

            }
            protected void DdlSurfaceId_TextChanged(object sender, EventArgs e)
            {
                int SurfaceId = (DdlSurfaceId.SelectedIndex - 1);
                int Pid = (int)Session["Pid"];
                List<Inventorys> LstInventorys = new List<Inventorys>();
                LstInventorys = (List<Inventorys>)Application["Inventorys"];
                Inventorys Inventory = new Inventorys();
                for (int i = 0; i < LstInventorys.Count; i++)
                {
                    if (LstInventorys[i].ProdId == Pid)
                    {
                        Inventory.InventoryId = LstInventorys[i].InventoryId;
                        Inventory.ProdId = LstInventorys[i].ProdId;
                        Inventory.StoragesLocatorId = LstInventorys[i].StoragesLocatorId;
                        Inventory.Quantity = LstInventorys[i].Quantity;
                    }
                }

                List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                LstStoragesLocators = (List<StoragesLocators>)Application["StoragesLocators"];
                StoragesLocators SL = new StoragesLocators();
                for (int i = 0; i < LstStoragesLocators.Count; i++)
                {
                    if (LstStoragesLocators[i].StoragesLocatorId == Inventory.StoragesLocatorId && LstStoragesLocators[i].StorageId == 3)
                    {
                        SL.StoragesLocatorId = LstStoragesLocators[i].StoragesLocatorId;
                        SL.StorageId = LstStoragesLocators[i].StorageId;
                        SL.LocatorName = LstStoragesLocators[i].LocatorName;
                        DownloadDitels[0] = SL.StoragesLocatorId;
                    }

                }

                List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                LstStoragesLocatorsProducts = (List<StoragesLocatorsProducts>)Application["StoragesLocatorsProducts"];
                StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                for (int i = 0; i < LstStoragesLocatorsProducts.Count; i++)
                {
                    if (LstStoragesLocatorsProducts[i].StoragesLocatorId == SL.StoragesLocatorId)
                    {
                        SLP.StoragesLocatorsProductsId = LstStoragesLocatorsProducts[i].StoragesLocatorsProductsId;
                        SLP.StoragesLocatorId = LstStoragesLocatorsProducts[i].StoragesLocatorId;
                        SLP.ProdId = LstStoragesLocatorsProducts[i].ProdId;
                        SLP.Maximum = LstStoragesLocatorsProducts[i].Maximum;
                        SLP.Minimum = LstStoragesLocatorsProducts[i].Minimum;
                    }
                }
                List<Surface> LstSurfaces = new List<Surface>();
                LstSurfaces = (List<Surface>)Application["Surfaces"];
                int count = 0;
                for (int i = 0; i < LstSurfaces.Count; i++)
                {
                    if (LstSurfaces[i].ProdId == Pid)
                        count++;
                }
                Surface[] Surf = new Surface[count];
                int flag = 0;
                for (int i = 0; i < LstSurfaces.Count; i++)
                {
                    if (LstSurfaces[i].ProdId == Pid)
                    {
                        Surface Surf1 = new Surface();
                        Surf1.SurfaceId = LstSurfaces[i].SurfaceId;
                        Surf1.ProdId = LstSurfaces[i].ProdId;
                        Surf1.Quantity = LstSurfaces[i].Quantity;
                        Surf1.Remarks = LstSurfaces[i].Remarks;
                        Surf[flag] = Surf1;
                        flag++;
                    }
                }
                int a = (SLP.Maximum - Inventory.Quantity);
                int c = SurfaceId;
                int b = Surf[SurfaceId].Quantity;

                if (Surf[SurfaceId].Quantity >= (SLP.Maximum - Inventory.Quantity))
                    TexQuantity.Text = "" + (SLP.Maximum - Inventory.Quantity);
                else
                    TexQuantity.Text = "" + Surf[SurfaceId].Quantity;

            }

            protected void Open_Click(object sender, EventArgs e)
            {
                TransferCertificate TC = new TransferCertificate();
                Pid = TC.Pull();
                Session["Pid"] = Pid;                
                DC = (DownloadCertificate)Session["DownloadCertificate"];
                DCD = (DownloadCertificateDetails)Session["DownloadCertificateDetails"];
                DCD.ProdId = Pid;                
                DCD.DownloadCertificateDetailsId = DCD.WritheProdInDCDetails(DCD);
                Session["DownloadCertificate"] = DC;
                Session["DownloadCertificateDetails"] = DCD;
                List<Product> LstProducts = new List<Product>();
                LstProducts = (List<Product>)Application["Products"];
                Product product = new Product();
                for (int i = 0; i < LstProducts.Count; i++)
                {
                    if (LstProducts[i].ProdId == Pid)
                    {
                        product.ProdId = LstProducts[i].ProdId;
                        product.Barcode = LstProducts[i].Barcode;
                        product.ShorBarcode = LstProducts[i].ShorBarcode;
                        product.CatId = LstProducts[i].CatId;
                        product.SupplierId = LstProducts[i].SupplierId;
                        product.ProdName = LstProducts[i].ProdName;
                        product.ProdDesc = LstProducts[i].ProdDesc;
                        product.Price = LstProducts[i].Price;
                        product.PicName = LstProducts[i].PicName;
                        product.Weight = LstProducts[i].Weight;
                        product.QuantityUnitsPeck = LstProducts[i].QuantityUnitsPeck;
                        product.QuantityUnitsBox = LstProducts[i].QuantityUnitsBox;
                    }
                }                
                List<Inventorys> LstInventorys = new List<Inventorys>();
                LstInventorys = (List<Inventorys>)Application["Inventorys"];
                Inventorys Inventory = new Inventorys();
                for (int i = 0; i < LstInventorys.Count; i++)
                {
                    if (LstInventorys[i].ProdId == Pid)
                    {
                        Inventory.InventoryId = LstInventorys[i].InventoryId;
                        Inventory.ProdId = LstInventorys[i].ProdId;
                        Inventory.StoragesLocatorId = LstInventorys[i].StoragesLocatorId;
                        Inventory.Quantity = LstInventorys[i].Quantity;
                    }
                }

                List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                LstStoragesLocators = (List<StoragesLocators>)Application["StoragesLocators"];
                StoragesLocators SL = new StoragesLocators();
                for (int i = 0; i < LstStoragesLocators.Count; i++)
                {
                    if (LstStoragesLocators[i].StoragesLocatorId == Inventory.StoragesLocatorId && LstStoragesLocators[i].StorageId == 3)
                    {
                        SL.StoragesLocatorId = LstStoragesLocators[i].StoragesLocatorId;
                        SL.StorageId = LstStoragesLocators[i].StorageId;
                        SL.LocatorName = LstStoragesLocators[i].LocatorName;
                        DownloadDitels[0] = SL.StoragesLocatorId;
                    }

                }

                List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                LstStoragesLocatorsProducts = (List<StoragesLocatorsProducts>)Application["StoragesLocatorsProducts"];
                StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                for (int i = 0; i < LstStoragesLocatorsProducts.Count; i++)
                {
                    if (LstStoragesLocatorsProducts[i].StoragesLocatorId == SL.StoragesLocatorId)
                    {
                        SLP.StoragesLocatorsProductsId = LstStoragesLocatorsProducts[i].StoragesLocatorsProductsId;
                        SLP.StoragesLocatorId = LstStoragesLocatorsProducts[i].StoragesLocatorId;
                        SLP.ProdId = LstStoragesLocatorsProducts[i].ProdId;
                        SLP.Maximum = LstStoragesLocatorsProducts[i].Maximum;
                        SLP.Minimum = LstStoragesLocatorsProducts[i].Minimum;
                    }
                }

                List<Surface> LstSurfaces = new List<Surface>();
                LstSurfaces = (List<Surface>)Application["Surfaces"];
                int count = 0;
                for (int i = 0; i < LstSurfaces.Count; i++)
                {
                    if (LstSurfaces[i].ProdId == Pid)
                        count++;
                }
                Surface[] Surf = new Surface[count];
                string[] SurfValue = new string[count];
                int flag = 0;
                for (int i = 0; i < LstSurfaces.Count; i++)
                {
                    if (LstSurfaces[i].ProdId == Pid)
                    {
                        Surface Surf1 = new Surface();
                        Surf1.SurfaceId = LstSurfaces[i].SurfaceId;
                        Surf1.ProdId = LstSurfaces[i].ProdId;
                        Surf1.Quantity = LstSurfaces[i].Quantity;
                        Surf1.Remarks = LstSurfaces[i].Remarks;
                        Surf[flag] = Surf1;
                        flag++;
                    }
                }
                List<SurfacesLocators> LstSurfacesLocators = new List<SurfacesLocators>();
                LstSurfacesLocators = (List<SurfacesLocators>)Application["SurfacesLocators"];
                DdlSurfaceId.Items.Clear();
                for (int i = 0; i < Surf.Length; i++)
                {
                    for (int j = 0; j < LstSurfacesLocators.Count; j++)
                    {
                        if (Surf[i].SurfaceId == LstSurfacesLocators[j].SurfaceId)
                        {
                            int SurfLocatorId = LstSurfacesLocators[j].StoragesLocatorId;
                            for (int k = 0; k < LstStoragesLocators.Count; k++)
                            {
                                if (LstStoragesLocators[k].StoragesLocatorId == SurfLocatorId)
                                {
                                    string SurfaceLocatorName = (string)LstStoragesLocators[k].LocatorName;                                    
                                    SurfValue[i] = " מספר משטח " + Surf[i].SurfaceId + "........" + SurfaceLocatorName;
                                    ListItem l = new ListItem(" מספר משטח " + Surf[i].SurfaceId + "........" + SurfaceLocatorName, "" + (i + 1), true);
                                    DdlSurfaceId.Items.Add(l);


                                }
                            }
                        }
                    }
                }
                    DownloadCertificateDetails dCd = new DownloadCertificateDetails();
                    dCd.Barcode = product.Barcode;
                    dCd.ShorBarcode = product.ShorBarcode;
                    dCd.ProdName = product.ProdName;
                    dCd.SurfaceValue = SurfValue;
                    dCd.Quantity = Convert.ToInt32("0");
                    dCd.QuantityUnitsPeck = Convert.ToInt32("0");
                    dCd.LocatorName = SL.LocatorName;
                    LstDCD.Add(dCd);
                    RptTable.DataSource = LstDCD;
                    RptTable.DataBind();
                //TxtBarcode.Text = product.Barcode;
                //TextShorBarcode.Text = product.ShorBarcode;
                //TextProdName.Text = product.ProdName;                   
                //TexQuantity.Text = "0";
                //TextQuantityUnitsPeck.Text = "0";
                //TextLocatorName.Text = SL.LocatorName;                
            }
        }
    }
}