
<?php

session_start();


//$db = mysql_connect('studmysql01.fhict.local','dbi448360','dbi448360','123456');
$db = mysqli_connect('studmysql01.fhict.local','dbi448360','123456','dbi448360');


$username ="";
$password = "";
$errors = array();


function GetUserById($id)
{
	global $db;

	$query = "SELECT * FROM user WHERE id =" .$id ;
	$result = mysql_query($db,$query);
	$user = mysql_fetch_assoc($result);

	return $user;
}


if (isset($_POST['login_btn'])) {
	login();
}


function login()
{
	global $db; 

	$username = $_POST['username'];
	$password = $_POST['password'];

	if(empty($username))
	{
		array_push($errors, "Username is required");
	}

	if(empty($password))
	{
		array_push($errors, "Password is required");
	}

	if (count($errors) == 0) 
	{
		$query = "SELECT * FROM user WHERE username='$username' AND password='$password' LIMIT 1";
		$results = mysqli_query($db, $query);

		if(mysqli_num_rows($results) == 1)
		{
			$logged_user = mysqli_fetch_assoc($results);
			$_SESSION['user'] = $logged_user;
		    $_SESSION['success']  = "You are now logged in";
		    header('dashboard.html');
		}
		else
		{
			array_push($errors, "Wrong username/password combination");
		}
	}
}




function display_error() 
{
	global $errors;

	if (count($errors) > 0)
	{
		echo '<div class="error">';
			foreach ($errors as $error)
			{
				echo $error .'<br>';
	        }
		echo '</div>';
	}
}


function isLoggedIn()
{
	if (isset($_SESSION['user'])) 
	{
		return true;
	}
	else
	{
		return false;
	}
}	


?>