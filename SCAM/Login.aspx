<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SCAM.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table class="auto-style2">
        <tr>
            <td>Username</td>
            <td>:
                <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>:&nbsp;<asp:TextBox ID="tbPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login!" />
            </td>
            <td>
                <asp:Label ID="lbResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
