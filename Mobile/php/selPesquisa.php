 <?php
$con = mysql_connect("localhost","root","root");
$sel = mysql_select_db("sigcel");

$sql = mysql_query("SELECT * FROM `sigcel`.`pesquisa`");

while($per = mysql_fetch_array($sql))
{
	echo "<div class=\"pesq\" id=\"$per[cd_pesquisa]\">".$per["nm_pesquisa"]."</div>";	
}
?>
<script>
		$(".pesq").click(function(e) {
            var cd = $(this).attr("id");
			window.location="php/pesqSelecionada.php?cd="+cd;			
        });
</script>