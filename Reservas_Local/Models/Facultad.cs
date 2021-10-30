using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Facultad
    {
        public int FacultadID { get; set; }
        public String NombreFacu { get; set; }
        public ICollection<Escuela> Escuelas { get; set; }
    }
    /*
    public class FacultadContext : DbContext
    {
        public FacultadContext() { }
        public DbSet<Facultad> Facultad { get; set; }
    }*/
}