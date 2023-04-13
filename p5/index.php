<?php
session_start();
if(isset($_SESSION['usuario'])){
    header('Location: index.php');
}
if($_SERVER['REQUEST_METHOD'] == 'POST'){
    $usuario = $_POST['usuario'];
    $contrasena = $_POST['contrasena'];
    // Consulta BD
    include 'conexion.inc.php';
    $query = "Select * from usuario where Usuario  = '$usuario' and Password = '$contrasena'";
    $result = mysqli_query($con, $query);
     if(mysqli_num_rows($result) > 0){
     	//Obtenemos ci
        $fila = mysqli_fetch_assoc($result);
        $ci = $fila['CI'];
        //inicia sesion
        //hallamos el nombre del usuario de la tabla persona
        $query2 = "SELECT Nombre_comp FROM persona WHERE ci  = '$ci'";
        $result2 = mysqli_query($con, $query2);
        $row = mysqli_fetch_assoc($result2);
        $username = $row['Nombre_comp'];
        $rol = $fila['Rol'];
        //echo "<h1>Bienvenido $username</h1>";
        //PARA SABER EL ROL 
        $_SESSION['rol']=$rol;
        $_SESSION['usuario'] = $usuario;
        header('Location: principal.php');

    }else{
        echo "<script type='text/javascript'>
                alert('Usuario o contraseña incorrecta intente de nuevo');
            </script>";
    }
}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="css/login.css">
	<title>Login FCPN</title>
</head>
<body>
    <div class="global-container">
        <div class="login-form">
            <div class="card-body">
                <h3 class="card-title text-center">Login FCPN</h3>
                <div class="card-text">
                    
                    <form method="POST" action="">
                        <!-- to error: add class "has-danger" -->
                        <div class="form-group">
                            <label for="exampleInputEmail1">Usuario: </label>
                            <input type="text" class="form-control form-control-sm" id="exampleInputEmail1" aria-describedby="emailHelp" name="usuario">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Password: </label>
                            <input type="password" class="form-control form-control-sm" id="exampleInputPassword1" name="contrasena">
                        </div>
                        <button type="submit" class="btn btn-primary btn-block">Aceptar</button>
                        
                        
                    </form>
                </div>
            </div>
        </div>
    </div>



	
</body>
</html>
