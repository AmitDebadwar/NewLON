/// <reference path="../jquery-1.4.1.js" />
/// <reference path="../../Common/jquery-ui-1.10.3.custom/js/jquery-ui-1.10.3.custom.min.js" />
/// <reference path="../API/API.js" />
/// <reference path="../Json2.js" />


$(function () {
    $("#popupNewMainCat").dialog({ 'autoOpen': false, 'width': 'auto' });
    $("#popUpNewParentCategory").dialog({ 'autoOpen': false, 'width': 'auto' });
    $("#popUpMainCatUpdate").dialog({ 'autoOpen': false, 'width': 'auto' });
    $("#popUpParentCatUpdate").dialog({ 'autoOpen': false, 'width': 'auto' });
    $("#popUpAddproduct").dialog({ 'autoOpen': false, 'width': 'auto', buttons: { "Ok": funSaveProduct, "Cancel": function () { } } });

    $("#menu").menu();

    $("#btnAddNewMainCategory,#btnAddNewParentCategory,#btnAddNewProduct")
      .button()
      .click(function (event) {
          event.preventDefault();
      });
});

///////////////////////////////////////////
function ShowMainCategoryPopup() {
   
    $("#popupNewMainCat").dialog({ buttons: { 'Save': SaveNewMainCategory, 'Cancel': CancelNewMainCategory }
    });
    $("#popupNewMainCat").dialog("open");
}

function SaveNewMainCategory() {
    var dataToSend = {};
    dataToSend.CategoryName = $("#txtMainCatName").val();
    dataToSend.ImagePath = $("#fileMainPath").val();

    dataToSend.CreatedDate = '';
    dataToSend.ModifiedDate = '';
    dataToSend.CreatedBy = "created";
    dataToSend.ModifiedBy = "Modified";

    API.SaveNewMainCategory(JSON.stringify(dataToSend));
}

function CancelNewMainCategory() {
    $("#popupNewMainCat").dialog("close");
}
///////////////////////////////////////////////////////////////

function ShowParentCategoryPopup() {
    $("#popUpNewParentCategory").dialog({ buttons: { 'Save': SaveNewParentCategory, 'Cancel': CancelNewParentCategory }

    });
    $("#popUpNewParentCategory").dialog("open");
}

function SaveNewParentCategory() {
    var dataToSend = {};
   
    //dataToSend.CategoryId = "1";
    dataToSend.CategoryName = "";
    dataToSend.CategoryImage = "";
    dataToSend.MainCategoryId = 1;
    dataToSend.CreatedBy = "";
    dataToSend.ModifiedBy = "";
    dataToSend.CreatedDate = "";
    dataToSend.ModifiedDate = "";
    
    API.SaveNewParentCategory(JSON.stringify(dataToSend));
}

function CancelNewParentCategory() {
    $("#popUpNewParentCategory").dialog("close");
}
/////////////////////////////////////////////////////////////


function funSaveProduct() {
    var prod = {};

    prod.ProductName = $("#txtProductName").val();
    prod.ProductNameAlternate = $("#txtAlternateName").val();
    prod.ProductPrice = 232; //$("#txtPrise").val();
    prod.ProductThumbnailImageFileName = $("#fileThumbnail").val();
    prod.ProductDisplayImageFileName = $("#fileProductImage").val();
    prod.ProductDescription = $("#taDescription").val();
    prod.ParentCategoryId = 2; //$("#selPCatId").val();
    prod.ProductStatusId = 22; //$("#selProdStatus").val();



//    prod.productname = 'n';
//    prod.productnamealternate = 'alt';
//    prod.productprice = 23;
//    prod.productthumbnailimagefilename = $("#filethumbnail").val();
//    prod.productdisplayimagefilename = $("#fileproductimage").val();
//    prod.productdescription = $("#tadescription").val();
//    prod.parentcategoryid = 2; //$("#selpcatid").val();
//    prod.productstatusid = 22; //$("#selprodstatus").val();


    API.SaveProduct(JSON.stringify(prod), {});
    
}





