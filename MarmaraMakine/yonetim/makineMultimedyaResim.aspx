<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineMultimedyaResim.aspx.cs" Inherits="MarmaraMakine.yonetim.makineMultimedyaResim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 109px;
        }
        .auto-style2 {
            width: 230px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/multi.js"></script>
<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="makineEkle.aspx" ><span>Makine Ekle</span></a></li>
                      <li><a href="makineDuzenle.aspx"><span>Makine Düzenle</span></a></li>
                      <li><a href="makineSil.aspx" ><span>Makine Sil</span></a></li>
                      <li><a href="makineMultimedya.aspx" class="current"><span>Makine Multimedya</span></a></li>
         
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
    <h1 class="makine">Makine Multimedya - Resim</h1>
    <asp:Panel runat="server" ID="panelBsr1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Resim Ekleme Başarılı</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Resim Ekleme Başarısız</span></p></asp:Panel>
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
            <table width="868" height="22">
            <tr>
            <td style="vertical-align:top" class="auto-style1">
                Resim Seç:<br />
              </td>
            <td style="vertical-align:middle">
                <strong>Eklediğiniz resim jpg,jpeg,gif veya png formatında olmalıdır.</strong><br />
                Çoklu seçim yapabilirsiniz. İlk resmi seçip &quot;aç&quot; dedikten sonra aşağıda resmin eklendiğini göreceksiniz. İşlemleri tekrar edip tüm resimleri ekledikten sonra &quot;Kaydet&quot; butonuna basınız.<br /><br />
                <asp:Panel runat="server" ID="panelAnaResim" Width="343px"> 
                <asp:FileUpload
    ID="fileAnaResim"  class="multi" runat="server" />&nbsp;&nbsp;<br /><br />
                    <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator3" runat="server" ControlToValidate="fileAnaResim"
                    ErrorMessage="Yalnızca jpg,jpeg,gif veya png dosyaları eklenebilir.." ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"></asp:RegularExpressionValidator>
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
           <tr>
               <td colspan="2">
<br />
                    <asp:Panel runat="server" ID="panelBasarili" Visible="false"> 
        <p class="info" id="success"><span class="info_inner">İşlem başarılı.</span></p>
        </asp:Panel>
        <asp:Panel runat="server" ID="panelBasarisiz" Visible="false"> 
        <p class="info" id="error"><span class="info_inner">İşlem başarısız.</span></p>
        </asp:Panel>
                   
                   
                   <br />



               </td>


           </tr>
              
            
            
            
</table>
            <br />
            <table>
               <tr>
                    <td class="auto-style1" style="vertical-align:top">
                        Mevcut Resimler:
                    </td>
                    <td>
                        <asp:ListBox runat="server" ID="listMevcut" CssClass="smallInput" Height="197px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="listMevcut_SelectedIndexChanged"></asp:ListBox>
                        
                    </td>
                   <td class="auto-style2">&nbsp;&nbsp; <asp:Image ImageUrl="" runat="server" ID="imageMevcut" /> </td>
                   <td>
                       <asp:Button Text="Seçili Resmi Sil" runat="server" OnClick="Unnamed1_Click1" /></td>

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
