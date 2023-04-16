using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace p7
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet Persona()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user=root;pwd=Carolinaloca123;database=mibasesamuelalegre; SslMode=none;";
            MySqlDataAdapter ada = new MySqlDataAdapter();
            ada.SelectCommand = new MySqlCommand();
            ada.SelectCommand.Connection = con;
            ada.SelectCommand.CommandText = "select * from persona";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ada.Fill(ds);
            con.Close();
            return ds;
        }
        [WebMethod]
        public void insertar(int ci, string nombre, DateTime fecha_nac, string telefono, string depto)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user=root;pwd=Carolinaloca123;database=mibasesamuelalegre;SslMode=none;";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES (@ci, @nombre, @fecha_nac, @telefono, @depto)";
                // Agregar parámetros a la consulta
                cmd.Parameters.AddWithValue("@ci", ci);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha_nac", fecha_nac);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@depto", depto);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
        [WebMethod]
        public void eliminar(int ci)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user=root;pwd=Carolinaloca123;database=mibasesamuelalegre; SslMode=none;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            // Construir la consulta SQL para actualizar los datos de la persona
            string query = $"DELETE FROM persona WHERE CI = {ci}";
            cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        [WebMethod]
        public void actualizar(int ci, string nombre, DateTime fecha_nac, string telefono, string depto)
        {
            try
            {
                
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = "server=localhost;user=root;pwd=Carolinaloca123;database=mibasesamuelalegre; SslMode=none;";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    // Construir la consulta SQL para actualizar los datos de la persona
                    cmd.CommandText = "UPDATE persona SET Nombre_comp = @nombre, Fecha_nac = @fecha_nac, Telefono = @telefono, Departamento = @depto WHERE CI = @ci";

                    // Agregar parámetros a la consulta
                    cmd.Parameters.AddWithValue("@ci", ci);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@fecha_nac", fecha_nac);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@depto", depto);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }


        }
    }
}
