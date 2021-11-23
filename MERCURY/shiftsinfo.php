<?php


$db = mysqli_connect('studmysql01.fhict.local','dbi448360','123456','dbi448360');
function GetShift(){
    global $db;

    $sql = "SELECT * FROM shifts WHERE empId = ?"; 
    $stmt = $db->prepare($sql); 
    $stmt->bind_param("i", $_SESSION['user']['id']);
    $stmt->execute();
    $results = $stmt->get_result();

         
    $info =  $results->fetch_assoc();

    $_SESSION['employee'] = $info; 
}

function GetDates(){
    GetShift();
    return $_SESSION['employee']['firstname']; 
    } 

?>