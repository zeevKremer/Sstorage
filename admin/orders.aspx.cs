using Sstorage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sstorage.DAL;
using System.Data;

namespace Sstorage
{
    namespace admin
    {
        public partial class orders : System.Web.UI.Page
        {
            int OrderId;
            User a = new User();
            string ColumnName;
            int Pid;
            int flag = 0;
            int flag2 = 0;
            int flag1;
            int prod1;
            int quantity1;
            Orders ORD = new Orders();
            List<OrdersDetails> LstoDetails = new List<OrdersDetails>();
            List<Ovalue> LstoValue = new List<Ovalue>();
            OrdersDetails oDetails = new OrdersDetails();
            
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
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
                    //p2.Visible = false;
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
                SqlObject sql = new SqlObject();
                System.Data.DataTable Dt = new DataTable();
                
                ListItem li = new ListItem("בחר מחסן", "-1");                
                Dt = sql.ExecuteKeyValue1("StorageName", "StorageId", "Tstorages");
                DdlStorageGeter.DataSource = Dt;
                DdlStorageGeter.DataTextField = "TextField";
                DdlStorageGeter.DataValueField = "ValueField";
                DdlStorageGeter.DataBind();
                DdlStorageGeter.Items.Insert(0, li);
                DdlStorageGeter.SelectedValue = "-1";
                sql.Close();
                List<Orders> LstORD = new List<Orders>();
                Orders ORD = new Orders();
                LstORD = ORD.GetTenOrders();
                List<Storages> LstStorages = new List<Storages>();
                Storages storage = new Storages();
                LstStorages = storage.GetAllStorages();
                for (int i = 0; i < LstORD.Count; i++)
                {
                    for (int j = 0; j < LstStorages.Count; j++)
                    {
                        if (LstStorages[j].StorageId == LstORD[i].StorageGeterId)
                            LstORD[i].StorageGeterName = LstStorages[j].StorageName;                        
                    }
                }
                List<User> LstUsers = new List<User>();
                User user = new User();
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstORD.Count; i++)
                {
                    for (int j = 0; j < LstUsers.Count; j++)
                    {
                        if (LstUsers[j].Uid == LstORD[i].UserId)
                            LstORD[i].UserName = LstUsers[j].Name;
                    }
                }
                Repeater1.DataSource = LstORD;
                Repeater1.DataBind();
            }

            protected void BtnOpenCertificate_Click(object sender, EventArgs e)
            {
                BtnOpenCertificate.Attributes.Add("AutoPostback", "true");
                int StorageSenderId = 2;
                int StorageGeterId = Convert.ToInt32(DdlStorageGeter.SelectedValue);
                int isExist = Orders.isExist(StorageSenderId, StorageGeterId);
                if (isExist != 0)
                {
                    //string str = "קיימת תעודה בסטטוס טיוטא ממחסן " + DdlStorageSender.Text + " למחסן " + DdlStorageGeter.Text;
                    //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "ModalMsege(" + "'" + str + "'" + ")", true);     
                    //LtlAaa.Text = str;
                }
                else
                {
                    Application["StorageSenderId"] = StorageSenderId;
                    Application["StorageGeterId"] = StorageGeterId;
                    Application["flag1"] = 0;                    
                    Application["LstoValue"] = LstoValue;
                    a = (User)Session["user"];
                    ORD.UserId = a.Uid;
                    ORD.StorageSenderId = StorageSenderId;
                    ORD.StorageGeterId = StorageGeterId;
                    DateTime date = DateTime.Now;
                    ORD.Date = date;
                    int id = ORD.OpenOrder(ORD);
                    ORD.OrderId = id;
                    Application["id"] = id;
                    Application["LstoDetails"] = LstoDetails;
                    List<Orders> LstOR = new List<Orders>();
                    Repeater1.DataSource = LstOR;
                    Repeater1.DataBind();
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "qwer()", true);
                    Repeater2.DataSource = LstoDetails;
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
                    SenderQuery = " select StorageName from Tstorages where StorageId =" + StorageSenderId;
                    GeterQuery = " select StorageName from Tstorages where StorageId =" + StorageGeterId;
                    StorageSender = sql.ExecuteScalarString(SenderQuery);
                    StorageGeter = sql.ExecuteScalarString(GeterQuery);
                    ListItem li1 = new ListItem("טיוטא", "1");
                    ListItem li2 = new ListItem("סגור", "2");
                    DdlSttus.Items.Insert(0, li1);
                    DdlSttus.Items.Insert(1, li2);
                    DdlSttus.SelectedValue = "1";
                    sql.Close();
                    LtlCertId.Text = "הזמנה מספר   ";
                    LtlDate.Text = "  זמן פתיחת הזמנה    ";
                    LtelSender.Text = "סניף מקבל";                    
                    LtlCertIdV.Text = " " + ORD.OrderId;
                    LtlDateV.Text = "    " + ORD.Date;
                    LtelSenderV.Text = " " + StorageGeter;                 
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
                Ovalue oValue = new Ovalue();
                List<Ovalue> LstoValue = new List<Ovalue>();
                List<Ovalue> LstoValue2 = new List<Ovalue>();
                LstoValue2 = (List<Ovalue>)Application["LstoValue"];
                if (LstoValue2 != null)
                {
                    for (int j = 0; j < LstoValue2.Count; j++)
                    {
                        if (LstoValue2[j].ProdId == Pid)
                            flag3 = 1;
                    }
                }
                if (flag3 == 0)
                {
                    flag2 = (int)Application["flag2"];
                    if (flag2 == 0)
                    {
                        LstoValue = (List<Ovalue>)Application["LstoValue"];
                        LstoValue.Add(oValue);
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
                    //int Pid = Convert.ToInt32(DdlProdName.SelectedValue);
                    int flag = 0;
                    int i;
                    for (i = 0; i < LstoValue.Count; i++)
                    {
                        if (LstoValue[i].ProdId == Pid)
                            flag = 1;
                        if (LstoValue[i].ProdId == 0)
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
                        LstoValue.RemoveAt(LstoValue.Count - 1);
                    }
                }

            }
            protected void TxtQuantity1_TextChanged(object sender, EventArgs e)
            {
                //string quantity1 = TxtQuantity.Text;
                //int id = (int)Application["id"];
                //if (quantity1 != "")
                //    TransferCertificateData.ChangeStatus(id);
            }
            protected void BtnNewRow_Click(object sender, EventArgs e)
            {
                LtlCheck.Text = "";
                LstoDetails = (List<OrdersDetails>)Application["LstoDetails"];
                OrdersDetails ODetails1 = new OrdersDetails();
                Ovalue oValue = new Ovalue();
                LstoValue = (List<Ovalue>)Application["LstoValue"];
                ODetails1.OrderId = (int)Application["id"];
                Application["flag1"] = 0;
                int PId = Convert.ToInt32(DdlProdName.SelectedValue);
                if (PId != -1)
                {
                    if (LstoDetails != null)
                    {
                        int IsExest = 0;
                        for (int i = 0; i < LstoValue.Count; i++)
                        {
                            if (LstoValue[i].ProdId == PId)
                                IsExest = 1;
                        }
                        if (IsExest == 0)
                        {
                            oValue.ProdId = PId;
                            int Quantity = 0;
                            if (TxtQuantity.Text != "")
                                Quantity = Convert.ToInt32(TxtQuantity.Text);
                            ODetails1.ProdId = PId;
                            ODetails1.Quantity = Quantity;
                            int check = OrdersDetailsData.check(ODetails1);
                            if (check != 0)
                            {
                                int id = 0;
                                if (Quantity > 0)
                                {
                                    Application["flag2"] = 0;
                                    id = ODetails1.AddingDetails1(ODetails1);
                                    ODetails1.OrderDetailsId = id;
                                    oValue.ProdName = DdlProdName.SelectedItem.Text;
                                    oValue.Barcode = TxtBarcode.Text;
                                    oValue.ShorBarcode = TxtShorBarcode.Text;
                                    oValue.Quantity = TxtQuantity.Text;
                                    oValue.Price = TxtPrice.Text;
                                    int flag1 = (int)Application["flag1"];
                                    if (flag1 == 0)
                                        LstoValue.RemoveAt(LstoValue.Count - 1);
                                    LstoValue.Add(oValue);
                                    flag1 = 1;
                                    Application["flag1"] = flag1;
                                    Application["LstoDetails"] = LstoDetails;
                                    Application["LstoValue"] = LstoValue;
                                    TransferCertificateData.ChangeStatus(ODetails1.OrderId);
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
                                    Repeater2.DataSource = LstoValue;
                                    Repeater2.DataBind();
                                }
                                //else
                                //{
                                //    id = TCD1.AddingDetails2(TCD1);
                                //}

                            }
                            else if (TxtBarcode.Text != "" && TxtShorBarcode.Text != "" && TxtQuantity.Text != "")
                            {
                                LtlCheck.Text = "הכמות שרשמת גדולה יותר מהמלאי שקיים ";
                            }
                        }
                    }
                }
            }
            protected void BtnCertDetails_Click(object sender, EventArgs e)
            {
                OrderId = int.Parse(((LinkButton)sender).CommandArgument);
                Orders ORD = new Orders();
                ORD = Orders.GetOrderById(OrderId);
                if (ORD.Status == "טיוטא" || ORD.Status == "בליקוט")
                {
                    List<OrdersDetails> LstoDetails = new List<OrdersDetails>();
                    LstoDetails = OrdersDetails.GetCertDetailsById(OrderId);
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
                    Repeater2.DataSource = LstoDetails;
                    Repeater2.DataBind();
                    Application["StorageSenderId"] = ORD.StorageSenderId;
                    Application["StorageGeterId"] = ORD.StorageGeterId;
                    Application["LstTcdValue"] = LstoValue;
                    Application["LstoDetails"] = LstoDetails;
                    Application["id"] = OrderId;
                    int flag1 = 1;
                    Application["flag1"] = flag1;
                    string SenderQuery, GeterQuery, StorageSender, StorageGeter;
                    SenderQuery = " select StorageName from Tstorages where StorageId =" + ORD.StorageSenderId;
                    GeterQuery = " select StorageName from Tstorages where StorageId =" + ORD.StorageGeterId;
                    StorageSender = sql.ExecuteScalarString(SenderQuery);
                    StorageGeter = sql.ExecuteScalarString(GeterQuery);
                    sql.Close();
                    LtlCertId.Text = "תעודה מספר   ";
                    LtlDate.Text = "  זמן פתיחת התעודה    ";                   
                    LtlGeter.Text = "סניף מקבל   ";
                    LtlCertIdV.Text = " " + ORD.OrderId;
                    LtlDateV.Text = "    " + ORD.Date;                   
                    LtlGeterV.Text = "   " + StorageGeter;
                    PanCertificate.Visible = false;
                    PanDetais.Visible = true;
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                    Panel4.Visible = true;
                    Panel5.Visible = false;
                    Repeater1.Visible = false;
                    if (ORD.Status == "טיוטא")
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
                    List<OrdersDetails> LstTCD = new List<OrdersDetails>();
                    LstTCD = OrdersDetails.GetCertDetailsById(OrderId);
                    string id = OrderId.ToString();
                    string strTCD = id + "$*";
                    for (int i = 0; i < LstTCD.Count; i++)
                    {
                        strTCD += LstTCD[i].ProdName + "*" + LstTCD[i].Barcode + "*" + LstTCD[i].ShorBarcode + "*" + LstTCD[i].Quantity + "*" + 0 + "*" + LstTCD[i].Quantity + "*" + LstTCD[i].Quantity + "*" + LstTCD[i].Price + "#*";
                    }
                    int size = strTCD.Length;
                    strTCD = strTCD.Substring(0, (size - 1));
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "p(" + "'" + strTCD + "'" + ")", true);
                }
            }
            protected void DdlSttus_TextChanged(object sender, EventArgs e)
            {
                LtlCheck.Text = "";
                OrdersDetails TCD2 = new OrdersDetails();
                int Pid = 0;
                int Quantity = 0;
                if (DdlProdName.SelectedValue != null)
                    Pid = Convert.ToInt32(DdlProdName.SelectedValue);
                if (TxtQuantity.Text != "")
                    Quantity = Convert.ToInt32(TxtQuantity.Text);
                TCD2.ProdId = Pid;
                TCD2.Quantity = Quantity;
                TCD2.OrderId = (int)Application["id"];
                int check = 0;
                if (TCD2.ProdId == -1 && TCD2.Quantity == 0)
                    check = 0;
                else
                    check = 1;
                int StatusId = Convert.ToInt32(DdlSttus.SelectedValue);
                if (DdlSttus.SelectedIndex == 1)
                {
                    LstoDetails = (List<OrdersDetails>)Application["LstoDetails"];
                    LstoValue = (List<Ovalue>)Application["LstoValue"];
                    flag1 = (int)Application["flag1"];
                    if (flag1 == 1 && TxtQuantity.Text != "")
                    {
                        prod1 = (int)Application["prod1"];
                        Ovalue oValue1 = new Ovalue();
                        OrdersDetails TCD1 = new OrdersDetails();
                        oValue1.ProdName = DdlProdName.SelectedItem.Text;
                        oValue1.Barcode = TxtBarcode.Text;
                        oValue1.ShorBarcode = TxtShorBarcode.Text;
                        oValue1.Quantity = TxtQuantity.Text;
                        oValue1.Price = TxtPrice.Text;
                        oValue1.ProdId = prod1;
                        LstoValue.RemoveAt(LstoValue.Count - 1);
                        LstoValue.Add(oValue1);
                        TCD1.OrderId = (int)Application["id"];
                        TCD1.ProdId = prod1;
                        TCD1.Quantity = Convert.ToInt32(TxtQuantity.Text);
                        check = OrdersDetailsData.check(TCD1);
                        if (check != 0)
                        {
                            flag1 = TCD1.AddingDetails1(TCD1);
                            Application["flag1"] = 0;
                        }
                    }
                    if (check != 0)
                    {
                        int StorageSenderId = (int)Application["StorageSenderId"];
                        int StorageGeterId = (int)Application["StorageGeterId"];
                        DdlSttus.Items.Clear();
                        ListItem li6 = new ListItem("סגור", "1");
                        DdlSttus.Items.Insert(0, li6);
                        int CertificateId = (int)Application["id"];
                        Orders.CloseOrderById(CertificateId);
                        if (LstoValue.Count == 0)
                        {

                        }
                        else if (LstoValue.Count == 1 && LstoValue[0].ProdId == 0)
                        {

                        }
                        else if (LstoValue[(LstoValue.Count - 1)].ProdId == 0)
                        {
                            LstoValue.RemoveAt(LstoValue.Count - 1);
                            OrdersData.UpInventory(LstoValue, StorageSenderId, StorageGeterId);
                        }
                        else
                            OrdersData.UpInventory(LstoValue, StorageSenderId, StorageGeterId);
                    }
                    else
                    {
                        if (Pid != -1)
                            LtlCheck.Text = "הכמות שרשמת גדולה יותר מהמלאי שקיים ";
                        else
                        {
                            DdlSttus.Items.Clear();
                            ListItem li6 = new ListItem("סגור", "1");
                            DdlSttus.Items.Insert(0, li6);
                            int CertificateId = (int)Application["id"];
                            Orders.CloseOrderById(CertificateId);
                        }
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
                    Dt = sql.ExecuteKeyValue("OrderId", "OrderId", "Torders");
                    DdlSerchDetails.DataSource = Dt;
                    DdlSerchDetails.DataTextField = "TextField";
                    DdlSerchDetails.DataValueField = "ValueField";
                    DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר קוד הזמנה", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "OrderId";
                }
                if (DdlSerchCertificate.SelectedIndex == 2)
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
                if (DdlSerchCertificate.SelectedIndex == 3)
                {
                    DdlSerchDetails.Visible = true;
                    DdlSerchDateY.Visible = false;
                    DdlSerchDateM.Visible = false;
                    qqq.Text = "";
                    Dt = sql.ExecuteKeyValue1("StorageName", "StorageId", "Tstorages");
                    DdlSerchDetails.DataSource = Dt;
                    DdlSerchDetails.DataTextField = "TextField";
                    DdlSerchDetails.DataValueField = "ValueField";
                    DdlSerchDetails.DataBind();
                    ListItem li = new ListItem("בחר סניף מקבל", "-1");
                    li.Attributes["disabled"] = "disabled";
                    DdlSerchDetails.Items.Insert(0, li);
                    DdlSerchDetails.SelectedValue = "-1";
                    ColumnName = "StorageGeterId";
                }
                if (DdlSerchCertificate.SelectedIndex == 4)
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
                    ColumnName = "UserId";
                }
                Application["ColumnName"] = ColumnName;

                //else if(DdlSerchCertificate.SelectedIndex == 1)
                //{
                //    DdlSerchDetails.Visible = false;
                //    DdlSerchDateY.Visible = true;
                //    DdlSerchDateM.Visible = true;
                //    qqq.Text = "";
                //}
                //else
                //{
                //    DdlSerchDetails.Visible = false;
                //    DdlSerchDateY.Visible = false;
                //    DdlSerchDateM.Visible = false;
                //    qqq.Text = "";
                //}
            }
            protected void DdlSerchDetails_TextChanged(object sender, EventArgs e)
            {
                List<Orders> LstTC1 = new List<Orders>();
                Orders TC = new Orders();
                ColumnName = (string)Application["ColumnName"];
                int UserId = (DdlSerchDetails.SelectedIndex);
                string status = (DdlSerchDetails.SelectedItem.Text);
                if (ColumnName == "StorageSenderId")
                    UserId++;                
                List<User> LstUsers = new List<User>();
                User user = new User();
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstTC1.Count; i++)
                {

                    if (LstUsers[i].Name == ColumnName)
                        UserId = LstUsers[i].Uid;

                }
                if (ColumnName == "Status")
                    LstTC1 = TC.GetOrderByColumnName(ColumnName, status);
                else if(ColumnName == "StorageGeterId")
                {
                    UserId += 2;
                    LstTC1 = TC.GetOrderByColumnName(ColumnName, UserId);
                }
                else
                    LstTC1 = TC.GetOrderByColumnName(ColumnName, UserId);
                List<Storages> LstStorages = new List<Storages>();
                Storages storage = new Storages();
                LstStorages = storage.GetAllStorages();
                for (int i = 0; i < LstTC1.Count; i++)
                {
                    for (int j = 0; j < LstStorages.Count; j++)
                    {
                        if (LstStorages[j].StorageId == LstTC1[i].StorageGeterId)
                            LstTC1[i].StorageGeterName = LstStorages[j].StorageName;
                        
                    }
                }
                LstUsers = user.GetAllUsers();
                for (int i = 0; i < LstTC1.Count; i++)
                {
                    for (int j = 0; j < LstUsers.Count; j++)
                    {
                        if (LstUsers[j].Uid == LstTC1[i].UserId)
                            LstTC1[i].UserName = LstUsers[j].Name;
                    }
                }
                ListItem li1 = new ListItem("בחר קוד הזמנה", "-1");
                li1.Attributes["disabled"] = "disabled";
                ListItem li2 = new ListItem("בחר סטטוס", "-1");
                li2.Attributes["disabled"] = "disabled";                
                ListItem li3 = new ListItem("בחר סניף מקבל", "-1");
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
                //DdlSerchDetails.SelectedValue = "-1";
                Repeater1.DataSource = LstTC1;
                Repeater1.DataBind();
            }





            protected void DdlSerchDateY_TextChanged(object sender, EventArgs e)
            {

            }

            protected void DdlSerchDateM_TextChanged(object sender, EventArgs e)
            {
                //string y = DdlSerchDateY.SelectedValue;
                //string m = DdlSerchDateM.SelectedValue;               
                //qqq.Text = y+"  " + m;               
            }

            protected void BtnLocatorName_Click(object sender, EventArgs e)
            {
                List<StoragesLocators> SL = new List<StoragesLocators>();
                SL = (List<StoragesLocators>)Application["StoragesLocators"];
                int size = SL.Count;
                string h = "";
                for (int i = 0; i < size; i++)
                {
                    h += "<br />";
                    h += "" + SL[i].LocatorName;
                }
            }

            protected void BtnDownloadOk_Click(object sender, EventArgs e)
            {
                //TCD.CertificateId = 1;
                //TCD.SurfaceId = 1;
                //TCD.Quantity = 1;
                //TCD.WritheQuantityInDCDetails(TCD);
            }


        }
    }
}