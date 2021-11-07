using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Local
    {
        public int LocalID { get; set; }
        public String NombreLocal { get; set; }
        public String Altitud { get; set; }
        public String Latitud { get; set; }

        public int EdificioID { get; set; }
        public Edificio Edificio { get; set; }

        public ICollection<Fotografia> Fotografias { get; set; }

        public int Planta { get; set; }
        public double Puntuacion { get; set; }
    }
}