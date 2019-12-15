<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tracking.aspx.cs" Inherits="E_Business.WinFormUI.Tracking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<!-- Favicon-->
	<link rel="shortcut icon" href="Assets/img/fav.png">
	<!-- Author Meta -->
	<meta name="author" content="CodePixar">
	<!-- Meta Description -->
	<meta name="description" content="">
	<!-- Meta Keyword -->
	<meta name="keywords" content="">
	<!-- meta character set -->
	<meta charset="UTF-8">
	<!-- Site Title -->
	<title>E-Business</title>
     <link href="Assets/css/bootstrap.css" rel="stylesheet" />
    <link href="Assets/css/main.css" rel="stylesheet" />
    <link href="Assets/css/nouislider.min.css" rel="stylesheet" />
    <link href="Assets/css/nice-select.css" rel="stylesheet" />
    <link href="Assets/css/font-awesome.min.css" rel="stylesheet" />
    <link href="Assets/css/themify-icons.css" rel="stylesheet" />
    <link href="Assets/css/owl.carousel.css" rel="stylesheet" />
    <link href="Assets/css/linearicons.css" rel="stylesheet" />
    <link href="Assets/scss/theme/_contact.scss.css" rel="stylesheet" />
    <link  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Order Tracking</h1>
                    <nav class="d-flex align-items-center">
                        <a href="index.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
                        <a href="category.aspx">Fashon Category</a>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <!-- End Banner Area -->

     <!--================Tracking Box Area =================-->
    <section class="tracking_box_area section_gap">
        <div class="container">
            <div class="tracking_box_inner">
                <p>To track your order please enter your Order ID in the box below and press the "Track" button. This
                    was given to you on your receipt and in the confirmation email you should have received.</p>
                <form class="row tracking_form" action="#" method="post" novalidate="novalidate">
                    <div class="col-md-12 form-group">
                        <input type="text" class="form-control" id="order" name="order" placeholder="Order ID" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Order ID'">
                    </div>
                    <div class="col-md-12 form-group">
                        <input type="email" class="form-control" id="email" name="email" placeholder="Billing Email Address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Billing Email Address'">
                    </div>
                    <div class="col-md-12 form-group">
                        <button type="submit" value="submit" class="primary-btn">Track Order</button>
                    </div>
                </form>
            </div>
        </div>
    </section>
    <!--================End Tracking Box Area =================-->

     <script src="Assets/js/vendor/bootstrap.min.js"></script>
    <script src="Assets/js/vendor/jquery-2.2.4.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCjCGmQ0Uq4exrzdcL6rvxywDDOvfAu6eE"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4"
	 crossorigin="anonymous"></script>
    <script src="Assets/js/countdown.js"></script>
    <script src="Assets/js/gmaps.min.js"></script>
    <script src="Assets/js/ion.rangeSlider.js"></script>
    <script src="Assets/js/jquery.ajaxchimp.min.js"></script>
    <script src="Assets/js/jquery.magnific-popup.min.js"></script>
    <script src="Assets/js/jquery.nice-select.min.js"></script>
    <script src="Assets/js/jquery.sticky.js"></script>
    <script src="Assets/js/main.js"></script>
    <script src="Assets/js/nouislider.min.js"></script>
    <script src="Assets/js/owl.carousel.min.js"></script>
    <script src="Assets/js/parallax.min.js"></script>

</asp:Content>
