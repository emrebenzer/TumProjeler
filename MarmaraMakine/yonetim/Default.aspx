﻿<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MarmaraMakine.yonetim.AnaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        window.document.onkeydown = function (e) {
            if (!e) {
                e = event;
            }
            if (e.keyCode == 27) {
                lightbox_close();
            }
        }

        function lightbox_open() {
            var lightBoxVideo = document.getElementById("VisaChipCardVideo");
            window.scrollTo(0, 0);
            document.getElementById('light').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
            lightBoxVideo.play();
        }

        function lightbox_close() {
            var lightBoxVideo = document.getElementById("VisaChipCardVideo");
            document.getElementById('light').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
            lightBoxVideo.pause();
        }


    </script>
    <style type="text/css">
                #fade {
  display: none;
  position: fixed;
  top: 0%;
  left: 0%;
  width: 100%;
  height: 100%;
  background-color: black;
  z-index: 1001;
  -moz-opacity: 0.8;
  opacity: .80;
  filter: alpha(opacity=80);
}

#light {
  display: none;
  position: absolute;
  top: 50%;
  left: 50%;
  max-width: 600px;
  max-height: 360px;
  margin-left: -300px;
  margin-top: -180px;
  border: 2px solid #FFF;
  background: #FFF;
  z-index: 1002;
  overflow: visible;
}

#boxclose {
  float: right;
  cursor: pointer;
  color: #fff;
  border: 1px solid #AEAEAE;
  border-radius: 3px;
  background: #222222;
  font-size: 31px;
  font-weight: bold;
  display: inline-block;
  line-height: 0px;
  padding: 11px 3px;
  position: absolute;
  right: 2px;
  top: 2px;
  z-index: 1002;
  opacity: 0.9;
}

.boxclose:before {
  content: "×";
}

#fade:hover ~ #boxclose {
  display:none;
}

.test:hover ~ .test2 {
  display: none;
}



    </style>




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid_16">
<!-- TABS START -->
    <div id="tabs">
         <div class="container">
            <ul>
                      <li><a href="" class="current"><span>Eğitim Videoları</span></a></li>
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
    <h1 class="dashboard">Ana Sayfa</h1>
    </div>
    <!--RIGHT TEXT/CALENDAR-->
    <div class="grid_6" id="eventbox">

    </div>
    <!--RIGHT TEXT/CALENDAR END-->
    <div class="clear">
    </div>
    <!--  TITLE END  -->    
    <!-- #PORTLETS START -->
    
    <!-- FIRST SORTABLE COLUMN START -->
        <div style="margin-left:15px">
                <div id="light">
  <a class="boxclose" id="boxclose" onclick="lightbox_close();"></a>
  <video id="VisaChipCardVideo" width="600" controls>
      <source src="../videolar/egitim.mp4" type="video/mp4">
      <!--Browser does not support <video> tag -->
    </video>
</div>

<div id="fade" onClick="lightbox_close();"></div>
            <span>Eğitim videosunu izlemek için lütfen üzerine tıklayınız.</span><br /><br />
<a href="#" onclick="lightbox_open();"><img src="images/videoEgitim.png" name="Image21" border="0" id="Image21" /></a>







        </div>

        
      
      <!-- FIRST SORTABLE COLUMN END -->
      <!-- SECOND SORTABLE COLUMN START --><!--  SECOND SORTABLE COLUMN END --><!--THIS IS A WIDE PORTLET-->
    <div class="portlet">
        <div class="portlet-header fixed"></div>
      </div>
<!--  END #PORTLETS -->  
   
    <div class="clear"> </div>
<!-- END CONTENT-->    
  </div>

</asp:Content>
