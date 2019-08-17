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
    <script>
        function radioCheck(id) {
            // https://stackoverflow.com/questions/32076944/select-one-gridview-row-with-radio-button-asp-net
            var gridC = document.getElementById('<%=gridCredit.ClientID %>');
            for (var i = 1; i < gridC.rows.length; i++) {
                var radBtn = gridC.rows[i].cells[0].getElementsByTagName("Input");
                
                if (radBtn[0].id != id.id) {
                    radBtn[0].checked = false;
                }
            }

        }
    </script>
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
                <asp:TextBox ID="tbCredit" runat="server" TextMode="Number" MaxLength="10"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="rfCredit" runat="server" ControlToValidate="tbCredit" ErrorMessage="You must enter a Credit Card Number" ValidationGroup="AddCard"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="tbName" runat="server" MaxLength="50"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfName" runat="server" ControlToValidate="tbName" ErrorMessage="You must enter a Name" ValidationGroup="AddCard"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Expiration Date</td>
            <td>
                <asp:TextBox ID="tbDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfDate" runat="server" ControlToValidate="tbDate" ErrorMessage="You must enter a Date" ValidationGroup="AddCard"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>CCV:</td>
            <td>
                <asp:TextBox ID="tbCCV" runat="server" TextMode="Number" MaxLength="3"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfCCV" runat="server" ControlToValidate="tbCCV" ErrorMessage="You must enter a CCV" ToolTip="The 3-digit number on the back of the card." ValidationGroup="AddCard"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAddCard" runat="server" OnClick="btnAddCard_Click" Text="Add Card" ValidationGroup="AddCard" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lbResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <table cellspacing="1" class="auto-style2">
        <tr>
            <td>
    <asp:GridView ID="gridCredit" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                <asp:RadioButton ID="rowSelector" runat="server" GroupName="rowGroup" onclick ="radioCheck(this)"/>
                    
            </ItemTemplate>

                    </asp:TemplateField>

            <asp:BoundField DataField ="name" HeaderText ="Name" />
            <asp:BoundField DataField ="number" HeaderText ="Number" />
            <asp:BoundField DataField ="expiration" HeaderText ="Expiration Date" />
            <asp:BoundField DataField ="ccv" HeaderText ="CCV" />

        </Columns>

    </asp:GridView>
            </td>
            <td>
                <asp:TextBox ID="tbPay" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDeleteCard" runat="server" OnClick="btnDeleteCard_Click" Text="Delete Card" />
            </td>
            <td>
                <asp:Button ID="btnPayWithCard" runat="server" Text="Pay With Card" OnClick="btnPayWithCard_Click" />
            </td>
        </tr>
    </table>
    <br />
    </asp:Content>
