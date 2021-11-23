<?php 

include 'config.php';

$id = $_GET['id'];

$result = mysqli_query($conn, "SELECT * FROM employees WHERE id = '$id'");

$row = mysqli_fetch_assoc($result);

  if(isset($_POST['submit'])){
  $id = $_GET['id'];
  $firstname = $_POST['firstname'];
  $lastname = $_POST['lastname'];
  $position = $_POST['position'];
  $phonenumber = $_POST['phonenumber'];
  $email = $_POST['email'];

  $sql = "UPDATE employees SET firstname =  '$firstname' , lastname = '$lastname', position = '$position' , phonenumber = '$phonenumber' , email = '$email' WHERE id = '$id'";

  if(mysqli_query($conn, $sql)){
    header("location: adminpage.php");
  }
}

?>

<!DOCTYPE html><html class="menu">
<html>

<head>
 
 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
   <link rel = "stylesheet" hreff="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity = "sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/IRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">

<meta charset="utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>

<title>Admin Page</title>
<link rel="stylesheet" type="text/css"href="css/adminpage.css">
<link rel="stylesheet" type="text/css" href="css/Style.css">
<link rel="stylesheet" type="text/css" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

</head>
<body class="bg-info">

<div class = "container">
  <div class ="row p-2">
    <div class = "col-lg-4 offset-lg-4 bg-light text-dark mt-4 p-3 rounded">
      <h3 class = "text-center p-2"> Employee's Information</h3>
      <hr class = "bg-light">
      <form action ="" method = "POST">
        <div class = "form-group">
          <label for="firstname"> Firstname : <?= $row['firstname']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="lastname"> Lastname : <?= $row['lastname']; ?></label>
        </div>

        <div class = "form-group">
          <label for="position"> Position : <?= $row['position']; ?></label>
        </div>

        
        <div class = "form-group">
          <label for="phone"> Phone : <?= $row['phonenumber']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Email : <?= $row['email']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Gender : <?= $row['gender']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Address : <?= $row['street']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Zipcode : <?= $row['zipcode']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> City : <?= $row['city']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Start day : <?= $row['startdate']; ?> </label>
        </div>

        <div class = "form-group">
          <label for="email"> Salary per hour : <?= $row['salary']; ?> </label>
        </div>

        <div class= "form-group text-center">
          <a href = "adminpage.php" class = "text-dark lead"> View records</a>
        </div>
             
       </form>
    </div>
  </div>
</div>





</body>
</html>