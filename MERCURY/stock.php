<!DOCTYPE html><html class="menu">
<?php include "config.php" ?>
<?php include('functions2.php');
include("userInfo.php"); ?>
<html>
<head>
  <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
  <meta name="google" value="notranslate"/>
  <title>Stock Overview</title>
  <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/css/bootstrap.min.css"/>
  <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css"/>
 
  <script type="text/javascript" src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
  <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/js/bootstrap.min.js"></script>
  <script type="text/javascript" src="https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js"></script>
  <script type="text/javascript" src="https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js"></script>
  <link rel="stylesheet" type="text/css" href="css/Style.css">
<link rel="stylesheet" type="text/css" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

</head>
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
<body>
  <div class="container">
    <div class="row justify-content-center">
      <div class="col-lg-10 bg-light rounded my-2 py-2">
        <h4 class="text-center text-dark pt-2">Stock Overview</h4>
        <hr>
        <table class="table table-bordered table-striped table-hover">
          <thead>
            <tr>
              <th>ID</th>
              <th>Product</th>
              <th>Type</th>
              <th>Brand</th>
              <th>Quantity</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            <?php
              $sql = "SELECT * FROM products";
              $res = $conn->query($sql);
              while ($row=$res->fetch_assoc()) {
            ?>
            <tr>
              <td><?= $row['id'] ?></td>
              <td><?= $row['product'] ?></td>
              <td><?= $row['type'] ?></td>
              <td><?= $row['brand'] ?></td>
              <td><?= $row['quantity'] ?></td>
              <td><?= $row['price'] ?></td>
            </tr>
            <?php } ?>
          </tbody>
        </table>
      </div>
    </div>
  </div>
  <script type="text/javascript">
    $(document).ready(function(){
      $('table').DataTable();
    });
  </script>
</body>
</html>