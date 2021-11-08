<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Gamora.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h2>Your Cart,</h2>
    <br />
    <hr />
    <p>*Only 3 of each item can be added to the cart.</p>
    <center>
         <asp:Table ID="Table1" runat="server" CellPadding="9" CellSpacing="2" GridLines="Both" Width="510px">
             <asp:TableHeaderRow id="Table1HeaderRow" BackColor="darkgoldenrod" runat="server">
               <asp:TableHeaderCell Scope="Column" Text="Game" />
               <asp:TableHeaderCell Scope="Column" Text="Price" />
               <asp:TableHeaderCell Scope="Column" Text="Quantity" />
               <asp:TableHeaderCell Scope="Column" Text="Total" />
               <asp:TableHeaderCell Scope="Column" Text="" />
            </asp:TableHeaderRow>      
        </asp:Table>
            <br />
        <asp:Table ID="Table2" runat="server" CellPadding="9" CellSpacing="2" GridLines="Both" Width="234px">
        
        </asp:Table>
    </center>
    
   
    <br />
    <asp:Button ID="ProceedButton" runat="server" Text="Proceed to Checkout" class="btn" OnClick="ProceedButton_Click" />
    </asp:Content>


