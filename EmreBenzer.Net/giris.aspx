<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="WebApplication16.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    GİRİŞ PANELİNE HOŞGELDİNİZ.
        <br /><br />
        <asp:Button Text="Gir" ID="btnGiris" runat="server" OnClick="btnGiris_Click" /><br /><br />
        <asp:Label Text="" ID="lblDene" runat="server" />
    </div>
    </form>
</body>
</html>
