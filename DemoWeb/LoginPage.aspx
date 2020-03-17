<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="DemoWeb.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style12">
        <tr>
            <td class="auto-style14" >UserId</td>
            <td class="auto-style15" >
                <asp:TextBox ID="txtUsername" runat="server" ClientIDMode="Static"   ></asp:TextBox></td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ControlToValidate="txtUsername"  ID  ="RequiredFieldValidator1" runat="server" ErrorMessage="Username cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style16">Password</td>
            <td class="auto-style17">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ClientIDMode="Static" ></asp:TextBox></td>
        <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Cannot be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LblMessage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

            </td>

        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="58px" OnClick="btnLogin_Click"  />
            </td>
        </tr>
        </table>
</asp:Content>
