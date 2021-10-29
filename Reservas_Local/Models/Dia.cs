using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Dia
    {
        [Key]
        public String NombreDia { get; set; }
    }

    public class DiaContext : DbContext
    {
        public DiaContext() { }
        public DbSet<Dia> Dia { get; set; }
    }
}