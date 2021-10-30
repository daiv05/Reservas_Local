using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class TipoActividad
    {
        public int TipoActividadID { get; set; }
        public String ActividadTipo { get; set; }
    }

    /*
    public class TipoActividadContext : DbContext
    {
        public TipoActividadContext() { }
        public DbSet<TipoActividad> TipoActividad { get; set; }
    }*/
}