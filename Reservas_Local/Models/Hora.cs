using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Hora
    {
        [Key]
        public String HInicio { get; set; }
        [Key]
        public String HFin { get; set; }
    }
    public class HoraContext : DbContext
    {
        public HoraContext() { }
        public DbSet<Hora> Hora { get; set; }
    }
}