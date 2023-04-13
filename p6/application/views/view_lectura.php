<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?><!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<title>Base de datos persona con codeigniter</title>

	<style type="text/css">

	::selection { background-color: #E13300; color: white; }
	::-moz-selection { background-color: #E13300; color: white; }

	body {
		background-color: #fff;
		margin: 40px;
		font: 13px/20px normal Helvetica, Arial, sans-serif;
		color: #4F5155;
	}

	a {
		color: #003399;
		background-color: transparent;
		font-weight: normal;
		text-decoration: none;
	}

	a:hover {
		color: #97310e;
	}

	h1 {
		color: #444;
		background-color: transparent;
		border-bottom: 1px solid #D0D0D0;
		font-size: 19px;
		font-weight: normal;
		margin: 0 0 14px 0;
		padding: 14px 15px 10px 15px;
	}

	code {
		font-family: Consolas, Monaco, Courier New, Courier, monospace;
		font-size: 12px;
		background-color: #f9f9f9;
		border: 1px solid #D0D0D0;
		color: #002166;
		display: block;
		margin: 14px 0 14px 0;
		padding: 12px 10px 12px 10px;
	}

	#body {
		margin: 0 15px 0 15px;
		min-height: 96px;
	}

	p {
		margin: 0 0 10px;
		padding:0;
	}

	p.footer {
		text-align: right;
		font-size: 11px;
		border-top: 1px solid #D0D0D0;
		line-height: 32px;
		padding: 0 10px 0 10px;
		margin: 20px 0 0 0;
	}

	#container {
		margin: 10px;
		border: 1px solid #D0D0D0;
		box-shadow: 0 0 8px #D0D0D0;
	}
	</style>
</head>
<body>

<div id="container">
	<h1>Bienvenido la BD es: </h1>
	<p>Realizado por: Samuel Alegre</p>
	<div id="body">
		
		<table border="1px">
			<tr>
				<td>
					CI
				</td>
				<td>
					Nombre_completo
				</td>
				<td>
					Fecha_nac
				</td>
				<td>
					Telefono
				</td>
				<td>
					Departamento
				</td>
			</tr>
		<?php
			//print_r($filas);
			foreach ($filas as $fila)
			{
				echo "<tr>";
				echo "<td>";
				echo "	$fila->CI";
				echo "</td>";
				echo "<td>";
				echo "	$fila->Nombre_comp";
				echo "</td>";
				echo "<td>";
				echo "	$fila->Fecha_nac";
				echo "</td>";
				echo "<td>";
				echo "	$fila->Telefono";
				echo "</td>";
				echo "<td>";
				echo "	$fila->Departamento";
				echo "</td>";
				echo "</tr>";
				
			}	
		?>
		</table>
	</div>

	<p class="footer">Page rendered in <strong>{elapsed_time}</strong> seconds. <?php echo  (ENVIRONMENT === 'development') ?  'CodeIgniter Version <strong>' . CI_VERSION . '</strong>' : '' ?></p>
</div>

</body>
</html>
