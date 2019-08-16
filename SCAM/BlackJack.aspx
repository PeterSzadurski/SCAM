<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlackJack.aspx.cs" Inherits="SCAM.BlackJack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        
.hand-container {
  display: float;
  

}
.card-item {

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
            <br />
        <div class ="hand-container" id="dealerContainer" runat="server">
            <asp:Image ID="dCard0" runat="server" Height="230px" />
            <asp:Image ID="dCard1" runat="server" Height="230px" />
            <asp:Image ID="dCard2" runat="server" Height="230px" />
            <asp:Image ID="dCard3" runat="server" Height="230px" />
            <asp:Image ID="dCard4" runat="server" Height="230px" />
            <asp:Image ID="dCard5" runat="server" Height="230px" />
            <asp:Image ID="dCard6" runat="server" Height="230px" />
        </div>
        </div>
        <div class ="hand-container" id="playerContainer" runat="server">
            <asp:Image ID="pCard0" runat="server" Height="230px" />
            <asp:Image ID="pCard1" runat="server" Height="230px" />
            <asp:Image ID="pCard2" runat="server" Height="230px" />
            <asp:Image ID="pCard3" runat="server" Height="230px" />
            <asp:Image ID="pCard4" runat="server" Height="230px" />
            <asp:Image ID="pCard5" runat="server" Height="230px" />
            <asp:Image ID="pCard6" runat="server" Height="230px" />
        </div>
        <div class ="hand-container" id="splitContainer" runat="server">
            <asp:Image ID="sCard0" runat="server" Height="230px" />
            <asp:Image ID="sCard1" runat="server" Height="230px" />
            <asp:Image ID="sCard2" runat="server" Height="230px" />
            <asp:Image ID="sCard3" runat="server" Height="230px" />
            <asp:Image ID="sCard4" runat="server" Height="230px" />
            <asp:Image ID="sCard5" runat="server" Height="230px" />
            <asp:Image ID="sCard6" runat="server" Height="230px" />
        </div>
    </form>
</body>
</html>
