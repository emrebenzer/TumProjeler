<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="sirket_bilgileri.aspx.cs" Inherits="MarmaraMakine.yonetim.sirket_bilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      
                      <li><a href="" class="current"><span>İletişim Bilgileri</span></a></li>
                      <li><a href="mailBilgileri.aspx"><span>Mail Bilgileri</span></a></li>
                                 
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div> 

<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="sirkett">İletişim Bilgileri</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END--><!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left" style="margin-left:15px" >
      <!--THIS IS A PORTLET--><!--THIS IS A PORTLET-->
        <div class="portlet">
          <div class="portlet-content2"><br /><br /><br />
            Sitede iletişim kısmında ve alt bölümde bulunan iletişim bilgilerini bu bölümden güncelleyebilirsiniz.<br /><br />
              <asp:Panel runat="server" ID="panelBasarili" Visible="false">
              <p class="info" id="success"><span class="info_inner">Bilgileriniz başarılı bir şekilde güncellendi.</span></p>
              </asp:Panel>
              <asp:Panel runat="server" ID="panelBasarisiz" Visible="false">
              <p class="info" id="error"><span class="info_inner">Bilgiler güncellenemedi. Lütfen daha sonra tekrar deneyin.</span></p>
              </asp:Panel>
          
		  <h3>Bilgiler</h3>
		  <form id="form1" name="form1" method="post" action="">
		    <p>
		      <label>Telefon</label>
                <asp:TextBox runat="server" class="smallInput" ID="txtTelefon" Width="190px"/>
		      
		      <label>Fax<br />
		        <asp:TextBox runat="server" class="smallInput" ID="txtFax" Width="190px"/>
		        </label>
		      <label>Adres - Türkçe<span style="font-size:9px;font-family:Arial"> - ( Lütfen enter kullanmayınız )</span></label>
		      <asp:TextBox runat="server" class="smallInput" ID="txtAdresTR" 
                    TextMode="MultiLine" Height="55px" Width="284px"/>
		 
		      <label>Adres - İngilizce<span style="font-size:9px;font-family:Arial"> - ( Lütfen enter kullanmayınız )</span></label>
              	      <asp:TextBox runat="server" class="smallInput" ID="txtAdresEN" 
                    TextMode="MultiLine" Height="55px" Width="284px"/>
                       <label>İletişim E-Posta <br />
		        <asp:TextBox runat="server" class="smallInput" ID="txtIletisimEMail" Width="190px"/>
		        </label>


		      <a class="button_ok" runat="server" onServerClick="Button1_Click"><span>Güncelle</span></a>
		      </p>
          </form>
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
