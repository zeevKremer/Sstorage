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
{namespace admin
    {
        public partial class OpeningSurfaces : System.Web.UI.Page
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
                SqlObject sql = new SqlObject();
                DataTable Dt = new DataTable();
                Dt = sql.ExecuteKeyValue("ProdName", "ProdId", "Tproducts");
                DdlProdId.DataSource = Dt;
                DdlProdId.DataTextField = "TextField";
                DdlProdId.DataValueField = "ValueField";
                DdlProdId.DataBind();
                sql.Close();
                ListItem lii = new ListItem("בחר מוצר", "-1");
                lii.Attributes["disabled"] = "disabled";
                DdlProdId.Items.Insert(0, lii);
                DdlProdId.SelectedValue = "-1";
            }

            protected void BtnOk_Click(object sender, EventArgs e)
            {
                LtlOpenSurface.Text = "";
                Literal1.Text = "";
                int flag = 0;
                if(DdlProdId.SelectedValue == "-1" || TxtQytUnits.Text == "" || TxtQytBaxs.Text == "")
                    flag = 1;
                if (flag != 1)
                {

                    for (int i = 0; i < TxtQytUnits.Text.Length; i++)
                    {
                        if (TxtQytUnits.Text[i] != '0' && TxtQytUnits.Text[i] != '1' && TxtQytUnits.Text[i] != '2' && TxtQytUnits.Text[i] != '3' && TxtQytUnits.Text[i] != '4' && TxtQytUnits.Text[i] != '5' && TxtQytUnits.Text[i] != '6' && TxtQytUnits.Text[i] != '7' && TxtQytUnits.Text[i] != '8' && TxtQytUnits.Text[i] != '9')
                            flag = 1;
                    }
                }
                if (flag != 1)
                {
                    for (int i = 0; i < TxtQytBaxs.Text.Length; i++)
                    {
                        if (TxtQytBaxs.Text[i] != '0' && TxtQytBaxs.Text[i] != '1' && TxtQytBaxs.Text[i] != '2' && TxtQytBaxs.Text[i] != '3' && TxtQytBaxs.Text[i] != '4' && TxtQytBaxs.Text[i] != '5' && TxtQytBaxs.Text[i] != '6' && TxtQytBaxs.Text[i] != '7' && TxtQytBaxs.Text[i] != '8' && TxtQytBaxs.Text[i] != '9')
                            flag = 1;
                    }
                }
                if (flag != 1)
                {
                    int prodId = Convert.ToInt32(DdlProdId.SelectedValue);
                    int qytUnits = Convert.ToInt32(TxtQytUnits.Text);
                    int qytBox = Convert.ToInt32(TxtQytBaxs.Text);
                    User a = (User)Session["user"];
                    int userId = a.Uid;
                    string remarks = TxtRemarks.Text;
                    SqlObject sql = new SqlObject();
                    string str = "insert into Tsurfaces(ProdId,Quantity,QuantityUnitsBox,UserIdOpen,Remarks)values (";
                    str += "" + prodId + "," + qytUnits + "," + qytBox + "," + userId + ",N'" + remarks + "')";
                    sql.ExecuteNonQuery(str);
                    str = "select max(SurfaceId) from Tsurfaces";
                    int SurfaceId = sql.ExecuteScalarInt(str);
                    sql.Close();
                    LtlOpenSurface.Text = "המשטח נפתח בהצלחה ";
                    Literal1.Text = "מספר משטח הוא " + SurfaceId;
                }
                   
            }
        }
    }   
}