<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="MarmaraMakine.Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/marmara.css" rel="stylesheet" type="text/css" />
<script src="SpryAssets/SpryEffects.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8/jquery.min.js"></script>
<script type="text/javascript" src="javaScript/html5placeholder.jquery.min.js">
</script>
<script type="text/javascript" src="js/prototype.js"></script>
<script type="text/javascript" src="js/scriptaculous.js?load=effects,builder"></script>
<script type="text/javascript" src="js/lightbox.js"></script>

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/swfobject/2.2/swfobject.js"></script>
<!--[if lt IE 9]>
  <script type="text/javascript" src="/js/excanvas/excanvas.js"></script>
<![endif]-->
<script type="text/javascript" src="js/spinners/spinners.min.js"></script>
<script type="text/javascript" src="js/lightview/lightview.js"></script>
<link rel="stylesheet" type="text/css" href="css/lightview/lightview.css"/>
	<!-- Initialise html5 placeholder -->
<%--<script type="text/javascript" src="javaScript/html5placeholder.jquery.min.js">
</script>--%>
<script type="text/javascript" src="js/jquery.aw-showcase.js"></script>
<link rel="stylesheet" type="text/css" href="engine1/style.css" />
	<script type="text/javascript" src="engine1/jquery.js"></script>
    <script type="text/javascript">

        window.document.onkeydown = function (e) {
            if (!e) {
                e = event;
            }
            if (e.keyCode == 27) {
                lightbox_close();
            }
        }

        function lightbox_open() {
            var lightBoxVideo = document.getElementById("VisaChipCardVideo");
            window.scrollTo(0, 0);
            document.getElementById('light').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
            lightBoxVideo.play();
        }

        function lightbox_close() {
            var lightBoxVideo = document.getElementById("VisaChipCardVideo");
            document.getElementById('light').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
            lightBoxVideo.pause();
        }




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




        function MM_swapImgRestore() { //v3.0
            var i, x, a = document.MM_sr; for (i = 0; a && i < a.length && (x = a[i]) && x.oSrc; i++) x.src = x.oSrc;
        }
        function MM_preloadImages() { //v3.0
            var d = document; if (d.images) {
                if (!d.MM_p) d.MM_p = new Array();
                var i, j = d.MM_p.length, a = MM_preloadImages.arguments; for (i = 0; i < a.length; i++)
                    if (a[i].indexOf("#") != 0) { d.MM_p[j] = new Image; d.MM_p[j++].src = a[i]; } 
            }
        }

        function MM_findObj(n, d) { //v4.01
            var p, i, x; if (!d) d = document; if ((p = n.indexOf("?")) > 0 && parent.frames.length) {
                d = parent.frames[n.substring(p + 1)].document; n = n.substring(0, p);
            }
            if (!(x = d[n]) && d.all) x = d.all[n]; for (i = 0; !x && i < d.forms.length; i++) x = d.forms[i][n];
            for (i = 0; !x && d.layers && i < d.layers.length; i++) x = MM_findObj(n, d.layers[i].document);
            if (!x && d.getElementById) x = d.getElementById(n); return x;
        }

        function MM_swapImage() { //v3.0
            var i, j = 0, x, a = MM_swapImage.arguments; document.MM_sr = new Array; for (i = 0; i < (a.length - 2); i += 3)
                if ((x = MM_findObj(a[i])) != null) { document.MM_sr[j++] = x; if (!x.oSrc) x.oSrc = x.src; x.src = a[i + 2]; }
        }
</script>
    <style type="text/css">
        #fade {
  display: none;
  position: fixed;
  top: 0%;
  left: 0%;
  width: 100%;
  height: 100%;
  background-color: black;
  z-index: 1001;
  -moz-opacity: 0.8;
  opacity: .80;
  filter: alpha(opacity=80);
}

#light {
  display: none;
  position: absolute;
  top: 50%;
  left: 50%;
  max-width: 600px;
  max-height: 360px;
  margin-left: -300px;
  margin-top: -180px;
  border: 2px solid #FFF;
  background: #FFF;
  z-index: 1002;
  overflow: visible;
}

#boxclose {
  float: right;
  cursor: pointer;
  color: #fff;
  border: 1px solid #AEAEAE;
  border-radius: 3px;
  background: #222222;
  font-size: 31px;
  font-weight: bold;
  display: inline-block;
  line-height: 0px;
  padding: 11px 3px;
  position: absolute;
  right: 2px;
  top: 2px;
  z-index: 1002;
  opacity: 0.9;
}

.boxclose:before {
  content: "×";
}

#fade:hover ~ #boxclose {
  display:none;
}

.test:hover ~ .test2 {
  display: none;
}


    </style>
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
  <form id="form2" name="form1" method="post" action="">
    <label for="ara"></label>
    
  <asp:Button Text="" ID="btnAra" class="butonara" runat="server" 
        onclick="btnAra_Click" />

  
  <asp:TextBox runat="server" ID="txtArama" CssClass="ara" Text="Arama" />

    

  </form>
  </div>
  
   <div id="dil">
   <%if (dil == "EN")
     { %>

   <img src='resim/tr.png' width='13' height='10' />&nbsp;&nbsp;<a href='Details.aspx?lang=TR&&id=<%=Request.QueryString["id"] %>'>TÜRKÇE</a>
   <%}
     else
     { %>
   <img src='resim/en.png' width='13' height='10' />&nbsp;&nbsp;<a href='Details.aspx?lang=EN&&id=<%=Request.QueryString["id"] %>'>ENGLISH</a>
   <%} %>
</div>
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

<div id="urunler-icerik">
<div id="icerik-baslik"><div id="baslikk">
    <asp:Label Text="" runat="server" ID="lblMakineBaslik"/></div></div>
<div id="icerik-sol-taraf">
<div id="ana-resim">
    <asp:Image ID="imageAnaResim" runat="server" width="420"/>
</div>
<div id="detaylar-baslik"><%=Request.QueryString["lang"] == "EN" ? "DETAILS" : "DETAYLAR"%></div>
<div id="detay-icerik">
    <asp:Label Text="" runat="server" ID="lblMakineIcerik"/><br /><br />





</div>
<div id="detaylar-baslik"><%=Request.QueryString["lang"] == "EN" ? "MULTIMEDIA" : "MULTİMEDYA"%></div>
<div id="multimedia">
    <div id="light">
  <a class="boxclose" id="boxclose" onclick="lightbox_close();"></a>
  <video id="VisaChipCardVideo" width="600" controls>
      <source src="videolar/<%=videoAdres %>" type="video/mp4">
      <!--Browser does not support <video> tag -->
    </video>
</div>

<div id="fade" onClick="lightbox_close();"></div>
    <div>
<%if (katalogVarMi == true)
  { %>
<a href="resim/pdfler/<%=katalogAdres %>" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image20','','resim/pdf2.png',1)"><img src="resim/pdf.png" name="Image20" width="100" height="100" border="0" id="Image20" /></a>&nbsp;&nbsp;&nbsp;
<%}
  else
  {%>
  <a href="resim/pdfler/<%=Request.QueryString["lang"] == "EN" ? "katalog-yok-en.jpg" : "katalog-yok.jpg"%>" class="lightview" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image20','','resim/pdf2.png',1)"><img src="resim/pdf.png" name="Image20" width="100" height="100" border="0" id="Img2" /></a>&nbsp;&nbsp;&nbsp;
<%} %>

<%if (videoVarMi == true)
  { %>
    


  <a href="#" onclick="lightbox_open();"><img src="resim/video.png" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image21','','resim/video2.png',1)" name="Image21" width="100" height="100" border="0" id="Image21" /></a>



<%--<a href="videolar/<%=videoAdres %>" class="lightview"  onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image21','','resim/video2.png',1)"><img src="resim/video.png" name="Image21" width="100" height="100" border="0" id="Image21" /></a>--%>
<%}
  else
  {%>
  <a href="videolar/<%=Request.QueryString["lang"] == "EN" ? "video-yok-en.jpg" : "video-yok.jpg"%>" class="lightview"  onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image21','','resim/video2.png',1)"><img src="resim/video.png" name="Image21" width="100" height="100" border="0" id="Img1" /></a>

<%} %>
    </div>
&nbsp;&nbsp;&nbsp;</div>

</div>
<div id="sag-taraf">
<div id="teknik-ozellikler"><%=Request.QueryString["lang"] == "EN" ? "SPECIFICATION" : "ÖZELLİKLER"%></div>
    <asp:Repeater runat="server" ID="rptTeknikOzellikler">
        <ItemTemplate>
        <%if (dil=="EN") { %>
        <div id="teknik-ozellikler-icerik">
<span style="float:left;margin-left:15px"><b><%# Eval("OzellikIsmiEN") %></b></span>
<span style="float:right;margin-right:10px"><%# Eval("DegerEN") %></span>
</div>
<%} else { %>
<div id="teknik-ozellikler-icerik">
<span style="float:left;margin-left:15px"><b><%# Eval("OzellikIsmiTR")%></b></span>
<span style="float:right;margin-right:10px"><%# Eval("DegerTR") %></span>
</div>
<%} %>

        </ItemTemplate>
    </asp:Repeater>




<div id="teknik-ozellikler"><%=Request.QueryString["lang"] == "EN" ? "PHOTOS" : "FOTOĞRAFLAR"%></div>

<div id="gallery">
<%if (resimVarMi == true)
  {%>
      <ul>
        <asp:Repeater ID="rptResimler" runat="server">
            <ItemTemplate>
            <li>
            <a href='resim/makine-resim/buyuk/<%#Eval("ResimUrl") %>' class='lightview' data-lightview-group='example' ><img src='resim/makine-resim/kucuk/<%#Eval("ResimUrl")%>' alt='' width="120" height="79"/>
  </a>
        </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
  <%}
  else
  { %>
  <span style="font-family:Arial;font-size:12px;margin-left:15px"><%=Request.QueryString["lang"] == "EN" ? "Photos of this machine is prepearing." : "Bu makineye henüz resim eklenmemiştir."%></span>


  <%} %>
    

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
