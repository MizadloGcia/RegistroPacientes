using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroPacientes
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsPacButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaPacientes.aspx");
        }

        protected void RegPacButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroPacientes.aspx");
        }

        protected void RegRevButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroRevision.aspx");
        }

        protected void RegSistButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroSistema.aspx");
        }

        protected void CerrarSesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSession.aspx");
        }

    }
}