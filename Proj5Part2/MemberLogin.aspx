<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="Proj5Part2.MemberLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Member Login Page</h1>
        <p>Please enter your credentials below:</p>
        <p>
            Username: 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="244px"></asp:TextBox>
        </p>
        <p>
            Password:
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" TextMode="password" runat="server" Height="21px" Width="244px"></asp:TextBox>
        </p>
        
        <div class="checkbox">
             <asp:CheckBox runat="server" ID="RememberMe" />
             <asp:Label runat="server" AssociatedControlID="RememberMe">Remember my credentials</asp:Label>
        </div>
        <p><asp:Button ID="Button1" runat="server" OnClick="LoginFunc" Text="Login" Width="161px" /></p>
        <p><asp:Label ID="lblText" runat="server"></asp:Label></p>
         <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
    </div>
    </form>
</body>
</html>
