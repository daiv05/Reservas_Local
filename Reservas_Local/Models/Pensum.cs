using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Pensum
    {
        public int PensumID { get; set; }
        public String NombrePensum { get; set; }
        public String Anio { get; set; }

        public ICollection<Asignatura> Asignaturas { get; set; }

    }
}