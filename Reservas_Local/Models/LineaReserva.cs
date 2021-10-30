using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class LineaReserva
    {
        public int LineaReservaID { get; set; }
        
        public int LocalID { get; set; }
        public Local Local { get; set; }
        
        public int HorarioID { get; set; }
        public Horario HorarioReserv { get; set; }
        
        public int SemanaID { get; set; }
        public Semana SemanaCiclo { get; set; }
    }
    /*
    public class LineaReservaContext : DbContext
    {
        public LineaReservaContext() { }
        public DbSet<LineaReserva> LineaReserva { get; set; }
    }*/
}