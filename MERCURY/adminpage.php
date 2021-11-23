<!DOCTYPE html><html class="menu">
<?php include "config.php" ?>
<?php include('functions2.php');
include("userInfo.php"); ?>
<html>
<head>

<title>Admin Page</title>
<link rel="stylesheet" type="text/css"href="css/adminpage.css">
<link rel="stylesheet" type="text/css" href="css/Style.css">
<link rel="stylesheet" type="text/css" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

  <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/css/bootstrap.min.css"/>
<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css"/>
 
<script type="text/javascript" src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js"></script>
</head>
<body class="bginfo">
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
        </ul>
        <ul class="logout">
        <li>
           <a href="logout.php"><i class="fa fa-sign-out fa-lg" name = "logout"></i><span class="nav-text">Logout</span></a>
          </li>
          </ul>
      </div>
    </nav>
  <div class="container">
    <div class="row justify-content-center">
      <div class="col-lg-10 bg-light rounded my-2 py-2">
        <h4 class="text-center text-dark pt-2">Employee Overview</h4>
        <hr>
        <table class="table table-bordered table-striped table-hover">
          <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
              <th>Surname</th>
              <th>Gender</th>
              <th>Edit</th>
              <th>View</th>
            </tr>
          </thead>
          <tbody>
            <?php
              $sql = "SELECT * FROM employees";
              $res = $conn->query($sql);
              while ($row=$res->fetch_assoc()) {
            ?>
            <tr>
              <td><?= $row['id'] ?></td>
              <td><?= $row['firstname'] ?></td>
              <td><?= $row['lastname'] ?></td>
              <td><?= $row['gender'] ?></td>
              <td><a class="btn btn-primary" href = "edit.php?id=<?= $row['id']; ?>">Edit</a></td>
              <td><a class="btn btn-danger" href = "view.php?id=<?= $row['id']; ?>">View</a></td>
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

