<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="SCAM.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table class="auto-style2">
        <tr>
            <td>Game</td>
            <td>Wins</td>
            <td>Losses</td>
        </tr>
        <tr>
            <td>Blackjack</td>
            <td>
                <asp:Label ID="lbBlackjackWins" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbBlackjackLosses" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Roulette</td>
            <td>
                <asp:Label ID="lbRouletteWins" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbRouletteLosses" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Slots</td>
            <td>
                <asp:Label ID="lbSlotsWins" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbSlotsLosses" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    Add Credit Card:<br />
    <table cellspacing="1" class="auto-style2">
        <tr>
            <td class="auto-style3">Credit Card Number:</td>
            <td class="auto-style3">
                <asp:TextBox ID="tbCredit" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="rfCredit" runat="server" ControlToValidate="tbCredit" ErrorMessage="You must enter a Credit Card Number"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfName" runat="server" ControlToValidate="tbName" ErrorMessage="You must enter a Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Expiration Date</td>
            <td>
                <asp:TextBox ID="tbDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfDate" runat="server" ControlToValidate="tbDate" ErrorMessage="You must enter a Date"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>CCV:</td>
            <td>
                <asp:TextBox ID="tbCCV" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfCCV" runat="server" ControlToValidate="tbCCV" ErrorMessage="You must enter a CCV"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAddCard" runat="server" OnClick="btnAddCard_Click" Text="Add Card" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
