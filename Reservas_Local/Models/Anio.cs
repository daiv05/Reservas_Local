using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Anio
    {
        public int AnioID { get; set; }
        public String AnioCurso { get; set; }
    }
}