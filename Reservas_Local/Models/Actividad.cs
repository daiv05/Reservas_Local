using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Actividad
    {
        [Key]
        public int ActividadID { get; set; }
        public TipoActividad TipoActividad { get; set; }
        public Asignatura Asignatura { get; set; }
        public Ciclo Ciclo { get; set; }
        public Anio Anio { get; set; }
    }

    public class ActividadContext : DbContext
    {
        public ActividadContext() { }
        public DbSet<Actividad> Actividad { get; set; }
    }
}