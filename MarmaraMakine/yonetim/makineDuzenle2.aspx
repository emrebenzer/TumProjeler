<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineDuzenle2.aspx.cs" Inherits="MarmaraMakine.yonetim.makineDuzenle2" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <asp:Panel runat="server" ID="panelBsr1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Makine isim ve içerik güncellemesi başarılı.</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Makine isim ve içerik güncellemesi başarısız.</span></p></asp:Panel>
    </div>

    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left">
      <!--THIS IS A PORTLET-->
		<div class="portlet">
            <div class="portlet-header"><img src="images/tr.png" width="21" height="16" alt="Reports" />Türkçe</div>
            <div class="portlet-content">
            <!--THIS IS A PLACEHOLDER FOR FLOT - Report & Graphs -->
            <div id="placeholder" style="width:auto; height:auto">
            <label>Makine İsim</label>
                <asp:TextBox runat="server" ID="txtTurkceIsim" class="smallInput wide" style="width:420px"/>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        <label>Detaylar</label>
                <CKEditor:CKEditorControl ID="ckTurkceDetay" class="smallInput wide" 
                    runat="server" Width="425" BasePath="ckeditor" 
                    ContentsCss="ckeditor/contents.css" 
                    TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                    Toolbar="Basic" BackColor="#FFFF99"></CKEditor:CKEditorControl>
        
            
            
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
		  <div id="placeholder2" style="width:auto; height:auto;">
          <label>Machine Name</label>
        <asp:TextBox runat="server" ID="txtEnglishIsim" class="smallInput wide" style="width:420px"/>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        <label>Details</label>
        <CKEditor:CKEditorControl ID="ckEnglishDetails" class="smallInput wide" 
                    runat="server" Width="425" BasePath="ckeditor" 
                    ContentsCss="ckeditor/contents.css" 
                    TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                    Toolbar="Basic" BackColor="#FFFFCC"></CKEditor:CKEditorControl>
          
          </div>
		</div>
       </div>   
           &nbsp;&nbsp;
              
          <asp:Button ID="Button3" Text="Başlık ve İçeriği Güncelle" runat="server" 
              onclick="Unnamed1_Click" />
                <br /><br /> 
      <!--THIS IS A PORTLET--></div>
	<!--  SECOND SORTABLE COLUMN END -->
    <div style="float:left">
        <div style="margin-top: 20px; margin-bottom: 20px; margin-left: 20px; width: 870px;
            border: 1px solid #ECECEC; padding: 10px">
            <table width="868" height="22">
            <tr>
            <td style="vertical-align:top">
            Ana Resim:<br />
                <asp:Image ImageUrl="" runat="server" ID="imageAnaResim" width="209"/>
              </td>
            <td style="vertical-align:middle">
&nbsp;&nbsp;<asp:Button ID="Button1" Text="Ana Resim Değiştir" runat="server" onclick="Unnamed2_Click" />&nbsp;&nbsp;<br /><br />
                <asp:Panel runat="server" ID="panelAnaResim" Visible="false" Width="343px"> 
                <asp:FileUpload
    ID="fileAnaResim" CssClass="smallInput" runat="server" />&nbsp;&nbsp;<asp:Button ID="Button2" Text="Değiştir" runat="server" 
                    onclick="Unnamed3_Click" /> <br /><br />
                    <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator3" runat="server" ControlToValidate="fileAnaResim"
                    ErrorMessage="Yalnızca Jpeg,gif ve png dosyaları eklenebilir.." ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"></asp:RegularExpressionValidator>
                </asp:Panel>
                <br /><br />
                <asp:Panel runat="server" ID="panelResimBasarili" Visible="false">
                    <p class="info" id="success"><span class="info_inner">Resim Ekleme Başarılı..</span></p>

                </asp:Panel>
                <asp:Panel runat="server" ID="panelResimBasarisiz" Visible="false"><p class="info" id="error"><span class="info_inner">Resim Ekleme başarısız. Lütfen bir süre sonra tekrar deneyiniz.</span></p></asp:Panel>


 </td>
            </tr>
             <tr>
            <td style="vertical-align:top" colspan="2">
<br /><br /><br />Teknik Özellikler - Özellik Sil<br /><div class="portlet-content nopadding">

		</div><br /><br />
            
            </td>

            </tr>
            <tr>
            <td style="vertical-align:top">
                Makinedeki mevcut özellikler
            
            </td>
            <td style="vertical-align:middle">
                <asp:ListBox runat="server" class="smallInput" Height="182px" Width="389px" 
                    ID="listOzellikler">

                </asp:ListBox>

        &nbsp;&nbsp;<asp:Button Text="Özellik Sil" runat="server" onclick="Unnamed4_Click" />
            &nbsp;&nbsp;&nbsp;<a href="TeknikOzellikDuzenle.aspx" style="margin-bottom:10px">Teknik Özellik Düzenle</a>
            </td>
            </tr>
            <tr>
            <td colspan="2"><asp:Panel runat="server" ID="panelSil1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Özellik silme başarılı..</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelSil2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Özellik silme başarısız...</span></p></asp:Panel><br /><br />Teknik Özellikler - Yeni Özellik Ekle/><div class="portlet-content nopadding">

		</div><br /><br /></td>

            </tr>
            <tr>
            <td width="213">
                Mevcut Özelliklerden Seç
            </td>
            <td width="643">
 
              <asp:DropDownList runat="server" class="smallInput" ID="ddlMevcutOzellik" 
                    style="width:250px" 
                    onselectedindexchanged="ddlMevcutOzellik_SelectedIndexChanged">

              </asp:DropDownList>
    </td>
            </tr>
            
            <tr>
            <td><br /></td>
            <td></td>
            </tr>
            
            <td style="vertical-align:top">
                <asp:Button Text="Yeni Özellik Ekle" ID="btnYeniOzellikAc" runat="server" 
                    Width="158px" onclick="btnYeniOzellikAc_Click" />
            </td>
            
            <td>
            <table width="645">
            <tr>
                
            <td width="246">
                <asp:Panel runat="server" ID="panelYeniOzellik1" Visible="false">
                <label>Türkçe - Özellik İsmi</label>
                <asp:TextBox runat="server" class="smallInput2" ID="txtOzellikTR"/>
                </asp:Panel>
            
		      </td>
            <td width="239"> <asp:Panel runat="server" ID="panelYeniOzellik2" Visible="false"><label>English - Name of Specification</label>
		      <asp:TextBox runat="server" class="smallInput2" ID="txtOzellikEN"/></asp:Panel></td>
              <td width="144" style="vertical-align:middle">
                  <asp:Button Text="Yeni Özelliği Ekle" ID="btnOzelligiEkle" Visible="false" 
                      runat="server" onclick="btnOzelligiEkle_Click" />
              </td>
            </tr>
            </table>
                <asp:Panel runat="server" ID="panelOzellikEkleBasarili" Visible="false">
                <p class="info" id="success"><span class="info_inner">Yeni Özellik Eklendi. Lütfen eklediğiniz yeni özelliği yukarıdan seçip aşağıya değerini giriniz.</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelOzellikEkleBasarisiz" Visible="false">
            <p class="info" id="error"><span class="info_inner">Yeni Özellik Eklenemedi. Lütfen kısa bir süre sonra tekrar deneyiniz.</span></p></asp:Panel>
            <asp:Panel runat="server" ID="pnl3" Visible="false">
            <p class="info" id="error"><span class="info_inner">Lütfen mevcut özelliklerden seçim yapınız.</span></p></asp:Panel>
            
            
            
            
            </td>
            </tr>
            <tr>
            <td><br /></td>
            <td></td>
            </tr>
            <tr>
            <td colspan="2">
            <table width="645">
            <tr>
            <td width="246"><label>Türkçe - Değer</label>
                <asp:TextBox runat="server" ID="txtValueTR" class="smallInput2"/></td>
            <td width="239"><label>English - Value</label>
                <asp:TextBox runat="server" class="smallInput2" ID="txtValueEN" /></td>
              <td width="144" style="vertical-align:bottom">
                  <asp:Button Text="Kaydet" runat="server" onclick="Unnamed3_Click1" />
              </td>
            </tr>
            </table>
                <asp:Panel runat="server" ID="panelYeniOzellikBasarili" Visible="false"> 
                <p class="info" id="success"><span class="info_inner">Yeni Özellik makineye başarı ile eklendi.</span></p> 
                </asp:Panel>
                <asp:Panel runat="server" ID="panelYeniOzellikBasarisiz" Visible="false">  
                <p class="info" id="error"><span class="info_inner">Yukarıdan mevcut özellik kısmından seçim yaptığınızdan emin olun.Eminseniz daha sonra tekrar deneyiniz.</span></p>
                </asp:Panel>
            
            
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
<!-- WRAPPER END -->
<!-- FOOTER START -->
</asp:Content>
