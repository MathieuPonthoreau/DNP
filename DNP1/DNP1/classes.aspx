﻿<%@ Page Language="C#" AutoEventWireup="true"CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!--Bootstrap CSS stylesheet-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <!-- Personnal CSS stylesheet -->
    <link rel="stylesheet" type="text/css" href="css/main.css" />
    <title>ViaFit</title>
</head>
<body data-spy="scroll" data-target=".navbar">
    <div class="fixed-top">
        <!--Apply fixed-top to both navbar -->
        <!-- 1st Navbar -->
        <nav class="navbar navbar-expand-md bg-dark navbar-dark ">
            <a class="navbar-brand" href="Default.aspx">
                <img src="images/logo.jpg" alt="Logo" />
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbars">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse navbars" id="collapsibleNavbar">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="about.aspx">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="classes.aspx">Classes</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="info.aspx">Info</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="daily.aspx">Daily</a>
                    </li>
                </ul>
            </div>
        </nav>
        <!-- 2nd Navbar -->
        <nav class="navbar navbar-expand-md bg-secondary navbar-dark  sticky">
            <div class="collapse navbar-collapse navbars" id="collapsibleNavbar2">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="#fitness">Fitness</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#weightLifting">Weight Lifting <span class="badge badge-light">!</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#aquaFit">Aqua Fit</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#spin">Spin</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <!-- Banner -->
    <div class="jumbotron jumbotron-fluid jump-down banner">
        <div class="container text-light">
            <h1>VIAFIT</h1>
            <form id="form1" runat="server">
                <div>    
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Pseudo"></asp:TextBox>
                    <br/>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="log in" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible ="false"></asp:Label>
                </div>
            </form>
            <p>DANMARKS STØRSTE FITNESSCENTER FOR ALLE</p>
        </div>
    </div>
    <!-- Main container -->
    <div class="container rounded shadow bg-light">
        <!-- 1st class -->
        <h1 id="fitness">Fitness</h1>
        <div class="row">
            <div class="col-md-6">
                <img src="images/4.jpeg" alt="Fitness" class="img-fluid rounded shadow">
            </div>
            <div class="col-md-6">
                <p>
                    Super high energy class. The ultimate cardio and strength interval workout designed to work every inch of your body and maximize your post workout caloric expenditure.
                </p>
            </div>
        </div>
        <!-- 2nd class -->
        <h1 id="weightLifting">Weight Lifting</h1>
        <div class="row">
            <div class="col-md-6">
                <img src="images/1.jpeg" alt="bench" class="img-fluid rounded shadow">
            </div>
            <div class="col-md-6">
                <p>
                    A total body workout devoted to toning and defining your muscles, improving muscular strength and endurance. Work every muscle, at every angle, in every way!
                </p>
                <!-- Button to Open the Modal -->
                <div class="text-center">
                    <button type="button" class="btn btn-secondary " data-toggle="modal" data-target="#myModal">
                        Available Material
                    </button>
                </div>
            </div>
        </div>
        <!-- 3rd class -->
        <h1 id="aquaFit">Aqua Fit</h1>
        <div class="row">
            <div class="col-md-6">
                <img src="images/3.jpeg" alt="pool" class="img-fluid rounded shadow">
            </div>
            <div class="col-md-6">
                <p>
                    The intensity of the water aerobics class is determined by how hard you decide to work. This shallow water workout includes calisthenics style movements with variations of upper and lower body resistive moves. Participants march, jog and ski through the water to create resistance to improve cardiovascular fitness, muscular endurance and flexibility. Each instructor uses his/her creativity to keep the pace moving and the activities interesting. As the participant, you manipulate the water to create your preferred level of intensity.
                </p>
            </div>
        </div>
        <!-- 4th class -->
        <h1 id="spin">Spin</h1>
        <div class="row">
            <div class="col-md-6">
                <img src="images/2.jpeg" alt="spin" class="img-fluid rounded shadow">
            </div>
            <div class="col-md-6">
                <p>
                    Spinning provides a fun and challenging cardiovascular workout for all fitness levels. Experience a full ride of hills, sprints and endurance intervals with energizing music. Experience the benefits of a cardio workout plus strength building in one class.
                </p>
            </div>
        </div>
    </div>
    <!-- The Modal -->
    <div class="modal fade" id="myModal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h4 class="modal-title">Available Material</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <!-- Modal Body -->
                <div class="modal-body">
                    <div class="container">
                        <h2>Barbells</h2>
                        <div class="col-6 offset-3">
                            <img src="images/Barbells.png" alt="bar" class="img-fluid">
                        </div>
                        <h2>Ball</h2>
                        <div class="col-6 offset-3">
                            <img src="images/boule.jpg" alt="ball" class="img-fluid">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--End Modal-->
    <footer>
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-6 text-center  padding-1">
                    <h4 class="bg-secondary text-light shadow">Social Media</h4>
                    <ul class="list-group shadow">
                        <li class="list-group-item"><a class="text-dark" href="https://www.facebook.com/">Facebook</a></li>
                        <li class="list-group-item"><a class="text-dark" href="https://twitter.com/">Twitter</a></li>
                    </ul>
                </div>

                <div class="col-sm-6 text-center  padding-1">
                    <h4 class="bg-secondary text-light shadow">Contact</h4>
                    <ul class="list-group shadow">
                        <li class="list-group-item"><a class="text-dark" href="mailto:271715@via.dk">Mail</a></li>
                        <li class="list-group-item"><a class="text-dark" href="tel:+33612134678">Phone</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    <!-- Bootstrap core JavaScript  -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
