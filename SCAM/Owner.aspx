<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Owner.aspx.cs" Inherits="SCAM.Owner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Username" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="True" SortExpression="Username" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="BlackjackWins" HeaderText="BlackjackWins" SortExpression="BlackjackWins" />
            <asp:BoundField DataField="RouletteWins" HeaderText="RouletteWins" SortExpression="RouletteWins" />
            <asp:BoundField DataField="SlotWins" HeaderText="SlotWins" SortExpression="SlotWins" />
            <asp:BoundField DataField="BlackJackLosses" HeaderText="BlackJackLosses" SortExpression="BlackJackLosses" />
            <asp:BoundField DataField="RouletteLosses" HeaderText="RouletteLosses" SortExpression="RouletteLosses" />
            <asp:BoundField DataField="SlotLosses" HeaderText="SlotLosses" SortExpression="SlotLosses" />
            <asp:BoundField DataField="Money" HeaderText="Money" SortExpression="Money" />
            <asp:BoundField DataField="RegistrationDate" HeaderText="RegistrationDate" SortExpression="RegistrationDate" />
            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ScamProjectConnectionString %>" DeleteCommand="DELETE FROM [Accounts] WHERE [Username] = @Username" InsertCommand="INSERT INTO [Accounts] ([Username], [Password], [BlackjackWins], [RouletteWins], [SlotWins], [BlackJackLosses], [RouletteLosses], [SlotLosses], [Money], [RegistrationDate], [Role]) VALUES (@Username, @Password, @BlackjackWins, @RouletteWins, @SlotWins, @BlackJackLosses, @RouletteLosses, @SlotLosses, @Money, @RegistrationDate, @Role)" SelectCommand="SELECT * FROM [Accounts]" UpdateCommand="UPDATE [Accounts] SET [Password] = @Password, [BlackjackWins] = @BlackjackWins, [RouletteWins] = @RouletteWins, [SlotWins] = @SlotWins, [BlackJackLosses] = @BlackJackLosses, [RouletteLosses] = @RouletteLosses, [SlotLosses] = @SlotLosses, [Money] = @Money, [RegistrationDate] = @RegistrationDate, [Role] = @Role WHERE [Username] = @Username">
        <DeleteParameters>
            <asp:Parameter Name="Username" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="BlackjackWins" Type="Int32" />
            <asp:Parameter Name="RouletteWins" Type="Int32" />
            <asp:Parameter Name="SlotWins" Type="Int32" />
            <asp:Parameter Name="BlackJackLosses" Type="Int32" />
            <asp:Parameter Name="RouletteLosses" Type="Int32" />
            <asp:Parameter Name="SlotLosses" Type="Int32" />
            <asp:Parameter Name="Money" Type="Decimal" />
            <asp:Parameter DbType="Date" Name="RegistrationDate" />
            <asp:Parameter Name="Role" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="BlackjackWins" Type="Int32" />
            <asp:Parameter Name="RouletteWins" Type="Int32" />
            <asp:Parameter Name="SlotWins" Type="Int32" />
            <asp:Parameter Name="BlackJackLosses" Type="Int32" />
            <asp:Parameter Name="RouletteLosses" Type="Int32" />
            <asp:Parameter Name="SlotLosses" Type="Int32" />
            <asp:Parameter Name="Money" Type="Decimal" />
            <asp:Parameter DbType="Date" Name="RegistrationDate" />
            <asp:Parameter Name="Role" Type="String" />
            <asp:Parameter Name="Username" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
