<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineEkle.aspx.cs" Inherits="MarmaraMakine.yonetim.makineEkle" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="" class="current"><span>Makine Ekle</span></a></li>
                      <li><a href="makineDuzenle.aspx"><span>Makine Düzenle</span></a></li>
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
    <h1 class="makine">Makine Ekle</h1>

            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Bir hata oluştu. Lütfen bir süre sonra tekrar deneyiniz.</span></p></asp:Panel>
    </div>

    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
        <table>
            <tr>
                <td>Kategori seçiniz:&nbsp;&nbsp;</td>
                <td>        <asp:DropDownList runat="server" CssClass="smallInput" Width="250" ID="ddlKategori" OnSelectedIndexChanged="ddlKategori_SelectedIndexChanged">

        </asp:DropDownList>&nbsp;&nbsp;&nbsp;Makineyi eklemek istediğiniz kategoriyi seçiniz.</td>

            </tr>

        </table>

        <br />
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left">
      <!--THIS IS A PORTLET-->
		<div class="portlet">
            <div class="portlet-header"><img src="images/tr.png" width="21" height="16" alt="Reports" />Türkçe</div>
            <div class="portlet-content">
            <!--THIS IS A PLACEHOLDER FOR FLOT - Report & Graphs -->
            <div id="placeholder" style="height:auto; width: 433px;">
            Makine İsim<asp:TextBox runat="server" ID="txtTurkceIsim" class="smallInput" style="width:420px"/>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        Detaylar
                <ckeditor:ckeditorcontrol ID="ckTurkceDetay" class="smallInput" 
                    runat="server" Width="425" BasePath="ckeditor" 
                    ContentsCss="ckeditor/contents.css" 
                    TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                    Toolbar="Basic" BackColor="#FFFF99"></ckeditor:ckeditorcontrol>
        
            
            
            </div>
            </div>
        </div>
        
             
              
      <!--THIS IS A PORTLET--></div>
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START -->
      <div class="column">
      <!--THIS IS A PORTLET-->        
      <div class="portlet">
		<div class="portlet-header"><img src="images/en.png" width="20" height="16" alt="Comments" />English</div>

		<div class="portlet-content">
		  <div id="placeholder2" style="width:435px; height:auto;">
          Machine Name
        <asp:TextBox runat="server" ID="txtEnglishIsim" class="smallInput" style="width:420px"/>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        Details
        <ckeditor:ckeditorcontrol ID="ckEnglishDetails" class="smallInput" 
                    runat="server" Width="425" BasePath="ckeditor" 
                    ContentsCss="ckeditor/contents.css" 
                    TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                    Toolbar="Basic" BackColor="#FFFFCC"></ckeditor:ckeditorcontrol>
          
          </div>
		</div>
       </div>   
           &nbsp;&nbsp;
              
          <asp:Button ID="Button1" Text="Kaydet ve Devam Et" runat="server" 
              onclick="Unnamed1_Click" />
                <br /><br /> 
      <!--THIS IS A PORTLET--></div>
	<!--  SECOND SORTABLE COLUMN END -->
    <div style="float:left">
        <div style="margin-top: 20px; margin-bottom: 20px; margin-left: 20px; width: 870px;
            border: 1px solid #ECECEC; padding: 10px">
            
            </div>
    
    </div>
    <div class="clear">
    
    
    </div>
    <!--THIS IS A WIDE PORTLET-->
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

		<!-- This contains the hidden content for modal box calls -->

</div>



</asp:Content>
