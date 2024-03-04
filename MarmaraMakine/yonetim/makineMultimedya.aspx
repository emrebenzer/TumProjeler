<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineMultimedya.aspx.cs" Inherits="MarmaraMakine.yonetim.makineMultimedya" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 331px;
        }
    </style>
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
                      <li><a href="" class="current"><span>Makine Multimedya</span></a></li>
         
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
    <h1 class="makine">Makine Multimedya</h1>
         <asp:Panel runat="server" Visible="false" ID="pnluy"><p class="info" id="error"><span class="info_inner">Lüten Makine Seçiniz.</span></p></asp:Panel>
      
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END-->
    <div class="clear">
      
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
    <b>Not:</b>Listeden video, katalog veya resim ekleyeceğiniz/düzenleyeceğiniz makineyi seçiniz.<div class="portlet">
    <br />
      <b>Makine Seç</b><div class="portlet-content nopadding">
        <table style="margin-left:30px; width: 716px;">
        <tr>
        <td width="198">Kategori:
        <br />
            <asp:ListBox runat="server" ID="listKtgr" Height="302px" Width="180px" AutoPostBack="True" OnSelectedIndexChanged="listKtgr_SelectedIndexChanged">

            </asp:ListBox>
        
        </td>
        <td width="20" class="ok">
        >
        </td>
        <td class="auto-style1">Makine:
        <br />
            <asp:ListBox runat="server" ID="listMkn" Height="307px" Width="349px">

            </asp:ListBox></td>
        <td width="76" class="ok">
          <p><a id="A1" class="button_ok" runat="server" onserverclick="Button1_Click"><span>Devam</span></a></p></td>
        </tr>
        
        
        </table>
        
		</div>
      
      
      
      
      
      </div>
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

		<!-- This contains the hidden content for modal box calls -->
		
</div>
<!-- WRAPPER END -->
<!-- FOOTER START -->



</asp:Content>
