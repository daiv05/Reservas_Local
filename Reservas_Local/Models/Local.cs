using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Local
    {
        [Key]
        public String NombreLocal { get; set; }
        public Edificio Edificio { get; set; }
        public int Planta { get; set; }
        public double Puntuacion { get; set; }
    }
    public class LocalContext : DbContext
    {
        public LocalContext() { }
        public DbSet<Local> Local { get; set; }
    }
}