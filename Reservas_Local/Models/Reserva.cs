using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }
        public Boolean Aproved { get; set; }
        public Actividad Actividad { get; set; }
        public ICollection<LineaReserva> LineasReservas { get; set; }
    }

    public class ReservaContext : DbContext
    {
        public ReservaContext() { }
        public DbSet<Reserva> Reserva { get; set; }
    }
}