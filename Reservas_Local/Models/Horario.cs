using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Horario
    {
        public int HorarioID { get; set; }
        
        public int HoraID { get; set; }
        public Hora Hora { get; set; }
        
        public int DiaID { get; set; }
        public Dia Dia { get; set; }

    }
}