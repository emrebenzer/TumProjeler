<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineDuzenle.aspx.cs" Inherits="MarmaraMakine.yonetim.makineDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 544px;
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
                      <li><a href="" class="current"><span>Makine Düzenle</span></a></li>
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
    <div class="clear"><b>Not:</b>Listeden düzenlemek istediğiniz makinyi seçiniz.</div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
    <br />
      <b>Makine Düzenle</b>
		<div class="portlet-content nopadding">
        <br />
        <table style="margin-left:30px; width: 883px;">
        <tr>
        <td style="width:10px">Kategori:
        <br />
            <asp:ListBox runat="server" class="smallInput" ID="listKategoriler" Width="195px" Height="241px" AutoPostBack="True" OnSelectedIndexChanged="listKategoriler_SelectedIndexChanged">

            </asp:ListBox>

        </td>
        <td width="20" class="ok">
        >
        </td>
        <td width="110">Makine:
        <br />
            <asp:ListBox runat="server" class="smallInput" ID="listMakineler" Width="357px" Height="239px">

            </asp:ListBox>
        </td>
        <td width="180">
          <p><a class="button_ok" runat="server"  onserverclick="btnDuzenle_Click"><span>Düzenle</span></a></p><br />
            <asp:Label Text="" ID="lblSonuc" runat="server" />


        </td>
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
</asp:Content>
