<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineMultimedyaSecim.aspx.cs" Inherits="MarmaraMakine.yonetim.makineMultimedyaSecim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="makineEkle.aspx"><span>Makine Ekle</span></a></li>
                      <li><a href="makineDuzenle.aspx"><span>Makine Düzenle</span></a></li>
                      <li><a href="makineSil.aspx"><span>Makine Sil</span></a></li>
                      <li><a href="makineMultimedya.aspx"  class="current"><span>Makine Multimedya</span></a></li>
         
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>
     <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="makine">Makine Multimedya</h1>
       <a href="makineMultimedyaKatalog.aspx?id=<%=Request.QueryString["id"] %>"><p class="info" id="success"><span class="info_inner">Katalog Ekle/Düzenle</span></p></a>
        <a href="makineMultimedyaVideo.aspx?id=<%=Request.QueryString["id"] %>"><p class="info" id="success"><span class="info_inner">Video Ekle/Düzenle</span></p></a>
        <a href="makineMultimedyaResim.aspx?id=<%=Request.QueryString["id"] %>"><p class="info" id="success"><span class="info_inner">Resim Ekle/Düzenle</span></p></a>
        
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END-->
    <div class="clear">
      
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

		<!-- This contains the hidden content for modal box calls -->
		
</div>

</asp:Content>
