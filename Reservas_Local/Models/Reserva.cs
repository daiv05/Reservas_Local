using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public String NombreReserva { get; set; }
        public Boolean Aproved { get; set; }

        public int ActividadID { get; set; }
        public Actividad Actividad { get; set; }

        public int DocenteID { get; set; }
        public Docente DocenteReserva { get; set; }

        public ICollection<LineaReserva> LineasReservas { get; set; }
    }
}