using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroPacientes
{
    public partial class RegistroSistema : System.Web.UI.Page
    {
        SistemasFisiologico sf = new SistemasFisiologico();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            sf.Nombre = NombreTextBox.Text;
            sf.Insertar();
        }

        protected void VerSistButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaSistemas.aspx");
        }
    }
}