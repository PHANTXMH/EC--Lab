<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasketballPage.aspx.cs" Inherits="Gamora.BasketballPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">Games</h1><br />
    <asp:Label ID="Label1" runat="server" Text="Categories" class="body-content"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="FootballPage.aspx">Football Games</asp:ListItem>
        <asp:ListItem Value="BasketballPage.aspx">Basketball Games</asp:ListItem>
        <asp:ListItem Value="ShooterPage.aspx">Shooter Games</asp:ListItem>
    </asp:DropDownList>
     <hr />
    <h3 class="title">BasketBall</h3>

    <asp:Image ID="nba2k22Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k22Name" runat="server" Text="nba2k22" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k22Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k22Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button4" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="nba2k21Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k21Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k21Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k21Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button5" runat="server" Text="Add to Cart" />
    <br />
    <br />
    <asp:Image ID="nba2k20Image" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Label ID="nba2k20Name" runat="server" Text="FIFA 20" class="product-name"></asp:Label><br /><br />
    <asp:Label ID="nba2k20Description" runat="server" Text="description"></asp:Label><br /><br />
    <asp:Label ID="nba2k20Price" runat="server" Text="price"></asp:Label><br /><br />
    <asp:Button ID="Button6" runat="server" Text="Add to Cart" />
    <br />
    <br />
</asp:Content>
