<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineEkle2.aspx.cs" Inherits="MarmaraMakine.yonetim.makineEkle2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 87px;
        }
    </style>
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
    <asp:Panel runat="server" ID="panelBsr1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Ana resim ekleme başarılı.</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Ana resim ekleme başarısız.</span></p></asp:Panel>
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
            Ana Resim:<br />
              </td>
            <td style="vertical-align:middle">
                Makine sayfalarında detaylar kısmının üzerindeki resimdir.<br /><br />
                <asp:Panel runat="server" ID="panelAnaResim" Width="343px"> 
                <asp:FileUpload
    ID="fileAnaResim" CssClass="smallInput" runat="server" />&nbsp;&nbsp;<br /><br />
                    <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator3" runat="server" ControlToValidate="fileAnaResim"
                    ErrorMessage="Yalnızca Jpeg,gif ve png dosyaları eklenebilir.." ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"></asp:RegularExpressionValidator>
                </asp:Panel>
                <br /><br />
                <asp:Panel runat="server" ID="panelResimBasarili" Visible="false">

                </asp:Panel>
                <asp:Panel runat="server" ID="panelResimBasarisiz" Visible="false"></asp:Panel>


 </td>
            </tr>
             <tr>
            <td style="vertical-align:top" colspan="2">
                <asp:Button Text="Kaydet ve Devam Et" runat="server" OnClick="Unnamed1_Click" /><br /><div class="portlet-content nopadding">

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
