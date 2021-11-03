using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Ubicacion
    {
        public int UbicacionID { get; set; }
        public String Latitud { get; set; }
        public String Altitud { get; set; }
    }
}