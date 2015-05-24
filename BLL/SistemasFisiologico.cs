using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class SistemasFisiologico
    {
        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        

        public SistemasFisiologico()
        {
            this.IdSistema = 0;
            this.Nombre = null;
           
        }

        Conexion con = new Conexion();

        public bool Insertar()
        {
            return con.EjecutarDB("Insert into SistemasFisiologico(Nombre) Values('" + Nombre + "')");
        }
        /*
        public bool Eliminar(int IdPaciente)
        {
            return con.EjecutarDB("Delete from Pacientes where IdPaciente =" + IdPaciente);
        }

        public bool Modificar(int IdPaciente)
        {
            return con.EjecutarDB("Update Pacientes set Nombres='" + Nombres + "',Apellidos ='" + Apellidos + "',Direccion ='" + Direccion + "',Telefono ='" + Telefono + "',Cedula ='" + Cedula + "',Celular ='" + Celular + "',FechaNac='" + FechaNacimiento.ToString("MM/dd/yy HH:mm:ss") + "',FechaIngreso='" + FechaIngreso.ToString("MM/dd/yy HH:mm:ss") + "',Sexo='" + Sexo + "',Ocupacion='" + Ocupacion
                + "'where IdPaciente =" + IdPaciente);
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
        }*/

        public static DataTable Listar(string Filtro,string Campos)
        {
            Conexion con = new Conexion();
            return con.BuscarDb("Select " + Campos + " from SistemasFisiologico where " + Filtro);
        }
    }
}