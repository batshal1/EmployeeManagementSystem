<?php


if(isset($_POST['search'])){

$valueToSearch = $_POST['valueToSearch'];
$query = "SELECT * FROM employees WHERE CONCAT(id, firstname, lastname, gender, street, city, email, startdate, position) LIKE '%".$valueToSearch."%'";
$search_result = filterTable($query);

}
else{
$query = "SELECT * FROM employees";
$search_result = filterTable($query);
}

function filterTable($query)
{
   include('config.php');

   $filter_Result = mysqli_query($conn, $query);

   return $filter_Result;
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
<link rel="stylesheet" type="text/css" href="css/stylecom.css">

<link rel="stylesheet" type="text/css" href="css/Style.css">
<link rel="stylesheet" type="text/css" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

</head>





<body class = "bg-info">

<div class = "wrapper">
	<div class="container1">
		<div class="search_wrap search_wrap_1">
			<div class="search_box">
				<form action = "combination.php" method = "post">
				<input type="text" class="input" name = "valueToSearch" placeholder="Value to search">  
				
				<div class="btn btn_common">
					<input type="submit" name="search"> 
					<!--<i class="fas fa-search" type="submit" name="search"></i>-->
				</div>
			</form>
				</div>
			</div>
		</div>
</div>

 
<div class = "container">

<div class = "row">
    <div class = "col-lg-10 offset-lg-1 mt-3">
        <table class = "table table-striped table-bordered bg-light">
            <thread>
                <tr class = "bg-dark text-light text-center">
                    <th>ID</th>
                    <th>Firstame</th>
                    <th>Lastname</th>
                    <th>Position</th>
                    <th>EDIT</th>
                    <th>VIEW</th>
                </tr>
            </thread>
            <tbody>
                <?php
               include'config.php';
               //$sql = "SELECT * FROM employees";
               //$result = mysqli_query($conn,$sql);
               //if(mysqli_num_rows($result)>0){
                while($row=mysqli_fetch_array($search_result)){
                    ?>
                    <tr class = "text-center">
                        <td><?= $row['id']; ?></td>
                        <td><?= $row['firstname']; ?></td>
                         <td><?= $row['lastname']; ?></td>
                          <td><?= $row['position']; ?></td>
                          <td><a class="btn btn-primary" href = "edit.php?id=<?= $row['id']; ?>">Edit</a></td>
                          <td><a class="btn btn-danger" href = "view.php?id=<?= $row['id']; ?>">View</a></td>
                      </tr>
                      <?php 
                }
              //}

                ?>
            </tbody>
        </table>
    </div>
</div>
</div>