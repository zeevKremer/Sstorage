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
        public partial class storagrs : System.Web.UI.Page
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
                Dt1 = sObject1.FillTable("Tstorages");
                string html = "$*";
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    html += Dt1.Rows[i]["StorageId"].ToString() + "*" + Dt1.Rows[i]["StorageName"] + "*" + Dt1.Rows[i]["CityId"].ToString() + "*" + Dt1.Rows[i]["Street"] + "*" + Dt1.Rows[i]["HomeNumber"] + "*" + Dt1.Rows[i]["Phone"] + "*" + Dt1.Rows[i]["Email"] + "#*";
                }
                int size = html.Length;
                html = html.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "z(" + "'" + html + "'" + ")", true);
                sObject1.Close();
                SqlObject sObject2 = new SqlObject();
                DataTable Dt2 = new DataTable();
                Dt2 = sObject2.FillTable("Tcitys");
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    for (int j = 0; j < Dt2.Rows.Count; j++)
                    {
                        if (Dt1.Rows[i]["CityId"].ToString() == Dt2.Rows[j]["CityId"].ToString())
                            Dt1.Rows[i]["CityName"] = Dt2.Rows[j]["CityName"];
                    }

                }
                RptTable.DataSource = Dt1;
                RptTable.DataBind();
                sObject2.Close();
                SqlObject sObject3 = new SqlObject();
                DataTable Dt3 = new DataTable();
                Dt3 = sObject3.ExecuteKeyValue("CityName", "CityId", "Tcitys");
                DdlCity.DataSource = Dt3;
                DdlCity.DataTextField = "TextField";
                DdlCity.DataValueField = "ValueField";
                DdlCity.DataBind();
                ListItem li = new ListItem("בחר עיר", "-1");
                li.Attributes["disabled"] = "disabled";
                DdlCity.Items.Insert(0, li);
                DdlCity.SelectedValue = "-1";
                DdlCity2.DataSource = Dt3;
                DdlCity2.DataTextField = "TextField";
                DdlCity2.DataValueField = "ValueField";
                DdlCity2.DataBind();
                DdlCity2.Items.Insert(0, li);
                DdlCity2.SelectedValue = "-1";
                sObject3.Close();
                TxtStorageName.Text = "";
                TxtStreet.Text = "";
                TxtHomeNumber.Text = "";
                TxtPhone.Text = "";
                TxtEmail.Text = "";
            }

            protected void BtnStrAdd_Click(object sender, EventArgs e)
            {
                Storages storage = new Storages();
                storage.StorageName = TxtStorageName.Text;
                storage.CityId = int.Parse(Hidden1.Value);
                storage.Street = TxtStreet.Text;
                storage.HomeNumber = TxtHomeNumber.Text;
                storage.Phone = TxtPhone.Text;
                storage.Email = TxtEmail.Text;
                
                int Exist = storage.isExist(storage);
                if (Exist == 0)
                {
                    storage.AddStorage(storage);
                    FillData();
                }
                TxtStorageName.Text = "";
                TxtStreet.Text = "";
                TxtStreet.Text = "";
                TxtHomeNumber.Text = "";
                TxtPhone.Text = "";
                TxtEmail.Text = "";
            }
            protected void BtnStrAdd2_Click(object sender, EventArgs e)
            {
                Storages storage = new Storages();                
                storage.StorageId = int.Parse(Hidden3.Value);
                if (TxtStorageName2.Text != "" && TxtHomeNumber2.Text != "" && TxtPhone2.Text != "" && TxtEmail2.Text != "")
                {
                    storage.StorageName = TxtStorageName2.Text;
                    storage.CityId = int.Parse(Hidden4.Value);
                    storage.Street = TxtStorageName2.Text;
                    storage.HomeNumber = TxtHomeNumber2.Text;
                    storage.Phone = TxtPhone2.Text;
                    storage.Email = TxtEmail2.Text;
                    storage.UpStorage(storage);
                }
                    
                FillData();
            }
        }
    }   
}