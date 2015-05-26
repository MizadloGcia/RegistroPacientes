using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroPacientes
{
    public partial class ConsultaSistemas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            string Filtro = "1=1";
            SistFisGridView.DataSource = SistemasFisiologico.Listar(Filtro, "*");
            SistFisGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string Filtro = "1=1";
            
            Filtro += "and Nombre like '%" + FiltroTextBox.Text + "%'";
            SistFisGridView.DataSource = SistemasFisiologico.Listar(Filtro, "*");
            SistFisGridView.DataBind();
        }
    }
}