<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Gamora.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <asp:Image ID="Image1" runat="server" /><br />
        <asp:Label ID="Label1" runat="server" Text="Login Here"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="LoginButton" runat="server" Text="Log In" class="btn" OnClick="LoginButton_Click" />
    </center>
</asp:Content>
