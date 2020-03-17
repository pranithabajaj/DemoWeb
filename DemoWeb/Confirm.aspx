<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="DemoWeb.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Empno
            </td>
            <td>
                <asp:Label ID="LblEmpno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Ename
            </td>
            <td>
                <asp:Label ID="LblEname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Job
            </td>
            <td>
                <asp:Label ID="LblJob" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Mgr
            </td>
            <td>
                <asp:Label ID="LblMgr" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                HireDate
            </td>
            <td>
                <asp:Label ID="LblHiredate" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Sal
            </td>
            <td>
                <asp:Label ID="LblSal" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Comm
            </td>
            <td>
                <asp:Label ID="LblComm" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Deptno
            </td>
            <td>
                <asp:Label ID="LblDeptno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
