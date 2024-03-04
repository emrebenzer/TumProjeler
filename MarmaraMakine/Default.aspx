<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MarmaraMakine.HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş.</title>

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

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.aw-showcase.js"></script>


	<!-- Initialise html5 placeholder -->



    
<script type="text/javascript">
    
    $(document).ready(function () {
        var textDil = $("#txtVeri").val();
        var textBrowser = $("#txtTur").val();
        if (textBrowser=='FF') {
            if (textDil=="TR") {
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

        $("#showcase").awShowcase(
	{
	    content_width: 770,
	    content_height: 331,
	    fit_to_parent: false,
	    auto: true,
	    interval: 4000,
	    continuous: true,
	    loading: true,
	    tooltip_width: 0,
	    tooltip_icon_width: 32,
	    tooltip_icon_height: 32,
	    tooltip_offsetx: 18,
	    tooltip_offsety: 0,
	    arrows: false,
	    buttons: false,
	    btn_numbers: false,
	    keybord_keys: true,
	    mousetrace: false, /* Trace x and y coordinates for the mouse */
	    pauseonover: false,
	    stoponclick: false,
	    transition: 'fade', /* hslide/vslide/fade */
	    transition_delay: 300,
	    transition_speed: 500,
	    show_caption: 'onhover', /* onload/onhover/show */
	    thumbnails: true,
	    thumbnails_position: 'outside-last', /* outside-last/outside-first/inside-last/inside-first */
	    thumbnails_direction: 'vertical', /* vertical/horizontal */
	    thumbnails_slidex: 0, /* 0 = auto / 1 = slide one thumbnail / 2 = slide two thumbnails / etc. */
	    dynamic_height: false, /* For dynamic height to work in webkit you need to set the width and height of images in the source. Usually works to only set the dimension of the first slide in the showcase. */
	    speed_change: true, /* Set to true to prevent users from swithing more then one slide at once. */
	    viewline: false /* If set to true content_width, thumbnails, transition and dynamic_height will be disabled. As for dynamic height you need to set the width and height of images in the source. */
	});

        


    });

</script>   
    <style type="text/css">
        @-moz-document url-prefix() {
    .drop {
        font-size: 12.4px !important;

    }
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
  
  

  <div id="dil"><%=Request.QueryString["lang"] == "EN" ? "<img src='resim/tr.png' width='13' height='10' />&nbsp;&nbsp;<a href='Default.aspx?lang=TR'>TÜRKÇE</a>" : "<img src='resim/en.png' width='13' height='10' />&nbsp;&nbsp;<a href='Default.aspx?lang=EN'>ENGLISH</a>"%></div>
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
<div id="icerik-baslik"></div>
<div id="icerik-sol-taraf2">




<!--<div id="ana-resim2"><img src="resim/makine-resim/anasayfa3.jpg"  /></div>-->




<div id="showcase" class="showcase">
		<!-- Each child div in #showcase with the class .showcase-slide represents a slide. -->

    <asp:Repeater runat="server" ID="rptSlayt">
        <ItemTemplate>
        <div class="showcase-slide">
			<div class="showcase-content">
				<img src="resim/<%# Eval("SlaytURL") %>" alt="03" />
			</div>
			
		</div>
        </ItemTemplate>
    </asp:Repeater>
		    
	</div>





<div id="detaylar-baslik2" style="background-color:none;background-image:url(resim/menu-arka2.png);color:#FFFBF0;text-shadow: 1px 1px 1px #000;">
    <asp:Label Text="" runat="server" ID="lblHakkimizdaBaslik"/></div>
<div id="yazilar">

<div id="detay-icerik2">
    <asp:Label Text="" runat="server" ID="lblHakkimizdaIcerik"/><span class="devamini"><%=Request.QueryString["lang"] == "EN" ? "<a href='AboutUs.aspx?lang=EN'>Read More...</a>" : "<a href='AboutUs.aspx?lang=TR'>Devamını Oku...</a>"%></span>
  
</div>
</div>
<div id="marmara-resim"><img src="resim/fabrika.png" width="230" height="166" /></div>
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

<%--<script type="text/javascript">
    // Placeholders functionality
    jQuery(function () {
        jQuery(':input[placeholder]').placeholder();
    });  
</script>--%>


    </form>
</body>
</html>
