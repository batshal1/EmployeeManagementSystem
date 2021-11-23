<?php include "config.php" ?>
<?php include('functions2.php');
      include('userInfo.php'); 



$_SESSION['update'] = "";

if(isset($_POST['changepass_btn']))
{

 $newPassword = Encrypt($_POST['newPassword']);
 
 $currentPassword = Encrypt($_POST['currentPassword']);

 $confirmPassword = Encrypt($_POST['confirmPassword']);

 change($currentPassword, $newPassword, $confirmPassword);

}

?>

<!DOCTYPE html><html class="menu">
<html>

<head>
  <!-- Required meta tags -->
  <title>Profile</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

<link rel="stylesheet" href="personalinfo.css">
<link rel="stylesheet" type="text/css"href="css/personalinfo.css">
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


<!---------------Icon + Position Section------------------->
<div class="container">
<div class="col-lg-10 bg-light rounded my-2 py-2">
<table class="table">
  <thead>
    <tr>
      <th style="text-align: center;" colspan="2" scope="col">Personal Information</th>
    </tr>
  </thead>
  <tbody>
  <tr>
    <td>Name</th>
    <td><?php  echo GetName(); ?></th>
  </tr>
  <tr>
    <td>Surname</td>
    <td><?php  echo GetSurname(); ?></td>
  </tr>
  <tr>
    <td>Address</td>
    <td><?php echo GetAddress(); ?></td>
  </tr>
  <tr>
    <td>Zip Code</td>
    <td><?php echo GetZipCode(); ?></td>
  </tr>
  <tr>
    <td>City</td>
    <td><?php echo GetCity(); ?></td>
  </tr>
  <tr>
    <td>Gender</td>
    <td><?php echo GetGender(); ?></td>
  </tr>
  <tr>
    <td>Birth Date</td>
    <td><?php echo GetDateOfBirth(); ?></td>
  </tr>
  <tr>
    <td>Started Since</td>
    <td><?php echo GetStartDate(); ?></td>
  </tr>
  <tr>
    <td>Email</th>
    <td><?php  echo GetEmail(); ?></th>
  </tr>
  <tr>
    <td>Phone Number</td>
    <td><?php  echo GetPhoneNumber(); ?></td>
  </tr>
  <tr>
    <td>Employee Position:</td>
    <td><?php  echo GetPosition(); ?></td>
  </tr>
  <tr>
    <td><a class="btn btn-primary" href = "editPersonal.php?id=<?= GetId(); ?>">Edit</a></td>
  </tr>
  </tbody>
</table>
</div>
</div>


<div class="container">
<div class="col-lg-10 bg-light rounded my-2 py-2">
    <h2>Account</h2>
   <h5> Username:  <?php  echo GetUsername(); ?></h5>  


<br>
    <div id="changepassword" class ="center" >
    <?php  echo $_SESSION['update'];?>
    <form method="post" action="personalinfo.php" align="center" class ="formStyle">
        <h6>Current Password:</h6>
    <input type="password" name="currentPassword"><span id="currentPassword" class="required"></span>
     <br>
        <h6>New Password:</h6>
    <input type="password" name="newPassword"required="required"><span id="newPassword" class="required"></span>
     <br>
        <h6>Confirm Password:</h6>
    <input type="password" name="confirmPassword"required="required"><span id="confirmPassword" class="required"></span>
    <br>
     <button style="margin: 10px;" type="submit" class="btn btn-primary" name="changepass_btn">Change</button>
    </form>
  </div>
</div>
</div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>


  </body>
</html>