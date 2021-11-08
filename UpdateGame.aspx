<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateGame.aspx.cs" Inherits="Gamora.UpdateGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Update Game</h2><br />
    <hr />
    <p>*Update the necessary fields for the displayed game.</p>
    <center>
       <asp:Label ID="nameLabel" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="updnameTextBox" runat="server" Width="292px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="descriptionLabel" runat="server" Text="Description: "></asp:Label><br />
        <asp:TextBox ID="upddescriptionTextBox" runat="server" Width="831px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="categoryLabel" runat="server" Text="Category: "></asp:Label>
        <asp:TextBox ID="updcategoryTextBox" runat="server" Width="242px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="imageLabel" runat="server" Text="ImageUrl: "></asp:Label>
        <asp:TextBox ID="updimageTextBox" runat="server" Width="353px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="priceLabel" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="updpriceTextBox" runat="server" Width="83px"></asp:TextBox>
        <br /><br />
        <asp:Button ID="updateButton" runat="server" Text="Update" class="btn" OnClick="UpdateButton_Click"/>
    </center>
</asp:Content>
