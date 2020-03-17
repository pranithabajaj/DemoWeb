<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="DemoWeb.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Empno

            </td>
            <td>
                <asp:TextBox ID="TxtEno" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Empno cannot be blank" ControlToValidate="TxtEno" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Ename

            </td>
            <td>
                <asp:TextBox ID="TxtEname" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ename cannot be blank" ControlToValidate="TxtEname" ForeColor="Red" Visible="True" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox ID="Txtpwd" runat="server" TextMode="Password"></asp:TextBox>

            </td>
           
        </tr>
        <tr>
            <td>
                Confirm Password
            </td>
            <td>
                <asp:TextBox ID="Txtconpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
             <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password doesnot match" ControlToCompare="Txtpwd" ControlToValidate="Txtconpwd" ForeColor="Red" Display="None"></asp:CompareValidator>

            </td>
            
        </tr>
        <tr>
            <td>
                Salary
            </td>
            <td>
                <asp:TextBox ID="Txtsal" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="salary between 10000 and 200000" ControlToValidate="Txtsal" ForeColor="Red" MaximumValue="200000" MinimumValue="10000" Type="Double" Display="None"></asp:RangeValidator>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Salary cannot be blank" ControlToValidate="Txtsal" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Pancard
            </td>
            <td>
                <asp:TextBox ID="Txtpan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid pan number" ControlToValidate="Txtpan" ForeColor="Red" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Date of birth
            </td>
            <td>
                <asp:TextBox ID="Txtdob" TextMode="Date" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Age must be between 21-58" ControlToValidate="Txtdob" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" Display="None"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
            
        </tr>
        
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
</asp:Content>
