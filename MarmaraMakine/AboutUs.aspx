<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="MarmaraMakine.AboutUs" %>

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
    <link rel="stylesheet" type="text/css" href="css/lightview/lightview.css" />
    <script type="text/javascript" src="js/jquery.aw-showcase.js"></script>
    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <script type="text/javascript" src="engine1/jquery.js"></script>
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
            var i, j = 0, x, a = MM_swapImage.arguments; document.MM_sr = new Array; for (i = 0; i < (a.length - 2) ; i += 3)
                if ((x = MM_findObj(a[i])) != null) { document.MM_sr[j++] = x; if (!x.oSrc) x.oSrc = x.src; x.src = a[i + 2]; }
        }
    </script>
</head>
<body>
    <form id="form5" runat="server">
        <div id="container3">
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
                                OnClick="btnAra_Click" />


                            <asp:TextBox runat="server" ID="txtArama" CssClass="ara" Text="Arama" />



                        </form>
                    </div>

                    <div id="dil"><%=Request.QueryString["lang"] == "EN" ? "<img src='resim/tr.png' width='13' height='10' />&nbsp;&nbsp;<a href='AboutUs.aspx?lang=TR'>TÜRKÇE</a>" : "<img src='resim/en.png' width='13' height='10' />&nbsp;&nbsp;<a href='AboutUs.aspx?lang=EN'>ENGLISH</a>"%></div>
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
                <!--menu bitis-->



            </div>

            <div id="urunler-icerik3">
                <div id="icerik-baslik">

                    <div id="baslikk"><%=Request.QueryString["lang"] == "EN" ? "ABOUT US" : "HAKKIMIZDA"%></div>
                </div>


                <div id="resim-hakkimizda" style="width: 780px; height: 275px; margin-left: auto; margin-right: auto; border: 2px solid #CCC">
                    <img src="resim/fabrika-hakkimizda2.jpg" width="780px" height="275px" /></div>

                <div id="hakkimizda-yazilar">
                    <span style="font-size: 17px; font-weight: bold; font-family: Arial, Helvetica, sans-serif">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label Text="" ID="lblHakkimizdaBaslik" runat="server" /></span><br />
                    <br />
                    <asp:Label Text="" ID="lblHakkimizdaIcerik" runat="server" />
                </div>

                <div id="hakkimizda-hizmet-resim">
                    <img src="resim/hakkimizda-hizmet.jpg" width="349" height="232" /></div>
                <div id="hakkimizda-resim">
                    <img src="resim/fabrika-ic.jpg" /></div>
                <div style="clear: both"></div>

            </div>

            <!--<div id="alt-bolum"></div>-->
            <div style="height: 30px; margin-top: 10px; margin-left: 37px">
                <span style="font-size: 17px; font-weight: bold; font-family: Arial, Helvetica, sans-serif"><%=Request.QueryString["lang"] == "EN" ? "Certificates" : "Sertifikalarımız"%></span>


            </div>
            <div style="float: left; width: 180px; margin-left: 37px">
                <a href='resim/certificate.jpg' class='lightview' data-lightview-group='example'>
                    <img src='resim/certificate.jpg' alt='' width="170" style="border: 1px solid #000000" />
                </a>
            </div>
            <div style="float: left; width: 180px; margin-left: 13px">
                <a href='resim/certificate2.jpg' class='lightview' data-lightview-group='example'>
                    <img src='resim/certificate2.jpg' alt='' width="170" style="border: 1px solid #000000" />
                </a>
            </div>
            <div style="float: left; width: 180px; margin-left: 13px">
                <a href='resim/certificate3.jpg' class='lightview' data-lightview-group='example'>
                    <img src='resim/certificate3.jpg' alt='' width="170" style="border: 1px solid #000000" />
                </a>
            </div>
            <div style="float: left; width: 180px; margin-left: 13px">
                <a href='resim/Bcertificate4.jpg' class='lightview' data-lightview-group='example'>
                    <img src='resim/certificate4.jpg' alt='' width="170" style="border: 1px solid #000000" />
                </a>
            </div>
            <div style="clear: both"></div>






        </div>
        <div id="alt-menu">
            <div id="footer2">
                <%=Request.QueryString["lang"] == "EN" ? "<a href='Default.aspx?lang=EN'>Home Page</a>" : "<a href='Default.aspx?lang=TR'>Ana Sayfa</a>"%>&nbsp;|&nbsp;
                <%=Request.QueryString["lang"] == "EN" ? "<a href='AboutUs.aspx?lang=EN'>About Us</a>" : "<a href='AboutUs.aspx?lang=TR'>Hakkımızda</a>"%>&nbsp;|&nbsp;
                <%=Request.QueryString["lang"] == "EN" ? "<a href='Information.aspx?lang=EN'>Information</a>" : "<a href='Information.aspx?lang=TR'>Bize Ulaşın</a>"%>
                <span style="float: right; font-size: 11px">Marmara Makina Kalıp Müh. ve Müm.San.Tic.AŞ. <%=Request.QueryString["lang"] == "EN" ? "Copyright" : "Her hakkı saklıdır."%> © 2013</span>
            </div>

            <div id="footer-alt-body">
                <div id="sol-footer-yazi">
                    <img src="resim/yer.png" width="9" height="12" />&nbsp;&nbsp;<span style="font-weight: bold; text-decoration: underline"><%=Request.QueryString["lang"] == "EN" ? "Address:" : "Adres:"%></span>&nbsp;<asp:Label
                        Text="" runat="server" ID="lblAdres" /><br />
                    <img src="resim/tel.png" width="12" height="11" />&nbsp;<span style="font-weight: bold; text-decoration: underline"><%=Request.QueryString["lang"] == "EN" ? "Phone:" : "Telefon:"%></span>&nbsp;<asp:Label
                        Text="" runat="server" ID="lblTelefon" /><br />
                    <img src="resim/fax.png" width="11" height="11" />&nbsp;<span style="font-weight: bold; text-decoration: underline">Fax</span>:&nbsp;<asp:Label
                        Text="" runat="server" ID="lblFax" />



                    <br />
                    <a href="http://www.benzeryazilim.com"
                        style="border-style: none; border-color: inherit; border-width: 0px; float: right; height: 10px;">
                        <img src="resim/benzer.png" style="border: 0px" /></a>
                </div>
                <div id="marmara-logo"></div>

            </div>

        </div>
        <!--alt menu bitis-->





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
