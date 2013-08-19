$(function () {
    $("#Login").dialog({ autoOpen: false, buttons: { "Login": function () {
        console.log($("#txtUserName").val());
        console.log($("#txtPassword").val());
       // window.location.href = "../Admin/adminDefault.aspx";
    }, "Cancel": function () { $(this).dialog("close"); }
    }
    });
    $("#btnLogin").click(function () {
        $("#Login").dialog("open");
    });
});