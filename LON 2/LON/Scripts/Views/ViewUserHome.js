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


function CartModel(crtItem) {
    this.name = crtItem.name;
    this.prise = crtItem.prise;
    this.proImg = crtItem.proImg;
    this.quantity = ko.observable(crtItem == NaN ? 0 : 1);
}

function MenuViewModel(menuItem) {
    this.Text = menuItem.Text;
}
