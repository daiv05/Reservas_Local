using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Semana
    {
        [Key]
        public int numSemana { get; set; }
    }

    public class SemanaContext : DbContext
    {
        public SemanaContext() { }
        public DbSet<Semana> Semana { get; set; }
    }
}