<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="makineMultimedyaVideo.aspx.cs" Inherits="MarmaraMakine.yonetim.makineMultimedyaVideo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function bitti() {
            
            $('#yuklemeDiv').css("visibility", 'hidden');
            $('#yuklemeDiv2').css("visibility", 'visible');
        }

        
        function basladi
            (sender, args) {
            var filename = args.get_fileName();
            var ext = filename.substring(filename.lastIndexOf(".") + 1);
            if (ext != 'MP4' && ext!='mp4') {
                throw { 
                    name:        "Hatalı dosya türü", 
                    level:       "Hata", 
                    message: "Sadece mp4 türünde dosya eklenebilir.",
                    htmlMessage: "Sadece mp4 türünde dosya eklenebilir."
                }
            
                return false;
            }
            else {
                $('#yuklemeDiv2').css("visibility", 'hidden');
                $('#yuklemeDiv').css("visibility", 'visible');
            }
            return true;
        }

           

        
 </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    


<div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="makineEkle.aspx"><span>Makine Ekle</span></a></li>
                      <li><a href="makineDuzenle.aspx"><span>Makine Düzenle</span></a></li>
                      <li><a href="makineSil.aspx" ><span>Makine Sil</span></a></li>
                      <li><a href="makineMultimedya.aspx" class="current"><span>Makine Multimedya</span></a></li>
         
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
        

    <h1 class="makine">Makine Multimedya - Video</h1>

            <asp:Panel runat="server" ID="panelBsr2" Visible="false">
            <p class="info" id="error"><span class="info_inner">Video Ekleme Başarısız</span></p></asp:Panel>
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
            <td style="vertical-align:top">
                <br />
              </td>
            <td style="vertical-align:middle">
                Eklediğiniz video &quot;mp4&quot; formatlarında olmalıdır.<br /><br /><br />
                Video Seç<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
                <asp:AsyncFileUpload ID="AsyncFileUpload1" runat="server" OnUploadedComplete="AsyncFileUpload1_UploadedComplete" OnClientUploadComplete="bitti" OnClientUploadStarted="basladi" UploaderStyle="Modern" Width="400px" /><br /><br />
                <div id="yuklemeDiv" style="visibility:hidden">
<img src="images/loading.gif" id="yukleme"/>&nbsp;&nbsp;<span id="Yazı">Yükleniyor. Lütfen bekleyiniz işleminiz dosya boyutuna bağlı olarak uzun sürebilir.</span>

                </div>
                <div id="yuklemeDiv2" style="visibility:hidden">
<p class="info" id="success"><span class="info_inner">Video Ekleme Başarılı</span></p>

                </div>
                <br /><br />
               
                <br /><br />



 </td>
            </tr>
             <tr>
            <td style="vertical-align:top" colspan="2">

                
                        &nbsp;&nbsp;<br />
                
                
                <div class="portlet-content nopadding"></div><br /><br />

                
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
