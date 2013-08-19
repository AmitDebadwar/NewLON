/// <reference path="../../Common/UI/Jquery1.9.1.js" />
/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../API/adminDefaultAPI.js" />
/// <reference path="../Json2.js" />
/// <reference path="../Views/ViewAdminDefault.js" />
/// <reference path="../GeneralFunctions/adminDefault.js" />



function ViewModel() {
    var self = this;
    self.tempArr = ko.observable('sai');

    self.act = ko.observable('Yes');

    //Observables
    self.alreadySelectedCatId = ko.observable();
    self.WindowFrame = ko.observable();
    //ObservableArrays

    self.arrMainCategories = ko.observableArray([]);
    self.arrParentCategories = ko.observableArray([]);
    self.leftArray = ko.observableArray(['Category Management', '--> Main Category', '--> Parent Category', 'Product Management', 'Temp Option', 'Temp 2']);
    self.arrProducts = ko.observableArray([]);
    self.fnShowMainFooter = function () {
        self.ShowMainFooter(true);
    };

    //functions
    self.fnShowSection = function (ancData, divv) {
        self.WindowFrame(ancData);
    };    //fnShowSection

    self.fnDeleteMainCat = function (itemToDelete) {
        self.arrMainCategories.remove(itemToDelete);
    };


    self.fnLoad = function () {

        API.GetAllMainCategories(function (recievedData) {
            var javaObjectMainCategories = JSON.parse(recievedData.d);
            self.arrMainCategories.removeAll();
            ko.utils.arrayMap(javaObjectMainCategories, function (oneCategory) {
                var adminViewModel = new ViewModel();
                self.arrMainCategories.push(
            new MainCategories(oneCategory)); //push()
            }); //arrayMap
        }); //GetAllMainCategories

        API.GetAllParentCategories(function (recievedData) {

            var javaObjectMainCategories = JSON.parse(recievedData.d);

            self.arrParentCategories.removeAll();
            ko.utils.arrayMap(javaObjectMainCategories, function (oneCategory) {
                var adminViewModel = new ViewModel();
                self.arrParentCategories.push(
            new ParentCategory(oneCategory)); //push()

            }); //arrayMap

        }); //GetAllParentCategories

        API.GetAllProducts(function (recievedData) {
            var javaObjectMainCategories = JSON.parse(recievedData.d);
            self.arrProducts.removeAll();

            ko.utils.arrayMap(javaObjectMainCategories, function (product) {
                var adminViewModel = new ViewModel();
                self.arrProducts.push(
            new Product(product)); //push()
            }); //arrayMap
        });
    };               //load

    self.fnEdit = function (row, event) {
        row.editMe(!row.editMe());
    };

    self.fnSaveUpdate = function (updatedRecord) {
        console.log(updatedRecord);
        updatedRecord.editMe(false);
    };

    self.fnMainUpdate = function (record) {
        $("#snCatId").html(record.MainCategoryId);
        $("#txtCatName").val(record.MainCategoryName);
        $("#popUpMainCatUpdate").dialog({ buttons: { "Update": function () { }, "Cancel": function () { } } });
        $("#popUpMainCatUpdate").dialog("open");
    }

    self.fnParentUpdate = function (record) {

        $("#lblParentCatUpdatePCatId").html(record.ParentCategoryId);
        $("#txtParentCatUpdateName").val(record.ParentCategoryName);
        $("#popUpParentCatUpdate").dialog({ buttons: { "Update": function () { }, "Cancel": function () { } } });
        $("#popUpParentCatUpdate").dialog("open");
        self.alreadySelectedCatId(record.MainCategoryId);
    };

    self.fnAddNewProduct = function () {
        $("#popUpAddproduct").dialog("open");
    };
}

$(function () {
    ko.applyBindings(new ViewModel(), $("#divAdminDefault")[0]);
});





        