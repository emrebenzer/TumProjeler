<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="mesajlar.aspx.cs" Inherits="MarmaraMakine.yonetim.mesajlar" %>

<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="Default.aspx"><span>Eğitim Videoları</span></a></li>
                      <li><a href="" class="current"><span>Mesajlar</span></a></li>
                                 
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
    <h1 class="maill">Mesajlar</h1>
    
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END--><!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
    <div class="clear"></div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
        <div class="portlet-header fixed"></div>
		<div class="portlet-content nopadding">
        <form action="" method="post">
          <table width="100%" cellpadding="0" cellspacing="0" id="box-table-a" summary="Employee Pay Sheet">
            <thead>
              <tr>

                <th width="100" scope="col">Gönderen</th>
                <th width="85" scope="col">Firma</th>
                <th width="90" scope="col">Telefon</th>
                <th width="120" scope="col">E-mail</th>
                <th width="180" scope="col">Mesaj</th>
                <th width="80" scope="col">Tarih</th>
                
              </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="rptMesajlar">
                    <ItemTemplate>
                    <tr>
</td>
                <td><%# Eval("IsimSoyad") %></td>
                <td><%# Eval("Firma") %></td>
                <td><%# Eval("Telefon") %></td>
                <td><%# Eval("EMail") %></td>
                <td><%# Eval("Mesaj") %></td>
                <td><%# Eval("Tarih") %></td>
                
              </tr>
                    </ItemTemplate>
                </asp:Repeater>

              <tr class="footer">
                <td colspan="4"></td>
                <td align="right">&nbsp;</td>
                <td align="right">
				<!--  PAGINATION START  --> 
                
                
                <cc1:CollectionPager ID="CollectionPager1" runat="server" ShowPageNumbers="True"
                            LabelText="&nbsp;&nbspSayfa&nbsp" PageSize="12" PageNumbersDisplay="Numbers" PageNumbersSeparator="&amp;nbsp;"
        PageNumbersStyle="" PageNumberStyle="" NextText="&nbsp;&nbsp;&nbspİleri" LastText="Son"
                            BackText="Geri&nbsp;&nbsp;&nbsp" FirstText="İlk" ControlCssClass="pagination" ResultsFormat="{2} tane referanstan {0} - {1} arası gösteriliyor" BackNextDisplay="HyperLinks" BackNextLinkSeparator="" BackNextLocation="Split" SliderSize="15" UseSlider="True">
                        </cc1:CollectionPager>
                        
                                   
                     
                <!--  PAGINATION END  -->       
                </td>
              </tr>
            </tbody>
          </table>
        </form>
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

</asp:Content>
