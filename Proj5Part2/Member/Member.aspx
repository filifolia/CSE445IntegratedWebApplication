<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Proj5Part2.Member.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Member Page</h1>
        <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> <br />
        
        <p> Welcome to your user page!</p>
        <p>You are welcome to use this string manipulation service </p>
        <p>Input a sentence and this service will remove all the stop words inside your input.</p>
            <p>
                Input a string here:</p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="416px"></asp:TextBox>&nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INVOKE" Width="426px" />
            </p>
            <p>
                The modified string :
                </p>
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
        <p><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" Width="75px" /></p>

    </div>
    </form>
</body>
</html>
