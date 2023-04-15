<?php
include "conexion.php";
$pdo=new Conexion();

//MANDAR VARIABLES
if($_SERVER["REQUEST_METHOD"]=="GET"){
	//si existe varible
	if(isset($_GET["CI"]))
	{
		//sacar un conjunto de datos
		//Tabla persona
		$sql=$pdo->prepare("select * from persona where CI=:CI");
		//rellenar
		$sql->bindValue(":CI", $_GET["CI"]);
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		//header("HTTP/1.1 200 Tengo datos");
		echo json_encode($sql->fetchAll());
		//Tabla usuario
		$sql2=$pdo->prepare("select * from usuario where CI=:CI");
		//rellenar
		$sql2->bindValue(":CI", $_GET["CI"]);
		$sql2->execute();
		$sql2->setFetchMode(PDO::FETCH_ASSOC);
		header("HTTP/1.1 200 Tengo datos usuario y persona");
		echo json_encode($sql2->fetchAll());
		exit;
	}
	else{
		//sacar un conjunto de datos
		//Tabla persona
		$sql=$pdo->prepare("select * from persona");
		$sql->execute();
		$sql->setFetchMode(PDO::FETCH_ASSOC);
		//header("HTTP/1.1 200 Tengo datos persona");
		echo json_encode($sql->fetchAll());
		//Tabla usuario
		$sql2=$pdo->prepare("select * from usuario");
		$sql2->execute();
		$sql2->setFetchMode(PDO::FETCH_ASSOC);
		header("HTTP/1.1 200 Tengo datos usuario y persona");
		echo json_encode($sql2->fetchAll());
		exit;
	}
}
//BORRA LOS DATOS

if($_SERVER["REQUEST_METHOD"]=="DELETE"){
		//sacar un conjunto de datos de la tabla persona
		$sql=$pdo->prepare("delete from persona where CI=:CI");
		//rellenar
		$sql->bindValue(":CI", $_GET["CI"]);
		$sql->execute();
		//$sql->setFetchMode(PDO::FETCH_ASSOC);
		//header("HTTP/1.1 200 Eliminado persona");
		//echo json_encode($sql->fetchAll());
		//Para tabla usuario
		$sql2=$pdo->prepare("delete from usuario where CI=:CI");
		//rellenar
		$sql2->bindValue(":CI", $_GET["CI"]);
		$sql2->execute();
		header("HTTP/1.1 200 Eliminado usuario y persona");
		exit;
}

//update Actualizar datos

if($_SERVER["REQUEST_METHOD"]=="PUT"){
    // Obtener los datos de la URL persona
    parse_str($_SERVER['QUERY_STRING'], $params);
    
    // Actualizar los datos en la base de datos PERSONA
    $sql=$pdo->prepare("UPDATE persona SET Nombre_comp=:nombre, Fecha_nac=:fecha_nac, Telefono=:telefono, Departamento=:depto  WHERE CI=:ci");
    $sql->bindValue(":ci", $params['CI']);
    $sql->bindValue(":nombre", $params['nombre']);
    $sql->bindValue(":fecha_nac", $params['fecha_nac']);
    $sql->bindValue(":telefono", $params['telefono']);
    $sql->bindValue(":depto", $params['depto']);
    
    $sql->execute();
    //Para usuario
    
    // Actualizar los datos en la base de datos USUARIO
    $sql2=$pdo->prepare("UPDATE usuario SET Usuario=:usuario, Password=:password, Rol=:rol WHERE CI=:ci");
    $sql2->bindValue(":ci", $params['CI']);
    $sql2->bindValue(":usuario", $params['usuario']);
    $sql2->bindValue(":password", $params['password']);
    $sql2->bindValue(":rol", $params['rol']);
    
    $sql2->execute();
    // Devolver una respuesta
    header("HTTP/1.1 200 Actualizado persona y usuario");
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
    //Para UsUARIO
    // Obtener los datos de la URL
    // Actualizar los datos en la base de datos
    $sql2=$pdo->prepare("INSERT INTO usuario (CI, Usuario, Password, Rol) VALUES (:ci, :usuario,:password, :rol)");
    $sql2->bindValue(":ci", $params['CI']);
    $sql2->bindValue(":usuario", $params['usuario']);
    $sql2->bindValue(":password", $params['password']);
    $sql2->bindValue(":rol", $params['rol']);
    $sql2->execute();
    // Devolver una respuesta
    header("HTTP/1.1 200 Insertado persona y usuario");
    exit;
}
?>