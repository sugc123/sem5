<html>

<head>
	<title>Registration Form</title>
</head>
<?php
if (isset($_GET["action"])) {
	$rollno = $_GET["rollno"];
	$cn = mysqli_connect("localhost", "root", "");
	$db = mysqli_select_db($cn, "student");
	$sql = "select * FROM `stud` WHERE `rollno`=$rollno ";
	$result = mysqli_query($cn, $sql);

	$row = mysqli_fetch_row($result);
	mysqli_close($cn);
}
?>

<body>
	<form id="form1" name="form1" method="post" action="pregistration.php">
		<label>Roll No :
			<input type="text" name="txtrno" value="<?php if (isset($row[0])) echo $row[0]; ?>" />
		</label>
		<p>
			<label>Name :
				<input type="text" name="txtname" value="<?php if (isset($row[1])) echo $row[1]; ?>" />
			</label>
		</p>
		<p>
			<label>Address :
				<input type="text" name="txtadd" value="<?php if (isset($row[2])) echo $row[2]; ?>" />
			</label>
		</p>
		<p>
			<label>Email :
				<input type="text" name="txtemail" value="<?php if (isset($row[3])) echo $row[3]; ?>" />
			</label>
		</p>
		<p>
			<label> Mobile No :
				<input type="text" name="txtmobile" value="<?php if (isset($row[4])) echo $row[4]; ?>" />
			</label>
		</p>
		<p>
			<label>
				<input type="submit" name="Submit" value="Insert" />
			</label>
			<input name="Submit" type="submit" id="Submit" value="Update" />
			<input name="Submit" type="submit" id="btnDelete" value="Delete" />
		</p>
		<table width="525" height="61" border="5">
			<tr bgcolor="#FFCCFF" align="center">
				<td width="96">Roll No </td>
				<td width="70">Name</td>
				<td width="95">Address</td>
				<td width="63">Email</td>
				<td width="94">Mobile No </td>
				<!--	<td width="33">&nbsp;</td>
			<td width="28">&nbsp;</td> -->
			</tr>
			<?php
			$cn = mysqli_connect("localhost", "root", "");
			$db = mysqli_select_db($cn, "student");
			$sql = "select * FROM `stud`";
			$result = mysqli_query($cn, $sql);

			while ($row = mysqli_fetch_row($result)) {
				echo "<tr>";
				echo "<td>$row[0]</td>";
				echo "<td>$row[1]</td>";
				echo "<td>$row[2]</td>";
				echo "<td>$row[3]</td>";
				echo "<td>$row[4]</td>";
				echo "</tr>";
			}
			mysqli_close($cn);
			?>
		</table>
		<p></p>
		<p>&nbsp;</p>
	</form>
</body>

</html>