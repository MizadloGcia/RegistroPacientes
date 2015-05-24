using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroPacientes
{
    public partial class RegistroRevision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                PacienteDropDownList.DataSource = Pacientes.Listar("1=1", "IdPaciente, Nombres");
                PacienteDropDownList.DataTextField = "Nombres";
                PacienteDropDownList.DataValueField = "IdPaciente";
                PacienteDropDownList.DataBind();

                SistemasDropDownList.DataSource = SistemasFisiologico.Listar("1=1", "IdSistema, Nombre");
                SistemasDropDownList.DataTextField = "Nombre";
                SistemasDropDownList.DataValueField = "IdSistema";
                SistemasDropDownList.DataBind();
            }
            catch (Exception) { }

        }
    }
}