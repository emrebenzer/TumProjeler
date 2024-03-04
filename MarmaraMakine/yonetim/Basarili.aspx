<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="Basarili.aspx.cs" Inherits="MarmaraMakine.yonetim.Basarili" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="makineEkle.aspx"class="current"><span>Makine Ekle</span></a></li>
                      <li><a href="MakineDuzenle.aspx" ><span>Makine Düzenle</span></a></li>
                      <li><a href="makineSil.aspx" ><span>Makine Sil</span></a></li>
                      <li><a href="makineMultimedya.aspx"><span>Makine Multimedya</span></a></li>
         
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>
<!-- HIDDEN SUBMENU START -->

<!-- HIDDEN SUBMENU END -->  

<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="makine">Makine Düzenle</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END-->
    <div class="clear">
      
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
        Makine başarıyla oluşturuldu. Makine için resim, video ve katoloğu &quot;Makine Multimedya&quot; bölümünden değiştirebilirsiniz.<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
   </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

		<!-- This contains the hidden content for modal box calls -->
		
</div>


</asp:Content>
