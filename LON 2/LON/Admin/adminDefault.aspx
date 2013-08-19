<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSiteMaster.Master" AutoEventWireup="true"
    CodeBehind="adminDefault.aspx.cs" Inherits="LON.Admin.adminDefault" %>

<%@ Register Assembly="LONCustomControl" Namespace="LONCustomControl" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="../Scripts/knockout-2.2.1.js" type="text/javascript"></script>
    <script src="../Common/UI/Jquery1.9.1.js" type="text/javascript"></script>
    <script src="../Common/UI/Ui.1.10.3.js" type="text/javascript"></script>
  
    <script src="../Scripts/ViewModel/AdminDefaultViewModel.js" type="text/javascript"></script>
    <script src="../Scripts/Views/ViewAdminDefault.js" type="text/javascript"></script>
  
    <link href="../Common/jquery-ui-1.10.3.custom/css/smoothness/jquery-ui-1.10.3.custom.min.css"
        rel="stylesheet" type="text/css" />
    <script src="../Scripts/GeneralFunctions/adminDefault.js" type="text/javascript"></script>
    <script src="../Scripts/API/adminDefaultAPI.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divAdminDefault">
        <table border="1" cellpadding="0" cellspacing="0" width="100%" height="400">
            <tr>
                <td style="width: 20%;" valign="top">
                    <div style="width: auto; background: gray; padding: 5px; color: Orange;">
                        Admin Task</div>
                    <ul id="menu" data-bind="foreach:leftArray">
                        <li><a href="#" data-bind="text: $data,click:$root.fnShowSection" class="HMenu"></a>
                        </li>
                    </ul>
                </td>
                <td style="width: 80%;" valign="top">
                    <cc1:LonCustCon ID="defaultAdminMainCategoryManagement" runat="server" />
                    <cc1:LonCustCon ID="defaultAdminParentCategoryManagement" runat="server" />
                    <cc1:LonCustCon ID="defaultAdminProductManagement" runat="server" />
                </td>
            </tr>
        </table>
        <input type="button" data-bind="click: fnLoad" value="Load Page Data" />
        <b data-bind="text: act"></b>
        <cc1:LonCustCon ID="defaultAdminPopUp" runat="server" />
    </div>
</asp:Content>
