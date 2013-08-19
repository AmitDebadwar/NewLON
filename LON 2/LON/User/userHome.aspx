<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="userHome.aspx.cs" Inherits="LON.User.userHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Common/UI/Jquery1.9.1.js" type="text/javascript"></script>
    <script src="../Scripts/knockout-2.2.1.js" type="text/javascript"></script>
    <script src="../Scripts/Json2.js" type="text/javascript"></script>
    <script src="../Scripts/API/adminDefaultAPI.js" type="text/javascript"></script>
    <script src="../Scripts/ViewModel/UserDefaultViewModel.js" type="text/javascript"></script>


    <link href="../Gift/DisplayProductAsGrid.css" rel="stylesheet" type="text/css" />
    <link href="../Gift/ListProductCss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<input type="button" data-bind="click:fnLoadPageData" />


<div data-bind="foreach:products">
<b data-bind="text:ProductId"></b>
</div>
</asp:Content>
