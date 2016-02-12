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

// Remove flash notices after 5 seconds
$(document).ready(function(){
  setTimeout(function(){
    $('#flash').remove();
  }, 5000);
});

// make parent class active with child in navbar dropdowns
$(document).ready(function(){
  
  var selector = '.nav li';

  $(selector).on('click', function(){
      $(selector).removeClass('active');
      $(this).addClass('active');
  });
});

// Automatically start carousel and change slides every 2 seconds
$(document).ready(function() {
	$('.carousel').carousel({
	   interval: 8000
	})
}); 

