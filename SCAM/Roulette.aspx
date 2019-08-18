<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Roulette.aspx.cs" Inherits="SCAM.Roulette" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 101%;
            height: 351px;
        }
        .auto-style13 {
            width: 60px;
            height: 71px;
        }
        .auto-style16 {
            height: 70px;
        }
        .auto-style17 {
            height: 71px;
        }
        .auto-style18 {
            width: 50px;
        }
        .auto-style20 {
            height: 70px;
            width: 62px;
        }
        .auto-style21 {
            height: 70px;
            width: 63px;
        }
        .auto-style22 {
            height: 70px;
            width: 61px;
        }
        .auto-style24 {
            height: 70px;
            width: 60px;
        }
        .auto-style25 {
            width: 60px;
        }
    </style>


            <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style18" rowspan="5" aria-invalid="grammar" style="background-color: #008000; color: #FFFFFF">
                        <asp:CheckBox ID="cb0" runat="server" Text="0" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb3" runat="server" Text="3" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb6" runat="server" Text="6" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb9" runat="server" Text="9" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb12" runat="server" Text="12" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb15" runat="server" Text="15" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb18" runat="server" Text="18" />
                    </td>
                    <td class="auto-style21" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb21" runat="server" Text="21" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb24" runat="server" Text="24" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb27" runat="server" Text="27" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb30" runat="server" Text="30" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb33" runat="server" Text="33" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb36" runat="server" Text="36" />
                    </td>
                    <td class="auto-style24" aria-invalid="grammar" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small; ">
                        <asp:CheckBox ID="cbs0" runat="server" Text="2 To 1" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb2" runat="server" Text="2" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb5" runat="server" Text="5" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb8" runat="server" Text="8" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb11" runat="server" Text="11" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb14" runat="server" Text="14" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb17" runat="server" Text="17" />
                    </td>
                    <td class="auto-style21" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb20" runat="server" Text="20" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb23" runat="server" Text="23" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb26" runat="server" Text="26" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb29" runat="server" Text="29" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb32" runat="server" Text="32" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb35" runat="server" Text="35" />
                    </td>
                    <td class="auto-style24" aria-invalid="grammar" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small; ">
                        <asp:CheckBox ID="cbs1" runat="server" Text="2 To 1" />
                    </td>
                </tr>
                <tr>
                    <td aria-invalid="grammar" class="auto-style20" style="color: #FFFFFF; background-color: #FF0000;">
                        <asp:CheckBox ID="cb1" runat="server" Text="1" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;" class="auto-style20">
                        <asp:CheckBox ID="cb4" runat="server" Text="4" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;" class="auto-style20">
                        <asp:CheckBox ID="cb7" runat="server" Text="7" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;" class="auto-style20">
                        <asp:CheckBox ID="cb10" runat="server" Text="10" />
                    </td>
                    <td class="auto-style20" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb13" runat="server" Text="13" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;" class="auto-style20">
                        <asp:CheckBox ID="cb16" runat="server" Text="16" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;" class="auto-style21">
                        <asp:CheckBox ID="cb19" runat="server" Text="19" />
                    </td>
                    <td class="auto-style22" aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;">
                        <asp:CheckBox ID="cb22" runat="server" Text="22" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;" class="auto-style22">
                        <asp:CheckBox ID="cb25" runat="server" Text="25" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;" class="auto-style22">
                        <asp:CheckBox ID="cb28" runat="server" Text="28" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #000000;" class="auto-style20">
                        <asp:CheckBox ID="cb31" runat="server" Text="31" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #FF0000;" class="auto-style22">
                        <asp:CheckBox ID="cb34" runat="server" Text="34" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small; " class="auto-style25">
                        <asp:CheckBox ID="cbs2" runat="server" Text="2 To 1" />
                    </td>
                </tr>
                <tr>
                    <td aria-invalid="grammar" colspan="4" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;" class="auto-style16">
                        <asp:CheckBox ID="cbs3" runat="server" Text="1st 12" />
                    </td>
                    <td aria-invalid="grammar" colspan="4" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;" class="auto-style16">
                        <asp:CheckBox ID="cbs4" runat="server" Text="2nd 12" />
                    </td>
                    <td aria-invalid="grammar" colspan="4" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;" class="auto-style16">
                        <asp:CheckBox ID="cbs5" runat="server" Text="3rd 12" />
                    </td>
                    <td aria-invalid="grammar" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small; " class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td aria-invalid="grammar" class="auto-style17" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs6" runat="server" Text="1 - 18" />
                    </td>
                    <td aria-invalid="grammar" class="auto-style17" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs7" runat="server" Text="Even" />
                    </td>
                    <td class="auto-style17" aria-invalid="grammar" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs8" runat="server" BackColor="Black" ForeColor="White" Text="Black" />
                    </td>
                    <td aria-invalid="grammar" class="auto-style17" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs9" runat="server" BackColor="Red" ForeColor="White" Text="Red" />
                    </td>
                    <td aria-invalid="grammar" class="auto-style17" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs10" runat="server" Text="Odd" />
                    </td>
                    <td aria-invalid="grammar" class="auto-style17" colspan="2" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small;">
                        <asp:CheckBox ID="cbs11" runat="server" Text="19 - 36" />
                    </td>
                    <td aria-invalid="grammar" class="auto-style13" style="color: #FFFFFF; background-color: #008000; font-family: 'Berlin Sans FB'; font-size: small; ">
                    </td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbBet" runat="server" Height="42px"></asp:TextBox>
                &nbsp;<asp:Button ID="SpinButton" runat="server" OnClick="SpinButton_Click" Text="Spin" BackColor="#00CC00" Font-Bold="True" Font-Size="XX-Large" />
            <br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="resultLbl" runat="server" Font-Bold="True" Font-Size="XX-Large"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblNumberRolled" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Number Rolled:"></asp:Label>

            &nbsp;<asp:Label ID="RouletteNumberlbl" runat="server" Text="0" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Money Left: $"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Moneylbl" runat="server" Text="100" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            <br />
        </div>
</asp:Content>
