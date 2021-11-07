using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Actividad
    {
        public int ActividadID { get; set; }

        public int TipoActividadID { get; set; }
        public TipoActividad TipoActividad { get; set; }

        public int AsignaturaID { get; set; }
        public Asignatura Asignatura { get; set; }

        public String Ciclo { get; set; }

        public int AnioID { get; set; }
        public Anio Anio { get; set; }
    }

}