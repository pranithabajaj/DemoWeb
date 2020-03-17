<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="DemoWeb.First" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="background-color: #C0C0C0" class="auto-style11">
        <tr>
            <td>Empno</td>
            <td><asp:TextBox ID="txtEno" runat="server" clientIDMode="Static"></asp:TextBox></td></tr>
        <tr><td>Ename</td>
            <td><asp:TextBox ID="txtEname" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>Job</td>
            <td><asp:TextBox ID="txtJob" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>Mgr</td>
            <td><asp:TextBox ID="txtMgr" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>Hiredate</td>
            <td>
                <asp:TextBox ID="txtHdate" runat="server" clientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr><td>Sal</td>
            <td><asp:TextBox ID="txtSal" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>Comm</td>
            <td><asp:TextBox ID="txtComm" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>Deptno</td>
            <td><asp:TextBox ID="txtDno" runat="server" clientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr><td>
            <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
            </td></tr>
        
        <tr><td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="return ValidateEmp();"/> </td></tr>
    </table>
</asp:Content>
