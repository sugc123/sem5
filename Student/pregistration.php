<?php
if (isset($_GET["action"])) {
	$rollno = $_GET["rollno"];
	$action = $_GET["action"];
} else {

	$rollno = $_POST["txtrno"];
	$name = $_POST["txtname"];
	$address = $_POST["txtadd"];
	$email = $_POST["txtemail"];
	$phoneno = $_POST["txtmobile"];
	$action = $_POST["Submit"];

	echo $action;
}
$cn = mysqli_connect("localhost", "root", "");
if ($cn) {
	echo "Connection sucessfully...<br>";
	$db = mysqli_select_db($cn, "student");
	if ($db) {
		echo "db connected <br>";
		if ($action == "Insert") {
			$sql = "INSERT INTO `stud` (`rollno`, `name`, `address`, `email`, `phoneno`) VALUES
			($rollno,'$name','$address','$email',$phoneno)";
		} else if ($action == "Update") {
			$sql = "UPDATE `stud` SET `name`='$name',`address`='$address',`email`='$email',`phoneno`=$phoneno WHERE `rollno`=$rollno";
		} else if ($action == "Delete") {
			$sql = "DELETE FROM `stud` WHERE `rollno`=$rollno";
		}
		echo $sql . "<br>";
		$result = mysqli_query($cn, $sql);
		if ($result) {

			echo "$action Sucessfully....<br>";
			header('location:./registration.php');
		} else {
			echo "Not $action <br>";
		}
	} else {
		echo "db not connected <br>";
	}
} else {
	echo "Connection not posible <br>";
}
mysqli_close($cn);
