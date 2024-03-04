<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="bilgi_sayfalari.aspx.cs" Inherits="MarmaraMakine.yonetim.bilgi_sayfalari" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      
                      <li><a href="" class="current"><span>Hakkımızda</span></a></li>
                                 
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>
<!-- HIDDEN SUBMENU START -->
<div class="grid_16" id="hidden_submenu">
	  <ul class="more_menu">
		<li><a href="#">More link 1</a></li>
		<li><a href="#">More link 2</a></li>  
	    <li><a href="#">More link 3</a></li>    
        <li><a href="#">More link 4</a></li>                               
      </ul>
	  <ul class="more_menu">
		<li><a href="#">More link 5</a></li>
		<li><a href="#">More link 6</a></li>  
	    <li><a href="#">More link 7</a></li> 
        <li><a href="#">More link 8</a></li>                                  
      </ul>
	  <ul class="more_menu">
		<li><a href="#">More link 9</a></li>
		<li><a href="#">More link 10</a></li>  
	    <li><a href="#">More link 11</a></li>  
        <li><a href="#">More link 12</a></li>                                 
      </ul>            
  </div>
<!-- HIDDEN SUBMENU END -->  

<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="bilgisayfasi">Hakkımızda</h1><asp:Panel runat="server" ID="panelBasarili" Visible="false">
            <p class="info" id="success"><span class="info_inner">Bilgiler başarı ile güncellendi</span></p><br />
            </asp:Panel>
            <asp:Panel runat="server" ID="panelBasarisiz" Visible="false">  
            <p class="info" id="error"><span class="info_inner">Bilgiler güncellenemedi. Kısa bir süre sonra tekrar deneyiniz</span></p><br />
            </asp:Panel>
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
            <label>Hakkımızda Başlık</label>
                <asp:TextBox ID="txtBaslikTurkce" runat="server" class="smallInput wide" Width="420px"></asp:TextBox>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        <label>İçerik</label>
                <CKEditor:CKEditorControl ID="ckEditorTR" runat="server" Height="380px"
                  BasePath="ckeditor" ContentsCss="ckeditor/contents.css" 
                  TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                  Toolbar="Basic" 
                  ToolbarBasic="Bold|Italic|-|NumberedList|BulletedList|-|Link|Unlink|-|Copy|Paste|" ToolbarFull="Source|-|Preview|-|Templates
Cut|Copy|Paste|PasteText|PasteFromWord|-|SpellChecker|Scayt
Undo|Redo|-|Find|Replace|-|RemoveFormat
Form|
Bold|Italic|Underline|Strike|-|Subscript|Superscript
NumberedList|BulletedList|-|Outdent|Indent|Blockquote|CreateDiv
JustifyLeft|JustifyCenter|JustifyRight|JustifyBlock
BidiLtr|BidiRtl
Link|Unlink|Anchor
Image|Flash|Table|HorizontalRule|Smiley|SpecialChar|PageBreak|Iframe
/
Styles|Format|Font|FontSize
TextColor|BGColor
Maximize|ShowBlocks|-|About"></CKEditor:CKEditorControl>
        
            
            
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
          <label>About Us Title</label>
        <asp:TextBox ID="txtBaslikEnglish" runat="server" class="smallInput wide" Width="420px"></asp:TextBox>
        <!--WYSIWYG Editor is linked to the textarea with id: #wysiwyg-->
        <label>Content</label>

              <CKEditor:CKEditorControl ID="ckEditorEN" runat="server" Height="380px"
                  BasePath="ckeditor" ContentsCss="ckeditor/contents.css" 
                  TemplatesFiles="ckeditor/plugins/templates/templates/default.js" 
                  Toolbar="Basic" 
                  ToolbarBasic="Bold|Italic|-|NumberedList|BulletedList|-|Link|Unlink|-|Copy|Paste|" ToolbarFull="Source|-|Preview|-|Templates
Cut|Copy|Paste|PasteText|PasteFromWord|-|SpellChecker|Scayt
Undo|Redo|-|Find|Replace|-|RemoveFormat
Form|
Bold|Italic|Underline|Strike|-|Subscript|Superscript
NumberedList|BulletedList|-|Outdent|Indent|Blockquote|CreateDiv
JustifyLeft|JustifyCenter|JustifyRight|JustifyBlock
BidiLtr|BidiRtl
Link|Unlink|Anchor
Image|Flash|Table|HorizontalRule|Smiley|SpecialChar|PageBreak|Iframe
/
Styles|Format|Font|FontSize
TextColor|BGColor
Maximize|ShowBlocks|-|About"></CKEditor:CKEditorControl>
          </div>
		</div>
       </div>    
      <!--THIS IS A PORTLET--></div>
	<!--  SECOND SORTABLE COLUMN END -->
    <div class="clear">
    
    
    </div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
      <a class="button_ok" runat="server" onServerClick="Button1_Click"><span>Güncelle</span></a>
    <br />
        <div class="portlet-header fixed">
        <br />
        <br />
            
            
        </div>
		<div class="portlet-content nopadding">

		</div>
      </div>
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

</div>

</asp:Content>
