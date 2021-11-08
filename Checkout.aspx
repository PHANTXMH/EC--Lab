<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Gamora.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>Thank you for shopping at Gamora!</h1>
        <h3>Your order will be shipped within five business days.</h3>
        <hr />
        <h4>Previous Orders</h4>
        <asp:Table ID="OrderTable" runat="server" CellPadding="9" CellSpacing="2" GridLines="Both" Width="518px">
             <asp:TableHeaderRow id="Table1HeaderRow" BackColor="darkgoldenrod" runat="server">
               <asp:TableHeaderCell Scope="Column" Text="Order Date" />
               <asp:TableHeaderCell Scope="Column" Text="Product Id" />
               <asp:TableHeaderCell Scope="Column" Text="User Id" />
               <asp:TableHeaderCell Scope="Column" Text="Quantity" />
               <asp:TableHeaderCell Scope="Column" Text="Total" />
            </asp:TableHeaderRow>      
        </asp:Table>
    </center>
</asp:Content>
