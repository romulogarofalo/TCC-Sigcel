<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Pesquisa Selecionada - SigCel</title>
<link href="../css/estilo_pesqSelecionada.css" rel="stylesheet" type="text/css">
<script src="../js/jquery.js" type="text/javascript"></script>
    
<script>
	$(document).ready(function(e) {
        $("#botaoVoltar").click(function(e){
            window.location = "http://localhost/mobile/pesquisas.html";
        })
        
        $("#logout").click(function (e){
			window.location = "../index.html";	
		})
		
		$("#lista_pesquisas").show();
		$("#user_logado").load("sessao.php");
        
        });
</script>
        
        <script language='JavaScript'>
        
        function SomenteNumero(e)
        {
            var tecla=(window.event)?event.keyCode:e.which;   
            if((tecla>47 && tecla<58)) return true;
            else
            {
    	       if (tecla==8 || tecla==0) return true;
	           else  return false;
            }
        }
        </script>
</head>
<body>

<div id="barraUsuario"><b>Online:</b> <span id="user_logado"></span>
	<div id="logout"><b>Logout </b>
        <div id="imgLogout"><img src="../imgs/ico_logout.png"></div>
    </div>
</div>
<div id="boxDadosPessoais">Dados pessoais</div>
    <div class="dados" id="dados1"><b>Renda mensal por residência:</b><br>
    	<input type="text" name="txtRenda" class="txtDados" maxlength="10" id='renda' onkeypress='return SomenteNumero(event)'><br>
        <b>Escolaridade (Formação):</b><br>
        <select size="1" name="cbEscolaridade" class="combobox" id="cbEscolaridade">
            <option selected value="Selecione">Selecione uma opção</option>
            <option value="1">Não sabe ler/escrever</option>
            <option value="2">Ensino Fundamental incompleto</option>
            <option value="3">Ensino Fundamental completo</option>
            <option value="4">Ensino Médio incompleto</option>
            <option value="5">Ensino Médio completo</option>
            <option value="6">Ensino Superior incompleto</option>
            <option value="7">Ensino Superior completo</option>
            <option value="8">Pós-Graduação</option>
        </select><br>
        <b>Idade:</b><br>
        <input type="text" name="txtIdade"  id="idade" class="txtDados" size="10" maxlength="3" onkeypress='return SomenteNumero(event)'><br>
        <b>Sexo:</b><br>
        <input type="radio" name="rbSexo"  class="radio" id="true">Masculino
        <input type="radio" name="rbSexo"  class="radio" id="false">Feminino
    </div>
    
    
<div id="boxTitulo">PESQUISA SELECIONADA</div>
<div id="lista_pgts">


<?php
$con = mysql_connect("localhost","root","root");
$sel = mysql_select_db("sigcel");

$cd=$_GET["cd"];

$sql = mysql_query("SELECT * FROM `sigcel`.`pergunta` WHERE cd_pesquisa = $cd");

while($per = mysql_fetch_array($sql))
{
	//echo "<input type=\"radio\" id=\"$per[cd_pergunta]\" value=\"$per[nm_pergunta]\">";
	echo "<div class=\"pgts\" id=\"$per[cd_pergunta]\">".$per["nm_pergunta"]."<br>";
	
	$cmdAlternativa = mysql_query("select nm_alternativa from alternativa where cd_pergunta = $per[cd_pergunta]");
	while($alt = mysql_fetch_array($cmdAlternativa))
	{
		echo "<input type=\"radio\" id=\"$per[cd_pergunta]\" name=\"$per[cd_pergunta]\" class=\"radio\" value=\"$per[nm_pergunta]\"> $alt[nm_alternativa]";
	}
	echo"</div>";	
}
?>
</div>
    
<div id="clear"></div>
<div id="boxBotaoSalvar">
    <div id="botaoSalvar"><center>Concluir Pesquisa</center></div>
</div><br>    
<div id="boxBotao">
    <div id="botaoVoltar"><center>Voltar</center></div>
</div> 

</body>
</html>
