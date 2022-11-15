<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculatePersonalBudget.aspx.cs" Inherits="PoePersonalBudget.Account.CalculatePersonalBudget" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Personal Budget Plan"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ToolTip="Income"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" ToolTip="Tax"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" ToolTip="Groceries"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox4" runat="server" ToolTip="WaterAndLights"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox5" runat="server" ToolTip="Travel"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox6" runat="server" ToolTip="CellphoneAndTelephone"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox7" runat="server" ToolTip="Expences"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Calculate Gross" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Gross Income"></asp:Label>
    <br />


    <asp:Label ID="Label2" runat="server" Text="Rent for Housing"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox8" runat="server" ToolTip="Rental"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Text="Save" OnClick="Button3_Click" />
    <br />

    <asp:Label ID="Label3" runat="server" Text="Pay for Housing"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox9" runat="server" ToolTip="Pay Purchase"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox10" runat="server" ToolTip="Pay Deposit"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox11" runat="server" ToolTip="Pay Interest"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox12" runat="server" ToolTip="Pay Months"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Calculate Pay" OnClick="Button2_Click" />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Total Amount"></asp:Label>
    <br />


    <asp:Label ID="Label4" runat="server" Text="Pay for Vehicle"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox13" runat="server" ToolTip="Vehicle Model"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox14" runat="server" ToolTip="Vehicle Purchase"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox15" runat="server" ToolTip="Vehicle Deposit"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox16" runat="server" ToolTip="Vehicle Interest"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox17" runat="server" ToolTip="Vehicle Insurance"></asp:TextBox>
    <br />
    <asp:Button ID="Button4" runat="server" Text="Calculate Pay" OnClick="Button4_Click" />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Total for Vehicle"></asp:Label>
    <br />


    <asp:Label ID="Label8" runat="server" Text="Save amount"></asp:Label> 
    <br />
    <asp:TextBox ID="TextBox18" runat="server" ToolTip="Amount"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox19" runat="server" ToolTip="Time (months)"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox20" runat="server" ToolTip="Reason"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox21" runat="server" ToolTip="Interest"></asp:TextBox>
    <br />
    <asp:Button ID="Button5" runat="server" Text="Calculate Amount" OnClick="Button5_Click" />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Monthly amount"></asp:Label>
    <br />

  


</asp:Content>
