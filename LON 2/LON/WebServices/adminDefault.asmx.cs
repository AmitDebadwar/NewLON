using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LON.Model;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace LON.WebServices
{
    /// <summary>
    /// Summary description for LONServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LONServices : System.Web.Services.WebService
    {
        JavaScriptSerializer serialize;
        LONDataClassesDataContext _dataContext;

        [WebMethod]
        public string HelloWorld(string data)
        {
            return "Hello World";
        }

        [WebMethod]
        public bool SaveNewMainCategory(string data)
        {
            bool status = false;
            try
            {

                _dataContext = new LONDataClassesDataContext();
                var dbObject = new MainCategoryMaster();
                var mainCategory = new MainCategoryModel();

                serialize = new JavaScriptSerializer();
                mainCategory = serialize.Deserialize<MainCategoryModel>(data);

                mainCategory.CreatedDate = DateTime.Now;
                mainCategory.ModifiedDate = DateTime.Now;
                mainCategory.ModifiedBy = "tempModifiedName";

                //Id is auto increamented. No need to pass value.
                ////  dbObject.MainCategoryId = 1;
                dbObject.MainCategoryName = mainCategory.CategoryName;
                dbObject.MainCategoryImage = mainCategory.ImagePath;
                dbObject.CreatedBy = mainCategory.CreatedBy;
                dbObject.CreatedDate = mainCategory.CreatedDate;
                dbObject.ModifiedDate = mainCategory.ModifiedDate;
                dbObject.ModifiedBy = mainCategory.ModifiedBy;

                _dataContext.MainCategoryMasters.InsertOnSubmit(dbObject);
                _dataContext.SubmitChanges();

                status = true;
            }
            catch (Exception exp)
            {
                status = false;
            }
            return status;
        }

        [WebMethod]
        public bool SaveNewParentCategory(string data)
        {
            bool status = false;
            var parentCategoryModel = new ParentCategoryModel();
            var dbModel = new ParentCategoryMaster();
            serialize = new JavaScriptSerializer();
            _dataContext = new LONDataClassesDataContext();

            try
            {
                parentCategoryModel = serialize.Deserialize<ParentCategoryModel>(data);
                parentCategoryModel.CreatedDate = DateTime.Now;
                parentCategoryModel.ModifiedDate = DateTime.Now;

                dbModel.ParentCategoryName = parentCategoryModel.CategoryName;
                dbModel.ParentCategoryImage = parentCategoryModel.CategoryImage;
                dbModel.CreatedBy = parentCategoryModel.CreatedBy;
                dbModel.CreatedDate = parentCategoryModel.CreatedDate;
                dbModel.MainCategoryId = parentCategoryModel.MainCategoryId;
                dbModel.ModifiedBy = parentCategoryModel.ModifiedBy;
                dbModel.ModifiedDate = parentCategoryModel.ModifiedDate;

                _dataContext.ParentCategoryMasters.InsertOnSubmit(dbModel);
                _dataContext.SubmitChanges();
                status = true;
            }

            catch (Exception exp)
            {
                status = false;
            }

            return status;
        }

        [WebMethod]
        public string GetAllMainCategories(string data)
        {
            //            return  new LONDataClassesDataContext().MainCategoryMasters.ToArray();
            return new JavaScriptSerializer().Serialize(
                new LONDataClassesDataContext().MainCategoryMasters);
        }

        [WebMethod]
        public string GetAllParentCategories(string data)
        {
            return new JavaScriptSerializer().Serialize(
               new LONDataClassesDataContext().ParentCategoryMasters);
        }

        [WebMethod]
        public string SaveProduct(string data)
        {

            try
            {
                serialize = new JavaScriptSerializer();

                var dbObj = serialize.Deserialize<ProductMaster>(data);
                Random n = new Random();

                dbObj.ProductId = n.Next();
                dbObj.CreatedBy = "Temp";
                dbObj.CreatedDate = DateTime.Now;
                dbObj.ModifiedBy = "Mod";
                dbObj.ModifiedDate = DateTime.Now;

                _dataContext = new LONDataClassesDataContext();

                _dataContext.ProductMasters.InsertOnSubmit(dbObj);
                _dataContext.SubmitChanges();

                return "saved";
            }

            catch (Exception exp)
            {
                return "NotSaved";
            }
        }

        [WebMethod]
        public string GetAllProducts(string data)
        {
            try
            {
                return new JavaScriptSerializer().Serialize(new LONDataClassesDataContext().ProductMasters);
            }
            catch (Exception exp)
            {

            }




            return "Error";
        }

       









    }


}
