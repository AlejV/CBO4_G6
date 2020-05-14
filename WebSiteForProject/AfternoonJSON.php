<?php
session_start();
$afternoonArr = $_SESSION["afternoonArray"];

$afternoonJSON = json_encode($afternoonArr);

echo $afternoonJSON;
