﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Dia
    {
        public int DiaID { get; set; }
        public String NombreDia { get; set; }
    }
}