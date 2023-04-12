using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;

namespace p2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                Response.Redirect("index.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string usuario = Busuario.Text.Trim();
            string contrasena = Bcontrasena.Text.Trim();

            DataSet ds = new DataSet();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user=root;pwd=Carolinaloca123;database=mibasesamuelalegre; SslMode=none;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            //Debug.WriteLine(usuario+" "+contrasena);
            cmd.CommandText = "SELECT * FROM usuario WHERE Usuario = @usuario AND Password = @contrasena";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Se encontró el usuario con el nombre de usuario y la contraseña proporcionados
                int ci = Convert.ToInt32(ds.Tables[0].Rows[0]["CI"]);
                string nombreUsuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
                string password = ds.Tables[0].Rows[0]["Password"].ToString();
                // El usuario ingresó correctamente su contraseña
                //INICIAMOS SESION
                Session["usuariologueado"] = Busuario.Text;
                //Guardamos el rol en variable de sesion
                Session["rol"] = ds.Tables[0].Rows[0]["Rol"].ToString(); ;
                Response.Redirect("index.aspx");

            }
            else
            {
                // Mala login
                Response.Redirect("error.aspx");
            }
            con.Close();
        }
    }
}