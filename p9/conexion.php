<?php 
//pdo de conexion
	class Conexion extends PDO
	{
		private $servidor="localhost";
		private $usuario="usuario";
		private $clave="123456";
		private $basedatos="mibasesamuelalegre";
		public function __construct(){
			
			try{
				//definir servidor
				parent::__construct("mysql:host=".$this->servidor.";dbname=".$this->basedatos.";charset=utf8",$this->usuario, $this->clave,array(PDO::ATTR_ERRMODE=>PDO::ERRMODE_EXCEPTION));
				//lo ultimo ve si existe un tipo de error
			}
			catch(PDOException $e){
				echo "Error: ".$e->getMessage();
				exit;
				//por si no sale
			}
		}
	}
?>