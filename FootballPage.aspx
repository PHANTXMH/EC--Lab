<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FootballPage.aspx.cs" Inherits="Gamora.FootballPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Games</h1><br />
    <asp:Label ID="Label1" runat="server" Text="Categories" class="body-content"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="FootballPage.aspx">Football Games</asp:ListItem>
        <asp:ListItem Value="BasketballPage.aspx">Basketball Games</asp:ListItem>
        <asp:ListItem Value="ShooterPage.aspx">Shooter Games</asp:ListItem>
    </asp:DropDownList>

    <hr />
    <h3 class="title">Football</h3>

    <asp:Image ID="fifa22Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa22Name" runat="server" Text="FIFA 22" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa22Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa22Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="fifa21Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa21Name" runat="server" Text="FIFA 21" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa21Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa21Price" runat="server" Text="price"></asp:Label><br /><br />    
    <asp:Button ID="Button2" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="fifa20Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="fifa20Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="fifa20Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="fifa20Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button3" runat="server" Text="Add to Cart" />
    <br />
    <br />
</asp:Content>
