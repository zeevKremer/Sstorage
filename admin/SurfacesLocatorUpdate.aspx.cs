using Sstorage.BLL;
using Sstorage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sstorage
{
    namespace admin
    {
        public partial class SurfacesLocatorUpdate : System.Web.UI.Page
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
                            string Sid = Request.QueryString["Sid"];
                            string SLN = Request.QueryString["SLN"];
                            if(Sid != null || SLN != null)
                            {
                                TxtSurfaceId.Text = Sid;
                                TxtSurfaceLocator.Text = SLN;
                            }
                        }
                    }
                    else
                        Response.Redirect("login.aspx");

                }
            }

            protected void BtnSubmit_Click(object sender, EventArgs e)
            {
                LtlOK.Text = "";


                int flag = 0;
                if(TxtSurfaceId.Text == ""  || TxtSurfaceLocator.Text == "")
                    flag = 1;
                if(flag != 1)
                {
                    for (int i = 0; i < TxtSurfaceId.Text.Length; i++)
                    {
                        if (TxtSurfaceId.Text[i] != '1' && TxtSurfaceId.Text[i] != '2' && TxtSurfaceId.Text[i] != '3' && TxtSurfaceId.Text[i] != '4' && TxtSurfaceId.Text[i] != '5' && TxtSurfaceId.Text[i] != '6' && TxtSurfaceId.Text[i] != '7' && TxtSurfaceId.Text[i] != '8' && TxtSurfaceId.Text[i] != '9')
                            flag = 1;
                    }
                    if (flag != 1)
                    {
                        if (TxtSurfaceLocator.Text.Length != 6)
                            flag = 1;
                        if (flag != 1)
                        {

                            if (TxtSurfaceLocator.Text[0] != 'A' && TxtSurfaceLocator.Text[0] != 'B' && TxtSurfaceLocator.Text[0] != 'C' && TxtSurfaceLocator.Text[0] != 'D' && TxtSurfaceLocator.Text[0] != 'E' && TxtSurfaceLocator.Text[0] != 'F')
                                flag = 1;
                            if (flag != 1)
                            {
                                if (TxtSurfaceLocator.Text[1] != '1' && TxtSurfaceLocator.Text[1] != '2' && TxtSurfaceLocator.Text[1] != '3' && TxtSurfaceLocator.Text[1] != '4' && TxtSurfaceLocator.Text[1] != '5' && TxtSurfaceLocator.Text[1] != '6' && TxtSurfaceLocator.Text[1] != '7' && TxtSurfaceLocator.Text[1] != '8' && TxtSurfaceLocator.Text[1] != '9')
                                    flag = 1;
                                if (flag != 1)
                                {
                                    if (TxtSurfaceLocator.Text[2] != 'H')
                                        flag = 1;
                                    if (flag != 1)
                                    {
                                        if (TxtSurfaceLocator.Text[3] != '1' && TxtSurfaceLocator.Text[3] != '2' && TxtSurfaceLocator.Text[3] != '3' && TxtSurfaceLocator.Text[3] != '4' && TxtSurfaceLocator.Text[3] != '5' && TxtSurfaceLocator.Text[3] != '6' && TxtSurfaceLocator.Text[3] != '7' && TxtSurfaceLocator.Text[3] != '8' && TxtSurfaceLocator.Text[3] != '9')
                                            flag = 1;
                                        if (flag != 1)
                                        {
                                            if (TxtSurfaceLocator.Text[4] != '-')
                                                flag = 1;
                                            if (flag != 1)
                                                if (TxtSurfaceLocator.Text[5] != '1' && TxtSurfaceLocator.Text[5] != '2' && TxtSurfaceLocator.Text[5] != '3' && TxtSurfaceLocator.Text[5] != '4' && TxtSurfaceLocator.Text[5] != '5' && TxtSurfaceLocator.Text[5] != '6' && TxtSurfaceLocator.Text[5] != '7' && TxtSurfaceLocator.Text[5] != '8' && TxtSurfaceLocator.Text[5] != '9')
                                                  flag = 1;
                                        }
                                            
                                    }                                       
                                }
                                  
                            }
                               
                        }
                    }
                       
                }
                
                if(flag != 1)
                {
                    int SurfaceId = Convert.ToInt32(TxtSurfaceId.Text);
                    string SurfaceLocator = TxtSurfaceLocator.Text;
                    Surface surface = new Surface(SurfaceId);
                    int isExist = surface.isExist(surface);
                    if (isExist == 0)
                    {
                        SqlObject sql = new SqlObject();
                        string str1 = "select StoragesLocatorId from TstoragesLocators where StorageId = 1 and LocatorName = '" + SurfaceLocator + "'";
                        int LocatorId = sql.ExecuteScalarInt(str1);
                        User a = (User)Session["user"];
                        int userId = a.Uid;
                        string str2 = "insert into TsurfacesLocators(SurfaceId,StoragesLocatorId,UserIdUpdate)";
                        str2 += "values(" + SurfaceId + "," + LocatorId + "," + userId + ")";
                        sql.ExecuteNonQuery(str2);
                        sql.Close();
                    }
                    else
                    {
                        SqlObject sql = new SqlObject();
                        string str1 = "select StoragesLocatorId from TstoragesLocators where StorageId = 1 and LocatorName = '" + SurfaceLocator + "'";
                        int NewLocatorId = sql.ExecuteScalarInt(str1);
                        string str2 = "select StoragesLocatorId from TsurfacesLocators where SurfaceId = " + SurfaceId;
                        int HoldLocatorId = sql.ExecuteScalarInt(str2);
                        string str3 = "select StoragesLocatorIdHistory from TsurfacesLocators where SurfaceId = " + SurfaceId;
                        string LocatorHistory = sql.ExecuteScalarString(str3);
                        User a = (User)Session["user"];
                        int userId = a.Uid;
                        string str4 = "update TsurfacesLocators set StoragesLocatorId = " + NewLocatorId + ", StoragesLocatorIdHistory = '" + LocatorHistory + HoldLocatorId + "@', UserIdUpdate = " + userId;
                        str4 += " where SurfaceId = " + SurfaceId;
                        sql.ExecuteNonQuery(str4);
                        string str5 = "update Tsurfaces set LocatorName = '" + SurfaceLocator;
                        str5 += "' where SurfaceId = " + SurfaceId;
                        sql.ExecuteNonQuery(str5);
                        sql.Close();
                    }

                    LtlOK.Text = "איתור המשטח עודכן בהצלחה";
                }
                
            }
        }
    }   
}