﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Owner.aspx.cs" Inherits="SCAM.Owner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Username" DataSourceID="Accounts" AllowSorting="True">
    <Columns>
        <asp:BoundField DataField="RegistrationDate" HeaderText="RegistrationDate" SortExpression="RegistrationDate" />
        <asp:BoundField DataField="Money" HeaderText="Money" SortExpression="Money" />
        <asp:BoundField DataField="SlotLosses" HeaderText="SlotLosses" SortExpression="SlotLosses" />
        <asp:BoundField DataField="RouletteLosses" HeaderText="RouletteLosses" SortExpression="RouletteLosses" />
        <asp:BoundField DataField="BlackJackLosses" HeaderText="BlackJackLosses" SortExpression="BlackJackLosses" />
        <asp:BoundField DataField="SlotWins" HeaderText="SlotWins" SortExpression="SlotWins" />
        <asp:BoundField DataField="RouletteWins" HeaderText="RouletteWins" SortExpression="RouletteWins" />
        <asp:BoundField DataField="BlackjackWins" HeaderText="BlackjackWins" SortExpression="BlackjackWins" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
        <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="True" SortExpression="Username" />
        <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="Accounts" runat="server" ConnectionString="<%$ ConnectionStrings:ScamProjectConnectionString %>" SelectCommand="SELECT [RegistrationDate], [Money], [SlotLosses], [RouletteLosses], [BlackJackLosses], [SlotWins], [RouletteWins], [BlackjackWins], [Password], [Username], [Role] FROM [Accounts]"></asp:SqlDataSource>
</asp:Content>
