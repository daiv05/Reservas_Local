using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Carrera
    {
        public int CarreraID { get; set; }
        public String NomCarrera { get; set; }

        public int PensumID { get; set; }
        public Pensum PensumCarrera { get; set; }
    }
    /*
    public class CarreraContext : DbContext
    {
        public CarreraContext() { }
        public DbSet<Carrera> Carrera { get; set; }
    }*/
}