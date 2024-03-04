<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication16.takvim.Dafault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmreBenzer.Net | Takvim</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 305px;margin-left:auto;margin-right:auto;text-align:center"><span style="font-family:Calibri;font-size:14px">
        Şuan da&nbsp;<asp:Label ID="lblYil" runat="server" />&nbsp; yılının&nbsp;
        <span style="font-family:Calibri;font-size:18px;color:red;font-weight:bold"><asp:Label Text="" ID="lblHafta" runat="server" />.</span> haftasındayız.</span><br />
        <br /><center>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="186px" Width="250px" CellPadding="4" DayNameFormat="Shortest" NextMonthText="ileri&gt;" PrevMonthText="&amp;lt;geri">
            <DayHeaderStyle Font-Bold="True" Font-Size="7pt" BackColor="#CCCCCC" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" ForeColor="White" Font-Bold="True" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
            <br />
            <br />
        <span style="font-family:Calibri;font-size:14px">Milenyumun tam tamına <span style="font-family:Calibri;font-size:18px;color:red;font-weight:bold"><asp:label ID="lblMilenyum" runat="server" />.</span> günündeyiz.<br />
            <br />
            <br />
            <b>Doğum Tarihini Seç: (Toplam Gün Hesaplama)</b><br />
            <br />
            Gün:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ay:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Yıl:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <asp:DropDownList ID="drpGun" runat="server" Height="28px" Width="40px">
                
            </asp:DropDownList>
&nbsp;
            <asp:DropDownList ID="drpAy" runat="server" Height="28px" Width="40px">
            </asp:DropDownList>
&nbsp;
            <asp:DropDownList ID="drpYil" runat="server" Height="28px" Width="70px">
            </asp:DropDownList>
            &nbsp;
            <asp:Button ID="Button1" runat="server" Height="28px" Text="Hesapla" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:label ID="lblGunAciklama" runat="server" />&nbsp;<span style="font-family:Calibri;font-size:18px;color:red;font-weight:bold"><asp:label ID="lblDogumGun" runat="server" /></span>
            </span>

            <br /><br />
            <script language="javascript" src="http://in.sitekodlari.com/tarih.js"></script>
              </center>
    </div>
    </form>
</body>
</html>
