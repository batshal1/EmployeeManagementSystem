<?php include('functions2.php');
include("userInfo.php");

//GetInfo();
 ?>

<!DOCTYPE html><html class="menu">
<html>

<head>
 
<meta charset="utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="google" value="notranslate"/>
<title>Announcement</title>
<link rel="stylesheet" type="text/css"href="css/announcementStyle.css">
<link rel="stylesheet" type="text/css" href="css/Style.css">
<link rel="stylesheet" type="text/css" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

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
  <div class = "main-icon">
    <span> 
      <h1 style="text-align: center;"> ANNOUNCEMENTS</h1>
    <div class="container">
    <table class="table">
      <tr>
        
        <th>Timespan</th>
        <th>Announcement</th>
      </tr>
      <?php
        include 'config.php'; 
        $query = mysqli_query($conn, "SELECT * FROM announcement where expiredate >= curdate()  ORDER BY id DESC ");
          while ($row = mysqli_fetch_array($query)) 
          {
            ?>
            <tr>
              <td><?php echo $row['publishdate'];?> Till <?php echo $row['expiredate'];?></td>
              <td><?php echo $row['announcement'];?></td>
            </tr>
          <?php } ?>
    </table>
  </div>
    </span>
  </div>

  
</body>
</html>