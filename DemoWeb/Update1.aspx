<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Update1.aspx.cs" Inherits="DemoWeb.Update1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="background-color: #C0C0C0" class="auto-style11">
        <tr>
            <td>Empno</td>
            <td><asp:TextBox ID="txtEno" runat="server" clientIDMode="Static" AutoPostBack="True" OnTextChanged="txtEno_TextChanged"></asp:TextBox></td></tr>
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
                <asp:TextBox ID="txtHdate" runat="server" clientIDMode="Static" TextMode="Date"></asp:TextBox>
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
            <asp:Button ID="btnSubmit" runat="server" Text="Update" OnClick="btnSubmit_Click" /> 
            </td></tr>
        <tr>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
