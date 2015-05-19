﻿using System;
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

        }

        Pacientes pac = new Pacientes();

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

            pac.Insertar();

            Limpiar();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {

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
        }
    }
}