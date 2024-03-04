<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineSil.aspx.cs" Inherits="MarmaraMakine.yonetim.makineSil" %>
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
                      <li><a href=""  class="current"><span>Makine Sil</span></a></li>
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
    <h1 class="makine">Makine Sil</h1>
        <asp:Panel runat="server" Visible="false" ID="pnlBsrl"><p class="info" id="success"><span class="info_inner">Makine Başarı ile silindi.</span></p></asp:Panel>
        <asp:Panel runat="server" Visible="false" ID="pnlBsrsz"><p class="info" id="error"><span class="info_inner">Makine silme başarısız.</span></p></asp:Panel>
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
    <b>Not:</b>Listeden seçtiğiniz makine bilgileri, resimleri, video ve katalogları tamamen kaldırılacaktır.
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
    <br />
      <b>Makine Sil</b>
		<div class="portlet-content nopadding">
        <table width="679" style="margin-left:30px">
        <tr>
        <td width="198">Kategori:
        <br />
            <asp:ListBox runat="server" ID="listKtgr" Height="131px" Width="180px" AutoPostBack="True" OnSelectedIndexChanged="listKtgr_SelectedIndexChanged">

            </asp:ListBox>
        
        </td>
        <td width="20" class="ok">
        >
        </td>
        <td width="365">Makine:
        <br />
            <asp:ListBox runat="server" ID="listMkn" Height="126px" Width="349px">

            </asp:ListBox></td>
        <td width="76" class="ok">
          <p><a class="button_notok" runat="server" onserverclick="Button1_Click"><span>Sil</span></a></p></td>
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
