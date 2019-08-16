<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SCAM.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 100%;
    }
    .auto-style3 {
        height: 23px;
    }
    .auto-style4 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <table class="auto-style2">
    <tr>
        <td class="auto-style4">Username</td>
        <td class="auto-style4">:
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:RequiredFieldValidator ID="UserValid" runat="server" ControlToValidate="tbUsername" ErrorMessage="You must enter a username"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Password</td>
        <td>:
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="PassValid" runat="server" ControlToValidate="tbPassword" ErrorMessage="You must enter a password"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Confirm Password</td>
        <td class="auto-style3">:
            <asp:TextBox ID="tbConPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style3">
            <asp:CompareValidator ID="passCMP" runat="server" ControlToCompare="tbPassword" ControlToValidate="tbConPassword" ErrorMessage="Passwords must match"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register!" />
        </td>
        <td class="auto-style3">
            <asp:Label ID="lbResult" runat="server"></asp:Label>
        </td>
        <td class="auto-style3">&nbsp;</td>
    </tr>
</table>

</asp:Content>
