using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Fotografia
    {
        public int FotografiaID { get; set; }
        public byte[] Imagen { get; set; }

        public int LocalID { get; set; }
        public Local Local { get; set; }

    }
}