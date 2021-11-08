<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Gamora.AdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="AddNewButton" runat="server" Text="Add a New Game" class="btn" OnClick="AddNewButton_Click"/>
    <br />
    <center>
         <asp:Table ID="ProductTable" runat="server" CellPadding="9" CellSpacing="2" GridLines="Both" Width="1082px">
             <asp:TableHeaderRow id="HeaderRow" BackColor="darkgoldenrod" runat="server">
               <asp:TableHeaderCell Scope="Column" Text="Game" />
               <asp:TableHeaderCell Scope="Column" Text="Description" />
               <asp:TableHeaderCell Scope="Column" Text="Category" />
               <asp:TableHeaderCell Scope="Column" Text="Image" />
               <asp:TableHeaderCell Scope="Column" Text="Price" />
               <asp:TableHeaderCell Scope="Column" Text="" />
            </asp:TableHeaderRow>      
        </asp:Table>
    </center>
   
</asp:Content>
