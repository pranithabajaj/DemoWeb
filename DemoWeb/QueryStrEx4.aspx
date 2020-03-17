<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStrEx4.aspx.cs" Inherits="DemoWeb.QueryStrEx4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script lang="JavaScript" type="text/javascript">
         function newDoc() {
             window.open("QueryStr5.aspx?A=10&B=20");
         }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="newDoc()" />
        </div>
    </form>
   
</body>
</html>
