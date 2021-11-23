<?php

//load.php

$connect = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi448360', 'dbi448360', '123456');

$data = array();

$query = "SELECT * FROM events";

$statement = $connect->prepare($query);

$statement->execute();

$result = $statement->fetchAll();

foreach($result as $row)
{
 $data[] = array(
 	'id' => $row["id"],
  'title' => $row["title"],
  'start'   => $row["start_event"],
  'end'   => $row["end_event"]
 );
}

echo json_encode($data);



?>