using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace RegistroPacientes
{
    public partial class RegistroRevision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){ 
            
                PacienteDropDownList.DataSource = Pacientes.Listar("1=1", "IdPaciente, Nombres");
                PacienteDropDownList.DataTextField = "Nombres";
                PacienteDropDownList.DataValueField = "IdPaciente";
                PacienteDropDownList.DataBind();

                SistemasDropDownList.DataSource = SistemasFisiologico.Listar("1=1", "IdSistema, Nombre");
                SistemasDropDownList.DataTextField = "Nombre";
                SistemasDropDownList.DataValueField = "IdSistema";
                SistemasDropDownList.DataBind();

                RevisionGridView.Dispose();
                }
            }
        

        

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable data;

            if (Session["data"] == null)
            {
                data = new DataTable();
                data.Columns.Add(new DataColumn("IdSistema"));
                data.Columns.Add(new DataColumn("Estado"));

            }
            else
            {
                data = Session["data"] as DataTable;
            }

            DataRow row = data.NewRow();
            row["IdSistema"] = SistemasDropDownList.SelectedValue;
            row["Estado"] = EstadoTextBox.Text;
            data.Rows.Add(row);

            Session["data"] = data;
            RevisionGridView.DataSource = data;
            RevisionGridView.DataBind();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Revision rev = new Revision();

            rev.IdPaciente = Convert.ToInt32(PacienteDropDownList.SelectedValue);
            rev.Fecha = Convert.ToDateTime(FechaTextBox.Text);

            if (rev.Insertar())
            {
                if (rev.BuscarIdRev())
                {
                    IdRevisionTextBox.Text = rev.IdRevision.ToString();
                }

                DataTable data = Session["data"] as DataTable;

                foreach (DataRow row in data.Rows)
                {
                    rev.IdSistema = int.Parse(row["IdSistema"].ToString());
                    rev.Estado = row["Estado"].ToString();

                    rev.InsertarDetalle();
                }
            }
        }
    }
}