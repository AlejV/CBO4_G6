<?php
session_start();
$myArr = $_SESSION["morningArray"];
//$afternoonArr = $_SESSION["afternoonArray"];

$myJSON = json_encode($myArr);

echo $myJSON;
