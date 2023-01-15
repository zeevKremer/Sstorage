using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sstorage.DAL;
using System.Data;
using Sstorage.BLL;
using System.Data.SqlClient;

namespace Sstorage
{
    namespace admin
    {
        public partial class products : System.Web.UI.Page
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
            void FillData()
            {
                SqlObject sObject1 = new SqlObject();
                DataTable Dt1 = new DataTable();
                Dt1 = sObject1.FillTable("Tproducts");
                string html = "$*";
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    html += Dt1.Rows[i]["ProdId"].ToString() + "*" + Dt1.Rows[i]["Barcode"] + "*" + Dt1.Rows[i]["ShorBarcode"] + "*" + Dt1.Rows[i]["CatId"].ToString() + "*" + Dt1.Rows[i]["SupplierId"].ToString() + "*" + Dt1.Rows[i]["Price"].ToString() + "*" + Dt1.Rows[i]["ProdName"] + "*" + Dt1.Rows[i]["ProdDesc"] + "#*";
                }
                int size = html.Length;
                html = html.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "z(" + "'" + html + "'" + ")", true);                
                sObject1.Close();
                SqlObject sObject2 = new SqlObject();
                DataTable Dt2 = new DataTable();
                Dt2 = sObject2.FillTable("Tcategorys");
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    for (int j = 0; j < Dt2.Rows.Count; j++)
                    {
                        if (Dt1.Rows[i]["CatId"].ToString() == Dt2.Rows[j]["CatId"].ToString())
                            Dt1.Rows[i]["CatName"] = Dt2.Rows[j]["CatName"];
                    }

                }
                RptTable.DataSource = Dt1;
                RptTable.DataBind();
                sObject2.Close();
                SqlObject sObject3 = new SqlObject();
                DataTable Dt3 = new DataTable();
                Dt3 = sObject3.ExecuteKeyValue("CatName", "CatId", "Tcategorys");
                DdlCat.DataSource = Dt3;
                DdlCat.DataTextField = "TextField";
                DdlCat.DataValueField = "ValueField";
                DdlCat.DataBind();
                ListItem li = new ListItem("בחר קטגוריה", "-1");
                li.Attributes["disabled"] = "disabled";
                DdlCat.Items.Insert(0, li);
                DdlCat.SelectedValue = "-1";
                DdlCat2.DataSource = Dt3;
                DdlCat2.DataTextField = "TextField";
                DdlCat2.DataValueField = "ValueField";
                DdlCat2.DataBind();                
                DdlCat2.Items.Insert(0, li);
                DdlCat2.SelectedValue = "-1";
                sObject3.Close();
                SqlObject sObject4 = new SqlObject();
                DataTable Dt4 = new DataTable();
                Dt4 = sObject4.FillTable("Tsuppliers");
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    for (int j = 0; j < Dt4.Rows.Count; j++)
                    {
                        if (Dt1.Rows[i]["SupplierId"].ToString() == Dt4.Rows[j]["SupplierId"].ToString())
                            Dt1.Rows[i]["SupplierName"] = Dt4.Rows[j]["SupplierName"];
                    }

                }
                RptTable.DataSource = Dt1;
                RptTable.DataBind();
                sObject4.Close();
                SqlObject sObject5 = new SqlObject();
                DataTable Dt5 = new DataTable();
                Dt5 = sObject5.ExecuteKeyValue("SupplierName", "SupplierId", "Tsuppliers");
                DdlSup.DataSource = Dt5;
                DdlSup.DataTextField = "TextField";
                DdlSup.DataValueField = "ValueField";
                DdlSup.DataBind();
                ListItem li2 = new ListItem("בחר ספק", "-1");
                li2.Attributes["disabled"] = "disabled";
                DdlSup.Items.Insert(0, li2);
                DdlSup.SelectedValue = "-1";
                DdlSup2.DataSource = Dt5;
                DdlSup2.DataTextField = "TextField";
                DdlSup2.DataValueField = "ValueField";
                DdlSup2.DataBind();
                DdlSup2.Items.Insert(0, li2);
                DdlSup2.SelectedValue = "-1";
                sObject5.Close();
            }

            protected void BtnProdAdd_Click(object sender, EventArgs e)
            {
                Product prod = new Product();
                prod.ProdName = TxtName.Text;
                prod.ProdDesc = TxtDesc.Text;
                prod.CatId = int.Parse(Hidden1.Value);
                prod.SupplierId = int.Parse(Hidden5.Value);
                prod.Barcode = TxtBarcode.Text;
                prod.ShorBarcode = TxtShorBarcode.Text;
                prod.Price = Convert.ToInt32(TxtPrice.Text);
                int Exist = ProductData.isExist(prod)
                    
                    
                    
                    
                    
                    
                    
                    
                    ;
                if (Exist == 0)
                {
                    prod.AddProduct(prod);
                    FillData();
                }                
                TxtName.Text = "";
                TxtDesc.Text = "";
                TxtBarcode.Text = "";
                TxtShorBarcode.Text = "";
                TxtPrice.Text = "";
            }
            protected void BtnProdAdd2_Click(object sender, EventArgs e)
            {
                Product prod = new Product();
                prod.ProdId = int.Parse(Hidden3.Value);
                if (TxtName2.Text != "" && TxtDesc2.Text != "" && TxtBarcode2.Text != "" && TxtShorBarcode2.Text != "" && (Convert.ToInt32(TxtPrice2.Text))>0 )
                {
                    prod.ProdName = TxtName2.Text;
                    prod.ProdDesc = TxtDesc2.Text;
                    prod.CatId = int.Parse(Hidden4.Value);
                    prod.SupplierId = int.Parse(Hidden6.Value);
                    prod.Barcode = TxtBarcode2.Text;
                    prod.ShorBarcode = TxtShorBarcode2.Text;
                    prod.Price = Convert.ToInt32(TxtPrice2.Text);
                    prod.UpProduct(prod);
                }
                   
                FillData();
            }
        }
    }
}