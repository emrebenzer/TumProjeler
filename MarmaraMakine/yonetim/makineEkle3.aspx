<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineEkle3.aspx.cs" Inherits="MarmaraMakine.yonetim.makineEkle3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 19px;
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
                      <li><a href="makineDuzenle.aspx" ><span>Makine Düzenle</span></a></li>
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
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START -->
	<!--  SECOND SORTABLE COLUMN END -->
    <div style="float:left">
        <div style="margin-top: 20px; margin-bottom: 20px; margin-left: 20px; width: 870px;
            border: 1px solid #ECECEC; padding: 10px">
            <table width="868px">
             <tr>
            <td style="vertical-align:top" colspan="2">
                <br />
            
            </td>

            </tr>
            
            <tr>
            <td colspan="2">Teknik Özellikler - Yeni Özellik Ekle<br /><div class="portlet-content nopadding">

		</div>
                <br /></td>

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
            <td class="auto-style1"><br /></td>
            <td class="auto-style1"></td>
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
                  <asp:Button ID="Button5" Text="Kaydet" runat="server" onclick="Unnamed3_Click1" />
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
                <tr>
            <td style="vertical-align:top">
            Makinedeki mevcut özellikler
            
            </td>
            <td style="vertical-align:middle">
                <asp:ListBox runat="server" class="smallInput" Height="182px" Width="389px" 
                    ID="listOzellikler">

                </asp:ListBox>

        &nbsp;&nbsp;<asp:Button ID="Button4" Text="Özellik Sil" runat="server" onclick="Unnamed4_Click" />
            </td>
            </tr>
                <tr>
                    <td colspan="2"><asp:Panel runat="server" ID="panelSil1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Özellik silme başarılı..</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelSil2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Özellik silme başarısız...</span></p></asp:Panel></td>


                </tr>
            
            
            
</table>
            
            </div>
        <asp:Button Text="Makineyi Kaydet" runat="server" OnClick="Unnamed1_Click" />
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
