﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Horario
    {
        [Key]
        public int HorarioID { get; set; }
        public Hora Hora { get; set; }
        public Dia Dia { get; set; }
    }
        public class HorarioContext : DbContext
    {
        public HorarioContext() { }
        public DbSet<Horario> Horario { get; set; }
    }
}