<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proj5Part2._Default" %>
<%@ Reference Control="TimeNow.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CSE 445: Project 5 Part 2</h1>
        <p class="lead">Integrated members and staff page.</p>
    </div>

    <div class="row">
        <h2>Welcome to our website!</h2>
        <p><asp:PlaceHolder runat="server" ID="TimeControl" /></p>
        <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
        <p>
            Please register and login to gain access to our services:
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Member Register" Width="161px" />&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Member Login" Width="161px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Staff Login" Width="161px" />&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Staff Page" Width="161px" />
        </p>
    </div>

</asp:Content>
