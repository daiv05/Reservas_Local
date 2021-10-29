using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Escuela
    {
        [Key]
        public String NombreEscu { get; set; }
        public Facultad Facultad { get; set; }
        public ICollection<Edificio> Edificios { get; set; }
    }
    public class EscuelaContext : DbContext
    {
        public EscuelaContext() { }
        public DbSet<Escuela> Escuela { get; set; }
    }
}