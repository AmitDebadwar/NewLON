using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace AssignmentBlog.Gift
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public partial class GiftDefault : System.Web.UI.Page
    {
       static string path = null;
     

        [WebMethod]
        public static bool CheckUserIsLoggedInOrNot()
        {
            return System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
        }

        [WebMethod]
        public static string ValidateUser(string credential)
        {



            var u = credential.Substring(0, credential.IndexOf("/"));
            var p = credential.Substring(credential.IndexOf("/") + 1);

            string result = FormsAuthentication.Authenticate(u, p) == true ? u : string.Empty;

            if (FormsAuthentication.Authenticate(u, p))
            {
                FormsAuthentication.SetAuthCookie(u, false);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, u, DateTime.Now, DateTime.Now.AddMinutes(3), false, "Admin");
                HttpCookie cookie = new HttpCookie("GiftAuth", FormsAuthentication.Encrypt(ticket));
                //    Response.Cookies.Add(cookie);



                HttpContext.Current.Response.Cookies.Add(cookie);
                return u;
            }

            return "invalid";
        }

        public static bool LogOut()
        {
           
            return true;
        }



        [WebMethod]
        public static string GetData()
        {
            XElement elements = XElement.Load(@"C:\A\Programs\Gift 3\ECom 6\AssignmentBlog\Gift\Database\User.xml");
            var listUser = new List<User>();
            foreach (var user in elements.Elements("User").ToList())
            {
                listUser.Add(new User() { Id = user.Element("Id").Value, Name = user.Element("Name").Value });
            }
            JavaScriptSerializer serialize = new JavaScriptSerializer();

            return serialize.Serialize(listUser);
        }


        [WebMethod]
        public static string GetMenu()
        {



            XElement elements = XElement.Load(path);
            var listMenu = new List<MyMenu>();
            foreach (var menuItem in elements.Elements("Menu").ToList())
            {
                listMenu.Add(new MyMenu() { Text = menuItem.Element("Text").Value, Url = menuItem.Element("Url").Value });
            }
            JavaScriptSerializer serialize = new JavaScriptSerializer();

            return serialize.Serialize(listMenu);
        }



        [WebMethod]
        public static string GetProducts()
        {
            XElement elements = XElement.Load(@"C:\A\Programs\Gift 3\ECom 6\AssignmentBlog\Gift\Database\Menu.xml");
            var listMenu = new List<MyMenu>();
            foreach (var menuItem in elements.Elements("Menu").ToList())
            {
                listMenu.Add(new MyMenu() { Text = menuItem.Element("Text").Value, Url = menuItem.Element("Url").Value });
            }
            JavaScriptSerializer serialize = new JavaScriptSerializer();

            return serialize.Serialize(listMenu);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            path = Server.MapPath("Database\\Menu.xml");
            if (User.Identity.IsAuthenticated)
            {
                Login1.Visible = false;
            }

        
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

                else {
                    Response.Redirect("~/Gift/GiftDefault.aspx");
                
                }

                
            }
        }
    }
}