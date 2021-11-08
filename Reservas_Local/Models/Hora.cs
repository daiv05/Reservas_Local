using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Hora
    {
        public int HoraID { get; set; }
        public String HInicio { get; set; }
        public String HFin { get; set; }
    }
}