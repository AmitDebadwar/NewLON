/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../jquery-1.9.1.js" />
/// <reference path="../API/API.js" />
/// <reference path="../Shorten-1.0.0.js" />
/// <reference path="../../GiftViewModel.js" />


//JQuery Functions

function Temp() {
    alert('GiftJqueryFunctions');
}
function ViewMore(element) {

    $(".DivProductDisplay").css("height", "auto");
    var autoH = $(".DivProductDisplay").height();
    $(".DivProductDisplay").animate({ height: autoH }, 1000);

}

function LogIn(d) {
    var vm = new ViewModel();
   
    if (d.childNodes[0].data == "Log In") {

        vm.fnShowCheckOut();

    }

    else {
        LogOut();
        vm.IsShowMain(false);        
    }
}

