
/// <reference path="../Scripts/knockout-2.2.1.js" />
/// <reference path="../Scripts/jquery-1.9.1.js" />
/// <reference path="Scripts/ViewModel/GiftJqueryFunctions.js" />


var productData = [
{ category: 'Mobile', name: 'Samsung S2', prise: 14458, details: 'Mobile', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Samsung s3', prise: 21547, details: 'Touchscreen', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Samsung Star', prise: 5478, details: 'Dual Sim Mobile', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Nokia N8', prise: 14500, details: 'Windows OS', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Nokia Lumia 720', prise: 19500, details: 'Windows OS', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Sony Experia Neo L', prise: 35000, details: 'Windows Mobile', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Sony Experia Neo U', prise: 18500, details: 'Android Mobile', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Nokia x6', prise: 14500, details: 'Simbian OS', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Mobile', name: 'Nokia Lumia 420', prise: 21000, details: 'Windows OS', proImg: 'ProductImages/Nokia-X6.png' },
{ category: 'Computer', name: 'Dell', prise: 21000, details: 'Inspiron', proImg: 'ProductImages/Dell.jpg' },
{ category: 'Computer', name: 'HP', prise: 21000, details: 'Inspiron', proImg: 'ProductImages/hp.jpg' },

{ category: 'Watches', name: 'Roland', prise: 21000, details: 'Zing', proImg: 'ProductImages/watch1.jpg' },
{ category: 'Watches', name: 'Titan 34', prise: 21000, details: 'Zing', proImg: 'ProductImages/watch2.jpg' },
{ category: 'Watches', name: 'Fasttrack', prise: 21000, details: 'Zing', proImg: 'ProductImages/watch3.jpg' },
{ category: 'Watches', name: 'H&T', prise: 21000, details: 'Zing', proImg: 'ProductImages/watch4.jpg' },
{ category: 'Watches', name: 'Digital Watch', prise: 21000, details: 'Zing', proImg: 'ProductImages/watch5.jpg' },


{ category: 'Pen', name: 'Park Avenue', prise: 210, details: 'Zing', proImg: 'ProductImages/pen1.jpg' },
{ category: 'Pen', name: 'Renolds', prise: 150, details: 'Zing', proImg: 'ProductImages/pen2.jpg' },
{ category: 'Pen', name: 'Renolds Gel', prise: 80, details: 'Zing', proImg: 'ProductImages/pen3.jpg' },
{ category: 'Pen', name: 'Digital P', prise: 450, details: 'Zing', proImg: 'ProductImages/pen4.jpg' },


{ category: 'Baquet', name: 'Park Avenue', prise: 210, details: 'Zing', proImg: 'ProductImages/b1.jpg' },
{ category: 'Baquet', name: 'Renolds', prise: 150, details: 'Zing', proImg: 'ProductImages/b2.jpg' },
{ category: 'Baquet', name: 'Renolds Gel', prise: 80, details: 'Zing', proImg: 'ProductImages/b3.jpg' },
{ category: 'Baquet', name: 'Digital P', prise: 450, details: 'Zing', proImg: 'ProductImages/b2.jpg' }
];

function ProductModel(itemModel) {
    this.name = itemModel.name;
    this.prise = itemModel.prise;
    this.details = itemModel.details;
    this.proImg = itemModel.proImg;
    this.category = itemModel.category;
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


function ViewModel() {
    var self = this;

    self.ary = ko.observableArray(['a', 'b']);
    self.act = ko.observable("sai");
    self.cartItems = ko.observableArray([]);
    self.products = ko.observableArray([]);
    self.selectedItem = ko.observable('Mobile');
    self.IsShowMain = ko.observable(true);
    self.menuArray = ko.observableArray([]);
    self.showGrid = ko.observable(true);
    self.currentPage = ko.observable('');
    self.IsviewMore = ko.observable(false);
    self.selectedPaymentMethod = ko.observable('sai');


    self.fnDisplayStyle = function (data, event) {
        self.showGrid(!self.showGrid());
    }

    self.fnSelectCategory = function (element) {
        self.selectedItem(element.Text);

        if (element.Text == "Home") {
            self.currentPage("");
        
            self.selectedItem('Mobile');
            self.IsviewMore(false);
        }

        else {
            self.currentPage(element.Text);

            self.IsviewMore(true);
        }

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
            sumT += i.prise * i.quantity();
            return sumT;
        });

        return sumT;
    }, this);

    self.fnAddToCart = function (cartItem) {
        var alreadyItemPresent = ko.utils.arrayFirst(self.cartItems(), function (found) {
            return found.name === cartItem.name;
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

    ko.utils.arrayMap(productData, function (item) {
        self.products.push(new ProductModel(item));
    });


    self.itemsToShow = ko.computed(function () {
        return ko.utils.arrayFilter(self.products(), function (it) {
            return it.category == self.selectedItem();
        });
    }, this);


    post({}, "GiftDefault.aspx/GetMenu").done(function (data) {
        javaMenuObject = JSON.parse(data.d);

        ko.utils.arrayMap(javaMenuObject, function (item) {

            self.menuArray.push(new MenuViewModel(item));
        });
    });

}

$(function () {
    ko.applyBindings(new ViewModel());
});




//API

function GetProducts() {

    post({}, "GiftDefault.aspx/GetProducts").done(function (data) {
        productData = JSON.parse(data.d);

        ko.utils.arrayMap(productData, function (item) {
            self.products.push(new ProductModel(item));

        });
    });
}

function GetMenu() {
    var javaMenuObject;
    post({}, "GiftDefault.aspx/GetMenu").done(function (data) {
        javaMenuObject = JSON.parse(data.d);
        ko.utils.arrayMap(javaMenuObject, function (item) {
            // $("#CatMenu").append("<a style='margin-left:10px;' href='#'>" + item.Text + "</a>");

        });
    });
}