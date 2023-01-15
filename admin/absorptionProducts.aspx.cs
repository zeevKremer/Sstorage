using Sstorage.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sstorage.BLL;

namespace Sstorage
{
    namespace admin
    {
        public partial class absorptionProducts : System.Web.UI.Page
        {
            int AbsorptionProductId;
            User a = new User();           
            int flag1;
            int flag2 = 0;            
            int prod1;
            int quantity1;
            string ColumnName;
            int Pid;
            int flag = 0;
            AbsorptionProducts AP = new AbsorptionProducts();
            List<AbsorptionProductsDetails> LstAPD = new List<AbsorptionProductsDetails>();
            List<APDvalue> LstApdValue = new List<APDvalue>();
            AbsorptionProductsDetails APD = new AbsorptionProductsDetails();                       
            protected void Page_Load(object sender, EventArgs e)
            {
                if(!IsPostBack)
                {
                    a = (User)Session["user"];
                    Application["flag"] = flag;
                    if (a != null)
                    {
                        if (a.Rid > 1)
                            Response.Redirect("login.aspx");
                        else
                        {
                            LtlUserDitels.Text = "" + a.Name;
                        }
                        FillData();
                        DateTime date = DateTime.Today;
                        string date1 = Convert.ToString(date);
                        TxtDate.Text = date1.Substring(0, 10);

                    }
                    else
                        Response.Redirect("login.aspx");

                    Panel3.Visible = true;
                    List<Product> LstProducts = new List<Product>();
                    Product product = new Product();
                    LstProducts = product.GetAllProduct();
                    Application["Products"] = LstProducts;
                    List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                    StoragesLocators SL = new StoragesLocators();
                    LstStoragesLocators = SL.GetAllLocators();
                    Application["StoragesLocators"] = LstStoragesLocators;

                    List<StoragesLocatorsProducts> LstStoragesLocatorsProducts = new List<StoragesLocatorsProducts>();
                    StoragesLocatorsProducts SLP = new StoragesLocatorsProducts();
                    LstStoragesLocatorsProducts = SLP.GetAllSLP();
                    Application["StoragesLocatorsProducts"] = LstStoragesLocatorsProducts;
                    Application["flag2"] = 0;
                }
            }
            public void FillData()
            {
                SqlObject sql1 = new SqlObject();
                DataTable Dt1 = new DataTable();
                Dt1 = sql1.ExecuteKeyValue("SupplierName", "SupplierId", "Tsuppliers");
                DdlSupplierId.DataSource = Dt1;
                DdlSupplierId.DataTextField = "TextField";
                DdlSupplierId.DataValueField = "ValueField";
                DdlSupplierId.DataBind();
                sql1.Close();
                DdlSupplierId.Items.Insert(0, new ListItem("בחר ספק", "-1"));
                DdlSupplierId.Items[0].Attributes.Add("disabled", "true");
                DdlSupplierId.Items[0].Attributes.Add("selected", "true");



                //SqlObject sql3 = new SqlObject();
                //DataTable Dt3 = new DataTable();
                //Dt3 = sql3.ExecuteKeyValue("ProdName", "ProdId", "Tproducts");
                //DdlProdId.DataSource = Dt3;
                //DdlProdId.DataTextField = "TextField";
                //DdlProdId.DataValueField = "ValueField";
                //DdlProdId.DataBind();
                //sql3.Close();
                //DdlProdId.Items.Insert(0, new ListItem("בחר מוצר", "-1"));
                //DdlProdId.Items[0].Attributes.Add("disabled", "true");
                //DdlProdId.Items[0].Attributes.Add("selected", "true");
                List<Supplier> LstSupplier = new List<Supplier>();
                Supplier supplier = new Supplier();
                LstSupplier = supplier.GetAllSuppliers();
                List<AbsorptionProducts> LstAP1 = new List<AbsorptionProducts>();
                AbsorptionProducts AP = new AbsorptionProducts();
                LstAP1 = AP.GetTenCertificats();
                for (int i = 0; i < LstAP1.Count; i++)
                {
                    for (int j = 0; j < LstSupplier.Count; j++)
                    {
                        if (LstSupplier[j].SupId == LstAP1[i].SupplierId)
                            LstAP1[i].SupplieName = LstSupplier[j].SupName;                        
                    }
                }
                List<User> LstUsers = new List<User>();
                User user = new User();
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstAP1.Count; i++)
                {
                    for (int j = 0; j < LstUsers.Count; j++)
                    {
                        if (LstUsers[j].Uid == LstAP1[i].UserIdOpen)
                            LstAP1[i].UserName = LstUsers[j].Name;
                    }
                }
                Repeater1.DataSource = LstAP1;
                Repeater1.DataBind();
            }

            protected void BtnOpenCertificate_Click(object sender, EventArgs e)
            {
                BtnOpenCertificate.Attributes.Add("AutoPostback", "true");
                int SupplierId = Convert.ToInt32(DdlSupplierId.SelectedValue);
                int isExist = AbsorptionProducts.isExist(SupplierId);
                if (isExist != 0)
                {
                    string str = "קיימת תעודה בסטטוס טיוטא מספק " + DdlSupplierId.Text;
                    //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "ModalMsege(" + "'" + str + "'" + ")", true);     
                    //LtlAaa.Text = str;
                }
                else
                {
                    Application["SupplierId"] = SupplierId;
                    Application["flag1"] = 0;
                    //APDvalue apdValue = new APDvalue();
                    //LstApdValue.Add(apdValue);
                    Application["LstApdValue"] = LstApdValue;
                    a = (User)Session["user"];
                    AP.UserIdOpen = a.Uid;
                    AP.SupplierId = SupplierId;
                    DateTime date = DateTime.Now;
                    AP.Date = date;
                    int id = AP.OpenAbsorptionProducts(AP);
                    AP.AbsorptionProductsId = id;
                    Application["id"] = id;
                    Application["LstAPD"] = LstAPD;
                    List<AbsorptionProducts> LstAP = new List<AbsorptionProducts>();
                    Repeater1.DataSource = LstAP;
                    Repeater1.DataBind();
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "qwer()", true);
                    Repeater2.DataSource = LstAPD;
                    Repeater2.DataBind();
                    Panel1.Visible = true;
                    SqlObject sql = new SqlObject();
                    DataTable Dt = new DataTable();
                    Dt = sql.ExecuteKeyValueSorting("ProdName", "ProdId", "Tproducts", "ProdName");
                    DdlProdName.DataSource = Dt;
                    DdlProdName.DataTextField = "TextField";
                    DdlProdName.DataValueField = "ValueField";
                    DdlProdName.DataBind();
                    ListItem li = new ListItem("בחר מוצר", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlProdName.Items.Insert(0, li);
                    DdlProdName.SelectedValue = "-1";
                    string SenderQuery, GeterQuery, StorageSender, StorageGeter;
                    SenderQuery = " select SupplierName from Tsuppliers where SupplierId =" + SupplierId;
                    StorageSender = sql.ExecuteScalarString(SenderQuery);
                    ListItem li1 = new ListItem("טיוטא", "1");
                    ListItem li2 = new ListItem("סגור", "2");
                    DdlSttus.Items.Insert(0, li1);
                    DdlSttus.Items.Insert(1, li2);
                    DdlSttus.SelectedValue = "1";
                    sql.Close();
                    LtlCertId.Text = "תעודה מספר   ";
                    LtlDate.Text = "  זמן פתיחת התעודה    ";
                    LtelSender.Text = "שם ספק";
                    LtlCertIdV.Text = " " + AP.AbsorptionProductsId;
                    LtlDateV.Text = "    " + AP.Date;
                    LtelSenderV.Text = " " + StorageSender;
                    PanCertificate.Visible = false;
                    PanDetais.Visible = true;
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                    Panel4.Visible = true;
                    Panel5.Visible = false;
                }
            }
            protected void DdlProdName_TextChanged(object sender, EventArgs e)
            {
                TxtBarcode.Text = "";
                TxtShorBarcode.Text = "";
                TxtPrice.Text = "";
                flag1 = prod1 = 0;
                int Pid = Convert.ToInt32(DdlProdName.SelectedValue);
                int flag3 = 0;
                APDvalue apdValue = new APDvalue();
                List<APDvalue> LstApdValue2 = new List<APDvalue>();
                LstApdValue2 = (List<APDvalue>)Application["LstApdValue"];
                for (int j = 0; j < LstApdValue2.Count; j++)
                {
                    if (LstApdValue2[j].ProdId == Pid)
                        flag3 = 1;
                }
                if(flag3 == 0)
                {
                    flag2 = (int)Application["flag2"];
                    if (flag2 == 0)
                    {
                        LstApdValue = (List<APDvalue>)Application["LstApdValue"];
                        LstApdValue.Add(apdValue);
                        Application["flag2"] = 1;
                    }
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "qwer()", true);
                    PanCertificate.Visible = false;
                    PanDetais.Visible = true;
                    DdlSttus.Items.Clear();
                    ListItem li = new ListItem("בליקוט", "2");
                    ListItem li1 = new ListItem("סגור", "3");
                    DdlSttus.Items.Insert(0, li);
                    DdlSttus.Items.Insert(1, li1);
                    DdlSttus.SelectedValue = "2";
                    int flag = 0;
                    int i;
                    for (i = 0; i < LstApdValue.Count; i++)
                    {
                        if (LstApdValue[i].ProdId == Pid)
                            flag = 1;
                        if (LstApdValue[i].ProdId == 0)
                        {
                            flag1 = 1;
                            prod1 = Convert.ToInt32(DdlProdName.SelectedValue);
                            Application["flag1"] = 1;
                            Application["prod1"] = prod1;
                        }
                        else
                        {
                            Application["flag1"] = 0;
                            Application["prod1"] = 0;
                        }
                    }
                    if (flag == 0)
                    {
                        List<Product> LstProducts = (List<Product>)Application["Products"];
                        for (i = 0; i < LstProducts.Count; i++)
                        {
                            if (LstProducts[i].ProdId == Convert.ToInt32(DdlProdName.SelectedValue))
                            {
                                TxtBarcode.Text = LstProducts[i].Barcode;
                                TxtShorBarcode.Text = LstProducts[i].ShorBarcode;
                                TxtPrice.Text = LstProducts[i].Price.ToString();

                            }
                        }
                    }
                    else
                    {
                        DdlProdName.Items.Remove(DdlProdName.Items.FindByText("בחר מוצר"));
                        ListItem lii = new ListItem("בחר מוצר", "-1");
                        lii.Attributes["disabled"] = "disabled";
                        DdlProdName.Items.Insert(0, lii);
                        LstApdValue.RemoveAt(LstApdValue.Count - 1);
                    }
                }
                
            }
            protected void TxtQuantity1_TextChanged(object sender, EventArgs e)
            {

            }
            protected void BtnNewRow_Click(object sender, EventArgs e)
            {
                LtlCheck.Text = "";
                LstAPD = (List<AbsorptionProductsDetails>)Application["LstAPD"];
                AbsorptionProductsDetails APD1 = new AbsorptionProductsDetails();
                APDvalue apdValue = new APDvalue();
                LstApdValue = (List<APDvalue>)Application["LstApdValue"];
                APD1.AbsorptionProductId = (int)Application["id"];
                Application["flag1"] = 0;
                int PId = Convert.ToInt32(DdlProdName.SelectedValue);
                if (PId != -1)
                {
                    if (LstAPD != null)
                    {
                        int IsExest = 0;
                        for (int i = 0; i < LstApdValue.Count; i++)
                        {
                            if (LstApdValue[i].ProdId == PId)
                                IsExest = 1;
                        }
                        if (IsExest == 0)
                        {
                            apdValue.ProdId = PId;
                            int Quantity = 0;
                            if (TxtQuantity.Text != "")
                                Quantity = Convert.ToInt32(TxtQuantity.Text);
                            APD1.ProdId = PId;
                            APD1.Quantity = Quantity;
                            int id = 0;
                            if (Quantity > 0)
                            {
                                Application["flag2"] = 0;
                                id = APD1.AddingDetails1(APD1);
                                APD1.AbsorptionProductsDetailsId = id;
                                apdValue.ProdName = DdlProdName.SelectedItem.Text;
                                apdValue.Barcode = TxtBarcode.Text;
                                apdValue.ShorBarcode = TxtShorBarcode.Text;
                                apdValue.Quantity = TxtQuantity.Text;
                                apdValue.Price = TxtPrice.Text;
                                int flag1 = (int)Application["flag1"];
                                if (flag1 == 0)
                                    LstApdValue.RemoveAt(LstApdValue.Count - 1);
                                LstApdValue.Add(apdValue);
                                flag1 = 1;
                                Application["flag1"] = flag1;
                                Application["LstAPD"] = LstAPD;
                                Application["LstApdValue"] = LstApdValue;
                                AbsorptionProductsData.ChangeStatus(APD1.AbsorptionProductId);
                                DdlSttus.Items.Clear();
                                ListItem li = new ListItem("בליקוט", "2");
                                ListItem li1 = new ListItem("סגור", "3");
                                DdlSttus.Items.Insert(0, li);
                                DdlSttus.Items.Insert(1, li1);
                                DdlSttus.SelectedValue = "2";
                                DdlProdName.SelectedValue = "-1";
                                TxtBarcode.Text = "";
                                TxtShorBarcode.Text = "";
                                TxtQuantity.Text = "";
                                TxtPrice.Text = "";
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "qwer()", true);
                                PanCertificate.Visible = false;
                                PanDetais.Visible = true;
                                Repeater2.DataSource = LstApdValue;
                                Repeater2.DataBind();
                            }
                            //else
                            //{
                            //    id = APD1.AddingDetails2(APD1);
                            //}
                            
                        }
                    }
                }
            }
            protected void BtnCertDetails_Click(object sender, EventArgs e)
            {
                AbsorptionProductId = int.Parse(((LinkButton)sender).CommandArgument);
                AbsorptionProducts AP = new AbsorptionProducts();
                AP = AbsorptionProducts.GetCertificatById(AbsorptionProductId);
                if (AP.Status == "טיוטא" || AP.Status == "בליקוט")
                {
                    List<AbsorptionProductsDetails> LstAPD = new List<AbsorptionProductsDetails>();
                    LstAPD = AbsorptionProductsDetails.GetCertDetailsById(AbsorptionProductId);
                    Panel1.Visible = true;
                    SqlObject sql = new SqlObject();
                    DataTable Dt = new DataTable();
                    Dt = sql.ExecuteKeyValueSorting("ProdName", "ProdId", "Tproducts", "ProdName");
                    DdlProdName.DataSource = Dt;
                    DdlProdName.DataTextField = "TextField";
                    DdlProdName.DataValueField = "ValueField";
                    DdlProdName.DataBind();
                    ListItem li = new ListItem("בחר מוצר", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlProdName.Items.Insert(0, li);
                    DdlProdName.SelectedValue = "-1";
                    Repeater2.DataSource = LstAPD;
                    Repeater2.DataBind();
                    Application["SupplierId"] = AP.SupplierId;                    
                    Application["LstApdValue"] = LstApdValue;
                    Application["LstAPD"] = LstAPD;
                    Application["id"] = AbsorptionProductId;
                    int flag1 = 1;
                    Application["flag1"] = flag1;
                    string SenderQuery, GeterQuery, StorageSender, StorageGeter;
                    SenderQuery = " select SupplierName from Tsuppliers where SupplierId =" + AP.SupplierId;                    
                    StorageSender = sql.ExecuteScalarString(SenderQuery);                 
                    sql.Close();
                    LtlCertId.Text = "תעודה מספר   ";
                    LtlDate.Text = "  זמן פתיחת התעודה    ";
                    LtelSender.Text = "שם ספק";                    
                    LtlCertIdV.Text = " " + AP.AbsorptionProductsId;
                    LtlDateV.Text = "    " + AP.Date;
                    LtelSenderV.Text = " " + StorageSender;                   
                    PanCertificate.Visible = false;
                    PanDetais.Visible = true;
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                    Panel4.Visible = true;
                    Panel5.Visible = false;
                    Repeater1.Visible = false;
                    if (AP.Status == "טיוטא")
                    {
                        DdlSttus.Items.Clear();
                        ListItem li1 = new ListItem("טיוטא", "1");
                        ListItem li2 = new ListItem("סגור", "2");
                        DdlSttus.Items.Insert(0, li1);
                        DdlSttus.Items.Insert(1, li2);
                        DdlSttus.SelectedValue = "1";
                    }
                    else
                    {
                        DdlSttus.Items.Clear();
                        ListItem li0 = new ListItem("בליקוט", "2");
                        ListItem li1 = new ListItem("סגור", "3");
                        DdlSttus.Items.Insert(0, li0);
                        DdlSttus.Items.Insert(1, li1);
                        DdlSttus.SelectedValue = "2";
                    }
                }
                else
                {
                    List<AbsorptionProductsDetails> LstAPD = new List<AbsorptionProductsDetails>();
                    LstAPD = AbsorptionProductsDetails.GetCertDetailsById(AbsorptionProductId);
                    string id = AbsorptionProductId.ToString();
                    string strAPD = id + "$*";
                    for (int i = 0; i < LstAPD.Count; i++)
                    {
                        strAPD += LstAPD[i].ProdName + "*" + LstAPD[i].Barcode + "*" + LstAPD[i].ShorBarcode + "*" + LstAPD[i].Quantity + "*" + LstAPD[i].QuantityUnitsPeck + "*" + LstAPD[i].Quantity + "*" + LstAPD[i].Quantity + "*" + LstAPD[i].Price + "#*";
                    }
                    int size = strAPD.Length;
                    strAPD = strAPD.Substring(0, (size - 1));
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "p(" + "'" + strAPD + "'" + ")", true);
                }
            }
            protected void DdlSttus_TextChanged(object sender, EventArgs e)
            {
                LtlCheck.Text = "";                
                int StatusId = Convert.ToInt32(DdlSttus.SelectedValue);
                if(Convert.ToInt32(TxtQuantity.Text) > 0)
                {

                }
                else
                {
                    if (DdlSttus.SelectedIndex == 1 && TxtQuantity.Text != "")
                    {
                        LstAPD = (List<AbsorptionProductsDetails>)Application["LstAPD"];
                        LstApdValue = (List<APDvalue>)Application["LstApdValue"];
                        flag1 = (int)Application["flag1"];
                        if (flag1 == 1 && TxtQuantity.Text != "")
                        {
                            prod1 = (int)Application["prod1"];
                            APDvalue apdValue1 = new APDvalue();
                            AbsorptionProductsDetails APD1 = new AbsorptionProductsDetails();
                            apdValue1.ProdName = DdlProdName.SelectedItem.Text;
                            apdValue1.Barcode = TxtBarcode.Text;
                            apdValue1.ShorBarcode = TxtShorBarcode.Text;
                            apdValue1.Quantity = TxtQuantity.Text;
                            apdValue1.Price = TxtPrice.Text;
                            apdValue1.ProdId = prod1;
                            apdValue1.SupplierName = LtelSenderV.Text;
                            LstApdValue.RemoveAt(LstApdValue.Count - 1);
                            LstApdValue.Add(apdValue1);
                            APD1.AbsorptionProductId = (int)Application["id"];
                            APD1.ProdId = prod1;
                            APD1.Quantity = Convert.ToInt32(TxtQuantity.Text);
                            flag1 = APD1.AddingDetails1(APD1);
                            Application["flag1"] = 0;
                        }
                        int SupplierId = (int)Application["SupplierId"];
                        DdlSttus.Items.Clear();
                        ListItem li6 = new ListItem("סגור", "1");
                        DdlSttus.Items.Insert(0, li6);
                        int AbsorptionProductId = (int)Application["id"];
                        AbsorptionProducts.CloseCertificatById(AbsorptionProductId);
                        if (LstApdValue.Count == 0)
                        {

                        }
                        else if (LstApdValue.Count == 1 && LstApdValue[0].ProdId == 0)
                        {

                        }
                        else if (LstApdValue[LstApdValue.Count - 1].ProdId == 0)
                        {
                            LstApdValue.RemoveAt(LstApdValue.Count - 1);
                            AbsorptionProductsData.UpInventory(LstApdValue);
                        }
                        else
                            AbsorptionProductsData.UpInventory(LstApdValue);
                    }
                
                }

            }





            protected void DdlSerchCertificate_TextChanged(object sender, EventArgs e)
            {
                
                    SqlObject sql = new SqlObject();
                    DataTable Dt = new DataTable();
                    DdlSerchDetails.Visible = false;
                    DdlSerchDateY.Visible = false;
                    DdlSerchDateM.Visible = false;
                    qqq.Text = "";
                    if (DdlSerchCertificate.SelectedIndex == 1)
                    {
                        DdlSerchDetails.Visible = true;
                        DdlSerchDateY.Visible = false;
                        DdlSerchDateM.Visible = false;
                        qqq.Text = "";
                        Dt = sql.ExecuteKeyValue("AbsorptionProductId", "AbsorptionProductId", "TabsorptionProducts");
                        DdlSerchDetails.DataSource = Dt;
                        DdlSerchDetails.DataTextField = "TextField";
                        DdlSerchDetails.DataValueField = "ValueField";
                        DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר קוד תעודה", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "AbsorptionProductId";
                    }
                    else if (DdlSerchCertificate.SelectedIndex == 2)
                    {
                        DdlSerchDetails.Visible = true;
                        DdlSerchDateY.Visible = false;
                        DdlSerchDateM.Visible = false;
                        qqq.Text = "";
                        Dt = sql.ExecuteKeyValue("StatusName", "StatusId", "Tstatuses");
                        DdlSerchDetails.DataSource = Dt;
                        DdlSerchDetails.DataTextField = "TextField";
                        DdlSerchDetails.DataValueField = "ValueField";
                        DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר סטטוס", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "Status";
                    }
                    else if (DdlSerchCertificate.SelectedIndex == 3)
                    {
                        DdlSerchDetails.Visible = true;
                        DdlSerchDateY.Visible = false;
                        DdlSerchDateM.Visible = false;
                        qqq.Text = "";
                        Dt = sql.ExecuteKeyValue("SupplierName", "SupplierId", "Tsuppliers");
                        DdlSerchDetails.DataSource = Dt;
                        DdlSerchDetails.DataTextField = "TextField";
                        DdlSerchDetails.DataValueField = "ValueField";
                        DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר שם ספק", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "SupplierId";
                    }                    
                    else if (DdlSerchCertificate.SelectedIndex == 4)
                    {
                        DdlSerchDetails.Visible = true;
                        DdlSerchDateY.Visible = false;
                        DdlSerchDateM.Visible = false;
                        qqq.Text = "";
                        Dt = sql.ExecuteKeyValue("UserName", "UserId", "Tusers");
                        DdlSerchDetails.DataSource = Dt;
                        DdlSerchDetails.DataTextField = "TextField";
                        DdlSerchDetails.DataValueField = "ValueField";
                        DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר שם עובד", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "UserIdOpen";
                    }
                    Application["ColumnName"] = ColumnName;                
            }
            protected void DdlSerchDetails_TextChanged(object sender, EventArgs e)
            {
                List<AbsorptionProducts> LstAP1 = new List<AbsorptionProducts>();
                AbsorptionProducts AP = new AbsorptionProducts();
                ColumnName = (string)Application["ColumnName"];
                int UserId = (DdlSerchDetails.SelectedIndex) ;
                string status = (DdlSerchDetails.SelectedItem.Text);
                List<User> LstUsers = new List<User>();
                User user = new User();
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstAP1.Count; i++)
                {

                    if (LstUsers[i].Name == ColumnName)
                        UserId = LstUsers[i].Uid;

                }
                if (ColumnName == "Status")
                    LstAP1 = AP.GetCertificatsByColumnName(ColumnName, status);
                else
                    LstAP1 = AP.GetCertificatsByColumnName(ColumnName, UserId);
                List<Storages> LstStorages = new List<Storages>();
                Supplier supplier = new Supplier();
                List<Supplier> LstSupplier = new List<Supplier>();
                LstSupplier = supplier.GetAllSuppliers();
                for (int i = 0; i < LstAP1.Count; i++)
                {
                    for (int j = 0; j < LstSupplier.Count; j++)
                    {
                        if (LstSupplier[j].SupId == LstAP1[i].SupplierId)
                            LstAP1[i].SupplieName = LstSupplier[j].SupName;                        
                    }
                }
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstAP1.Count; i++)
                {
                    for (int j = 0; j < LstUsers.Count; j++)
                    {
                        if (LstUsers[j].Uid == LstAP1[i].UserIdOpen)
                            LstAP1[i].UserName = LstUsers[j].Name;
                    }
                }
                ListItem li1 = new ListItem("בחר קוד תעודה", "-1");
                li1.Attributes["disabled"] = "disabled";
                ListItem li2 = new ListItem("בחר סטטוס", "-1");
                li2.Attributes["disabled"] = "disabled";
                ListItem li3 = new ListItem("בחר שם ספק", "-1");
                li3.Attributes["disabled"] = "disabled";
                ListItem li4 = new ListItem("בחר שם עובד", "-1");
                li4.Attributes["disabled"] = "disabled";
                DdlSerchDetails.Items.RemoveAt(0);
                if (DdlSerchCertificate.SelectedIndex == 1)
                    DdlSerchDetails.Items.Insert(0, li1);
                else if (DdlSerchCertificate.SelectedIndex == 2)
                    DdlSerchDetails.Items.Insert(0, li2);
                else if (DdlSerchCertificate.SelectedIndex == 3)
                    DdlSerchDetails.Items.Insert(0, li3);
                else if (DdlSerchCertificate.SelectedIndex == 4)
                    DdlSerchDetails.Items.Insert(0, li4);
                Repeater1.DataSource = LstAP1;
                Repeater1.DataBind();
            }

            protected void DdlSerchDateY_TextChanged(object sender, EventArgs e)
            {

            }

            protected void DdlSerchDateM_TextChanged(object sender, EventArgs e)
            {
                string y = DdlSerchDateY.SelectedValue;
                string m = DdlSerchDateM.SelectedValue;
                qqq.Text = y + "  " + m;
            }



            //protected void BtnSubmit_Click(object sender, EventArgs e)
            //{
            //    int supplierId = Convert.ToInt32(DdlSupplierId.SelectedValue);
            //    int storageId  = Convert.ToInt32(DdlStorageId.SelectedValue);
            //    int prodId  = Convert.ToInt32(DdlProdId.SelectedValue);
            //    int qytUnits = Convert.ToInt32(TxtQytUnits.Text);
            //    int qytPacets = Convert.ToInt32(TxtQytPacets.Text);
            //    int qytBox = Convert.ToInt32(TxtQytBaxs.Text);
            //    int qytSurfaces = Convert.ToInt32(TxtQytSurfaces.Text);
            //    int userId = 1;   
            //    string shippingCertificate = "";
            //    if (RbNormalQuantity.Checked)
            //        shippingCertificate = "כן";
            //    else if(RbNotNormalQuantity.Checked)
            //        shippingCertificate = "לא";
            //    string NewFileName = "";
            //    if (FuShippingCertificate.HasFile)
            //    {
            //        NewFileName = Funcs.RandomName(5);
            //        string Aend = Path.GetExtension(FuShippingCertificate.FileName);
            //        FuShippingCertificate.SaveAs(Server.MapPath("/uploads/images/products/") + NewFileName + Aend);
            //        NewFileName += Aend;

            //    }
            //    string picName = NewFileName;                                
            //    //string remarks = TxtRemarks.Text;
            //    SqlObject sql = new SqlObject();
            //    string str = "insert into TabsorptionProducts(SupplierId,StorageId,ProdId,Quantity,QuantityUnitsPeck,QuantityUnitsBox,QuantitySurfaces,UserIdGetting,ShippingCertificatePicName,QuantityProper,Remarks)values (";
            //    str += ""+ supplierId+","+ storageId+","+ prodId+","+ qytUnits+","+ qytPacets+","+ qytBox+","+ qytSurfaces+","+ userId+",N'"+ picName + "',N'"+ shippingCertificate + "')";
            //    sql.ExecuteNonQuery(str);
            //    sql.Close();
            //    LtlOK.Text = "הפעולה בוצע בהצלחה";
            //}
           

           

            

            

            

        }
    }    
}