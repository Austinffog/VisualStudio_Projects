<%@ Page Title="BigPillows" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BigPillows.aspx.cs" Inherits="ProgApp.BigPillows" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Big Pillows</h2>
    <h3>You can search the products of pillows by their color.</h3>

    <br />


<table class="nav-justified">
    <tr>
        <td style="width: 254px">Search...</td>
        <td style="width: 326px">
            <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="174px"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btn_Search" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" OnClick="btn_Search_Click" Text="Search" />
        </td>
    </tr>
    <tr>
        <td style="width: 254px">&nbsp;</td>
        <td style="width: 326px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 254px">&nbsp;</td>
        <td style="width: 326px">
            <asp:GridView ID="GridView1" runat="server" Width="504px">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>

    <br />

    <h3>Fill in the details for the product in which you would like to purchase.</h3>

    <br />

<table class="nav-justified">
    <tr>
        <td>Product Name</td>
        <td>Product Color</td>
        <td>Size</td>
        <td>Quantity</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tb_Color" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tb_Size" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="tb_Quantity" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btn_Purchase" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" OnClick="btn_Purchase_Click" Text="Purchase" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_SuccessMessage" runat="server" ForeColor="#009900" Text="Purchase was a Success!"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lbl_errorMessage" runat="server" ForeColor="#990000" Text="Only customers can make a purchase."></asp:Label>
        </td>
    </tr>
</table>

    <br />

       

<br />
<asp:Label ID="lbl_Total" runat="server" Text="Total number of big pillows ordered = "></asp:Label>

       

</asp:Content>
