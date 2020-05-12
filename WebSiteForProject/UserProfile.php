<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link href="main.css" type="text/css" rel="stylesheet">
    <link href="profileStyle.css" type="text/css" rel="stylesheet">
    <title>Media Bazaar - Hardware Store</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

</head>
<body background="mbImages/bglong2.jpg">
<header>
    <div class="menu">
        <a href="HomePage.php"><img src="mbImages/mediabazaar.png" alt="logo" class="logo">
            <nav>
                <ul>
                    <li><a href="Logout.php">Log Out</a></li>
                    <li><a href="HomePage.php">Home</a></li>
                    <li><a href="ContactManager.php">Contact manager</a></li>
                    <li><a href= "UserProfile.php">
                            Welcome, <?php echo "{$_SESSION['fname'] }  {$_SESSION['lname']}"?>
                        </a>

                </ul>
            </nav>
        </a>
    </div>
</header>
<div class="galleryBody">
    <div class="titleRow">
        <div class="myProfileTitle">
            <h1>Employee Profile</h1>
        </div>
        <img src="mbImages/pngkit_construction-worker-png_699859.png" class="profilePicture">
    </div>
    <div class="rowProfile">

        <div class="profileInfo">
            <p style="color:white">Full Name: <span
                    style="color: black;"><?php echo "{$_SESSION['fname'] }  {$_SESSION['lname']}"?></span></p>
            <p style="color:white">Username: <span
                    style="color: black;"><?php echo $_SESSION['username'] ?></span></p>
            <p style="color:white">Department: <span
                    style="color: black;"><?php echo $_SESSION['department'] ?></span></p>
            <p style="color:white">Phone Number: <span
                    style="color: black;"><?php echo $_SESSION['phoneNr'] ?></span></p>
            <p style="color:white">Address: <span
                    style="color: black;"><?php echo $_SESSION['address'] ?></span></p>
            <p style="color:white">Emergency Contact: <span
                    style="color: black;"><?php echo $_SESSION['contactFirstName'] ?></span></p>
            <p style="color:white">Emergency Contact Phone: <span
                    style="color: black;"><?php echo $_SESSION['contactPhone'] ?></span></p>
            <p style="color:white">Position: <span
                    style="color: black;"><?php echo $_SESSION['position'] ?></span></p>
            <p style="color:white">Salary: <span
                    style="color: black;"><?php echo $_SESSION['salary'] ?></span></p>
            <p style="color:white">Age: <span
                    style="color: black;"><?php
                    if(getAge($_SESSION['birthDate']) > 0){
                        echo getAge($_SESSION['birthDate']);
                    }else{
                        echo 1;
                    }
                    ?></span></p>


        </div>
    </div>
    <div class="myProfileTitle">
        <h1>Shift Details:</h1>
    </div>
    <div class="rowProfile">
        <div class="shiftInfo">
            <!-- Top up credits pop up form -->
            <p>Coming soon!</p>

        </div>
    </div>
</div>
<footer class="footer">All rights reserved (c) 2020 George Manev</footer>

</body>
<?php

//function for debugging php code
function debug_to_console($data) {
    $output = $data;
    if (is_array($output))
        $output = implode(',', $output);

    echo "<script>console.log('Debug Objects: " . $output . "' );</script>";
}


function getAge($date) { // Y-m-d format
    return intval(substr(date('Ymd') - date('Ymd', strtotime($date)), 0, -4));
}
?>
</html>
