using Sstorage.BLL;
using Sstorage.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sstorage
{
    namespace admin
    {
        public partial class inventorys : System.Web.UI.Page
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
                    Application["ProdId"] = -1;
                    FillData();
                    

                }
            }
            protected void FillData()
            {
                SqlObject Sql = new SqlObject();
                DataTable Dt = new DataTable();
                Dt = Sql.ExecuteKeyValue("ProdName", "ProdId", "Tproducts");
                DdlSerch.DataSource = Dt;
                DdlSerch.DataTextField = "TextField";
                DdlSerch.DataValueField = "ValueField";
                DdlSerch.DataBind();                
                 ListItem li = new ListItem("בחר מוצר", "-1");
                li.Attributes["disabled"] = "disabled";
                DdlSerch.Items.Insert(0, li);
                int p = (int)Application["ProdId"];
                if(p != -1)
                    DdlSerch.SelectedValue = "" + p;

                Sql.Close();
            }
            protected void DdlSerch_TextChanged(object sender, EventArgs e)
            {
                Inventorys invt = new Inventorys();
                Product Prod = new Product();
                Prod.ProdId = int.Parse(DdlSerch.SelectedValue);
                Application["ProdId"] = Prod.ProdId;
                List<Inventorys> LstInvt = new List<Inventorys>();
                LstInvt = invt.GetInventorysByPid(Prod);
                SqlObject Sql1 = new SqlObject();
                DataTable Dt1 = new DataTable();
                Dt1 = Sql1.FillTable("Tstorages");
                Sql1.Close();
                for (int i = 0; i < LstInvt.Count; i++)
                {
                    for (int j = 0; j < Dt1.Rows.Count; j++)
                    {
                        if (LstInvt[i].StoragesLocatorId.ToString() == Dt1.Rows[j]["StorageId"].ToString())
                            LstInvt[i].StorageName = Dt1.Rows[j]["StorageName"].ToString();
                    }
                }
                string str = LstInvt[LstInvt.Count - 1].LocatorName;
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "func1(" + "'" + str + "'" + ")", true);
                LstInvt.RemoveAt(LstInvt.Count - 1);
                RptTable.DataSource = LstInvt;
                RptTable.DataBind();
                FillData();

            }
           
        }
    }
}