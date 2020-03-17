<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DemoWeb.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>One</asp:ListItem>
                    <asp:ListItem>Two</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> and
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
    </table>
</asp:Content>
