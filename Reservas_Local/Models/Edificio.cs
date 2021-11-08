using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Edificio
    {
        public int EdificioID { get; set; }
        public String NombreEdif { get; set; }

        public int EscuelaID { get; set; }
        public Escuela Escuela { get; set; }

        public int NumPlantas { get; set; }

        public ICollection<Local> Locales { get; set; }

    }
}