using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroPacientes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                if (Request.QueryString["IdPaciente"] != null)
                {
                    Session["IdPaciente"] = Request.QueryString["IdPaciente"];
                    ButtonEliminar.Visible = true;
                    Buscar();
                }
        }

        Pacientes pac = new Pacientes();
        public void Buscar()
        {

            int id = 0;
            int.TryParse(Session["IdPaciente"].ToString(), out id);
            pac.IdPaciente = id;
            if (pac.Buscar() == true)
            {
                NombresTextBox.Text = pac.Nombres;
                ApellidosTextbox.Text  =pac.Apellidos;
                CedulaTextBox.Text = pac.Cedula;
                CelularTextBox.Text = pac.Celular;
                DireccionTextBox.Text = pac.Direccion;
                FechaIngresoTextBox.Text = pac.FechaIngreso.ToString("yyyy-MM-dd");
                FechaNacTextBox.Text = pac.FechaNacimiento.ToString("yyyy-MM-dd");
                OcupacionTextBox.Text = pac.Ocupacion;
                SexoDropDownList.SelectedIndex = pac.Sexo;
                TelefonoTextBox.Text = pac.Telefono;
            }
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            pac.Nombres = NombresTextBox.Text;
            pac.Apellidos = ApellidosTextbox.Text;
            pac.Cedula = CedulaTextBox.Text;
            pac.Celular = CelularTextBox.Text;
            pac.Direccion = DireccionTextBox.Text;
            pac.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);
            pac.FechaNacimiento = Convert.ToDateTime(FechaNacTextBox.Text);
            pac.Ocupacion = OcupacionTextBox.Text;
            pac.Sexo = SexoDropDownList.SelectedIndex;
            pac.Telefono = TelefonoTextBox.Text;

            if (Session["IdPaciente"] == null)
                pac.Insertar();
            else
            {
                int id = 0;
                int.TryParse(Session["IdPaciente"].ToString(), out id);
                pac.Modificar(id);
            }
            Limpiar();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdPaciente"].ToString(), out id);
            pac.Eliminar(id);
            Limpiar();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaPacientes.aspx");
        }

        protected void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            NombresTextBox.Text = "";
            ApellidosTextbox.Text = "";
            CedulaTextBox.Text = "";
            CelularTextBox.Text = "";
            DireccionTextBox.Text = "";
            FechaIngresoTextBox.Text = "";
            FechaNacTextBox.Text = "";
            OcupacionTextBox.Text = "";
            SexoDropDownList.SelectedIndex = 0;
            TelefonoTextBox.Text = "";
            ButtonEliminar.Visible = false;
        }
    }
}