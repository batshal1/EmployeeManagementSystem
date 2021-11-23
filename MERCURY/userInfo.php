<?php


$db = mysqli_connect('studmysql01.fhict.local','dbi448360','123456','dbi448360');
function GetInfo(){
    global $db;

    $sql = "SELECT * FROM employees WHERE id = ?"; 
    $stmt = $db->prepare($sql); 
    $stmt->bind_param("i", $_SESSION['user']['id']);
    $stmt->execute();
    $results = $stmt->get_result();

         
    $info =  $results->fetch_assoc();

    $_SESSION['employee'] = $info; 
}

      


function GetId()
{
    GetInfo();
    return $_SESSION['employee']['id'];     

}

function GetName()
{
    GetInfo();
    return $_SESSION['employee']['firstname'];     

}


function GetSurname()
{   GetInfo();
    return $_SESSION['employee']['lastname']; 
}


function GetAddress()
{   GetInfo();
    return $_SESSION['employee']['street']; 
}


function GetZipCode()
{  GetInfo();
    return $_SESSION['employee']['zipcode']; 
}


function GetCity()
{   GetInfo();
    return $_SESSION['employee']['city']; 
}

function GetGender()
{  GetInfo();
   return $_SESSION['employee']['gender']; 
}

function GetDateOfBirth()
{  GetInfo();
   return $_SESSION['employee']['birthdate']; 
}


function GetEmail()
{  GetInfo();
   return $_SESSION['employee']['email']; 
} 

function GetPhoneNumber()
{  GetInfo();
   return $_SESSION['employee']['phonenumber'];
}

function GetUsername()
{   GetInfo();
	return $_SESSION['user']['username'];
}

function GetPosition()
{   GetInfo();
	return $_SESSION['employee']['position'];
}

function GetStartDate()
{
    GetInfo();
    return $_SESSION['employee']['startdate'];
}




function checkcurrent($currentPassword)
    {
        

        if($_SESSION['user']['password'] == $currentPassword)
        {
            return true;
        }
        return false;
    }



function checknew($newPassword, $confirmPassword)
    {
        if($newPassword == $confirmPassword)
        {
            return true;
        }
        return false;
    }


function change($currentPassword, $newPassword, $confirmPassword)
    {
        if(checknew($newPassword, $confirmPassword) == false)
        {
            $_SESSION['update'] =   "The two passwords are not the same !";
        }
        else 
        {
            if( (checkcurrent($currentPassword) == false))
            {
                 $_SESSION['update'] =  "The current password is not correct !";
            }
            else
            {
               update($newPassword);

               $_SESSION['user']['password'] = $newPassword;

               $_SESSION['update'] =  "Password successfully changed!";
            }
        }
   
    }



function update ($newPassword)
    {
        global $db;
                 
                         
        $sql = "UPDATE user SET password=? WHERE id= ?";

        $stmt = $db->prepare($sql);

        $stmt->bind_param("si", $newPassword, $_SESSION['user']['id']);

        $stmt->execute();   
    }
?>


