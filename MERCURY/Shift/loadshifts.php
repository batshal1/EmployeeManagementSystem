<?php

//load.php

$connect = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi448360', 'dbi448360', '123456');

$data = array();

$query = "
			SELECT * FROM shifts INNER JOIN user ON shifts.empId=user.id;
			SELECT * FROM events;
		 ";

$statement = $connect->prepare($query);

$statement->execute();

$result = $statement->fetchAll();

foreach($result as $row)
{
 $data[] = array(
 	'id' => $row["id"],
  'title' => $row["username"], 
  'start'   => $row["starttime"],
  'end'   => $row["endtime"]
 );
}

echo json_encode($data);

?>