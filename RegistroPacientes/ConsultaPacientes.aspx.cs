using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroPacientes
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Buscar();
        }
        

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string Filtro = "1=1";
            if (FiltroDropDownList.SelectedIndex == 1)
                Filtro += "and Nombres like '%" + FiltroTextBox.Text + "%'";
            else if (FiltroDropDownList.SelectedIndex == 2)
                Filtro += "and Apellidos like '%" + FiltroTextBox.Text + "%'";
            FiltroGridView.DataSource = Pacientes.Listar(Filtro, "*");
            FiltroGridView.DataBind();
        }

        public void Buscar()
        {
            string Filtro = "1=1";
            FiltroGridView.DataSource = Pacientes.Listar(Filtro, "*");
            FiltroGridView.DataBind();
        }
    }
}