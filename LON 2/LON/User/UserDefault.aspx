<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.Master" AutoEventWireup="true"
    CodeBehind="UserDefault.aspx.cs" Inherits="LON.User.UserDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/ListProductCss.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/DisplayProductAsGrid.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/ViewModel/UserDefaultViewModel.js" type="text/javascript"></script>
    <script src="../Scripts/API/userDefaultAPI.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="cMain" ContentPlaceHolderID="cphMain" runat="server">
    <dl id="browse">
        <dt>Full Category Lists</dt>
        <div data-bind="foreach:menuArray">
            <dd>
                <a href="#" data-bind="text:$data,click:$root.fnSelectCategory"></a>
            </dd>
        </div>
        <dt>Select Gift By Occassion</dt>
        <div data-bind="foreach:menuArray">
            <dd>
                <a href="#" data-bind="text:$data,click:$root.fnSelectCategory"></a>
            </dd>
        </div>
        <dt>Select Gift By Range</dt>
        <dd class="searchform">
            <form action="http://all-free-download.com/free-website-templates/" method="get">
            <div>
                <select name="cat">
                    <option value="-" selected="selected">CATEGORIES</option>
                    <option value="-">------------</option>
                </select>
            </div>
            <div class="clear br">
            </div>
            <div>
                <input name="q" type="text" value="DVD TITLE" class="text" />
            </div>
            <div class="clear br">
            </div>
            <div class="softright">
                <input type="image" src="../images/btn_search.gif" />
            </div>
            </form>
        </dd>
    </dl>
    <div id="body">
        <div class="inner">
            <div style="border: 0.5px solid gray;" data-bind="visible:cartItems().length>0">
                <div style="background: gray; color: orange; padding: 5px; margin-left: 5px;">
                    Shopping Cart</div>
                <div id="wrapper">
                    <div id="content">
                        <div data-bind="foreach: cartItems">
                            <div style="display: inline-block;">
                                <a target="_blank" href="klematis_big.htm">
                                    <img data-bind="attr:{src:ProductDisplayImageFileName}" height="40" width="100" />
                                </a>
                                <div class="desc">
                                    <a href="#" style="float: left; margin-left: 4px; font-weight: bold; color: red;
                                        text-decoration: none;" data-bind="click:$root.fnRemoveItemMin">-</a> <b data-bind="text:quantity()+' * '+ProductPrice">
                                        </b><a href="#" style="float: right; font-weight: bold; color: red; margin-right: 4px;
                                            text-decoration: none;" data-bind="click:$root.fnAddItemPlus">+</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <h3>
                Best Seller</h3>
            <%--Display product as grid--%>
            <div data-bind="foreach:products,visible:showGrid(),css:{DivProductDisplay:true,ViewMoreCls:IsviewMore()==true,NoViewMoreCls:IsviewMore()==false}"
                style="overflow: hidden;">
                <div class="container">
                    <%--  <b data-bind="attr:{class:$index()%2==0?'Even':'odd'}">s</b>--%>
                    <div class="Desc">
                        <b data-bind="text:name"></b>
                        <br />
                        <b data-bind="text:ProductDescription">Details</b><br />
                        Prise: <b data-bind="text:ProductPrice"></b>
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
                    <img data-bind="attr:{src:ProductDisplayImageFileName}" />
                </div>
                <div class="br">
                </div>
            </div>
            <!-- end .inner -->
        </div>
    </div>
</asp:Content>
