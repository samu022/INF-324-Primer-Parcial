using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            dataGridView1.DataSource = sw.Persona().Tables[0];
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.insertar(int.Parse(cii.Text), nombrei.Text, DateTime.Parse(fechai.Text), telefonoi.Text, departamentoi.Text);
            dataGridView1.DataSource = sw.Persona().Tables[0];
            cii.Text = "";
            nombrei.Text = "";
            telefonoi.Text = "(591)";
            departamentoi.Text = "";
        }

        private void eliminarb_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.eliminar(int.Parse(cie.Text));
            dataGridView1.DataSource = sw.Persona().Tables[0];
            cie.Text = "";
        }

        private void actualizarb_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient sw = new ServiceReference2.WebService1SoapClient();
            sw.actualizar(int.Parse(cia.Text), nombrea.Text, DateTime.Parse(fechaa.Text), telefonoa.Text, departamentoa.Text);
            dataGridView1.DataSource = sw.Persona().Tables[0];
            cia.Text = "";
            nombrea.Text = "";
            telefonoa.Text = "(591)";
            departamentoa.Text = "";
        }
    }
}
