<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="mailBilgileri.aspx.cs" Inherits="MarmaraMakine.yonetim.mailBilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      
                      <li><a href="sirket_bilgileri.aspx"><span>İletişim Bilgileri</span></a></li>
                      <li><a href="" class="current"><span>Mail Bilgileri</span></a></li>
                                 
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>


<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="maill">MailMail Bilgileri</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END--><!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left" style="margin-left:15px;width:800px" >
      <!--THIS IS A PORTLET--><!--THIS IS A PORTLET-->
        <div class="portlet">
          <div class="portlet-content2"><br />
              <br />
              <br />
            Sitenin iletişim bölümünde bulunan iletişim formunun çalışabilmesi için ihtiyaç duyduğu bilgiler bu bölümden düzenlenmektedir.<br /><b>NOT:</b> Bu bölümde yapacağınız en ufak bir hata iletişim formunuzun çalışmamasına sebep olabilir.<br /><br />
		  <h3>Bilgiler</h3>
          <asp:Panel runat="server" ID="panelBasarili" Visible="false">
              <p class="info" id="success"><span class="info_inner">Bilgileriniz başarılı bir şekilde güncellendi.</span></p>
              </asp:Panel>
              <asp:Panel runat="server" ID="panelBasarisiz" Visible="false">
              <p class="info" id="error"><span class="info_inner">Bilgiler güncellenemedi. Lütfen daha sonra tekrar deneyin.</span></p>
              </asp:Panel>
		  
		   
		      <label>SMTP Mail Adresi</label>
		      <asp:TextBox runat="server" class="smallInput" ID="txtSMTPMailAdresi" Width="190px"/>
		        <label>SMTP Kullanıcı Adı<br /></label>
		        <asp:TextBox runat="server" class="smallInput" ID="txtSMTPKullaniciAdi" Width="190px"/>
		        
		       <label>SMTP Şifre<br /></label>
		        <asp:TextBox runat="server" class="smallInput" ID="txtSMTPSifre" Width="190px"/>
                <label>SMTP Giden Kutusu Adresi<br /></label>
		        <asp:TextBox runat="server" class="smallInput" ID="txtGidenKutusu" Width="190px"/>
		        <label>Mesajın Gönderileceği Mail Adresi <br /></label>
		        <asp:TextBox runat="server" class="smallInput" ID="txtGonderilecekMail" Width="190px"/>
		        
		      <a class="button_ok" runat="server" onServerClick="Button1_Click"><span>Güncelle</span></a>
		      

		  <p>&nbsp;</p>

		</div>
        </div>
      </div>
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
    <div class="clear"></div>
    <!--THIS IS A WIDE PORTLET--><!--  END #PORTLETS -->  
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
