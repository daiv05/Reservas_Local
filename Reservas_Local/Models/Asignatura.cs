using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Reservas_Local.Models
{
    public class Asignatura
    {
        [Key]
        public String CodAsignatura { get; set; }
        public String NombreAsignatura { get; set; }
        public int UV { get; set; }
        public TipoAsignatura TipoAsignatura { get; set; }
        public Ciclo CicloAsignatura { get; set; }
        public Asignatura Prerrequisito { get; set; }
    }

    public class AsignaturaContext : DbContext
    {
        public AsignaturaContext() { }
        public DbSet<Asignatura> Asignatura { get; set; }
    }
}