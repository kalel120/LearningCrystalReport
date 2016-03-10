<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Dataedge.Report.LearningCrystalReport.Default" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        <asp:Button ID="btntakeInput" runat="server" Text="Take Parameter" />
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="True" ToolPanelWidth="200px" Width="350px" />
    <br />
    <asp:Label ID="lblShowValue" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlSelectValue" runat="server">
        <asp:ListItem>1000</asp:ListItem>
        <asp:ListItem>2000</asp:ListItem>
        <asp:ListItem>3000</asp:ListItem>
    </asp:DropDownList>
</asp:Content>
