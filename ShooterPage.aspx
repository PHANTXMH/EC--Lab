<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShooterPage.aspx.cs" Inherits="Gamora.ShooterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Games</h1><br />
    <asp:Label ID="Label1" runat="server" Text="Categories" class="body-content"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="FootballPage.aspx">Football Games</asp:ListItem>
        <asp:ListItem Value="BasketballPage.aspx">Basketball Games</asp:ListItem>
        <asp:ListItem Value="ShooterPage.aspx">Shooter Games</asp:ListItem>
    </asp:DropDownList>
    <hr />
    <h3 class="title">Shooters</h3>

    <asp:Image ID="codcoldwarImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codcoldwarName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codcoldwarDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codcoldwarPrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button7" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="codmodernwarfareImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codmodernwarfareName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codmodernwarfareDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codmodernwarfarePrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button8" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="codblackopsImage" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="codblackopsName" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="codblackopsDescription" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="codblackopsPrice" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button9" runat="server" Text="Add to Cart" />
    <br />
    <br />
</asp:Content>
