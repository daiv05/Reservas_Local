using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Escuela
    {
        public int EscuelaID { get; set; }
        public String NombreEscu { get; set; }
        
        public int FacultadID { get; set; }
        public Facultad Facultad { get; set; }

        public ICollection<Edificio> Edificios { get; set; }
    }
}