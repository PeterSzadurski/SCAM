<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Blackjack.aspx.cs" Inherits="SCAM.Blackjack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
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



        <div>
            <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" BackColor="White" BorderColor="Black" Font-Size="XX-Large" />
                        <asp:TextBox ID="tbBet" runat="server" Font-Size="XX-Large" Height="48px"></asp:TextBox>
            <br />
            <br />
        <div class ="hand-container" id="dealerContainer" runat="server">
            <asp:Image ID="dCard0" runat="server" Height="230px" />
            <asp:Image ID="dCard1" runat="server" Height="230px" />
            <asp:Image ID="dCard2" runat="server" Height="230px" />
            <asp:Image ID="dCard3" runat="server" Height="230px" />
            <asp:Image ID="dCard4" runat="server" Height="230px" />
            <asp:Image ID="dCard5" runat="server" Height="230px" />
            <asp:Image ID="dCard6" runat="server" Height="230px" />
            <br />
&nbsp;<asp:Button ID="btnStay" runat="server" OnClick="btnStay_Click" Text="Stay" Visible="False" BackColor="White" BorderColor="Black" Font-Size="XX-Large" Height="121px" Width="172px" />
                        <asp:Button ID="btnHit" runat="server" OnClick="btnHit_Click" Text="Hit" Visible="False" BackColor="White" BorderColor="Black" Font-Size="XX-Large" Height="121px" Width="200px" />
                        <asp:Button ID="btnDoubleDown" runat="server" OnClick="btnDoubleDown_Click" Text="Double Down" Visible="False" BackColor="White" BorderColor="Black" Font-Size="XX-Large" Height="121px" />
                    &nbsp;
            <asp:Label ID="lbWin" runat="server" Font-Size="XX-Large"></asp:Label>
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

</asp:Content>
