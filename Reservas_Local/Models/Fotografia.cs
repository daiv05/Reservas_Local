using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Fotografia
    {
        public Local Local { get; set; }
        [Key]
        public byte[] Imagen { get; set; }
    }
    public class FotografiaContext : DbContext
    {
        public FotografiaContext() { }
        public DbSet<Fotografia> Fotografia { get; set; }
    }
}