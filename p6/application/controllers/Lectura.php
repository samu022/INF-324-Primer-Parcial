<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Lectura extends CI_Controller {

	
	public function index()
	{
		
		$this->load->model("Mibasesamuelalegre_model");
		$filas = $this->Mibasesamuelalegre_model->personas();
		$datos["filas"]=$filas;
		$this->load->view('view_lectura', $datos);
		$this->load->view('insertar', $datos);
		$this->load->view('eliminar', $datos);
		$this->load->view('cambiar', $datos);
	}
	public function alta_persona()
	{

	    $this->load->model("Mibasesamuelalegre_model");
	    $datos = array(
	        'ci' => $this->input->post('ci'),
	        'nombre_comp' => $this->input->post('nombre_comp'),
	        'fecha_nac' => $this->input->post('fecha_nac'),
	        'telefono' => $this->input->post('telefono'),
	        'departamento' => $this->input->post('departamento')
	    );
	    $this->Mibasesamuelalegre_model->insertar_persona($datos['ci'], 
													        $datos['nombre_comp'], 
													        $datos['fecha_nac'], 
													        $datos['telefono'], 
													        $datos['departamento']);
	    $filas = $this->Mibasesamuelalegre_model->personas();
	    redirect('http://localhost/code/index.php/Lectura/');
	}
	public function baja_persona()
	{

	    $this->load->model("Mibasesamuelalegre_model");
	    $datos = array(
	        'ci' => $this->input->post('ci'),
	    );
	    $this->Mibasesamuelalegre_model->eliminar_persona($datos['ci']);
	    $filas = $this->Mibasesamuelalegre_model->personas();
	    redirect('http://localhost/code/index.php/Lectura/');
	}
	public function cambio_persona()
	{

	    $this->load->model("Mibasesamuelalegre_model");
	    $datos = array(
	        'ci' => $this->input->post('ci'),
	        'nombre_comp' => $this->input->post('nombre_comp'),
	        'fecha_nac' => $this->input->post('fecha_nac'),
	        'telefono' => $this->input->post('telefono'),
	        'departamento' => $this->input->post('departamento')
	    );
	    $this->Mibasesamuelalegre_model->cambiar_persona($datos['ci'], 
													        $datos['nombre_comp'], 
													        $datos['fecha_nac'], 
													        $datos['telefono'], 
													        $datos['departamento']);
	    $filas = $this->Mibasesamuelalegre_model->personas();
	    redirect('http://localhost/code/index.php/Lectura/');
	}

	
	
}

