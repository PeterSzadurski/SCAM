<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Slots.aspx.cs" Inherits="SCAM.Slots" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
            <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="row0xcol0lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row1xcol0lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row2xcol0lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row3xcol0lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row4xcol0lbl" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="row0xcol1lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row1xcol1lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row2xcol1lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row3xcol1lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row4xcol1lbl" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="row0xcol2lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row1xcol2lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row2xcol2lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row3xcol2lbl" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="row4xcol2lbl" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
                <asp:TextBox ID="tbBet" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Spinbtn" runat="server" OnClick="Spinbtn_Click" Text="Spin" />
                <asp:Label ID="lbWarning" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLbl" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Moneylbl" runat="server" Text="100"></asp:Label>
        </div>
</asp:Content>
