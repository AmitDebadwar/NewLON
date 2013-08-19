<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSiteMaster.Master" AutoEventWireup="true"
    CodeBehind="TempA.aspx.cs" Inherits="LON.Admin.TempA" %>

<%@ Register Assembly="LONCustomControl" Namespace="LONCustomControl" TagPrefix="cc2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  

    <script src="../Scripts/jquery-1.4.1.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <cc2:LonCustCon ID="defaultAdminMainCategoryManagement" runat="server" />
    
    </asp:Content>
