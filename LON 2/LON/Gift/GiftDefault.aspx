<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="GiftDefault.aspx.cs" Inherits="AssignmentBlog.Gift.GiftDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="DisplayProductAsGrid.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/ListProductCss.css" rel="stylesheet" type="text/css" />
    <script src="../Common/UI/Jquery1.9.1.js" type="text/javascript"></script>
    <script src="../Scripts/knockout-2.2.1.js" type="text/javascript"></script>
    <script src="Scripts/API/API.js" type="text/javascript"></script>
    <script src="GiftViewModel.js" type="text/javascript"></script>
    <script src="Scripts/ViewModel/GiftJqueryFunctions.js" type="text/javascript"></script>
    <script src="../Scripts/Json2.js" type="text/javascript"></script>
    <style type="text/css">
        .Active
        {
            border: 3px solid orange;
        }
        
        .InActive
        {
            border: 3px solid gray;
        }
        
        .ViewMoreCls
        {
            height: 'auto';
        }
        
        .NoViewMoreCls
        {
            height: 410px;
        }
        
        
        
        .NoListViewMoreCls
        {
            height: 362px;
        }
    </style>
    <link href="jquery-ui-1.10.3.custom/css/smoothness/jquery-ui-1.10.3.custom.css" rel="stylesheet"
        type="text/css" />
    <script src="jquery-ui-1.10.3.custom/js/jquery-ui-1.10.3.custom.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="clear hideSkiplink">
        <div id="NavigationMenu" class="menu" style="float: left;">
            <ul data-bind="foreach:menuArray" style="position: relative; width: auto; float: left;"
                role="menubar">
                <li style="position: relative; float: left;"><a class="level1" href="#" data-bind="text:Text,click: $root.fnSelectCategory">
                </a></li>
            </ul>
        </div>
    </div>
    <br />
    <br />
    <div>
        &nbsp</div>
    <div>
        You are Here: <b><span data-bind="text:'Home > '+currentPage()"></span></b>
    </div>
    <div data-bind="visible:IsShowMain">
        <br />
        Shopping Cart: <b data-bind="text:cartItems().length+'  Items'"></b>
        <div style="margin-bottom: 10px;" data-bind="visible:cartItems().length>0">
            Total: <b data-bind="text:sumTotal()"></b>
            <input type="button" value="Clear Cart" data-bind="click:fnClearCart" />
            <input type="button" data-bind="click:fnShowCheckOut" value="Check Out" /></div>
        <div style="border: 0.5px solid gray;" data-bind="visible:cartItems().length>0">
            <div id="wrapper">
                <div id="content">
                    <div data-bind="foreach: cartItems">
                        <div class="imgCart">
                            <a target="_blank" href="klematis_big.htm">
                                <img data-bind="attr:{src:proImg}" height="40" width="100" />
                            </a>
                            <div class="desc">
                                <a href="#" style="float: left; margin-left: 4px; font-weight: bold; color: red;
                                    text-decoration: none;" data-bind="click:$root.fnRemoveItemMin">-</a> <b data-bind="text:quantity()+' * '+prise">
                                    </b><a href="#" style="float: right; font-weight: bold; color: red; margin-right: 4px;
                                        text-decoration: none;" data-bind="click:$root.fnAddItemPlus">+</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <table border="1" cellpadding="4" cellspacing="5" width="100%">
            <tr>
                <td style="width: 20%" valign="top">
                    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" BackColor="#FFFBD6"
                        BorderColor="#FFDFAD" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px"
                        DisplayRememberMe="False" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                        <LoginButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
                        <TextBoxStyle Font-Size="0.8em" Width="150" Height="12" />
                        <TitleTextStyle BackColor="#990000" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    </asp:Login>
                    <h4>
                        Select By Range</h4>
                    <%--   <div id="Div2" class="menu">
                        <ul data-bind="foreach:menuArray" class="level1">
                            <li><a class="level1" href="#" data-bind="text:Text,click: $root.fnSelectCategory"></a>
                            </li>
                        </ul>
                    </div>
                    --%>
                    <h4>
                        Select By Occassion</h4>
                </td>
                <td>
                    <img src="http://localhost:4906/Gift/ProductImages/grid.png" width="20" height="20"
                        style="float: right; margin-left: 4px; margin-right: 4px; padding: 4px; border: 3px solid orange;"
                        data-bind="click:$root.fnDisplayStyle" />
                    <img src="http://localhost:4906/Gift/ProductImages/list.png" width="20" height="20"
                        style="float: right; padding: 4px; border: 3px solid gray;" data-bind="click:$root.fnDisplayStyle" />
                    <h3>
                        Best Seller</h3>
                    <%--Display product as grid--%>
                    <div data-bind="foreach:$root.itemsToShow,visible:showGrid(),css:{DivProductDisplay:true,ViewMoreCls:IsviewMore()==true,NoViewMoreCls:IsviewMore()==false}"
                        style="overflow: hidden;">
                        <div class="container">
                            <div class="Desc">
                                <b data-bind="text:name"></b>
                                <br />
                                <b data-bind="text:details">Details</b><br />
                                Prise: <b data-bind="text:prise"></b>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <a href="#" style="color: Wheat; margin-left: 30px; font-weight: bold; background: black;
                                    padding: 4px;" data-bind="click:$root.fnAddToCart">Add To Cart</a>
                            </div>
                            <img data-bind="attr:{src:proImg}" />
                        </div>
                    </div>
                    <%--Display products as list--%>
                    <div data-bind="foreach:itemsToShow,visible:!showGrid(),css:{NoListViewMoreCls:IsviewMore()==false,ViewMoreCls:IsviewMore()==true}"
                        style="overflow: hidden;">
                        <div class="prod-box-list shadow">
                            <img data-bind="attr:{src:proImg}" width="50" height="150" />
                            <div class="buy-ico">
                            </div>
                            <h3>
                                <a href="#">Feather Dress With Embellished Lace Top</a>
                            </h3>
                            <span class="price">$454.00</span> <span class="price old" data-bind="text:prise,style:{color:'orange'}">
                                $96.00</span>
                        </div>
                    </div>
                    <a href="#" style="float: right;" data-bind="click:fnViewMore" id="ancViewMore">View
                        More</a>
                    <br />
                    <hr style="border: 3px solid orange;">
                    <h3>
                        Recently Added</h3>
                    <div data-bind="foreach:$root.itemsToShow,visible:showGrid(),css:{DivProductDisplay:true,NoViewMoreCls:true}"
                        style="overflow: hidden;">
                        <div class="container">
                            <div class="Desc">
                                <b data-bind="text:name"></b>
                                <br />
                                <b data-bind="text:details">Details</b><br />
                                Prise: <b data-bind="text:prise"></b>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <a href="#" style="color: Wheat; margin-left: 30px; font-weight: bold; background: black;
                                    padding: 4px;" data-bind="click:$root.fnAddToCart">Add To Cart</a>
                            </div>
                            <img data-bind="attr:{src:proImg}" />
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <div data-bind="visible:!IsShowMain()">
        <div style="display: inline-block; border: 2px solid orange; padding: 10px;">
            <h1>
                Checkout:</h1>
            <div>
                <table border="1" cellpadding="0" cellspacing="0">
                    <thead>
                        <tr>
                            <th>
                                Product Name
                            </th>
                            <th>
                                Prise
                            </th>
                            <th>
                                Quantity
                            </th>
                        </tr>
                    </thead>
                    <tbody data-bind="foreach: cartItems">
                        <tr>
                            <td>
                                <a target="_blank" href="klematis_big.htm">
                                    <img data-bind="attr:{src:proImg}" height="40" width="100" />
                                </a>
                                <div class="desc">
                                    <a href="#" style="float: left; margin-left: 4px; font-weight: bold; color: red;
                                        text-decoration: none;" data-bind="click:$root.fnRemoveItemMin">-</a> <b data-bind="text:quantity()+' * '+prise">
                                        </b><a href="#" style="float: right; font-weight: bold; color: red; margin-right: 4px;
                                            text-decoration: none;" data-bind="click:$root.fnAddItemPlus">+</a>
                                </div>
                            </td>
                            <td data-bind="text: prise">
                            </td>
                            <td data-bind="text: quantity">
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div style="display: inline-block; border: 2px solid orange; padding: 10px; margin-left: 100px;">
            <h1>
                Payment Method</h1>
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <th align="left">
                        Paypal
                    </th>
                    <td>
                        <input type="radio" name="paymentMethod" />
                    </td>
                </tr>
                <tr>
                    <th align="left">
                        Credit Card
                    </th>
                    <td>
                        <input type="radio" name="paymentMethod" data-bind="checked:selectedPaymentMethod" />
                    </td>
                </tr>
                <tr>
                    <th align="left">
                        Online Banking
                    </th>
                    <td>
                        <input type="radio" name="paymentMethod" data-bind="click: function(f){alert('this is sel');}" />
                        <b data-bind="text:selectedPaymentMethod"></b>
                    </td>
                </tr>

                <tr>
                 <th align="left"><br /><br />Enter credit card No:</th>
                <td><br /><br /><input type="text" /></td>
                </tr>

                <tr>
                <th align="left"><br /><br />Select Bank:</th>
                <td><br /><br /><select data-bind="options:['ICICI Bank','State Bank Of India','State Bank Of Hyderabad']"></select></td>
                </tr>





            </table>
        </div>
        <br />
        <br />
        Total: <b data-bind="text:sumTotal()"></b>
        <br />
        <br />
        <input type="button" data-bind="click:function(){window.location.href='http://www.paypal.com';}"
            value="Payment" />
        <input type="button" value="Back To Products" data-bind="click:fnShowCheckOut" />
    </div>
</asp:Content>
