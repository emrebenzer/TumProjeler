/*-----------------------------------------------------------------------------------*/
/* 		Mian Js Start
/*-----------------------------------------------------------------------------------*/
(function(cash) { "use strict";
				 
    /*-----------------------------------------------------------------------------------*/
	/* 		Magnific Popup
	/*-----------------------------------------------------------------------------------*/				 

	$('.popup-with-zoom-anim').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: true,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-zoom-in'
	});
	$('.popup-with-move-anim').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: true,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-slide-bottom'
	});
	$("#owl-gallery").owlCarousel({
		   navigation : true, // Show next and prev buttons
		   slideSpeed : 300,
		   paginationSpeed : 400,
		   singleItem:true,
		   autoPlay:true,
		   mouseDrag : false,
		   rewindSpeed : 1000,
		   navigationText: ["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
		   transitionStyle : "fade"

	  });
	$('.image-popup').magnificPopup({
			type: 'image',
			closeOnContentClick: true,
			mainClass: 'mfp-img-mobile',
			enabled: true,
			duration: 3000, 
			image: {
			verticalFit: true
			}
		});
	$('.popup-vedio').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: true,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-zoom-in'
	});
	$('.popup-vedio').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: true,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-slide-bottom'
	});
				 
	/*-----------------------------------------------------------------------------------*/
	/* 		Swiper Slide
	/*-----------------------------------------------------------------------------------*/
				 
    if ($('.wall-baner').length){ 
    var wall_container;         
		 $(function(){
			 wall_container = $('.wall-baner').swiper({
				slidesPerView: 1,
                calculateHeight: true,
                speed: 1000,
				loop: true,
				resistance: false,
                grabCursor: true 
			});
		});
    }
				 
    /*-----------------------------------------------------------------------------------*/
	/* 		Menu On Click
	/*-----------------------------------------------------------------------------------*/   
				 
    $('.dropdown a > .fa').on( "click", function() {
        var LinkThis = $(this).parent().parent();
        if (LinkThis.find('.dropdown-menu').hasClass('slideUp')) {
            LinkThis.find('.dropdown-menu').removeClass('slideUp');
        }else {
            $('.dropdown .dropdown-menu').removeClass('slideUp');
            LinkThis.find('.dropdown-menu').addClass('slideUp');
        }
        return false;
    });

	/*-----------------------------------------------------------------------------------*/
	/* 		Baner Click
	/*-----------------------------------------------------------------------------------*/

	////////////// BANNER 1  /////////////

		$( ".showr" ).on( "click", function() {
		  $( ".banner-coll" ).first().show( "fast", function showNext() {
			$( this ).next( ".banner-coll" ).show( "fast", showNext );
		  });
		});

		$( ".hidr" ).on( "click", function() {
		  $( ".banner-coll" ).hide( 0 );
		});

	////////////// BANNER 2  //////////////
				 
		$( ".showr1" ).on( "click", function() {
		  $( ".banner-coll1" ).first().show( "fast", function showNext() {
			$( this ).next( ".banner-coll1" ).show( "fast", showNext );
		  });
		});

		$( ".hidr1" ).on( "click", function() {
		  $( ".banner-coll1" ).hide( 0 );
		});

	////////////// BANNER 2  //////////////

		$( ".showr2" ).on( "click", function() {
		  $( ".banner-coll2" ).first().show( "fast", function showNext() {
			$( this ).next( ".banner-coll2" ).show( "fast", showNext );
		  });
		});

		$( ".hidr2" ).on( "click", function() {
		  $( ".banner-coll2" ).hide( 0 );
		});

	//////////////// BANNER 3  //////////////////

		$( ".showr3" ).on( "click", function() {
		  $( ".banner-coll3" ).first().show( "fast", function showNext() {
			$( this ).next( ".banner-coll3" ).show( "fast", showNext );
		  });
		});

		$( ".hidr3" ).on( "click", function() {
		  $( ".banner-coll3" ).hide( 0 );
		});

	///////////////// BANNER 2  /////////////////

		$( ".showr4" ).on( "click", function() {
		  $( ".banner-coll4" ).first().show( "fast", function showNext() {
			$( this ).next( ".banner-coll4" ).show( "fast", showNext );
		  });
		});

		$( ".hidr4" ).on( "click", function() {
		  $( ".banner-coll4" ).hide( 0 );
		});

	/*-----------------------------------------------------------------------------------*/
	/* 		Back to Top
	/*-----------------------------------------------------------------------------------*/

	$(window).scroll(function(){
	 if($(window).scrollTop() > 1000){
		  $("#back-to-top");
		} else{
		  $("#back-to-top");
		}
	});
	$('#back-to-top, .back-to-top').click(function() {
		  $('html, body').animate({ scrollTop:0 }, '3000');
		  return false;
	});
	
	/*-----------------------------------------------------------------------------------*/
	/* 		Google Map
	/*-----------------------------------------------------------------------------------*/             
    
     function initialize(obj) {
		var lat = $('#'+obj).attr("data-lat");
        var lng = $('#'+obj).attr("data-lng");
		var contentString = $('#'+obj).attr("data-string");
		var myLatlng = new google.maps.LatLng(lat,lng);
		var map, marker, infowindow;
		var image = 'images/marker.png';
		var zoomLevel = parseInt($('#'+obj).attr("data-zoom"));

		var styles = [{"featureType":"landscape","stylers":[{"saturation":-100},{"lightness":65},{"visibility":"on"}]},{"featureType":"poi","stylers":[{"saturation":-100},{"lightness":51},{"visibility":"simplified"}]},{"featureType":"road.highway","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"road.arterial","stylers":[{"saturation":-100},{"lightness":30},{"visibility":"on"}]},{"featureType":"road.local","stylers":[{"saturation":-100},{"lightness":40},{"visibility":"on"}]},{"featureType":"transit","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"administrative.province","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"labels","stylers":[{"visibility":"on"},{"lightness":-25},{"saturation":-100}]},{"featureType":"water","elementType":"geometry","stylers":[{"hue":"#ffff00"},{"lightness":-25},{"saturation":-97}]}]
		
		var styledMap = new google.maps.StyledMapType(styles,{name: "Styled Map"});
	
		var mapOptions = {
			zoom: zoomLevel,
			disableDefaultUI: true,
			center: myLatlng,
            scrollwheel: false,
			mapTypeControlOptions: {
            mapTypeIds: [google.maps.MapTypeId.ROADMAP, 'map_style']
			}
		}
		
		map = new google.maps.Map(document.getElementById(obj), mapOptions);
	
		map.mapTypes.set('map_style', styledMap);
		map.setMapTypeId('map_style');
	
		infowindow = new google.maps.InfoWindow({
			content: contentString
		});
      
	    
        marker = new google.maps.Marker({
			position: myLatlng,
			map: map,
			icon: image
		});
	
		google.maps.event.addListener(marker, 'click', function() {
			infowindow.open(map,marker);
		});
	
	}           			 

	/*-----------------------------------------------------------------------------------*/
	/* 		Window load
	/*-----------------------------------------------------------------------------------*/

	$(window).load(function() {
	  if($('#map-canvas-contact').length==1){
		 initialize('map-canvas-contact');}	
		
	  $('#carousel').flexslider({
		animation: "slide",
		controlNav: false,
		animationLoop: true,
		slideshow: true,
		itemWidth: 130,
		itemMargin: 5,
		asNavFor: '#slider'
	  });

	  $('#slider').flexslider({
		animation: "slide",
		controlNav: false,
		animationLoop: true,
		slideshow: true,
		sync: "#carousel"
	  });
		
	  
	 });

	 new UISearch( document.getElementById( 'sb-search' ) );


})(jQuery);