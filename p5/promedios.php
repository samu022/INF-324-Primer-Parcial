<?php
	include 'conexion.inc.php';
    $query = "SELECT
		    COALESCE(SUM(CASE WHEN Departamento = 'Chuquisaca' THEN notafinal END), 0) chuquisaca,
		    COALESCE(SUM(CASE WHEN Departamento = 'La Paz' THEN notafinal  END), 0) lapaz,
		    COALESCE(SUM(CASE WHEN Departamento = 'Cochabamba' THEN notafinal END), 0) cochabamba,
		    COALESCE(SUM(CASE WHEN Departamento = 'Oruro' THEN notafinal  END), 0) oruro,
		    COALESCE(SUM(CASE WHEN Departamento = 'Potosi' THEN notafinal  END), 0) potosi,
		    COALESCE(SUM(CASE WHEN Departamento = 'Tarija' THEN notafinal  END), 0) tarija,
		    COALESCE(SUM(CASE WHEN Departamento = 'Santa Cruz' THEN notafinal END), 0) santacruz,
		    COALESCE(SUM(CASE WHEN Departamento = 'Beni' THEN notafinal  END), 0) beni,
		    COALESCE(SUM(CASE WHEN Departamento = 'Pando' THEN notafinal  END), 0) pando,
		    COALESCE(SUM(CASE WHEN Departamento = 'Otro' THEN notafinal  END), 0) otro
		FROM(
		    SELECT
		        (CASE 
		            WHEN Departamento = '01' THEN 'Chuquisaca'
		            WHEN Departamento = '02' THEN 'La Paz'
		            WHEN Departamento = '03' THEN 'Cochabamba'
		            WHEN Departamento = '04' THEN 'Oruro'
		            WHEN Departamento = '05' THEN 'Potosi'
		            WHEN Departamento = '06' THEN 'Tarija'
		            WHEN Departamento = '07' THEN 'Santa Cruz'
		            WHEN Departamento = '08' THEN 'Beni'
		            WHEN Departamento = '09' THEN 'Pando'
		            ELSE 'Otro'
		        END) AS Departamento,
		        AVG(notafinal) AS notafinal
		    FROM(
		        SELECT i.notafinal, p.Departamento
		        FROM persona p
		        INNER JOIN inscripcion i ON i.CIestudiante = p.CI
		    ) AS notas
		    GROUP BY Departamento
		) AS agregado";
    $resultado = mysqli_query($con, $query);
 ?>
     
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Promedio de notas</title>
	<style>
		table {
			border-collapse: collapse;
			width: 100%;
		}
		th, td {
			text-align: center;
			padding: 8px;
			border: 1px solid #ddd;
		}
		th {
			background-color: #4CAF50;
			color: white;
		}
		tr:nth-child(even) {
			background-color: #f2f2f2;
		}
		.button {
		  display: inline-block;
		  border-radius: 4px;
		  background-color: #007bff;
		  color: #fff;
		  text-align: center;
		  font-size: 14px;
		  padding: 10px 20px;
		  cursor: pointer;
		  text-decoration: none;
		}

		.button:hover {
		  background-color: #0069d9;
		}
	</style>
</head>
<body>
	<table border="1px">
		<tr>
			<th>Departamento: </th>
			<th>Chuquisaca</th>
			<th>La Paz</th>
			<th>Cochabamba</th>
			<th>Oruro</th>
			<th>Potosi</th>
			<th>Tarija</th>
			<th>Santa Cruz</th>
			<th>Beni</th>
			<th>Pando</th>
		</tr>

		
		<?php
			$fila = mysqli_fetch_array($resultado);
			//mostrar las medias en la tabla en cada columna
			echo '<tr>';
			echo '<td> Promedios </td>';
			if($fila['chuquisaca']!=0)
		    	echo '<td>' . number_format($fila['chuquisaca'], 2) . '</td>';
		    else
		    	echo '<td> - </td>';
		   	if($fila['lapaz']!=0)
			    echo '<td>' . number_format($fila['lapaz'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['cochabamba']!=0)
			    echo '<td>' . number_format($fila['cochabamba'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['oruro']!=0)
			    echo '<td>' . number_format($fila['oruro'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['potosi']!=0)
			    echo '<td>' . number_format($fila['potosi'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['tarija']!=0)
			    echo '<td>' . number_format($fila['tarija'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['santacruz']!=0)
			    echo '<td>' . number_format($fila['santacruz'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['beni']!=0)
			    echo '<td>' . number_format($fila['beni'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
			if($fila['pando']!=0)
			    echo '<td>' . number_format($fila['pando'], 2) . '</td>';
			else
		    	echo '<td> - </td>';
		    echo '</tr>';
		?>
	</table>
	<a href="principal.php" class="button">Volver</a>
</body>
</html>