<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlackJack.aspx.cs" Inherits="SCAM.BlackJack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" />
            <table class="auto-style1">
                <tr>
                    <td>Player</td>
                    <td>Dealer</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="playerTable" runat="server">
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:GridView ID="dealerTable" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnHit" runat="server" OnClick="btnHit_Click" Text="Hit" />
                    &nbsp;
                        <asp:Button ID="btnDoubleDown" runat="server" OnClick="btnDoubleDown_Click" Text="Double Down" />
                    </td>
                    <td>
                        <asp:Button ID="btnStay" runat="server" OnClick="btnStay_Click" Text="Stay" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tbMoney" runat="server"></asp:TextBox>
                    </td>
                    <td>
            <asp:Label ID="lbMoney" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbPlayerMoney" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbDealerMoney" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lbWin" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
