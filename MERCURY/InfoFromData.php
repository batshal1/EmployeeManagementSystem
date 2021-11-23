<?php

 $conn = mysqli_connect('studmysql01.fhict.local','dbi448360','123456','dbi448360');

$view = "View more";



//$id = $_GET['id'];

//$id = mysqli_real_escape_string($conn,$id);

//$query = "SELECT * FROM `employees` WHERE `id`='" . $id . "'";

//$results = mysqli_query($conn,$query);

// Check connection
if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);
}
$sql = "SELECT id, firstname, lastname, position FROM employees";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
// output data of each row
while($row = $result->fetch_assoc()) {
echo "<tr><td>" . $row["id"]. "</td><td>" . $row["firstname"] . "</td><td>"
. $row["lastname"]. "</td><td>" . $row["position"]. "</td><td>" .$view. "</td></tr>";
}
echo "</table>";
} else { echo "0 results"; }
//$conn->close();



?>