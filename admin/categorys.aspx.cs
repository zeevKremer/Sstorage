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
        public partial class categorys : System.Web.UI.Page
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
                Dt1 = sObject1.FillTable("Tcategorys");
                string html = "$*";
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    html += Dt1.Rows[i]["CatId"].ToString() + "*" + Dt1.Rows[i]["CatName"] + "#*";
                }
                int size = html.Length;
                html = html.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "z(" + "'" + html + "'" + ")", true);
                sObject1.Close();                
                RptTable.DataSource = Dt1;
                RptTable.DataBind();                               
            }
            protected void BtnCatAdd_Click(object sender, EventArgs e)
            {
                Category cat = new Category();
                cat.CatName = TxtCatName.Text;                
                int Exist = cat.isExist(cat);
                if (Exist == 0)
                {
                    cat.AddCategory(cat);
                    FillData();
                }
                TxtCatName.Text = "";
            }
            protected void BtnCatAdd2_Click(object sender, EventArgs e)
            {
                Category cat = new Category();
                cat.CatId = int.Parse(Hidden3.Value);
                if(TxtCatName2.Text != "")
                {
                    cat.CatName = TxtCatName2.Text;
                    cat.UpCategory(cat);                    
                }
                FillData();
            }
        }
    }

}