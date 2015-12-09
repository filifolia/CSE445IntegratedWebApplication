<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="Proj5Part2.MemberRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Member Registration Page</h1>
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
        <p>
            Confirm Password:
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" TextMode="password" runat="server" Height="21px" Width="244px"></asp:TextBox>
        </p>
        <p><asp:Image ID="verify" runat="server" Enabled="True" ImageUrl="http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/Hc6sd"></asp:Image></p>
        <p>Verify the image: &nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="244px"></asp:TextBox>
        </p>
        <p><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" Width="161px" /></p>
        <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
        <p><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Homepage" Width="161px" /></p>
    </div>
    </form>
</body>
</html>
