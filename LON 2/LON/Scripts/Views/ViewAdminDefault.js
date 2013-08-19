function ParentCategory(ParentCategory) {
    var Cdate = new Date(parseInt(ParentCategory.CreatedDate.replace("/Date(", "").replace(")/", ""), 10));
    var Mdate = new Date(parseInt(ParentCategory.ModifiedDate.replace("/Date(", "").replace(")/", ""), 10));

    this.ParentCategoryId = ParentCategory.ParentCategoryId;
    this.ParentCategoryName = ParentCategory.ParentCategoryName;
    this.ParentCategoryImage = ParentCategory.ParentCategoryImage;
    this.MainCategoryId = ParentCategory.MainCategoryId;
    this.CreatedDate = Cdate;
    this.ModifiedDate = Mdate;
    this.CreatedBy = ParentCategory.CreatedBy;
    this.ModifiedBy = ParentCategory.ModifiedBy;
}

function MainCategories(Maincategory) {
    var Cdate = new Date(parseInt(Maincategory.CreatedDate.replace("/Date(", "").replace(")/", ""), 10));
    var Mdate = new Date(parseInt(Maincategory.ModifiedDate.replace("/Date(", "").replace(")/", ""), 10));

    this.MainCategoryId = Maincategory.MainCategoryId;
    this.MainCategoryName = Maincategory.MainCategoryName;
    this.MainCategoryImage = Maincategory.MainCategoryImage;
    this.CreatedDate = Cdate;
    this.ModifiedDate = Mdate;
    this.CreatedBy = Maincategory.CreatedBy;
    this.ModifiedBy = Maincategory.ModifiedBy;
}

function Product(productP) {
    this.ProductId = productP.ProductId;
    this.ProductName = productP.ProductName;
    this.ProductNameAlternate = productP.ProductNameAlternate;
    this.ProductPrice = productP.ProductPrice;
    this.ProductThumbnailImageFileName = productP.ProductThumbnailImageFileName;
    this.ProductDisplayImageFileName = productP.ProductDisplayImageFileName;
    this.ProductDescription = productP.ProductDescription;
    this.ParentCategoryId = productP.ParentCategoryId;
    this.ProductStatusId = productP.ProductStatusId;
    this.CreatedDate = productP.CreatedDate;
    this.ModifiedDate = productP.ModifiedDate;
    this.CreatedBy = productP.CreatedBy;
    this.ModifiedBy = productP.ModifiedBy;
    this.editMe = ko.observable(false);
}