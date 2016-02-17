// This is a manifest file that'll be compiled into application.js, which will include all the files
// listed below.
//
// Any JavaScript/Coffee file within this directory, lib/assets/javascripts, vendor/assets/javascripts,
// or any plugin's vendor/assets/javascripts directory can be referenced here using a relative path.
//
// It's not advisable to add code directly here, but if you do, it'll appear at the bottom of the
// compiled file.
//
// Read Sprockets README (https://github.com/rails/sprockets#sprockets-directives) for details
// about supported directives.
//

//= require jquery
//= require jquery_ujs
//= require turbolinks
//= require_tree .
//= require bootstrap
//= require moment
//= require bootstrap-datetimepicker
//= require bootstrap-datepicker
//= require owl.carousel

// Remove flash notices after 5 seconds
$(document).ready(function(){
  setTimeout(function(){
    $('#notice').remove();
    $('#alert').remove();
  }, 3000);

  $('.carousel').carousel({
     interval: 5000
  });

  $('.datepicker').datepicker();


  // Parallax init JS
  

  $('section[data-type="background"]').each(function(){
   // declare the variable to affect the defined data-type
   var $scroll = $(this);
                   
    $(window).scroll(function() {
      // HTML5 proves useful for helping with creating JS functions!
      // also, negative value because we're scrolling upwards                            
      var yPos = -($window.scrollTop() / $scroll.data('speed'));
       
      // background position
      var coords = '50% '+ yPos + 'px';

      // move the background
      $scroll.css({ backgroundPosition: coords });   
    }); // end window scroll
  });  // end section function

});


  


