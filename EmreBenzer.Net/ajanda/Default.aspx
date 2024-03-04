<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication16.postakodu.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmreBenzer.Net | Ajanda</title>
    <style>
        .bilgi
        {
            font-size:12px;

        }

        .deger
        {
            color:Red;
        }



    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 542px;margin-left:40px;font-family:Calibri"><br />
        POSTA KODU, TELEFON KODU VE PLAKA ÖĞRENME ARACI
        <br /><br /><br />
    İl: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="drpsehirler" runat="server" Height="21px" AutoPostBack="true" OnSelectedIndexChanged="drpsehirler_SelectedIndexChanged" Width="189px">
        </asp:DropDownList>&nbsp;&nbsp;<asp:Label Text="Telefon Kodu: " ID="lblTelefonBilgi" CssClass="bilgi" Visible="false" runat="server" /> <asp:Label ID="telefon" runat="server" CssClass="deger" />&nbsp;&nbsp;<asp:Label Text="Plaka No: " ID="lblPlakaBilgi" CssClass="bilgi" Visible="false" runat="server" /> <asp:Label ID="plaka" runat="server" CssClass="deger" /><br /><br />
        İlçe: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ilceler" AutoPostBack="true" OnSelectedIndexChanged="ilceler_SelectedIndexChanged" runat="server" Height="21px" Width="189px">
        </asp:DropDownList><br /><br />
        Mahalle: &nbsp;<asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="mahalle_SelectedIndexChanged" ID="mahalle" runat="server" Width="189px" Height="21px">
            
        </asp:DropDownList><br /><br />
        <span class="bilgi">Posta Kodu:</span> <asp:Label ID="posta" CssClass="deger" runat="server" />
        <br />
        <br />
        <br />
        <br />
        İLLER ARASI MESAFE ÖLÇÜMÜ (KM)<br />
        <br />
        <asp:DropDownList ID="sehir1" runat="server" Height="34px" Width="242px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="sehir2" runat="server" Height="34px" Width="241px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mesafe Ölç" Height="34px" Width="123px" />
        <br />
        <br />
        <asp:Label Text="İki İl Arası Mesafe: " CssClass="bilgi" runat="server" />  <asp:Label ID="lblMesafe" CssClass="deger" runat="server"></asp:Label>
    </div>
<br/><br/><br/><center>
Ne kadar yardımcı olursanız o kadar fazla araç gelir.
<br/><br/>
<a href="http://www.havanemlendir.com/oren.php?cid=A9690213A16F4949AD320549D4C13CC6&did=A2T3&utm_source=Affiliate%20Engineer&utm_medium=Affiliate%20Engineer&utm_campaign=Affiliate%20Engineer"><img src="reklam.jpg"/></a>
    </form>
</body>
</html>
