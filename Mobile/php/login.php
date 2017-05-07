<?php
$con = mysql_connect("localhost","root","root");
$sel = mysql_select_db("sigcel");

$usuario = $_GET["usuario"];
$senha = $_GET["senha"];

$sql = mysql_query("select nm_funcionario from funcionario 
					where nm_email_funcionario = \"$usuario\" and cd_senha_funcionario = md5(\"$senha\") limit 1 ");

$qtdLinhas = mysql_num_rows($sql);
$nome = mysql_fetch_array($sql);

session_start();
$_SESSION["nm_funcionario"] = $nome["nm_funcionario"];


if ($qtdLinhas != 0)
{
	echo "1";
}
else
{
	echo "0";	
}

?>