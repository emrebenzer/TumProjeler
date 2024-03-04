<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="TeknikOzellikDuzenle.aspx.cs" Inherits="MarmaraMakine.yonetim.TeknikOzellikDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 213px;
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
    <asp:Panel runat="server" ID="panelBsr1" Visible="false">
                <p class="info" id="success"><span class="info_inner">Özellik Düzenleme Başarılı</span></p>
                </asp:Panel>
            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Özellik Düzenleme başarısız.</span></p></asp:Panel>
    </div>

    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left">
      <!--THIS IS A PORTLET-->
        
             
              
      <!--THIS IS A PORTLET-->Lütfen aşağıdan düzenlemek istediğiniz özelliği seçiniz. <asp:Panel runat="server" ID="pnlSecim" Visible="false">
            <p class="info" id="error"><span class="info_inner">Lütfen seçim yapınız...</span></p></asp:Panel></div>
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START -->
	<!--  SECOND SORTABLE COLUMN END -->
    <div style="float:left">
        <div style="margin-top: 20px; margin-bottom: 20px; margin-left: 20px; width: 870px;
            border: 1px solid #ECECEC; padding: 10px">
            <table width="868" height="22">
            
             
            <tr>
            <td style="vertical-align:top" class="auto-style1">
                Teknik özellikler
            
            </td>
            <td style="vertical-align:middle">
                <asp:ListBox runat="server" class="smallInput" Height="182px" Width="389px" 
                    ID="listOzellikler" OnSelectedIndexChanged="listOzellikler_SelectedIndexChanged" AutoPostBack="True">

                </asp:ListBox>

        &nbsp;&nbsp;&nbsp;&nbsp;</td>
            </tr>

            
            <tr>
            <td class="auto-style1"><br /></td>
            <td></td>
            </tr>
            
            <td style="vertical-align:top" class="auto-style1">
                &nbsp;</td>
            
            <td>
            <table width="645">
            <tr>
                
            <td width="246">
                <asp:Panel runat="server" ID="panelYeniOzellik1" >
                <label>Türkçe - Özellik İsmi</label>
                <asp:TextBox runat="server" class="smallInput2" ID="txtOzellikTR"/>
                </asp:Panel>
            
		      </td>
            <td width="239"> <asp:Panel runat="server" ID="panelYeniOzellik2"><label>English - Name of Specification</label>
		      <asp:TextBox runat="server" class="smallInput2" ID="txtOzellikEN"/></asp:Panel></td>
              <td width="144" style="vertical-align:middle">
                  <asp:Button Text="Özelliği Güncelle" ID="btnOzelligiEkle" 
                      runat="server" onclick="btnOzelligiEkle_Click" />
              </td>
            </tr>
            </table>
            
            
            
            
            </td>
            </tr>
            <tr>
            <td class="auto-style1"><br /></td>
            <td></td>
            </tr>
            <tr>
            <td colspan="2">
                &nbsp;</td>
            
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
