<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PoePersonalBudget.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact page.</h3>
    <address>
        Seven DouglasDale Drive<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@personalbudgetplan.com">Support@personalbudgetplan.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@personalbudgetplan.com">Marketing@personalbudgetplan.com</a>
    </address>
</asp:Content>
