<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineMultimedyaKatalog.aspx.cs" Inherits="MarmaraMakine.yonetim.makineMultimedyaKatalog" %>
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
                      <li><a href="makineSil.aspx" ><span>Makine Sil</span></a></li>
                      <li><a href="makineMultimedya.aspx"  class="current"><span>Makine Multimedya</span></a></li>
         
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
    <h1 class="makine">Makine Multimedya - Katalog</h1>
    <asp:Panel runat="server" ID="panelBsr1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Katalog Ekleme Başarılı</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Katalog Ekleme Başarısız</span></p></asp:Panel>
    </div>

    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START -->
	<!--  SECOND SORTABLE COLUMN END -->
    <div style="float:left">
        <div style="margin-top: 20px; margin-bottom: 20px; margin-left: 20px; width: 870px;
            border: 1px solid #ECECEC; padding: 10px">
            <table width="868" >
            <tr>
            <td style="vertical-align:top" class="auto-style1">
                Katalog Seç:<br />
              </td>
            <td style="vertical-align:middle">
                Eklediğiniz katalog pdf formatında olmalıdır.<br /><br />
                <asp:Panel runat="server" ID="panelAnaResim" Width="343px"> 
                <asp:FileUpload
    ID="fileAnaResim" CssClass="smallInput" runat="server" />&nbsp;&nbsp;<br /><br />
                    <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator3" runat="server" ControlToValidate="fileAnaResim"
                    ErrorMessage="Yalnızca pdf dosyaları eklenebilir.." ValidationExpression="^.*\.((p|P)(d|D)(f|F))$"></asp:RegularExpressionValidator>
                </asp:Panel>
                <br /><br />



 </td>
            </tr>
             <tr>
            <td style="vertical-align:top" colspan="2">
                <asp:Button ID="Button1" Text="Kaydet" runat="server" OnClick="Unnamed1_Click" /><br /><div class="portlet-content nopadding">

		</div><br /><br />
            
            </td>

            </tr>
           
            
            
            
</table>
            
            </div>
    
    </div>
    <div class="clear">
    
    
    </div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">&nbsp;&nbsp;<br />
        <div class="portlet-header fixed"></div>
		<div class="portlet-content nopadding">

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
