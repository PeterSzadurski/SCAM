<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Slots.aspx.cs" Inherits="SCAM.Slots" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 8px;
        }
        .auto-style2 {
            width: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <style>
                #outer {
            width: 100%;
            text-align:center;
        }
    </style>        
    <div id ="outer">
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Image ID="row0xcol0lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Image ID="row1xcol0lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row2xcol0lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Image ID="row3xcol0lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row4xcol0lbl" runat="server" Width="150px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="row0xcol1lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Image ID="row1xcol1lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row2xcol1lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Image ID="row3xcol1lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row4xcol1lbl" runat="server" Width="150px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="row0xcol2lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Image ID="row1xcol2lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row2xcol2lbl" runat="server" Width="150px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Image ID="row3xcol2lbl" runat="server" Width="150px" />
                    </td>
                    <td>
                        <asp:Image ID="row4xcol2lbl" runat="server" Width="150px" />
                    </td>
                </tr>
            </table>
            <br />
                <asp:TextBox ID="tbBet" runat="server" Font-Size="XX-Large"></asp:TextBox>
            <asp:Button ID="Spinbtn" runat="server" OnClick="Spinbtn_Click" Text="Spin" BackColor="White" BorderColor="Black" Font-Size="XX-Large" />
            <br />
                <asp:Label ID="lbWarning" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLbl" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
</asp:Content>
