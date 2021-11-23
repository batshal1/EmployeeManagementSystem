<?php
//index.php

include('../functions2.php');
include('../shiftsinfo.php'); 
include('../userinfo.php'); 

$_SESSION['update'] = "";


?>
<!DOCTYPE html>
<html>
 <head>

    <meta content='text/html; charset=UTF-8' http-equiv='Content-Type'>
    <meta charset='utf-8'>
    <link href='css/Style.css' rel='stylesheet' type='text/css'>
    <link href='css/dashboard.css' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <link href='https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css' rel='stylesheet' type='text/css'>


  <title>Title</title>
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.css" />
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha.6/css/bootstrap.css" />
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js"></script>
  <script>
   
  $(document).ready(function() {
   var calendar = $('#calendar').fullCalendar({
    header:{
     left:'prev,next today',
     center:'title',
     right:'month,agendaWeek,agendaDay'
     selectable:true,
    },
    events: 'loadshifts.php',


      <?php if( GetPosition() == "administrator"): ?>
    eventClick:function(event)
    {
     if(confirm("Are you sure you want to remove it?"))
     {
      var id = event.id;
      $.ajax({
       url:"deleteshifts.php",
       type:"POST",
       data:{id:id},
       success:function()
       {
        calendar.fullCalendar('refetchEvents');
        alert("Event Removed");
       }
      })
     }
    }
          <?php endif; ?>


   });
  });
   

   
  </script>
 </head>
 <body>
  <br />
  <h1 align="center">Test</h1>
  <br />
  <div class="container">
   <div id="calendar"></div>
  </div>
 </body>
</html>
