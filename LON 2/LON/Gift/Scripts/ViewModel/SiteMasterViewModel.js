
/// <reference path="../API/API.js" />
/// <reference path="../../GiftViewModel.js" />

function fnLogin() {
    $("#dialog").dialog("open");
}

function fnRegister() {
    $("#popRegister").dialog("open");
}

$(function () {

    $("#logImg").load(function () {
        $("#dialog").dialog({height:'auto',width:'450', autoOpen: false, buttons: { "Login": function () {

            var n = ApiValidateUser($('#txtUserName').val(), $('#txtPassword').val());
            n.done(function (data) {
                if (data.d != "invalid") {

                    $("#ancLogin").fadeOut(2000);
                    $("#ancRegister").fadeOut(2000);

                    $('#userName').fadeIn(5000).html('<b>Welcome ' + $('#txtUserName').val() + ' !</b>&nbsp&nbsp&nbsp<small><a href="#" style="color:white;" onclick="fnredirectToMyAccount()" runat="server">My Account</a> | <a href="#" style="color:white;" onclick="LogOut()">Log Out</a> </small>');
                    $("#dialog").dialog("close");
                    //                window.location.href = "../Gift/MyAccount.aspx";



                }
                else {
                    $('#divLogInFail').html("<small>Username/Password is invalid !</small>");
                }
            });

        }
        }
        });

    });
    $("#ancLogin").button();
    $("#ancRegister").button();


    $("#popRegister").dialog({
        autoOpen: false,
        buttons: { "Register": function () {
            $("#popRegister").dialog("close");
        }
        },
        width: '350'

    });
});


function fnredirectToMyAccount() {
    window.location.href = "../Gift/MyAccount.aspx";
}


function LogOut() {
    alert('You have been successfully logged out !');
    createCookie("GiftAuth", "", -1);
    $("#ancLogin").fadeIn(2000);
    $("#ancRegister").fadeIn(2000);
    $('#userName').fadeOut(1000);
}

function createCookie(name, value, days) {
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        var expires = "; expires=" + date.toGMTString();
    }
    else var expires = "";
    document.cookie = name + "=" + value + expires + "; path=/";
}

function getCookie(c_name) {
    debugger;
    var c_value = document.cookie;
    var c_start = c_value.indexOf(" " + c_name + "=");
    if (c_start == -1) {
        c_start = c_value.indexOf(c_name + "=");
    }
    if (c_start == -1) {
        c_value = null;
    }
    else {
        c_start = c_value.indexOf("=", c_start) + 1;
        var c_end = c_value.indexOf(";", c_start);
        if (c_end == -1) {
            c_end = c_value.length;
        }
        c_value = unescape(c_value.substring(c_start, c_end));
    }
    var m = c_value;
    return c_value;
}


