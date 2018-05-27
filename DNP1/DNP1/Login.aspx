﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
<body>
    <nav class="navbar navbar-expand-md bg-dark navbar-dark fixed-top">
        <a class="navbar-brand" href="Default.aspx">
            <img src="images/logo.jpg" alt="Logo" />
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="collapsibleNavbar">
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
    <!-- Banner -->
    <div class="jumbotron jumbotron-fluid banner">
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
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="~/Register.aspx">Register Here!</asp:HyperLink>
                     <asp:Button ID="Button2" runat="server" Visible="false" Text="Log out" OnClick="Button2_Click" />
                    <br />
                    <asp:HyperLink ID="HyperLink2" Visible="false" runat="server" NavigateUrl ="~/admin.aspx">Admin acces</asp:HyperLink>

                </div>
            </form>
            
            
            <p>DANMARKS STØRSTE FITNESSCENTER FOR ALLE</p>
        </div>
    </div>
    <!-- Main container -->
    <div class="container rounded shadow bg-light">
        <!-- 1st row -->
        <div class="row">
            <div class="col-md-12 text-center">
                You Need to be log in first!
            </div>
        </div>
    </div>
    <footer>
        <div class="container-fluid">
            <!-- 2nd row -->
            <div class="row">
                <div class="col-sm-6 text-center padding-1">
                    <h4 class="bg-secondary text-light shadow ">Social Media</h4>
                    <ul class="list-group shadow">
                        <li class="list-group-item"><a class="text-dark" href="https://www.facebook.com/">Facebook</a></li>
                        <li class="list-group-item"><a class="text-dark" href="https://twitter.com/">Twitter</a></li>
                    </ul>
                </div>

                <div class="col-sm-6 text-center padding-1">
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
