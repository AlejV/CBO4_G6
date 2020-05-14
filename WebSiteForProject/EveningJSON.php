<?php
session_start();
$afternoonArr = $_SESSION["eveningArray"];

$eveningJSON = json_encode($afternoonArr);

echo $eveningJSON;