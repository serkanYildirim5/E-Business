<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="E_Business.WinFormUI.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<!-- Favicon-->
	<link rel="shortcut icon" href="Assets/img/fav.png">
	<!-- Author Meta -->
	<meta name="author" content="CodePixar">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>


    <link href="Assets/css/bootstrap.css" rel="stylesheet" />
    <link href="Assets/css/main.css" rel="stylesheet" />
    <link href="Assets/css/nouislider.min.css" rel="stylesheet" />
    <link href="Assets/css/nice-select.css" rel="stylesheet" />
    <link href="Assets/css/font-awesome.min.css" rel="stylesheet" />
    <link href="Assets/css/themify-icons.css" rel="stylesheet" />
    <link href="Assets/css/owl.carousel.css" rel="stylesheet" />
    <link href="Assets/css/linearicons.css" rel="stylesheet" />

    <title>E-Business</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    	<!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Login/Register</h1>
					<nav class="d-flex align-items-center">
						<a href="index.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="category.aspx">Login/Register</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!--================Login Box Area =================-->
	<section class="login_box_area section_gap">
		<div class="container">
			<div class="row">
				<div class="col-lg-6">
					<div class="login_box_img">
						<img class="img-fluid" src="Assets/img/login.jpg" alt="">
						<div class="hover">
							<h4>New to our website?</h4>
							<p>There are advances being made in science and technology everyday, and a good example of this is the</p>
							<a class="primary-btn" href="registration.aspx">Create an Account</a>
						</div>
					</div>
				</div>
				<div class="col-lg-6">
					<div class="login_form_inner">
						<h3>Log in to enter</h3>
						<form class="row login_form" action="contact_process.php" method="post" id="contactForm" novalidate="novalidate">
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="name" name="name" placeholder="Username" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Username'">
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="name" name="name" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'">
							</div>
							<div class="col-md-12 form-group">
								<div class="creat_account">
									<input type="checkbox" id="f-option2" name="selector">
									<label for="f-option2">Keep me logged in</label>
								</div>
							</div>
							<div class="col-md-12 form-group">
								<button type="submit" value="submit" class="primary-btn">Log In</button>
								<a href="#">Forgot Password?</a>
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================End Login Box Area =================-->



     <script src="Assets/js/vendor/jquery-2.2.4.min.js"></script>
    <script src="Assets/js/vendor/bootstrap.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCjCGmQ0Uq4exrzdcL6rvxywDDOvfAu6eE"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4"
	 crossorigin="anonymous"></script>
    <script src="Assets/js/countdown.js"></script>
    <script src="Assets/js/gmaps.min.js"></script>
    <script src="Assets/js/ion.rangeSlider.js"></script>
    <script src="Assets/js/jquery.ajaxchimp.min.js"></script>
    <script src="Assets/js/jquery.nice-select.min.js"></script>
    <script src="Assets/js/jquery.magnific-popup.min.js"></script>
    <script src="Assets/js/jquery.sticky.js"></script>
    <script src="Assets/js/main.js"></script>
    <script src="Assets/js/nouislider.min.js"></script>
    <script src="Assets/js/owl.carousel.min.js"></script>
    <script src="Assets/js/parallax.min.js"></script>

</asp:Content>
