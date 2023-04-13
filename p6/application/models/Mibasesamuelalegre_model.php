<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Mibasesamuelalegre_model extends CI_Model {

	
	public function __construct()
	{
		parent::__construct();
	}
	public function personas()
	{
		//muestra
		$this->load->database();
		$query=$this->db->query("select * from persona");
		return $query->result();
		
	}
	/*public function persona($ci)
	{
		
		$this->load->database();
		$query=$this->db->query("select * from persona where CI='$ci");
		return $query->result();
		
	}*/

	public function insertar_persona($ci, $nombre_comp, $fecha_nac, $telefono, $departamento){
			$this->load->database();
			$post_data = array(
				'CI'	=> $ci,
				'Nombre_comp' => $nombre_comp,
				'Fecha_nac' => $fecha_nac,
				'Telefono' => $telefono,
				'Departamento' => $departamento
			);
			$this->db->insert('persona', $post_data);
	}
	public function eliminar_persona($ci){
			$this->load->database();
			$this->db->where('ci', $ci);
        	$this->db->delete('persona');
	}

	public function cambiar_persona($ci, $nombre_comp, $fecha_nac, $telefono, $departamento){
			$this->load->database();
			$post_data = array(
				'Nombre_comp' => $nombre_comp,
				'Fecha_nac' => $fecha_nac,
				'Telefono' => $telefono,
				'Departamento' => $departamento
			);
			$this->db->where('ci', $ci);
			$this->db->update('persona', $post_data);
	}

	
}
