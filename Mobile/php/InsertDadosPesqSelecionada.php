<?php
$con = mysql_connect("localhost","root","root");
$sel = mysql_select_db("sigcel");

$renda = $_GET["txtRenda"];
$escolaridade = $_GET["cbEscolaridade"];
$idade = $_GET["txtIdade"];
$sexo = $_GET["rbSexo"];



$sql = mysql_query("INSERT INTO participante qt_salario,qt_idade,cd_escolaridade,ic_sexo_masculino 
					values (".$renda.",".$idade.",".$escolaridade.",".$sexo.");"); 
			
$sql2 =
			
		 mysqli_query($con, $sql);

					
					
?>