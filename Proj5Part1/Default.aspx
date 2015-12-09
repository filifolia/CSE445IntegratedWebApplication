<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proj5Part1._Default" %>
<%@ Register TagPrefix = "date" TagName="Date" src="TimeNow.ascx" %>
<%@ Reference Control="TimeNow.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="margin-left: 22px">
        <h1>*TryIt Page - Assignment 5</h1>
        <p>Service Directory: Web application components</p>
    </div>
    <div class="row" style="margin-left: 22px">
        On-page cookie loading/unloading controls<br />
        [Provider: Kathleen Anderson]<br />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Reload Form Cookies" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Clear Form Cookies" />
        <br />
        </div>
    <div class="row" style="margin-left: 22px">
            <h3>Word Filter - Web Service</h3>
            <p>
                Manipulate input string as it removes stop words and removes any attribute or element types inside <> brackets
            </p>
            
            <p>[Provider: William Minar Widjaja]</p>
            <p>
                Input: string, Output: string
            </p>
            <p>
                Input a string here:</p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INVOKE" Width="261px" />
            </p>
            <p>
                The modified string :
                </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="(Please input a string first)" BackColor="#99FFCC"></asp:Label>
            </p>
    </div>

    <div class="row" style="margin-left: 22px">
            <h3>Global asax - Event Handler</h3>
            <p>[Provider: William Minar Widjaja]</p>
            <p>
                Display the number of visits to the page
            </p>
            <p>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="INVOKE" Width="261px" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="The number of visits: "></asp:Label>
                <asp:Label ID="hitDisplayLabel" runat="server" BackColor="#99FFCC" Text="[# hits]"></asp:Label>
            </p>
            <p> Another global event handler: Error handling. </p>
            <p> [Provider: William Minar Widjaja]</p>
            <p> Redirects the page to Error.aspx if unhandled error occurs.</p>
            <p>&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Invoke an error" Width="261px" />&nbsp;</p>
    </div>
    <div class="row" style="margin-left: 22px">
            <h3>Encryption &amp; Decryption - DLL Component</h3>
            <p>
                Encrypt or decrypt a given input</p>
            <p>[Provider: William Minar Widjaja]</p>
            <p>Input: string, Output: string</p>
            <p>
                Turn String to Hashcode: 
                &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;
                &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Get Hashcode" Width="261px" />
            </p>
            <p>
                Hashcode:&nbsp;
                &nbsp;<asp:Label ID="Label3" runat="server" Text="(Please input a word first)" BackColor="#99FFCC"></asp:Label>&nbsp;
            </p>
            <p>
                Turn Hashcode to String: 
                &nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;
                &nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get String" Width="261px" />&nbsp;
                </p>
            <p>
                String: &nbsp;<asp:Label ID="Label4" runat="server" Text="(Please input a word first)" BackColor="#99FFCC"></asp:Label>&nbsp;
            </p>
    </div>
    <div class="row" style="margin-left: 22px">
            <h3>User Control</h3>
            <p>
                Display the time when the page is accessed</p>
            <p>
                [Provider: William Minar Widjaja]</p>
            <p><asp:PlaceHolder runat="server" ID="TimeControl" /></p>
    </div>
     <div class="row" style="margin-left: 22px">
            <h3>XML Manipulation</h3>
            <p>
                Able to add new elements to Members.xml and search existing elements</p>
            <p>
                [Provider: William Minar Widjaja]</p>
            <p>Enter a username&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;</p>
            <p>Enter a password&nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;</p>
            <p>&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Create Account" Width="261px" />&nbsp;</p>
            &nbsp;<asp:Label ID="Label5" runat="server" Text="(Waiting for an action...)" BackColor="#99FFCC"></asp:Label>&nbsp;
            <p></p>
            <p>Search for any existing element with the matching name</p>
            <p>[Provider: William Minar Widjaja]</p>
            <p>Enter a username&nbsp;<asp:TextBox ID="TextBox6" runat="server" Height="21px" Width="244px"></asp:TextBox>&nbsp;</p>
            <p>&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Search" Width="261px" />&nbsp;</p>
            <p>&nbsp;<asp:Label ID="Label6" runat="server" Text="(Waiting for an action...)" BackColor="#99FFCC"></asp:Label>&nbsp;</p>

    </div>

</asp:Content>
