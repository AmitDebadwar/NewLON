using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LON.Model
{
    public class ParentCategoryModel
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public int MainCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}