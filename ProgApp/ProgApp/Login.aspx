<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProgApp.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>

    <asp:Button ID="btn_Logout" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" OnClick="btn_Logout_Click" Text="Logout" />

    <br />

    <table class="nav-justified">
        <tr>
            <td style="width: 252px">Username</td>
            <td>
                <asp:TextBox ID="tb_Username" runat="server" Font-Size="Medium" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 252px">Email</td>
            <td>
                <asp:TextBox ID="tb_Email" runat="server" Font-Size="Medium" Width="179px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 252px">Employee/Customer</td>
            <td>
                <asp:TextBox ID="tb_Role" runat="server" Font-Size="Medium" Width="179px" OnTextChanged="tb_Role_TextChanged">Employee/Customer</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 252px">Password</td>
            <td>
                <asp:TextBox ID="tb_Password" runat="server" Font-Size="Medium" TextMode="Password" Width="178px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 252px">
                <asp:Button ID="btn_Login" runat="server" BackColor="#00CCFF" BorderColor="#FF0066" OnClick="btn_Login_Click" Text="Login" />
            </td>
            <td>
                <asp:Label ID="lbl_ErrorMessage" runat="server" ForeColor="#CC0000" Text="Incorrect User Credentials"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
