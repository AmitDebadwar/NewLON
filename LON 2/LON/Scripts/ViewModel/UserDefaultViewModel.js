/// <reference path="../Jquery1.9.1.js" />
/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../Json2.js" />
/// <reference path="../Views/ViewUserHome.js" />
/// <reference path="../API/userDefaultAPI.js" />


function CartModel(crtItem) {
    this.ProductName = crtItem.ProductName;
    this.ProductPrice = crtItem.ProductPrice;
    this.ProductDisplayImageFileName = crtItem.ProductDisplayImageFileName;
    this.quantity = ko.observable(crtItem == NaN ? 0 : 1);
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

function ViewModel() {
    var self = this;

    self.ary = ko.observableArray([]);
    self.act = ko.observable("Activated !");
    self.cartItems = ko.observableArray([]);
    self.products = ko.observableArray([]);
    self.selectedItem = ko.observable('Mobile');
    self.IsShowMain = ko.observable(true);
    self.menuArray = ko.observableArray([]);
    self.showGrid = ko.observable(true);
    self.currentPage = ko.observable('');
    self.IsviewMore = ko.observable(false);
    self.selectedPaymentMethod = ko.observable();


    self.fnDisplayStyle = function (data, event) {
        self.showGrid(!self.showGrid());
    }

    self.fnSelectCategory = function (element) {
        self.selectedItem(element);
    };

    self.fnViewMore = function () {
        self.IsviewMore(!self.IsviewMore());
    };
    self.fnBackToProduct = function () {
        self.IsShowMain(true);
    };

    self.fnShowCheckOut = function (data, event) {
        console.log(event)
        self.IsShowMain(!self.IsShowMain());
    };

    self.fnAddItemPlus = function (itemToAdd) {
        itemToAdd.quantity(itemToAdd.quantity() + 1);
    };

    self.fnRemoveItemMin = function (itemToRem) {

        itemToRem.quantity(itemToRem.quantity() - 1);
        if (itemToRem.quantity() == 0) {
            self.cartItems.remove(itemToRem);
        }
    };

    self.fnClearCart = function () {
        self.cartItems.removeAll();
    };

    self.removeCartItem = function (remCrt) {
        self.cartItems.remove(remCrt);
    };

    self.sumTotal = ko.computed(function () {
        var sumT = 0;
        ko.utils.arrayForEach(self.cartItems(), function (i) {
            sumT += i.ProductPrice * i.quantity();
            return sumT;
        });

        return sumT;
    }, this);

    self.fnAddToCart = function (cartItem) {
     
        var alreadyItemPresent = ko.utils.arrayFirst(self.cartItems(), function (found) {
            return found.ProductName === cartItem.ProductName;
        });

        if (alreadyItemPresent) {
            alreadyItemPresent.quantity(alreadyItemPresent.quantity() + 1);

        }
        else {
            self.cartItems.push(new CartModel(cartItem));

        }
    };

    self.fnGetAll = function () {
        ko.utils.arrayForEach(self.cartItems(), function (temp) {
            alert(temp.name);
        });
    };


    API.GetAllProductsUser(function (productData) {
        ko.utils.arrayMap(JSON.parse(productData.d), function (product) {
            self.products.push(new Product(product));
        });
    });



    self.fnLoadPageData = function () {

        var bigObject;

     
        debugger;
        var temp = bigObject;


    }
    self.itemsToShow = ko.computed(function () {

        return ko.utils.arrayFilter(self.products(), function (it) {
            return it.category == self.selectedItem();
        });
    }, this);


    API.GetMenu(function (myMenu) {
        ko.utils.arrayMap(myMenu.d, function (menuItem) {
            self.menuArray.push(menuItem);
        });
    });

    self.fnLoadMenu = function () {
    };



}




$(function () {
    ko.applyBindings(new ViewModel(), $("#divUserHome")[0]);
});

