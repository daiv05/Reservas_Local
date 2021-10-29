using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Anio
    {
        [Key]
        public String AnioCurso { get; set; }
    }

    public class AnioContext : DbContext
    {
        public AnioContext() { }
        public DbSet<Anio> Anio { get; set; }
    }
}