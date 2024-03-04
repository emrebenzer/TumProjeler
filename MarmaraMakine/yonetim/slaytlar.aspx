<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="slaytlar.aspx.cs" Inherits="MarmaraMakine.yonetim.slaytlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 119px;
        }
        .style2
        {
            vertical-align: middle;
            font-size: 26px;
            width: 160px;
        }
        .style4
        {
            width: 362px;
        }
        .style6
        {
            width: 713px;
        }
        .style7
        {
            width: 449px;
        }
        .style8
        {
            width: 160px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      
                      <li><a href="" class="current"><span>Slaytlar</span></a></li>
                                 
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
    <h1 class="slayyt">Slayt Düzenlemeleri</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END--><!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START --><!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END -->
    <div class="clear"></div>
    <!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
        <asp:Panel runat="server" ID="panelBasarili" Visible="false"> 
        <p class="info" id="success"><span class="info_inner">İşlem başarılı.</span></p>
        </asp:Panel>
        <asp:Panel runat="server" ID="panelBasarisiz" Visible="false"> 
        <p class="info" id="error"><span class="info_inner">İşlem başarısız.</span></p>
        </asp:Panel>
    <br />
    <b>Slayt Resmi Sil</b>
		<div class="portlet-content nopadding">
        <br />
        <table style="margin-left:30px; width: 826px;">
        <tr>
        <td class="style1">Slayt Listesi:
        <br />
            <asp:ListBox runat="server" CssClass="smallInput" ID="listListele" 
                Height="154px" Width="118px" >
            </asp:ListBox>
        </td>
        <td width="20" class="ok">
            &nbsp;</td>
        <td class="style2" style="vertical-align:middle">
            <a id="A1" class="button_notok" runat="server" onserverclick="button1_Click"><span>Slayt Resmini Sil</span></a></td>
        <td width="350" style="vertical-align:middle">
        <span>Silmek istediğiniz Slayt İsminin hangi resim olduğunu öğrenmek için sayfanın altındaki önizleme bölümüne bakınız.</span>
        </td>
        </tr>
        
        
        </table>
        
		</div><br />
        <b>Slayt Resmi Ekle</b>
        <div class="portlet-content nopadding">
        <br /><br />
        <table width="882" style="margin-left:30px">
        <tr>
        <td colspan="4">
        <b>Uyarı: </b>Ekleyeceğiniz slayt 780x330 boyutlarına çevrilecektir. Bu yüzden ekleyeceğiniz resmin boy/uzunluk oranı 780/330=2,36 olursa en güzel sonucu alırsınız. <br /><br />
        </td>
        </tr>
        <tr>
        
        <td style="padding-top:16px" class="style7"><label><b>Slayt Resmi Seç:</b>
            <asp:FileUpload ID="fileUpload1" runat="server" CssClass="smallInput"/></label>
            <br />
            </td>
        <td style="vertical-align:middle" class="style8"><label><b>Slayt İsmi Yazınız:</b><asp:TextBox 
                runat="server" CssClass="smallInput" ID="txtSlaytIsmi" >Slayt</asp:TextBox>
            </label></td>
        <td style="vertical-align:middle;padding-top:10px" class="style4">
        <a id="A2" class="button_ok" runat="server" onserverclick="button2_Click"><span>Resmi Ekle</span></a>
        </td>
        <td class="style6" style="padding-top:15px">
        <br /><span style="color:Red;font-size:14px">
        <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator3" runat="server" ControlToValidate="fileUpload1"
                    ErrorMessage="Yalnızca Jpeg,gif ve png dosyaları eklenebilir.." ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"></asp:RegularExpressionValidator></span>
        
        </td>
        </tr>
        
        </table>
        
        </div>
        <br />
        <b>Slayt Önizleme</b>
        <div class="portlet-content nopadding">
        <br /><br />
        <table width="639" style="margin-left:30px">
            <asp:Repeater runat="server" ID="rptResimListele">
                <ItemTemplate>
                <tr>

        <td width="63" style="vertical-align:middle"><%# Eval("SlaytIsim") %></td>
        <td width="377"><img src="../resim/<%# Eval("SlaytURL") %>" width="373px" height="160px"/></td>
        <td width="183" style="vertical-align:middle">&nbsp;</td>
        
        </tr>
        <tr height="30px"><td colspan="3"></td></tr>
                </ItemTemplate>
            </asp:Repeater>
        
        </table>
        
        </div>
      </div>
<!--  END #PORTLETS -->  
   </div>
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>
<div class="clear"> </div>

</div>
<!-- WRAPPER END -->
<!-- FOOTER START -->

</asp:Content>
