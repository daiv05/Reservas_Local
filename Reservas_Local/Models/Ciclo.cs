using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Ciclo
    {
        public int CicloID { get; set; }
        public String TipoCiclo { get; set; }
    }
}