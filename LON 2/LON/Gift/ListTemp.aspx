<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ListTemp.aspx.cs" Inherits="AssignmentBlog.Gift.ListTemp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/ListProductCss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="prod-box-list shadow" style="opacity: 1;">
        <img src="ProductImages/hp.jpg" />
        <div class="buy-ico">
        </div>
        <h3>
            <a href="#">Feather Dress With Embellished Lace Top</a>
        </h3>
            <span class="price old">
                $96.00</span>
            <span class="price">
                $454.00</span>
    </div>

    <div class="prod-box-list shadow" style="opacity: 1;overflow: hidden; height: 380px;" data-bind="foreach:itemsToShow"  >
                       <img data-bind="attr:{src:proImg}" />
                        <div class="buy-ico">
                        </div>
                        <h3>
                            <a href="#" data-bind="text:details">Feather Dress With Embellished Lace Top</a>
                        </h3>
                        <span class="price old" data-bind="text:prise">$96.00</span> <span class="price">$454.00</span>
                    </div>



                     <div id="DivProductDisplay" style="overflow: hidden; height: 380px;" data-bind="foreach:itemsToShow">
                        <div class="img">
                            <h3 data-bind="text:name">
                            </h3>
                            <hr style="border: 3px solid orange;">
                            <img   height="140" width="140" data-bind="attr:{src:proImg}" />
                            <div class="desc" data-bind="text:details">
                            </div>
                            <br />
                            <b>Prise: </b><b data-bind="text:prise,style:{color:'orange'}"></b>
                            <hr style="border: 3px solid gray;">
                            <div>
                                <input type="button" value="Add" data-bind="click:$root.fnAddToCart" />
                                <input type="button" value="Details" />
                            </div>
                        </div>
                    </div>
</asp:Content>
