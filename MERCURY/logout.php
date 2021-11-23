<?php 

session_destroy();
unset($_SESSION['user']);

session_destroy();
unset($_SESSION['employee']);

header("location: login.php");

?>