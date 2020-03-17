<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="DemoWeb.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td class="auto-style14">
        <asp:RadioButton ID="rdbHiredate" runat="server" GroupName="G1" Text="Joining Date" OnCheckedChanged="rdbHiredate_CheckedChanged" AutoPostBack="True" />
        </td>
        <td class="auto-style11">
            <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>and
            
            <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
        </td></tr>
    <tr><td class="auto-style12">
        <asp:RadioButton ID="rdbDeptno" runat="server" GroupName="G1" Text="Deptno" AutoPostBack="True" OnCheckedChanged="rdbDeptno_CheckedChanged" />
        </td><td class="auto-style13">
            <asp:DropDownList ID="ddlDeptno" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">SELECT</asp:ListItem>
            </asp:DropDownList>
        </td></tr>
        <tr><td>
            <asp:Button ID="btnExtract" runat="server" Text="Extract" OnClick="btnExtract_Click" /></td></tr>
        <tr><td>
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </td></tr>
    </table>
</asp:Content>
