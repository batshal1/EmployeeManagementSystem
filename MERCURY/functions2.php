<?php


session_start();

 function Encrypt($plaintext){
        $password = 'ShpG`6G*(f2';
        $method = 'aes-256-cbc';
        
        // Must be exact 32 chars (256 bit)
        $password = substr(hash('sha256', $password, true), 0, 32);
        
        
        // IV must be exact 16 chars (128 bit)
        $iv = chr(0x48). chr(0x75). chr(0x69). chr(0x6d). chr(0x21). chr(0x5a). chr(0x55). chr(0x62). chr(0x68). chr(0x72). chr(0x60). chr(0x64). chr(0x78). chr(0x42). chr(0x35). chr(0x16);
        // av3DYGLkwBsErphcyYp+imUW4QKs19hUnFyyYcXwURU=
        $encrypted = base64_encode(openssl_encrypt($plaintext, $method, $password, OPENSSL_RAW_DATA, $iv));
        
        // My secret message 1234
        $decrypted = openssl_decrypt(base64_decode($encrypted), $method, $password, OPENSSL_RAW_DATA, $iv);
        
        return $encrypted;
        
        exit; 
    }

// connect to database
$db = mysqli_connect('studmysql01.fhict.local','dbi448360','123456','dbi448360');


// variable declaration
$username = "";
$password    = "";
$errors   = array(); 


if (isset($_POST['login_btn'])) {
	login();
}


// LOGIN USER
function login(){
	global $db, $username, $errors;

	// grap form values
	$username = e($_POST['username']);
	$password = e($_POST['password']);

  
	// make sure form is filled properly
	if (empty($username)) 
	{
		array_push($errors, "Username is required");
	}

	if (empty($password)) 
	{
		array_push($errors, "Password is required");
	}

	// attempt login if no errors on form
	if (count($errors) == 0) 
	{
		$password = Encrypt($password);

		//$query = "SELECT * FROM user WHERE username='$username' AND password='$password' LIMIT 1";
		//$results = mysqli_query($db, $query);


		$sql = "SELECT * FROM user WHERE username=? AND password=?"; // SQL with parameters
        $stmt = $db->prepare($sql); 
        $stmt->bind_param("ss", $username, $password);
        $stmt->execute();
        $results = $stmt->get_result(); // get the mysqli result
       



             
		if (mysqli_num_rows($results) == 1) 
		{ 
		    // user found
			
			   // $logged_in_user = mysqli_fetch_assoc($results);

			       $logged_in_user = $results->fetch_assoc();
			
				$_SESSION['user'] = $logged_in_user;

				$_SESSION['success']  = "You are now logged in"; 
				              
               
				header('location: shifts.php');		  
		}
			
		else 
		{
			array_push($errors, "Wrong username/password combination");
			//echo mysqli_num_rows($results);
		}
	}
}





// return user array from their id
function getUserById($id){
	global $db;
	$query = "SELECT * FROM user WHERE id=" . $id;
	$result = mysqli_query($db, $query);
 	$user = mysqli_fetch_assoc($result);
	return $user;
}

// escape string
function e($val){
	global $db;
	return mysqli_real_escape_string($db, trim($val));
}


function display_error() {
	global $errors;

	if (count($errors) > 0){
		echo '<div class="error">';
			foreach ($errors as $error){
				echo $error .'<br>';
			}
		echo '</div>';
	}
}	

function isLoggedIn()
{
	if (isset($_SESSION['user'])) {
		return true;
	}else{
		return false;
	}
}


