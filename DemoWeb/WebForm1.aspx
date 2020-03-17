<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/javascript">
        function Validate()
        {
            var eno = document.getElementById("txtEno").value;
            var ename = document.getElementById("txtEname").value;
            var job = document.getElementById("txtJob").value;
            var mgr = document.getElementById("txtMgrid").value;
            var hd = document.getElementById("txtHdate").value;
            var sal = document.getElementById("txtSal").value;
            var comm = document.getElementById("txtComm").value;
            var dno = document.getElementById("txtdno").value;
            if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
                return true;

            else
            {
                alert("enter all details");
                return false;
            }
        }
    </script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 85px;
        }
        .auto-style2 {
            width: 331px;
        }
        .auto-style3 {
            width: 115px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Employee No</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Employee Name</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Job</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtJob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Manager Id</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtMgrid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Hiredate</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtHdate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Salary</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Commission</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtComm" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Deptno</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
            </table>
          </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
