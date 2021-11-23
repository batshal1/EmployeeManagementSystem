<?php include('functions2.php'); ?>

<!DOCTYPE html>
<html>
<head>
	<title>Registration system PHP and MySQL</title>
	
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body style="background-color: #666666;">
	
<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">

				<form class="login100-form validate-form" method="post" action="index.php">
					
					<span class="login100-form-title p-b-43">
						Login to continue
					</span>

        
	                <?php echo display_error(); ?>
	                <span>Username</span>
                    <div class="wrap-input100 validate-input" data-validate = "Username is required">
						<input class="input100" type="text" name="username" required>
						<span class="focus-input100"></span>
						
					</div>
					
					<span>Password</span>
					<div class="wrap-input100 validate-input" data-validate="Password is required">
						<input class="input100" type="password" name="password" required>
						<span class="focus-input100"></span>
						
					</div>

					<div class="container-login100-form-btn">
						<button type="submit" class="login100-form-btn" name="login_btn">
							Login
						</button>
					</div>

		        </form>

				    <div class="login100-more" style="background-image: url('images/bg-01.jpg');">
				    </div>
		    </div>
	    </div>
</div>

		
</body>
</html>


