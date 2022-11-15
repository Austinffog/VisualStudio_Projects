<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ProgApp.ShoppingCart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shopping Cart</h2>
    <h3>View your purchased products.</h3>

    <br />

    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

</asp:Content>
