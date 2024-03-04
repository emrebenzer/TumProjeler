<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" EnableEventValidation="false"  Inherits="MarmaraMakine.Information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="css/marmara.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8/jquery.min.js"></script>
     <script type="text/javascript">
        $(document).ready(function () {
            var textDil = $("#txtVeri").val();
            var textBrowser = $("#txtTur").val();
            if (textBrowser == 'FF') {
                if (textDil == "TR") {
                    $(".drop").css("cssText", "font-size:12.6px !important");
                }
                else {
                    $(".drop").css("cssText", "font-size:11.6px !important");
                }
            }
            else {
                if (textDil == "TR") {
                    $(".drop").css("cssText", "font-size:13.2px !important");
                }
                else {
                    $(".drop").css("cssText", "font-size:11.9px !important");
                }
            }
        });


    </script>
</head>
<body>
    <form id="form5" runat="server">
    

    <div id="container">
<div id="ust">
<div id="logo"><%=Request.QueryString["lang"] == "EN" ? "<a href='Default.aspx?lang=EN'><img src='resim/l.jpg' width='280' height='90' border='0' /></a>" : "<a href='Default.aspx?lang=TR'><img src='resim/l.jpg' width='280' height='90' border='0' /></a>"%></div>


<div id="ust-sag-taraf">
<div id="ust-menu">
        <input type="text" id="txtVeri" value="<%=dil %>" style="display:none"/>
    <input type="text" id="txtTur" value="<%=browser %>" style="display:none"/>
<%=Request.QueryString["lang"] == "EN" ? "<a href='Default.aspx?lang=EN'>Home Page</a>" : "<a href='Default.aspx?lang=TR'>Ana Sayfa</a>"%>&nbsp;&nbsp;|&nbsp;&nbsp;<%=Request.QueryString["lang"] == "EN" ? "<a href='Information.aspx?lang=EN'>Information</a>" : "<a href='Information.aspx?lang=TR'>İletişim</a>"%>
</div>
<div id="arama">
   <form id="form2" name="form2" method="post" action="">
    <label for="ara"></label>   
  <asp:Button Text="" ID="btnAra" class="butonara" runat="server" 
        onclick="btnAra_Click" />

  <asp:TextBox runat="server" ID="txtArama" CssClass="ara" Text="Arama" />

  </form>
  </div>
  
  <div id="dil"><%=Request.QueryString["lang"] == "EN" ? "<img src='resim/tr.png' width='13' height='10' />&nbsp;&nbsp;<a href='Information.aspx?lang=TR'>TÜRKÇE</a>" : "<img src='resim/en.png' width='13' height='10' />&nbsp;&nbsp;<a href='Information.aspx?lang=EN'>ENGLISH</a>"%></div>
</div>



</div>
<div id="menukalip">

<ul id="menu">

                    <li><a href="#" class="drop"><%=Request.QueryString["lang"] == "EN" ? "&nbsp;&nbsp;&nbsp;Tincan Production" : "Teneke Kutu Üretimi"%></a><!-- Begin Home Item -->

                        <div class="dropdown_2columns">
                            <!-- Begin 2 columns container -->

                            <br />
                            <div class="col sep">
                                <h3><%=Request.QueryString["lang"] == "EN" ? "Body Production Lines" : "Gövde Üretim Hatları"%></a></h3>
                                <ul class="list">
                                    <asp:Repeater runat="server" ID="rptGovdeUretim">
                                        <ItemTemplate>
                                            <li>
                                                <%if (dil == "EN")
                                                    { %>
                                                <a href="Details.aspx?lang=EN&&id=<%#Eval ("MakineID") %>">
                                                    <img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimEN") %></a><%}
                                                                                                                                                     else
                                                                                                                                                     { %><a href="Details.aspx?lang=TR&&id=<%#Eval ("MakineID") %>"><img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimTR") %></a><%} %></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                            <!--/ col-->
                            <div class="col_last_buyuk">
                                <h3><%=Request.QueryString["lang"] == "EN" ? "End Making Lines" : "Kapak Üretim Hatları"%></h3>
                                <ul class="list">
                                    <asp:Repeater runat="server" ID="rptKapatmaHatti">
                                        <ItemTemplate>
                                            <li>
                                                <%if (dil == "EN")
                                                    { %>
                                                <a href="Details.aspx?lang=EN&&id=<%#Eval ("MakineID") %>">
                                                    <img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimEN") %></a><%}
                                                                                                                                                     else
                                                                                                                                                     { %><a href="Details.aspx?lang=TR&&id=<%#Eval ("MakineID") %>"><img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimTR") %></a><%} %></li>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </ul>
                            </div>
                            <!--/ col-->

                        </div>
                        <!-- End 2 columns container -->

                    </li>
                    <!-- End Home Item -->

                    <li><a href="#" class="drop"><%=Request.QueryString["lang"] == "EN" ? "&nbsp;&nbsp;&nbsp;Closing and Seaming Machines" : "Kavanoz ve Kutu Kapatma"%></a><!-- Begin 5 columns Item -->

                        <div class="dropdown_5columns">
                            <!-- Begin 5 columns container -->
                            <div class="col_last">


                                <ul class="list">
                                    <asp:Repeater runat="server" ID="rptKavanozKapagiKapatma">
                                        <ItemTemplate>
                                            <li>
                                                <%if (dil == "EN")
                                                    { %>
                                                <a href="Details.aspx?lang=EN&&id=<%#Eval ("MakineID") %>">
                                                    <img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimEN") %></a><%}
                                                                                                                                                     else
                                                                                                                                                     { %><a href="Details.aspx?lang=TR&&id=<%#Eval ("MakineID") %>"><img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimTR") %></a><%} %></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                            <!--/ col-->
                        </div>
                    </li>
                    <!-- End 5 columns Item -->

                    <li><a href="#" class="drop"><%=Request.QueryString["lang"] == "EN" ? "&nbsp;&nbsp;&nbsp;Pet and Hdpe Bottle Production" : "Pet ve Plastik Şişe Üretimi"%></a><!-- Begin 4 columns Item -->

                        <div class="dropdown_4columns">
                            <!-- Begin 4 columns container -->
                            <div class="col_last">


                                <ul class="list">
                                    <asp:Repeater runat="server" ID="rptPetPlastik">
                                        <ItemTemplate>
                                            <li>
                                                <%if (dil == "EN")
                                                    { %>
                                                <a href="Details2.aspx?lang=EN&&id=<%#Eval ("MakineID") %>">
                                                    <img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimEN") %></a><%}
                                                                                                                                                      else
                                                                                                                                                      { %><a href="Details2.aspx?lang=TR&&id=<%#Eval ("MakineID") %>"><img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimTR") %></a><%} %></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                            <!--/ col-->

                        </div>
                        <!-- End 4 columns container -->

                    </li>
                    <!-- End 4 columns Item -->

                    

                    <li><a href="#" class="drop"><%=Request.QueryString["lang"] == "EN" ? "&nbsp;&nbsp;&nbsp;Engineering Services" : "Mühendislik Hizmetleri"%></a><!-- Begin 3 columns Item -->

                        <div class="dropdown_3columns align_right2">
                            <!-- Begin 3 columns container -->

                            <div class="col_last">
                                <ul class="list">
                                    <asp:Repeater runat="server" ID="rptMuhendislik">
                                        <ItemTemplate>
                                            <li>
                                                <%if (dil == "EN")
                                                    { %>
                                                <a>
                                                    <img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimEN") %></a><%}
                                                                                          else
                                                                                          { %><a><img src="resim/menu-ikon.png" width="5" height="8" border="0" />&nbsp;<%# Eval("MakineIsimTR") %></a><%} %></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>

                        </div>
                        <!-- End 3 columns container -->

                    </li>
    <li>
                        
                        
                        <%=Request.QueryString["lang"] == "EN" ? "<a href='AboutUs.aspx?lang=EN' class='drop'>About Us</a>" : "<a href='AboutUs.aspx?lang=TR' class='drop'>Hakkımızda</a>"%>
    
		
        
                    </li>
                    <!-- End 3 columns Item -->



                </ul>



</div>

<div id="urunler-icerik2">
<div id="icerik-baslik">

  <div id="baslikk"><%=Request.QueryString["lang"] == "EN" ? "INFORMATION" : "İLETİŞİM"%></div>
</div>

<div id="hakkimizda-yazilar2">
<div id="adres-bilgileri">
  <table width="386" border="0">
    <tr>
      <td width="178"><img src="resim/marmara-iletisim.jpg" width="170" height="106" /></td><br />
      <td width="198" valign="top">
      <b><span style="font-size:13px"><%=Request.QueryString["lang"] == "EN" ? "Factory" : "Fabrika"%></span></b><br /><br />
      <b><%=Request.QueryString["lang"] == "EN" ? "Address:" : "Adres:"%></b> 
          <asp:Label Text="" ID="lblAdres2" runat="server" /><br />
      <b><%=Request.QueryString["lang"] == "EN" ? "Phone:" : "Telefon:"%></b> 
          <asp:Label Text="" ID="lblTelefon2" runat="server" /><br />
      <b>Fax:</b> <asp:Label Text="" ID="lblFax2" runat="server" /><br />
      <b>E-Mail:</b> 
          <asp:HyperLink NavigateUrl="" runat="server" Text="" ID="hyper1"/><br />
      
      
      </td>
    </tr>
    </table>
    <br />
    <iframe width="425" height="350" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com/maps?q=41.074236,28.12508&amp;num=1&amp;t=h&amp;ie=UTF8&amp;ll=41.073851,28.125515&amp;spn=0.005662,0.00912&amp;z=16&amp;output=embed"></iframe>
    
</div>
<div id="form1">	
  
<fieldset><legend>Contact form</legend>
				<p class="first">
					<label><%=Request.QueryString["lang"] == "EN" ? "Name & Surname:" : "Ad Soyad"%></label>
                    <asp:TextBox runat="server" CssClass="txtler" ID="txtAdSoyad" Width="180"/>
				</p>
				<p>
					<label for="email">Email</label>
					<asp:TextBox runat="server" CssClass="txtler" ID="txtEmail" Width="180"/>
				</p>
				<p>
					<label for="web"><%=Request.QueryString["lang"] == "EN" ? "Company" : "Firma"%></label>
					<asp:TextBox runat="server" CssClass="txtler" ID="txtFirma" Width="180"/>
				</p>	
                <p>
					<label for="web"><%=Request.QueryString["lang"] == "EN" ? "Phone Number" : "Telefon"%></label>
					<asp:TextBox runat="server" CssClass="txtler" ID="txtTelefon" Width="180"/>
				</p>
                <p>
					<label for="web"><%=Request.QueryString["lang"] == "EN" ? "Subject" : "Konu"%></label>
					<asp:TextBox runat="server" CssClass="txtler" ID="txtKonu" Width="180"/>
				</p>		
																		
				<p>
					<label for="message"><%=Request.QueryString["lang"] == "EN" ? "Message" : "Mesajınız"%></label>
					<asp:TextBox runat="server" CssClass="txtler" ID="txtMesaj" TextMode="MultiLine" Width="220" Height="80"/><br />
				</p>								
							

		<asp:Button ID="btnGonder" runat="server" CssClass="button" onclick="btnGonder_Click"/><br /><br />
    <asp:Label Text="" runat="server" ID="lblSonuc"/>
                	
				</fieldset>			
		</div>	
</div>
</div>

<!--<div id="alt-bolum"></div>-->
<script type="text/javascript" src="engine1/wowslider.js"></script>
<script type="text/javascript" src="engine1/script.js"></script>
</div>
<div id="alt-menu">
<div id="footer2">
<%=Request.QueryString["lang"] == "EN" ? "<a href='Default.aspx?lang=EN'>Home Page</a>" : "<a href='Default.aspx?lang=TR'>Ana Sayfa</a>"%>&nbsp;|&nbsp;
<%=Request.QueryString["lang"] == "EN" ? "<a href='AboutUs.aspx?lang=EN'>About Us</a>" : "<a href='AboutUs.aspx?lang=TR'>Hakkımızda</a>"%>&nbsp;|&nbsp;
<%=Request.QueryString["lang"] == "EN" ? "<a href='Information.aspx?lang=EN'>Information</a>" : "<a href='Information.aspx?lang=TR'>Bize Ulaşın</a>"%>
<span style="float:right;font-size:11px">Marmara Makina Kalıp Müh. ve Müm.San.Tic.AŞ. <%=Request.QueryString["lang"] == "EN" ? "Copyright" : "Her hakkı saklıdır."%> © 2013</span>
</div>
<div id="footer-alt-body">
<div id="sol-footer-yazi">
 <img src="resim/yer.png" width="9" height="12" />&nbsp;&nbsp;<span style="font-weight:bold;text-decoration:underline"><%=Request.QueryString["lang"] == "EN" ? "Address:" : "Adres:"%></span>&nbsp;<asp:Label
      Text="" runat="server" ID="lblAdres"/><br />
  <img src="resim/tel.png" width="12" height="11" />&nbsp;<span style="font-weight:bold;text-decoration:underline"><%=Request.QueryString["lang"] == "EN" ? "Phone:" : "Telefon:"%></span>&nbsp;<asp:Label
      Text="" runat="server" ID="lblTelefon"/><br /><img src="resim/fax.png" width="11" height="11" />&nbsp;<span style="font-weight:bold;text-decoration:underline">Fax</span>:&nbsp;<asp:Label
      Text="" runat="server" ID="lblFax"/>
      <br />
  <a href="http://www.benzeryazilim.com" 
        style="border-style: none; border-color: inherit; border-width: 0px; float:right; height: 10px;"><img src="resim/benzer.png" style="border:0px"/></a>
  </div>
<div id="marmara-logo"></div>

</div>


</div>





</div>

<script type="text/javascript">
    // Placeholders functionality
    jQuery(function () {
        jQuery(':input[placeholder]').placeholder();
    });  
</script>



    </form>
</body>
</html>
