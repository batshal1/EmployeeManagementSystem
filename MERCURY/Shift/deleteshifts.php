<?php

//delete.php

$connect = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi448360', 'dbi448360', '123456');
if(isset($_POST["id"]))
{
 $query = "
 DELETE from shifts WHERE id=:id
 ";
 $statement = $connect->prepare($query);
 $statement->execute(
  array(
   ':id' => $_POST['id']
  )
 );
}

?>