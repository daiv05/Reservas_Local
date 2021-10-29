using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Reservas_Local.Models
{
    public class TipoAsignatura
    {
        [Key]
        public string TipoAsigna { get; set; }
    }
    public class TipoAsignaturaContext : DbContext
    {
        public TipoAsignaturaContext() { }
        public DbSet<TipoAsignatura> TipoAsignatura { get; set; }
    }
}