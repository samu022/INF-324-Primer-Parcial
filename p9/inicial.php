<?php
include "conexion.php";
$pdo=new Conexion();

//MANDAR VARIABLES
if($_SERVER["REQUEST_METHOD"]=="GET"){
	//si existe varible
	if(isset($_GET["CI"]))
	{
		//sacar un conjunto de datos
		$sql=$pdo->prepare("select * from persona where CI=:CI");
		//rellenar
		$sql->bindValue(":CI", $_GET["CI"]);
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		header("HTTP/1.1 200 Tengo datos");
		echo json_encode($sql->fetchAll());
		exit;
	}
	else{
		//sacar un conjunto de datos
		$sql=$pdo->prepare("select * from persona");
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		header("HTTP/1.1 200 Tengo datos");
		echo json_encode($sql->fetchAll());
		
		exit;
	}
}
//BORRA LOS DATOS

if($_SERVER["REQUEST_METHOD"]=="DELETE"){
		//sacar un conjunto de datos
		$sql=$pdo->prepare("delete from persona where CI=:CI");
		//rellenar
		$sql->bindValue(":CI", $_GET["CI"]);
		$sql->execute();
		//$sql->setFetchMode(PDO::FETCH_ASSOC);
		header("HTTP/1.1 200 Eliminado");
		//echo json_encode($sql->fetchAll());
		exit;
}

//update Actualizar datos

if($_SERVER["REQUEST_METHOD"]=="PUT"){
    // Obtener los datos de la URL
    parse_str($_SERVER['QUERY_STRING'], $params);
    
    // Actualizar los datos en la base de datos
    $sql=$pdo->prepare("UPDATE persona SET Nombre_comp=:nombre, Fecha_nac=:fecha_nac, Telefono=:telefono, Departamento=:depto  WHERE CI=:ci");
    $sql->bindValue(":ci", $params['CI']);
    $sql->bindValue(":nombre", $params['nombre']);
    $sql->bindValue(":fecha_nac", $params['fecha_nac']);
    $sql->bindValue(":telefono", $params['telefono']);
    $sql->bindValue(":depto", $params['depto']);
    
    $sql->execute();
    
    // Devolver una respuesta
    header("HTTP/1.1 200 Actualizado");
    exit;
}




//insert para insertar nueva persona
if($_SERVER["REQUEST_METHOD"]=="POST"){
    // Obtener los datos de la URL
    parse_str($_SERVER['QUERY_STRING'], $params);
    
    // Actualizar los datos en la base de datos
    $sql=$pdo->prepare("INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono,Departamento) VALUES (:ci, :nombre,:fecha_nac, :telefono, :depto)");
    $sql->bindValue(":ci", $params['CI']);
    $sql->bindValue(":nombre", $params['nombre']);
    $sql->bindValue(":fecha_nac", $params['fecha_nac']);
    $sql->bindValue(":telefono", $params['telefono']);
    $sql->bindValue(":depto", $params['depto']);
    $sql->execute();
    
    // Devolver una respuesta
    header("HTTP/1.1 200 Insertado");
    exit;
}
?>