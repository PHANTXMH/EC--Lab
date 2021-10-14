<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Gamora.Products" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Games</h1><br />

    <hr />
    <h3 class="title">Football</h3>

    <asp:Image ID="fifa22Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa22Name" runat="server" Text="FIFA 22" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa22Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa22Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="fifa22Button" runat="server" Text="Add to Cart" class="btn" OnClick="fifa22Button_Click"/>
    <br />
    <br />
    <asp:Image ID="fifa21Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa21Name" runat="server" Text="FIFA 21" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa21Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa21Price" runat="server" Text="price"></asp:Label><br /><br />    
    <asp:Button ID="fifa21Button" runat="server" Text="Add to Cart" class="btn" OnClick="fifa21Button_Click" />
    <br />
    <br />
    <asp:Image ID="fifa20Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa20Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa20Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa20Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="fifa20Button" runat="server" Text="Add to Cart" class="btn" OnClick="fifa20Button_Click"/>
    <br />
    <br />

    <hr />
    <h3 class="title">BasketBall</h3>

    <asp:Image ID="nba2k22Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k22Name" runat="server" Text="nba2k22" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k22Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k22Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="nba2k22Button" runat="server" Text="Add to Cart" class="btn" OnClick="nba2k22Button_Click"/>
    <br />
    <br />
    <asp:Image ID="nba2k21Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k21Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k21Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k21Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="nba2k21Button" runat="server" Text="Add to Cart" class="btn" OnClick="nba2k21Button_Click"/>
    <br />
    <br />
    <asp:Image ID="nba2k20Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k20Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k20Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k20Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="nba2k20Button" runat="server" Text="Add to Cart" class="btn" OnClick="nba2k20Button_Click"/>
    <br />
    <br />

    <hr />
    <h3 class="title">Shooters</h3>

    <asp:Image ID="codcoldwarImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codcoldwarName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codcoldwarDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codcoldwarPrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="codcoldwarButton" runat="server" Text="Add to Cart" class="btn" OnClick="codcoldwarButton_Click"/>
    <br />
    <br />
    <asp:Image ID="codmodernwarfareImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codmodernwarfareName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codmodernwarfareDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codmodernwarfarePrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="codmodernwarfareButon" runat="server" Text="Add to Cart" class="btn" OnClick="codmodernwarfareButon_Click"/>
    <br />
    <br />
    <asp:Image ID="codblackopsImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codblackopsName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codblackopsDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codblackopsPrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="codblackopsButton" runat="server" Text="Add to Cart" class="btn" OnClick="codblackopsButton_Click"/>
    <br />
    <br />
</asp:Content>
