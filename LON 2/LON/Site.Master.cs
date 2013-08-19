using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LON
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(Login1.UserName, Login1.Password))
            {
                FormsAuthentication.SetAuthCookie(Login1.UserName, true);

                if (Roles.GetRolesForUser(Login1.UserName)[0] == "Admin")
                {
                    Response.Redirect("~/Admin/adminDefault.aspx");
                }

                else
                {
                    Response.Redirect("~/Gift/GiftDefault.aspx");

                }


            }
        }

    }
}
