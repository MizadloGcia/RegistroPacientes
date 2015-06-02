using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace RegistroPacientes
{
    public partial class InicioSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInButton_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            if (us.Buscar(NomUsuarioTextBox.Text, PassTextBox.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(NomUsuarioTextBox.Text, true);
                Response.Redirect("MenuPrincipal.aspx");
            }
            else
            {
                Response.Write("Usuario o Password invalido!");
            }
        }


    }
}