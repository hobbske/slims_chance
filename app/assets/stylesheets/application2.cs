/*
 * This is a manifest file that'll be compiled into application.css, which will include all the files
 * listed below.
 *
 * Any CSS and SCSS file within this directory, lib/assets/stylesheets, vendor/assets/stylesheets,
 * or any plugin's vendor/assets/stylesheets directory can be referenced here using a relative path.
 *
 * You're free to add application-wide styles to this file and they'll appear at the bottom of the
 * compiled file so the styles you add here take precedence over styles defined in any styles
 * defined in the other CSS/SCSS files in this directory. It is generally better to create a new
 * file per style scope.
 *
 *= require_tree .
 *= require_self
 *= require bootstrap-datepicker3
 */

  // import bootstrap-sprockets before bootstrap if using bootstrap >= 3.2
  @import 'bootstrap-sprockets';
  @import 'bootstrap-datetimepicker';
  @import "bootstrap-united";


body, h1, h2, h3, h4, h5, h6, p, li {
  font-family: 'Raleway', Helvetica, Arial, sans-serif;
  font-weight: 100px;
}

ul#menu-main li {  
  padding: 6px 0px;
  font-size: 12px;
  text-transform: uppercase;
  letter-spacing: 1.5px;
}

ul#menu-main li a:hover{  
  background: transparent;
  color: #581c08;
}

ul#sub-link li a:hover {  
  background: #DD4814;
  color: #fff;
}

.align-middle-yield {
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    margin: 0;
}

.home-two-header {
  margin: 5%;
  color: #fff;
}

.background-header {
  background: rgba(255,255,255,.7);
  border-radius: 15px;
}

.base-text {
  color: #581c08;
  letter-spacing: 2px;
}

.brand {
	margin: auto;
}

.table-hover tr:hover td,.table-hover tr:hover {
  color:#DD4814;
  background-color: rgba(221,72,20,.3);
}

.brand-text {
	color: #581c08;
	letter-spacing: 2px;
  margin: 10px;
}

.brand-logo {
  color: #581c08;
  font-size: 1.250em;
  text-transform: uppercase;
  letter-spacing: 2px;
  margin: 4% 0%;
  font-size: inherit;
}

.brand-logo:hover {
  color: #fff;
}

.brand-text-only {
  color: #581c08;
  letter-spacing: 2px;
}

.brand-text-lt {
  color: #DD4814;
  letter-spacing: 2px;
}

.btn-brand {
  color: #fff;
  background-color: rgba(221,72,20,1);
  border-color: rgba(132,43,12,1);
  letter-spacing: 1.5px;
}

.btn-brand:hover {
  color: #fff;
  background-color: rgba(132,43,12,1);
  border-color: rgba(221,72,20,1);
}

.col-centered {
  display: inline-block;
  float: none;
  text-align: left;
  margin-right: -4px;
}

.container-fluid {
  margin: 0;
  padding: 0;
  height: 100%
}

.form-outline {
  background: rgba(255,255,255,.5);
  border-style: solid;
  border-width: 1px;
  border-radius: 15px;
  border-color: rgba(221,72,20,0);
  padding: 5%;
  padding-top: 1%;
}

.default-text {
  color: #191919;
  margin: 10% 0%;
}

.brand-text-two {
  color: #191919;
  letter-spacing: 2px;
}

.default-textx {
  color: #191919;
  letter-spacing: 2px;
  margin-top: 4%;
}

.field-group {
  display: inline-block;
}


.jumbotron { 
  background-size: 100% 100%;
  border-radius: 15px;
  padding: 5px;
  margin-bottom: 0;
}

.jumbotron-brand { 
  background-color: none;
  background-size: 100% 100%;
  border-radius: 5px;
  padding: 5px;
  margin: 1%;
  color: rgba(221,72,20,1);
}

.jumbo-table {
    padding: 0px;   
    margin: 0% 0%;
    color: inherit;
    background-color: #eeeeee;
}

.jumbotron-title { 
  background-size: 100% 100%;
  border-radius: 15px;
  padding: 5px;
  margin-bottom: 0px;
}

.navbar {
  margin: 0;
}

.no-background {
  background: none;
  border: none;
}

.row-fluid {
    word-wrap: break-word;
}

.thead-brand { 
  background-color: rgba(221,72,20,1);
  background-size: 100% 100%;

  color: rgba(255,255,255,1);
}

.title-text {
  color: #581c08;
  margin-bottom: 0;

}

.well {
  margin: 3%;
  display: inline-block;
  text-align: center;

}

.white-text {
  color: rbga(250,250,250,1);
  letter-spacing: 2px;
  margin: 10px;
}

.align-center-slim {
  width: 100%;
  left: 0;
  right: 0;
  margin: 0%;
}

/*   ------------------ DESKTOP - SCREENS OVER 767px WIDE --------------------------*/

a.brand {
  color: #581c08;
  margin-right: 30px; 
  font-size: 18px;
  font-weight: 900px;
}

.breadcrumb {
  background: rgba(255,255,255,0);
  font-size: 10ox;
  padding: 0px 5px;
  margin: 0% 1%;
}

.center-slim-pic {
  display: inline-block
}

img.brand {
  margin: auto;
  margin-top: 5%;
  left: 20%;
}

ul.nav {
  font-size: 1.250em; // 12px
}

// ***** FONTS ***************************

h1 {
  font-size: 3.75em; // px
}

h2 {
  font-size: 3.00em;  // px
}

h3 {
  font-size: 2.5em; // px
}

h4 {
  font-size: 1.75em; // px
}

h5 {
  font-size: 1.250em; // 12px
}

h6 {
  font-size: 0.750em; // 10px
}

// ***** CAROUSEL - HOME ******************

.background {
  /* ... */
  width: 60%;
  height: 710px;
  background-color: #232323;
}

.carousel-caption {
  width: 60%; 
  height: 710px;
  margin: auto;
  background-size: cover;
}

.logo {
  /* ... */
  width: auto;
  height: 210px;
  margin-top: 28%;
  margin-bottom: 10%;
  margin-left: 0%;
}

.bottom {
  position: absolute; 
  bottom: 5%;
  left: 10%;
  right: 10%;
  width: 50%; 
  margin: 0 auto;
}

img.image {
  /* ... */
  width: 185%;
  height: 710px;
  margin: auto;
}

img.image-two {
  /* ... */
  width: 170%;
  height: 710px;
  margin: auto;
}

img.image-four {
  /* ... */
  width: 170%;
  height: 710px;
  margin: auto;
}


.bottom-btn {
  position: absolute; 
  bottom: 4%;
  left: 10%;
  right: 10%;
  width: 50%; 
  margin: 0 auto;
}

.bottom-btn-two {
  position: absolute; 
  bottom: 4%;
  left: 10%;
  right: 10%;
  width: 50%; 
  margin: 0 auto;
}

.bottom-btn-four {
  position: absolute; 
  bottom: 4%;
  left: 10%;
  right: 10%;
  width: 50%; 
  margin: 0 auto;
}

.bottom-caption {
  position: absolute; 
  bottom: 73%;
  left: 10%;
  right: 10%;
  width: 80%; 
  margin: 0 auto;
}

.bottom-caption-two {
  position: absolute; 
  bottom: 73%;
  left: 10%;
  right: 10%;
  width: 80%; 
  margin: 0 auto;
}

.bottom-caption-four {
  position: absolute; 
  bottom: 73%;
  left: 10%;
  right: 10%;
  width: 80%; 
  margin: 0 auto;
}

.tagline {
  position: absolute; 
  bottom: 15%;
  left: 2%;
  right: 2%;
  width: 93%; 
  margin: 0 auto;
}

.tagline-two {
  position: absolute; 
  bottom: 15%;
  left: 10%;
  right: 10%;
  width: 80%; 
  margin: 0 auto;
}

.tagline-four {
  position: absolute; 
  bottom: 15%;
  left: 10%;
  right: 10%;
  width: 80%; 
  margin: 0 auto;
}

#full-screen {
  padding: 0px;
  margin: 0px;
}

#slide-title {
  font-size: 38px;
  padding: 3%;
  margin: auto;
}

#slide-title-two {
  font-size: 38px;
  padding: 3%;
  margin: auto;
}

#slide-title-four {
  font-size: 38px;
  padding: 3%;
  margin: auto;
}

// ***** ABOUT SLIM ******************

.role-object {
  display: inline-block;
  color: white;
  width: 15%;
  height: auto;
  border-color: none;
  border-radius: 10px;
  background: url(<%= asset_path('about.png') %>);
}

.role-object-title {
  margin: 5px 0;
}

.media-object { 
  width: 64px; 
  height: 64px; 
  padding-bottom: 30px;
}


// ***** BASEBALL CAMP PAGE ******************

.role-object-bb {
  display: inline-block;
  color: white;
  width: 25%;
  height: auto;
  border-color: none;
  border-radius: 10px;
  background: url(<%= asset_path('about.png') %>);
}

.role-object-title-bb {
  margin: 5px 0;
}

.media-object-bb { 
  width: 64px; 
  height: 64px; 
  padding-bottom: 30px;
}



table {
  font-size: 0.875em;
}


/*   ------------------ MOBILE PORTRAIT -----------------   */

@media only screen and (max-width: 479px) {
  
  // ***** GENERAL *************************
  
  .align-middle {
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    margin: 0% 10%;
  }

  .breadcrumb {
    background: rgba(255,255,255,0);
    font-size: 10px;
    padding: 0px 5px;
    margin: 0% 1%;
  }

  // ***** NAVBAR **************************

  a.brand {
    color: #581c08;
    margin-right: 30px; 
    font-size: 1.000em;
    font-weight: 900px;
  }

  .center-slim-pic {
    display: inline-block
  }

  img.brand {
    height: 95%;
    margin: auto;
    margin-top: 2%;
    left: 20%;
  }

  ul.nav {
    font-size: 1.125em; // 18px
  }

  // ***** CAROUSEL - HOME ******************

  .background {
    /* ... */
    width: 100%;
    height: 560px;
    background-color: #232323;
  }

  .brand-text {
    color: #581c08;
    letter-spacing: 2px;
    margin: 0px;
  }

  .carousel-caption {
    width: 100%;
    text-align: center;
    margin: auto;
  }

  .carousel-indicators {
    bottom: 8%;
  }

  img.image {
    /* ... */
    width: 370px;
    height: 330px;
    margin: auto;
  }

  img.image-two {
    /* ... */
    width: 370px;
    height: 330px;
    margin: auto;
  }

  img.image-four {
    /* ... */
    width: 370px;
    height: 330px;
    margin: auto;
  }

  .logo {
    /* ... */
    width: auto;
    height: 110px;
    margin-top: 41%;
    margin-bottom: 5%;
    margin-left: 6%;
  }

  .bottom {
    position: absolute; 
    bottom: 5%;
    left: 10%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn {
    position: absolute; 
    bottom: 20%;
    left: 10%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn-two {
    position: absolute; 
    bottom: 20%;
    left: 10%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn-four {
    position: absolute; 
    bottom: 20%;
    left: 10%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-caption {
    position: absolute; 
    bottom: 45%;
    left: 10%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .bottom-caption-two {
    position: absolute; 
    bottom: 45%;
    left: 10%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .bottom-caption-four {
    position: absolute; 
    bottom: 45%;
    left: 10%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .tagline {
    position: absolute; 
    bottom: 29%;
    left: 2%;
    right: 2%;
    width: 93%; 
    margin: 0 auto;
  }

  .tagline-two {
    position: absolute; 
    bottom: 31%;
    left: 10%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .tagline-four {
    position: absolute; 
    bottom: 31%;
    left: 10%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .slide-title {
    padding: 3%;
    margin: auto;
  }

  #slide-title {
    font-size: 20px;
    padding: 3%;
    margin: auto;
  }

  #slide-title-two {
    font-size: 20px;
    padding: 3%;
    margin: auto;
  }

  #slide-title-four {
    font-size: 20px;
    padding: 3%;
    margin: auto;
  }


  // ***** BUTTONS *************************

  .btn-lg, .btn-group-lg > .btn {
    padding: 9px 11px;
    font-size: 14px;
    line-height: 1.3333333;
    border-radius: 6px;
  }

  

  // ***** FONTS ***************************

  h1 {
    font-size: 1.375em;
  }

  h2 {
    font-size: 1.250em;
  }

  h3 {
    font-size: 1.250em;
  }

  h4 {
    font-size: 0.875em;
  }

  h5 {
    font-size: 0.875em;
  }

  p {
    font-size: 0.625em;
  }

  // ***** EVENTS - TABLE ***************************

  table {
    font-size: 0.750em; // 12px
  }

  th:nth-of-type(2) {
  display: none;
  }

  td:nth-of-type(2) {
    display: none;
  }

  th:nth-of-type(5) {
    display: none;
  }

  td:nth-of-type(5) {
    display: none;
  }

  // ***** ABOUT SLIM ***************************

  .role-object-title {
    margin: 2% 0%;
  }

}




/*   ------------------ MOBILE LANDSCAPE -----------------   */
@media only screen and (min-width: 480px) and (max-width: 767px) {
  
  // ***** GENERAL *************************
  
  .align-middle {
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    margin: 0% 10%;
  }

  .breadcrumb {
    background: rgba(255,255,255,0);
    font-size: 10px;
    padding: 0px 5px;
    margin: 0% 1%;
  }

  // ***** NAVBAR **************************

  a.brand {
    color: #581c08;
    margin-right: 30px; 
    font-size: 1.000em;
    font-weight: 900px;
  }

  .center-slim-pic {
    display: inline-block
  }

  img.brand {
    height: 95%;
    margin: auto;
    margin-top: 1%;
    margin-left: 3%;
    left: 25%;
  }

  ul.nav {
    font-size: 1.125em; // 18px
  }

  // ***** CAROUSEL - HOME ******************

  .background {
    /* ... */
    width: 675px;
    height: 300px;
    background-color: #232323;
  }

  .brand-text {
    color: #581c08;
    letter-spacing: 2px;
    margin: 0px;
  }

  .carousel-caption {
    width: 675px;
    text-align: center;
    margin: auto;
  }

  .carousel-indicators {
    bottom: 7%;
  }

  img.image {
    /* ... */
    width: 740px;
    height: 100%;
    margin: auto;
  }

  img.image-two {
    /* ... */
    width: 700px;
    height: 100%;
    margin: auto;
  }

  img.image-four {
    /* ... */
    width: 650px;
    height: 100%;
    margin: auto;
  }

  .logo {
    /* ... */
    width: auto;
    height: 110px;
    margin-top: 40%;
    margin-bottom: 5%;
    margin-left: 20%;
  }

  .bottom {
    position: absolute; 
    bottom: 5%;
    left: 10%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn {
    position: absolute; 
    bottom: 34%;
    left: 7%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn-two {
    position: absolute; 
    bottom: 34%;
    left: 7%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-btn-four {
    position: absolute; 
    bottom: 34%;
    left: 7%;
    right: 10%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-caption {
    position: absolute; 
    bottom: 60%;
    left: 5%;
    right: 5%;
    width: 60%; 
    margin: 0 auto;

  }

  .bottom-caption-two {
    position: absolute; 
    bottom: 60%;
    left: 5%;
    right: 5%;
    width: 50%; 
    margin: 0 auto;
  }

  .bottom-caption-four {
    position: absolute; 
    bottom: 60%;
    left: 5%;
    right: 5%;
    width: 50%; 
    margin: 0 auto;
  }

  .tagline {
    position: absolute; 
    bottom: 60%;
    left: 2%;
    right: 2%;
    width: 80%; 
    margin: 0 auto;
  }

  .tagline-two {
    position: absolute; 
    bottom: 41%;
    left: 8%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .tagline-four {
    position: absolute; 
    bottom: 43%;
    left: 8%;
    right: 10%;
    width: 80%; 
    margin: 0 auto;
  }

  .slide-title {
    padding: 3%;
    margin: auto;
  }

  #slide-title {
    font-size: 1.250em;
    padding: 3%;
    margin: auto;
    display: none;
  }

  #slide-title-two {
    font-size: 1.250em;
    padding: 3%;
    margin: auto;
  }

  #slide-title-four {
    font-size: 1.250em;
    padding: 3%;
    margin: auto;
  }


  // ***** BUTTONS *************************

  .btn-lg, .btn-group-lg > .btn {
    padding: 7px 9px;
    font-size: 0.875em;
    line-height: 1.3333333;
    border-radius: 6px;
  }

  

  // ***** FONTS ***************************

  h1 {
    font-size: 1.375em;
  }

  h2 {
    font-size: 1.250em;
  }

  h3 {
    font-size: 1.250em;
  }

  h4 {
    font-size: 0.875em;
  }

  h5 {
    font-size: 0.875em;
  }

  p {
    font-size: 0.625em;
  }

  // ***** EVENTS - TABLE ***************************

  table {
    font-size: 0.750em; // 12px
  }

  th:nth-of-type(2) {
  display: none;
  }

  td:nth-of-type(2) {
    display: none;
  }

  th:nth-of-type(5) {
    display: none;
  }

  td:nth-of-type(5) {
    display: none;
  }

  // ***** ABOUT SLIM ***************************

  .role-object-title {
    margin: 2% 0%;
  }
}


/*   ------------------ ABOUT SLIM -----------------*/

#section-one { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-image: image-url("about.png") 50% 0 fixed;
  background-color: #232323;
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding-bottom: 10px;
}

#section-two {
  background: url(<%= asset_path('slim.jpg') %>) 100% 100% fixed;
  background-image: image-url("slim.jpg") 50% 0 fixed; 
  background-size: cover;
  background-repeat: no-repeat;
  background-color: #581c08;
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 200px 0;
}

#section-three { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-image: image-url("about.png") 50% 0 fixed;
  background-color: #232323;
  height: auto;
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 100px 0;
  color: #fff;
}


.hero-unit {
  background-color: rgba(255,255,255,0);
  color: rgba(255,255,255,1);
  padding: 10px;
  margin: 10px 0;
  box-shadow: 0 0 20px rgba(0,0,0,0.1);
}




/*   ------------------ SC BASEBALL CAMP -----------------*/

#scbc-one { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-image: image-url("about.png") 50% 0 fixed;
  background-color: #232323;
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding-bottom: 10px;
}

#scbc-two {
  background: url(<%= asset_path('baseball_camp_team.jpg') %>) 50% 0 fixed;
  background-image: image-url("baseball_camp_team.jpg") 50% 0 fixed; 
  background-size: cover;
  background-repeat: no-repeat;
  background-color: rgba(204,204,204,.4);
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 200px 0;
}

#scbc-three { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-image: image-url("about.png") 50% 0 fixed;
  background-color: #232323;
  height: auto;
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 100px 0;
  color: #fff;
}

/*   ------------------ OUR MISSION -----------------*/

#mission-one { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-color: #232323;
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding-bottom: 10px;
}

#mission-two {
  background: url(<%= asset_path('logo.png') %>) 50% 0 fixed;
  background-size: contain;
  background-repeat: no-repeat;
  background-color: rgba(204,204,204,.4);
  height: auto;  
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 200px 0;
}

#mission-three { 
  background: url(<%= asset_path('about.png') %>) 50% 0 fixed;
  background-color: #232323;
  height: auto;
  margin: 0 auto; 
  width: 100%; 
  position: relative; 
  box-shadow: 0 0 50px rgba(0,0,0,0.8);
  padding: 100px 0;
  color: #fff;
}


.hero-unit {
  background-color: rgba(255,255,255,0);
  color: rgba(255,255,255,1);
  padding: 10px;
  margin: 10px 0;
  box-shadow: 0 0 20px rgba(0,0,0,0.1);
}

.foundation-principles {
  background-color: rgba(204,204,204,.8);
  color: #581c08;
}

/*   ------------------ HOME PAGE -----------------*/



#home-one { 
  background: url(<%= asset_path('cover_photo_lg.jpg') %>) 50% 0 fixed;
  background-image: image-url("cover_photo_lg.jpg") 50% 0 fixed;
  background-repeat: no-repeat;
  background-color: #581c08;
  height: inherit;  
  margin: auto;
  padding-bottom: 10px;
}

#home-two {
  background: url(<%= asset_path('about.png') %>) 100% 100% fixed;
  background-image: image-url("about.png") 50% 0 fixed; 
  height: 500px;  
  margin: 0 auto; 
  position: relative;
  padding: 2% 0;
}

#home-three { 
  background: url(<%= asset_path('cover_photo_kid_bw2.jpg') %>);
  background-color: #232323;
  background-size: stretch;
  background-repeat: no-repeat;
  margin: 0 auto;
  margin-top: 50px;
  height: 100%;
  width: 100%;
  padding: 5% 0;
  color: #fff;
}

#about-object {
  margin: auto;
  color: rgba(255,255,255,1);
  width: 70%;
  background-color: rgba(255,248,167,0);
  border-radius: 15px;
  padding: 10px;
  font-size: 22px;
  letter-spacing: 2.0px;

}

#stat-object {
  margin: auto;
  color: #DD4814;
  width: 90%;
  background-color: rgba(255,255,255,0);
  padding: 10px;
  font-size: 22px;
  letter-spacing: 2.0px;

}

.border-home-bottom {
  border-bottom-style: solid;
  border-bottom-width: 30px;
  border-bottom-color: #DD4814;
}

.border-home-top {
  border-top-style: solid;
  border-top-width: 30px;
  border-top-color: #DD4814;
}

.container-home {
  height: 450px;
  margin: auto 0;  
}

.hero-unit {
  background-color: rgba(255,255,255,0);
  color: rgba(255,255,255,1);
  padding: 10px;
  margin: 10px 0;
  box-shadow: 0 0 20px rgba(0,0,0,0.1);
}

.center-vert {
  margin: 1% auto;
}

.image-circle {
  border-radius: 100%;
}

.stats {
  background-color: #ffffff;
  color: black;
  padding: 20px;
}

.stat-circle {
  border-style: solid;
  border-color: #DD4814;
  border-width: 6px;
  border-radius: 90%;
  margin: auto;
  padding: 2%;
}

.three-pillars {
  padding: 10px 0;
}

