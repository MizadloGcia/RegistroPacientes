using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
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
        
        public bool Eliminar(int IdPaciente)
        {
            return con.EjecutarDB("Delete from Pacientes where IdPaciente =" + IdPaciente);
        }

        public bool Modificar(int IdPaciente)
        {
            return con.EjecutarDB("Update Pacientes set Nombres=" + Nombres + ",Apellidos =" + Apellidos + ",Direccion =" + Direccion + ",Telefono =" + Telefono + ",Cedula =" + Cedula + ",Celular =" + Celular + ",FechaNac=" + FechaNacimiento.ToString("MM/dd/yy HH:mm:ss") + ",FechaIngreso=" + FechaIngreso.ToString("MM/dd/yy HH:mm:ss") + ",Sexo=" + Sexo + ",Ocupacion=" + Ocupacion
                + "where IdPaciente =" + IdPaciente);
        }

        public bool Buscar()
        {
            bool msj=false;
            DataTable dt=new DataTable();
            dt = con.BuscarDb("Select * from Pacientes where IdPaciente =" + IdPaciente);
            if (dt.Rows.Count > 0) 
            {
                msj = true;
                IdPaciente = (int)dt.Rows[0]["IdPaciente"];
                Nombres = dt.Rows[0]["Nombres"].ToString();
                Apellidos = dt.Rows[0]["Apellidos"].ToString();
                FechaNacimiento = (DateTime)dt.Rows[0]["FechaNac"];
                FechaIngreso = (DateTime)dt.Rows[0]["FechaIngreso"];
                Direccion = dt.Rows[0]["Direccion"].ToString();
                Telefono = dt.Rows[0]["Telefono"].ToString();
                Celular = dt.Rows[0]["Celular"].ToString();
                Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
                Sexo = (int)dt.Rows[0]["Sexo"];
                Cedula = dt.Rows[0]["Cedula"].ToString();
            }
             return msj; 
        }

        public DataTable Listar(string Filtro,string Campos)
        {
            return con.BuscarDb("Select " + Campos + " from Pacientes " + Filtro);
        }
    }
}