using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LON.Model
{
    public class MainCategoryModel
    {
        public string   CategoryName { get; set; }
        public string   ImagePath{get;set;}
        public DateTime CreatedDate { get; set; }
        public DateTime  ModifiedDate { get; set; }
        public string    CreatedBy { get; set; }
        public string    ModifiedBy { get; set; }
    }
}