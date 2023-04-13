<?php
session_start();
// Borra todas las variables de sesión
$_SESSION = array();

// Destruye la sesión
session_destroy();
header('Location: index.php');
?>