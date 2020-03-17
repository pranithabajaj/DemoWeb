<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerEx1.aspx.cs" Inherits="DemoWeb.ServerEx1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Server Variables<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Application Variables<asp:TextBox ID="TextBox2" runat="server" Width="147px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
