<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Deleteemp.aspx.cs" Inherits="DemoWeb.Deleteemp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/ValidateDel.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Empno
            </td>
            <td>
                <asp:TextBox ID="txtEno" runat="server" clientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
       
        <tr><td>
            <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
            </td></tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="return ValidateDel();"/>
            </td>
        </tr>
    </table>
</asp:Content>
