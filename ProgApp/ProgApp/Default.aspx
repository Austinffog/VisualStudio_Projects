<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProgApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--Heading-->
    <div>
        <div style="font-size: x-large" align="center">Pillow Ecommerce Store</div>
    </div>

    <br />

    <!--Sub Heading-->
    <div>
        <div style="font-size: medium" align="center">Categories</div>
    </div>

    <br />

    <div>

        <!--First Button- category for big pillows-->
        <asp:Button ID="btn_BigPillow" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" Text="Big Pillows" align="left" OnClick="btn_BigPillow_Click" />

        <!--Second Button- category for small pillows-->
        <asp:Button ID="btn_SmlPillow" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" Text="Small Pillows" align="right" OnClick="btn_SmlPillow_Click" />

    </div>

</asp:Content>
