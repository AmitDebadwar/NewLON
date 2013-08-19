/// <reference path="../../Common/UI/Jquery1.9.1.js" />
/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../Json2.js" />

function post(d, url) {

    return $.ajax({
        type: "POST",
        url: url,
        dataType: "json",
        contentType: "application/json",
        processData: false,
        data: "{'data':'" + d + "'}"
    });
}
var API = {};
/////////////////////////////////////////////////   Admin Services        ////////////////////////////////////////////////////
API.SaveNewMainCategory = function (dataToSave) {
    post(dataToSave, "../WebServices/adminDefault.asmx/SaveNewMainCategory");
};

API.SaveNewParentCategory = function (NewParentCategoryData) {
    post(NewParentCategoryData, "../WebServices/adminDefault.asmx/SaveNewParentCategory");
}

API.GetAllMainCategories = function (callBack) {
    post({}, "../WebServices/adminDefault.asmx/GetAllMainCategories").done(function (recievedAllMainCategories) {
        callBack(recievedAllMainCategories);
    });
}

API.GetAllParentCategories = function (callBack) {
    post({}, "../WebServices/adminDefault.asmx/GetAllParentCategories").done(function (recievedAllMainCategories) {
        callBack(recievedAllMainCategories);
    });
}

API.SaveProduct = function (product, callBack) {
    post(product, "../WebServices/adminDefault.asmx/SaveProduct").done(function (recievedAllMainCategories) {

    });
}

API.GetAllProducts = function (callBack) {
    post({}, "../WebServices/adminDefault.asmx/GetAllProducts").done(function (recievedAllProducts) {
        callBack(recievedAllProducts);
    });
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////   User Services //////////////////////////////////////////////////////////////////

API.GetAllProductsUser = function (callBack) {
    post({}, "../WebServices/adminDefault.asmx/GetAllProductsUser").done(function (recievedAllProducts) {
        callBack(recievedAllProducts);
    });
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////























