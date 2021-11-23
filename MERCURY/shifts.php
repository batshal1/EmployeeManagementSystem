<?php include('functions2.php');
include("userInfo.php");
//GetInfo();
 ?>

<!DOCTYPE html>
<html ng-app='calendarApp' ng-cloak='true'>
  <head>
  <title>Calendar</title>
    <meta content='text/html; charset=UTF-8' http-equiv='Content-Type'>
    <meta charset='utf-8'>
    <link href='css/Style.css' rel='stylesheet' type='text/css'>
    <!--<link href='css/dashboard.css' rel='stylesheet' type='text/css'>-->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <link href='https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css' rel='stylesheet' type='text/css'>

  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.css" />
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha.6/css/bootstrap.css" />
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js"></script>



  </head>
  <body>
 <nav class='main-menu'>
      <div>
        <a class='logo' href='http://startific.com'></a>
      </div>
      <div class='settings'></div>
      <div class='scrollbar' id='style-1'>
        <ul>
          <li>
            <a href='shifts.php'>
              <i class='fa fa-calendar fa-lg'></i>
              <span class='nav-text'>Shifts</span>
            </a>
          </li>
          <li>
            <a href='dashboard.php'>
              <i class='fa fa-calendar fa-lg'></i>
              <span class='nav-text'>Leaves</span>
            </a>
          </li>
          <li>
            <a href='announcement.php'>
              <i class='fa fa-comments fa-lg'></i>
              <span class='nav-text'>Announcements</span>
            </a>
          </li>
          <li>
            <a href='personalinfo.php'>
              <i class='fa fa-user fa-lg'></i>
              <span class='nav-text'>Profile</span>
            </a>
          </li>
          <?php if( GetPosition() == "administrator"): ?>
          <li>
            <a href='adminpage.php'>
              <i class='fa fa-users fa-lg'></i>
              <span class='nav-text'>Users</span>
            </a>
          </li>
          <?php endif; ?>
          <li>
            <a href='stock.php'>
              <i class='fa fa-home fa-lg'></i>
              <span class='nav-text'>Stock</span>
            </a>
          </li>

           <li>
           <a href="logout.php"><i class="fa fa-sign-out fa-lg" name = "logout"></i><span class="nav-text">Logout</span></a>
          </li>
        </ul>
      </div>
    </nav>
<!--<br />
  <h1 align="center">Dashboard</h1>
  <br />-->

  <!--<div class="container">
   <div id="calendar"></div>
  </div>-->

  <p align="center"><iframe src="shift/shifts.php" width="100%" height= "1200px">
</iframe></p>
 



  </body>
</html>
