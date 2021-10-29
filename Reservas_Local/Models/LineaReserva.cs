using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class LineaReserva
    {
        [Key]
        public int LineaReservaID { get; set; }
        public Local Local { get; set; }
        public Horario HorarioReservado { get; set; }
        public Semana SemanaCiclo { get; set; }
    }

    public class LineaReservaContext : DbContext
    {
        public LineaReservaContext() { }
        public DbSet<LineaReserva> LineaReserva { get; set; }
    }
}