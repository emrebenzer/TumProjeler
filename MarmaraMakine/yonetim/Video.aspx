<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="MarmaraMakine.yonetim.Video" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="Default.aspx" class="current"><span>Eğitim Videoları</span></a></li>
                      <li><a href="mesajlar.aspx"><span>Mesajlar</span></a></li>
                                 
           </ul>
        </div>
    </div>
<!-- TABS END -->    
</div>


<!-- CONTENT START -->
    <div class="grid_16" id="content">
    <!--  TITLE START  --> 
    <div class="grid_9">
    <h1 class="vieo">Video</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR--><!--RIGHT TEXT/CALENDAR END--><!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    <div id="portlets">
    <!-- FIRST SORTABLE COLUMN START -->
      <div class="column" id="left" style="margin-left:15px;width:800px" >
      <!--THIS IS A PORTLET--><!--THIS IS A PORTLET-->
        <div class="portlet">
            
          <div class="portlet-content2">&nbsp;
              
		    <center><OBJECT classid='clsid:02BF25D5-8C17-4B23-BC80-D3488ABDDC6B' width="600" height="375" codebase='http://www.apple.com/qtactivex/qtplugin.cab'>
<param name='src' value="images/<%=adres%>">
<param name='autoplay' value="true">
<param name='controller' value="false">
<param name='loop' value="false">
<EMBED src="images/<%=adres.ToString()%>" width="600" height="375" autoplay="true" 
controller="false" loop="false" bgcolor="#000000" pluginspage='http://www.apple.com/quicktime/download/'>
</EMBED>
</OBJECT>  </center>

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

</asp:Content>
