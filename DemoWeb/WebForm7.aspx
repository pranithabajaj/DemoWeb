<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="DemoWeb.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            width: 74px;
        }
        .auto-style13 {
            width: 83px;
        }
        .auto-style14 {
            width: 84px;
        }
        .auto-style15 {
            width: 430px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" OnPageIndexChanging="FormView1_PageIndexChanging" Width="385px">
        <ItemTemplate>
    <table class="auto-style11">
        <tr>
            <td class="auto-style12">OrderID</td>
            <td class="auto-style13">OrderDesc</td>
            <td class="auto-style14">TotalCost</td>
            <td class="auto-style15">DisAmt</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("OrderID") %>'></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("OrderDesc") %>'></asp:Label>&nbsp;</td>
            <td class="auto-style14">
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("TotalCost") %>'></asp:Label>&nbsp;</td>
            <td class="auto-style15">
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("DisAmt") %>'></asp:Label></td>
        </tr>
    </table>
            </ItemTemplate>
    </asp:FormView>
</asp:Content>
