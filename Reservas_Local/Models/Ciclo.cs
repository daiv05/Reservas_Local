using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Ciclo
    {
        [Key]
        public String TipoCiclo { get; set; }
    }
    public class CicloContext : DbContext
    {
        public CicloContext() { }
        public DbSet<Ciclo> Ciclo { get; set; }
    }
}