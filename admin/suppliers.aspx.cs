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
        public partial class suppliers : System.Web.UI.Page
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
                //FillData();

            }
            void FillData()
            {                
                SqlObject sObject1 = new SqlObject();
                DataTable Dt1 = new DataTable();
                Dt1 = sObject1.FillTable("Tsuppliers");
                string html = "$*";
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    html += Dt1.Rows[i]["SupplierId"].ToString()+"*" + Dt1.Rows[i]["SupplierName"] + "*" + Dt1.Rows[i]["SupplierPhone"] +"*" + Dt1.Rows[i]["SupplierEmail"]+ "*" + Dt1.Rows[i]["CatId"].ToString() + "#*";
                }
                int size = html.Length;
                html = html.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "z(" + "'" + html + "'" + ")", true);
                sObject1.Close();                
                SqlObject sObject2 = new SqlObject();
                DataTable Dt2 = new DataTable();
                Dt2 = sObject2.FillTable("Tcategorys");  
                for(int i = 0; i < Dt1.Rows.Count; i++)
                {
                    for(int j = 0; j < Dt2.Rows.Count; j++)
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
                DdlCategorys.DataSource = Dt3;
                DdlCategorys.DataTextField = "TextField";
                DdlCategorys.DataValueField = "ValueField";
                DdlCategorys.DataBind();                
                DdlCategorys2.DataSource = Dt3;
                DdlCategorys2.DataTextField = "TextField";
                DdlCategorys2.DataValueField = "ValueField";
                DdlCategorys2.DataBind();
                ListItem li = new ListItem("בחר קטגוריה", "-1");
                li.Attributes["disabled"] = "disabled";
                DdlCategorys.Items.Insert(0, li);
                DdlCategorys.SelectedValue = "-1";
                DdlCategorys2.Items.Insert(0, li);
                DdlCategorys2.SelectedValue = "-1";
                sObject3.Close();                                
            }

            protected void BtnAddSupp_Click(object sender, EventArgs e)
            {
                Supplier Sup = new Supplier();
                Sup.SupName = TxtName.Text;
                Sup.SupPhone = TxtPhone.Text;
                Sup.SupEmail = TxtEmail.Text;
                Sup.CatId = int.Parse(Hidden1.Value);
                TxtName.Text = "";
                TxtPhone.Text = "";
                TxtEmail.Text = "";
                int Exist = Sup.isExist(Sup);
                if(Exist == 0)
                {
                    Sup.AddSupplier(Sup);
                    FillData();
                }               
            }

            protected void BtnAddSp2_Click(object sender, EventArgs e)
            {
                Supplier Sup = new Supplier();
                Sup.SupId = int.Parse(Hidden3.Value);
                if (TxtName2.Text != "" && TxtPhone2.Text != "" && TxtEmail2.Text != "" )
                {
                    Sup.SupName = TxtName2.Text;
                    Sup.SupPhone = TxtPhone2.Text;
                    Sup.SupEmail = TxtEmail2.Text;
                    Sup.CatId = int.Parse(Hidden4.Value);
                    TxtName2.Text = "";
                    TxtPhone2.Text = "";
                    TxtEmail2.Text = "";
                    Sup.UpSupplier(Sup);
                }
                   
                     FillData();                
            }
        }
    }
}