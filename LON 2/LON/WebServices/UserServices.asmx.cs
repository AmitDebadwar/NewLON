using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace LON.WebServices
{
    /// <summary>
    /// Summary description for UserServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class UserServices : System.Web.Services.WebService
    {
        LONDataClassesDataContext _dataContext;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] GetCategoriesMenu()
        {
            return new LONDataClassesDataContext().MainCategoryMasters.Select(c => c.MainCategoryName).ToArray();
        }
        [WebMethod]
        public string GetAllProductsUser(string data)
        {
            try
            {
                return new JavaScriptSerializer().Serialize(new LONDataClassesDataContext().ProductMasters.Select(c => new { c.ParentCategoryId, c.ProductDescription, c.ProductName, c.ProductPrice, c.ProductStatusId, c.ProductThumbnailImageFileName, c.ProductId,c.ProductDisplayImageFileName }));
            }
            catch (Exception exp)
            {

            }
            return "Error";
        }

        [WebMethod]
        public string ValidateUser(string userName, string password)
        {
            if (Membership.ValidateUser(userName, password))
            {
                FormsAuthentication.SetAuthCookie(userName, true);
            }
            return userName;
        }

    }
}
