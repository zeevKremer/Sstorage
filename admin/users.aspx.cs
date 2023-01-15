using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public partial class users : System.Web.UI.Page
        {
            List<User> LstUser = new List<User>();
            protected void Page_Load(object sender, EventArgs e)
            {
                string Uid = "";               
                if (!IsPostBack)
                {
                    User a = (User)Session["user"];
                    if (a != null)
                    {
                        if (a.Rid > 1)
                            Response.Redirect("login.aspx");
                        else
                        {
                            LtlUserDitels.Text = " " + a.Name ;
                        }
                    }
                    else
                        Response.Redirect("login.aspx");
                    FillData();

                }
            }
            void FillData()
            {
                LtlCheck.Text = "";
                SqlObject sObject1 = new SqlObject();
                DataTable Dt1 = new DataTable();
                Dt1 = sObject1.FillTable("Tusers");
                string html = "$*";
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    html += Dt1.Rows[i]["UserId"].ToString() + "*" + Dt1.Rows[i]["UserName"] + "*" + Dt1.Rows[i]["UserPassword"] + "*" + Dt1.Rows[i]["RatingId"] + "*" + Dt1.Rows[i]["AddingDate"].ToString() + "#*";
                }
                int size = html.Length;
                html = html.Substring(0, (size - 1));
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "z(" + "'" + html + "'" + ")", true);
                sObject1.Close();
                SqlObject sObject2 = new SqlObject();
                DataTable Dt2 = new DataTable();
                Dt2 = sObject2.FillTable("Tratings");
                for (int i = 0; i < Dt1.Rows.Count; i++)
                {
                    for (int j = 0; j < Dt2.Rows.Count; j++)
                    {
                        if (Dt1.Rows[i]["RatingId"].ToString() == Dt2.Rows[j]["RatingId"].ToString())
                            Dt1.Rows[i]["RatName"] = Dt2.Rows[j]["Description"];
                    }

                }
                RptTable.DataSource = Dt1;
                RptTable.DataBind();
                sObject2.Close();
                SqlObject sObject3 = new SqlObject();
                DataTable Dt3 = new DataTable();
                Dt3 = sObject3.ExecuteKeyValue("Description", "RatingId", "Tratings");
                DdlRatings.DataSource = Dt3;
                DdlRatings.DataTextField = "TextField";
                DdlRatings.DataValueField = "ValueField";
                DdlRatings.DataBind();
                ListItem li = new ListItem("בחר דרגה", "-1");
                li.Attributes["disabled"] = "disabled";
                DdlRatings.Items.Insert(0, li);
                DdlRatings.SelectedValue = "-1";
                DdlRatings2.DataSource = Dt3;
                DdlRatings2.DataTextField = "TextField";
                DdlRatings2.DataValueField = "ValueField";
                DdlRatings2.DataBind();
                DdlRatings2.Items.Insert(0, li);
                DdlRatings2.SelectedValue = "-1";
                sObject3.Close();
            }                           
            protected void BtnUsAdd_Click(object sender, EventArgs e)
            {

                LtlCheck.Text = "";
                User user = new User();
                user.Name = TxtUserName.Text;
                user.Password = TxtPassword.Text;  
                if(user.Password.Length<8)
                {
                    string str = "סיסמה צריכה להכיל 8 תווים";
                    LtlCheck.Text = str;
                }
                else
                {
                    user.Rid = int.Parse(Hidden1.Value);
                    TxtUserName.Text = "";
                    TxtPassword.Text = "";
                    TxtPassword.Text = "";
                    user.AddUser(user);
                    FillData();
                }
                TxtUserName.Text = "";
                TxtPassword.Text = "";
            }
            protected void BtnUsAdd2_Click(object sender, EventArgs e)
            {                
                User user = new User();
                user.Uid = int.Parse(Hidden3.Value);
                if (TxtUserName2.Text != "" && TxtPassword2.Text != "")
                {
                    user.Name = TxtUserName2.Text;
                    user.Password = TxtPassword2.Text;
                    user.Rid = int.Parse(Hidden4.Value);
                    TxtUserName.Text = "";
                    TxtPassword.Text = "";
                    TxtPassword.Text = "";
                    user.UpUser(user);
                }
                
                    FillData();               
            }               
        }
    }
   
}