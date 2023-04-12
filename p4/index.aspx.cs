using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "Bienvenido/a "+usuariologueado;
                if (Session["rol"] != null && Session["rol"].ToString() == "director")
                {
                    // Mostrar el botón para administradores
                    BtnDirector.Visible = true;
                }
                else
                {
                    // Ocultar el botón para no-administradores
                    BtnDirector.Visible = false;
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("usuariologueado");
            Response.Redirect("login.aspx");
        }
        
    }
}