<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Gamora.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <asp:Image ID="Image1" runat="server" /><br />
        <asp:Label ID="Label1" runat="server" Text="Login Here"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" class="btn"/><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Login as admin" OnClick="Button1_Click" class="btn"/>
    </center>
</asp:Content>
