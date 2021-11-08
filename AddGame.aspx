<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddGame.aspx.cs" Inherits="Gamora.AddGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Game</h2><br />
    <hr />
    <center>
        <asp:Label ID="nameLabel" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="descriptionLabel" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="descriptionTextBox" runat="server" Width="508px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="categoryLabel" runat="server" Text="Category: "></asp:Label>
        <asp:TextBox ID="categoryTextBox" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="priceLabel" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="priceTextBox" runat="server" Width="91px"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" class="btn" OnClick="Button1_Click"/>
    </center>
</asp:Content>
