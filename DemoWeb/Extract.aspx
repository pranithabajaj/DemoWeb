<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Extract.aspx.cs" Inherits="DemoWeb.Extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            margin-left: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Enter the deptno:<asp:DropDownList ID="ddlDeptno" runat="server" OnSelectedIndexChanged="ddlDeptno_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Value="-1">SELECT</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style11" OnClick="Button1_Click" Text="Button" />
    </h2>
    <asp:GridView ID="gvData" runat="server"></asp:GridView>
</asp:Content>
