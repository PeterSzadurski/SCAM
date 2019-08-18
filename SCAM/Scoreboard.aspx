<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Scoreboard.aspx.cs" Inherits="SCAM.Scoreboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Username" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="True" SortExpression="Username" />
                <asp:BoundField DataField="BlackjackWins" HeaderText="BlackjackWins" SortExpression="BlackjackWins" />
                <asp:BoundField DataField="RouletteWins" HeaderText="RouletteWins" SortExpression="RouletteWins" />
                <asp:BoundField DataField="BlackJackLosses" HeaderText="BlackJackLosses" SortExpression="BlackJackLosses" />
                <asp:BoundField DataField="SlotWins" HeaderText="SlotWins" SortExpression="SlotWins" />
                <asp:BoundField DataField="RouletteLosses" HeaderText="RouletteLosses" SortExpression="RouletteLosses" />
                <asp:BoundField DataField="SlotLosses" HeaderText="SlotLosses" SortExpression="SlotLosses" />
                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="Money" HeaderText="Money" SortExpression="Money" />
                <asp:BoundField DataField="RegistrationDate" HeaderText="RegistrationDate" SortExpression="RegistrationDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ScamProjectConnectionString %>" SelectCommand="SELECT [Username], [BlackjackWins], [RouletteWins], [BlackJackLosses], [SlotWins], [RouletteLosses], [SlotLosses], [Role], [Money], [RegistrationDate] FROM [Accounts]"></asp:SqlDataSource>
    </p>
</asp:Content>
