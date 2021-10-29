using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Pensum
    {
        [Key]
        public String Nombre { get; set; }
        public String Anio { get; set; }
        public ICollection<Asignatura> Asignaturas { get; set; }

    }

    public class PensumContext : DbContext
    {
        public PensumContext() { }
        public DbSet<Pensum> Pensum { get; set; }
    }
}