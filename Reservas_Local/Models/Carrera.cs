using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Carrera
    {
        [Key]
        public String NomCarrera { get; set; }
        public Pensum Pensum { get; set; }
    }

    public class CarreraContext : DbContext
    {
        public CarreraContext() { }
        public DbSet<Carrera> Carrera { get; set; }
    }
}