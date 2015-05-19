using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Pacientes
    {
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Sexo { get; set; }
        public string Ocupacion { get; set; }

        public Pacientes()
        {
            this.IdPaciente = 0;
            this.Nombres = null;
            this.Apellidos = null;
            this.Direccion = null;
            this.Telefono = null;
            this.Cedula = null;
            this.Celular = null;
            this.FechaNacimiento = DateTime.Now;
            this.FechaIngreso = DateTime.Now;
            this.Sexo = 0;
            this.Ocupacion = null;
        }

        Conexion con = new Conexion();

        public bool Insertar()
        {
            return con.EjecutarDB("Insert into Pacientes(Nombres, Apellidos, Direccion, Telefono, Cedula, Celular, FechaNac, FechaIngreso, Sexo, Ocupacion) Values('" + Nombres +
                "','" + Apellidos + "','" + Direccion + "','" + Telefono + "','" + Cedula + "','" + Celular + "','" + FechaNacimiento.ToString("MM/dd/yy HH:mm:ss") + "','" + FechaIngreso.ToString("MM/dd/yy HH:mm:ss") + "','" + Sexo + "','" + Ocupacion + "')");
        }
    }
}