﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Ubicacion
    {
        [Key]
        public int UbicacionID { get; set; }
        public String Latitud { get; set; }
        public String Altitud { get; set; }
    }

    public class UbicacionContext : DbContext
    {
        public UbicacionContext() { }
        public DbSet<Ubicacion> Ubicacion { get; set; }
    }
}