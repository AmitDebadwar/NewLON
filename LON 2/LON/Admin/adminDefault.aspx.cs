using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;
using LON.Model;

namespace LON.Admin
{
    public partial class adminDefault : System.Web.UI.Page
    {
        static JavaScriptSerializer serializer;
        static LONDataClassesDataContext _dataContext;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        [WebMethod]
        public static string ValidateUser(string data)
        {
            serializer = new JavaScriptSerializer();
            var user = serializer.Deserialize<UserModel>(data);
            return user.UserName;
        }
    }
}