using Sstorage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sstorage.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TxtUserName.Text = null;
                TxtPassword.Text = null;
            }
            tval1.Text = "";
            tval2.Text = "";
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
                tval1.Text = "נא הזן שם משתמש";
            if (TxtPassword.Text == "")
                tval2.Text = "נא הזן סיסמה";
            if (TxtUserName.Text != "" && TxtPassword.Text != "")
            {
                int rid;
                string UserName = TxtUserName.Text;
                string Password = TxtPassword.Text;
                User user = new User(UserName, Password);                
                rid = user.isExist(user);
                if (rid != 0)
                {
                    User Suser = user.getUser(user);
                    Session["user"] = Suser;                    
                    Response.Redirect("index.aspx");                                                      
                }

                else
                    tval2.Text = "שם וסיסמא שגוים";
            }
        }
    }
}