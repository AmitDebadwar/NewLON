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


API.GetMenu = function (callBack) {
    post({}, "../WebServices/UserServices.asmx/GetCategoriesMenu").done(function (receivedMenu) {
        callBack(receivedMenu);
    });
}

API.GetAllProductsUser = function (callBack) {
    post({}, "../WebServices/UserServices.asmx/GetAllProductsUser").done(function (receivedProducts) {
        callBack(receivedProducts);
    });
}

























