using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class TipoActividad
    {
        [Key]
        public String TipoActi { get; set; }
    }

    public class TipoActividadContext : DbContext
    {
        public TipoActividadContext() { }
        public DbSet<TipoActividad> TipoActividad { get; set; }
    }
}