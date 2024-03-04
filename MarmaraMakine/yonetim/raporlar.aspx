<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="raporlar.aspx.cs" Inherits="MarmaraMakine.raporlar" %>

<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      
                      <li><a href="" class="current"><span>Raporlar</span></a></li>
                                 
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>
 

<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="rapor">Raporlar</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END-->
    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
    <div class="clear"></div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
        <div class="portlet-header fixed"><img src="images/icons/user.gif" width="16" height="16" alt="Latest Registered Users" />Sayfaları Ziyaret Edilme İstatistikleri</div>
		<div class="portlet-content nopadding">
        <center>
        <br />
          <table cellpadding="0" cellspacing="0" id="box-table-a" summary="Employee Pay Sheet">
            <thead>
              <tr>

                <th width="180" scope="col">Kategori İsmi</th>
                <th width="350" scope="col">Sayfa İsmi</th>
                <th width="100" scope="col" style="text-align:center">Ziyaret Sayısı</th>
              </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="rptRaporlar">
                    <ItemTemplate>
                    <tr>
                <td><%# Eval("KategoriIsim") %></td>
                <td><%# Eval("MakineIsimTR") %></td>
                <td style="text-align:center"><%# Eval("Sayi") %></td>
   
              </tr>
                    </ItemTemplate>
                </asp:Repeater>
              
              
              <tr class="footer">
                <td colspan="1"></td>
                <td align="right" colspan="2">
                <cc1:CollectionPager ID="CollectionPager1" runat="server" ShowPageNumbers="True"
                            LabelText="&nbsp;&nbspSayfa&nbsp" PageSize="15" PageNumbersDisplay="Numbers" PageNumbersSeparator="&amp;nbsp;"
        PageNumbersStyle="" PageNumberStyle="" NextText="&nbsp;&nbsp;&nbspİleri" LastText="Son"
                            BackText="Geri&nbsp;&nbsp;&nbsp" FirstText="İlk" ControlCssClass="pagination" ResultsFormat="{2} tane referanstan {0} - {1} arası gösteriliyor" BackNextDisplay="HyperLinks" BackNextLinkSeparator="" BackNextLocation="Split" SliderSize="15" UseSlider="True">
                        </cc1:CollectionPager>
                
                
                
                </td>
                
              </tr>
            </tbody>
          </table>
          </center>
        
		</div>
      </div>
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

		<!-- This contains the hidden content for modal box calls -->
		<div class='hidden'>
			<div id="inline_example1" title="This is a modal box" style='padding:10px; background:#fff;'>
			<p><strong>This content comes from a hidden element on this page.</strong></p>
            			
			<p><strong>Try testing yourself!</strong></p>
            <p>You can call as many dialogs you want with jQuery UI.</p>
			</div>
		</div>
</div>
<!-- WRAPPER END -->
<!-- FOOTER START -->


</asp:Content>
