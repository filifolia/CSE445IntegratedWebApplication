<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Proj5Part2.Staffs.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Staff Master Page</h1>
        <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> <br />
        This page can only be viewed by registered staff member.<br /> 

    </div>
    </form>
</body>
</html>
