<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmreBenzer.Net Dolar Hesaplama Aracı</title>
    <style type="text/css">
        .auto-style1 {
            width: 111px;
            border:solid 1px #808080;
        }
        .auto-style2 {
            width: 119px;
            border: solid 1px #808080;
        }
        .auto-style3 {
            width: 60px;
            border: solid 1px #808080;
        }

        .sonuc {
        
            color:#55be0d;
            font-size:14px;
            font-family:Calibri;
            font-weight:bold;
        
        }
        .baslik {

            font-size:14px;
            font-family:Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
        <b>MERKEZ BANKASI DÖVİZ HESAPLAMA ARACI</b><br />
        <br />
    
        <table style="border:solid 1px #808080" cellpadding="5">
            <tr style="border:solid 1px #808080">
                <td class="auto-style3"></td>
                <td class="auto-style1">Alış</td>
                <td class="auto-style2">Satış</td>
                <td class="auto-style1">Efektif Alış</td>
                <td class="auto-style2">Efektif Satış</td>
            </tr>
            <tr style="border:solid 1px #808080">
                <td class="auto-style3"><b>Dolar:</b></td>
                <td class="auto-style1">
                    <asp:Label Text="" ID="lblDolarAlis" runat="server" /></td>
                <td class="auto-style2"><asp:Label Text="" ID="lblDolarSatis" runat="server" /></td>
                <td class="auto-style1">
                    <asp:Label Text="" ID="lblDolarEfektifAlis" runat="server" /></td>
                <td class="auto-style2"><asp:Label Text="" ID="lblDolarEfektifSatis" runat="server" /></td>
            </tr>
            <tr style="border:solid 1px #808080">
                <td class="auto-style3"><b>Euro:</b></td>
                <td class="auto-style1"><asp:Label Text="" ID="lblEuroAlis" runat="server" /></td>
                <td class="auto-style2"><asp:Label Text="" ID="lblEuroSatis" runat="server" /></td>
                <td class="auto-style1"><asp:Label Text="" ID="lblEfektifEuroAlis" runat="server" /></td>
                <td class="auto-style2"><asp:Label Text="" ID="lblEfektifEuroSatis" runat="server" /></td>
            </tr>
        </table>
    </div>
        <span style="font-size:10px;font-family:Calibri">
            <br />
            * Veriler merkez bankasından otomatik olarak çekilir. Eğer yukarıdaki tabloda veriler gelmemiş ise hesap yapamazsınız. Veriler varsa hesap yapılır. </span><br />
        <br />
        
            <span class="baslik">
                <asp:DropDownList ID="drpDolarSecim" runat="server" Height="21px" Width="148px">
                    <asp:ListItem Text="Dolar Satış" Selected="True" Value="1" />
                    <asp:ListItem Text="Dolar Alış" Value="2" />
                    <asp:ListItem Text="Dolar Efektif Satış" Value="3" />
                    <asp:ListItem Text="Dolar Efektif Alış" Value="4" />
                </asp:DropDownList></span>&nbsp;&nbsp;
            <asp:TextBox ID="txtDeger" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Hesapla" Width="70px" />
&nbsp;
            <asp:Label ID="lblSonuc" CssClass="sonuc" runat="server" Text=""></asp:Label>
        
        <br />
        <br />
        <br />
        <span class="baslik"><asp:DropDownList ID="drpEuroSecim" runat="server" Height="21px" Width="148px">
                    <asp:ListItem Text="Euro Satış" Selected="True" Value="1" />
                    <asp:ListItem Text="Euro Alış" Value="2" />
                    <asp:ListItem Text="Euro Efektif Satış" Value="3" />
                    <asp:ListItem Text="Euro Efektif Alış" Value="4" />
                </asp:DropDownList></span>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDegerEuro" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" OnClick="Button2_Click" runat="server" Text="Hesapla" Width="70px" />
&nbsp;
            <asp:Label ID="lblSonuc0" CssClass="sonuc" runat="server" Text=""></asp:Label>

        
    </form>
</body>
</html>
