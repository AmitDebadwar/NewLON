/// <reference path="../jquery-1.9.1.js" />
/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../../../Scripts/Json2.js" />

function post(d, url) {
    return $.ajax({
        type: "POST",
        url: url,
        dataType: "json",
        contentType: "application/json",
        processData: false,
        data: ko.toJSON(d)
    });
}



function ApiValidateUser(u,p) {
    return post({ 'credential': u + "/" + p }, "GiftDefault.aspx/ValidateUser");

}