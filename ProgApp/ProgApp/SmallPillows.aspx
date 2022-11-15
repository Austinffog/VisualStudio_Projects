<%@ Page Title="SmallPillows" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SmallPillows.aspx.cs" Inherits="ProgApp.SmallPillows" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Small Pillows</h2>
    <h3>Search your favourite small pillows by name.</h3>

    <table class="nav-justified">
        <tr>
            <td style="width: 271px">Search...</td>
            <td style="width: 408px">
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="249px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btn_Search" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" OnClick="btn_Search_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td style="width: 271px">&nbsp;</td>
            <td style="width: 408px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 271px">&nbsp;</td>
            <td style="width: 408px">
                <asp:GridView ID="GridView1" runat="server" Width="418px">
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
                <asp:TextBox ID="tb_ProductName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="tb_ProductColor" runat="server"></asp:TextBox>
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
                <asp:Label ID="lbl_errorMessage" runat="server" ForeColor="#990000" Text="Only customers can make a purchase!"></asp:Label>
            </td>
        </tr>
    </table>

    <br />

    <br />
    <asp:Label ID="lbl_Total" runat="server" Text="Total number of small pillows ordered = "></asp:Label>

</asp:Content>
