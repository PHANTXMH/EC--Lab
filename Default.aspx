<%@ Page Title="Contact"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gamora._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">GAMORA</h1>
    <center>
        <asp:TextBox ID="TextBox1" runat="server" Width="623px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" class="btn"/>
    </center>
    <hr />
    <h3>Download and play your favourite games for a prices as low as $1800</h3>
    
    <center>
        <asp:Image ID="Image1" runat="server" />&emsp;&emsp;&emsp;&emsp;
    <asp:Image ID="Image2" runat="server"/>&emsp;&emsp;&emsp;&emsp;
    <asp:Image ID="Image3" runat="server" />&emsp;&emsp;&emsp;&emsp;
    <br /><br />
    <a href="Products.aspx" class="shoplink">Shop Now</a><br /><br />
         <asp:Image ID="Image4" runat="server" p/>
    </center>
   

   

</asp:Content>
