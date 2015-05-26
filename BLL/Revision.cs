using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace BLL
{
    public class Revision
    {
        public int IdRevisionDetalle { get; set; }
        public int IdRevision { get; set; }
        public int IdSistema { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPaciente { get; set; }
        

        public Revision()
        {
            this.IdRevisionDetalle = 0;
            this.IdSistema = 0;
            this.Estado = null;
            this.Fecha = DateTime.Now;
            this.IdPaciente = 0;
        }

        Conexion con = new Conexion();

        public bool InsertarDetalle()
        {
            return con.EjecutarDB("Insert into RevisionDetalle(IdRevision, IdSistema, Estado) Values('" + IdRevision +
                "','" + IdSistema + "','" + Estado + "')");
        }

        public bool Insertar()
        {
            return con.EjecutarDB("Insert into RevisionPaciente(Fecha, IdPaciente) Values('" + Fecha +
                "','" + IdPaciente + "')");
        }
        
        public bool Eliminar(int IdPaciente)
        {
            return false;
        }

        public bool Modificar(int IdPaciente)
        {
            return false;
        }

        public bool Buscar()
        {

            return false;
        }

        public bool BuscarIdRev()
        {
            bool msj = false;
            DataTable dt = new DataTable();
            dt = con.BuscarDb("Select Max(IdRevision) as IdRevision from RevisionPaciente");
            if (dt.Rows.Count > 0)
            {
                msj = true;
                IdRevision = (int)dt.Rows[0]["IdRevision"];
                
            }
            return msj; 
        }

        
    }
}