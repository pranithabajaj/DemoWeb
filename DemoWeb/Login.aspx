<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/LoginValidations.js"></script>
    
    <style type="text/css">
        .auto-style11 {
            width: 377px;
            height: 149px;
        }
        .auto-style12 {
            margin-left: 80px;
        }
        .auto-style13 {
            height: 37px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style15 {
            height: 37px;
            width: 169px;
        }
        .auto-style16 {
        width: 169px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style11" >
       <tr>
           <td class="auto-style15">Username</td>
           <td class="auto-style13">
               <asp:TextBox ID="txtUname" runat="server" clientIDMode="Static" CssClass="auto-style14" Width="190px"></asp:TextBox>

           </td>
           </tr>
       <tr>
           <td class="auto-style16">Password</td>
           <td class="auto-style12">
               <asp:TextBox ID="txtPwd" runat="server" clientIDMode="Static" OnTextChanged="txtPwd_TextChanged" TextMode="Password" Width="188px"></asp:TextBox>

           </td>
       </tr>

       <tr>
            <td class="auto-style16">
                <asp:Label ID="LblMsg" runat="server" ForeColor="#CC0000"></asp:Label>
            </td>
       </tr>
       <tr>
            <td class="auto-style16">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="57px" OnClientClick="return Validate();"/></td>
       </tr>
   </table>
</asp:Content>
