using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservas_Local.Models
{
    public class Asignatura
    {
        public int AsignaturaID { get; set; }
        public String CodAsignatura { get; set; }
        public String NombreAsignatura { get; set; }
        public int UV { get; set; }

        public int TipoAsignaturaID { get; set; }
        public TipoAsignatura TipoAsignatura { get; set; }

        public int CicloID { get; set; }
        public Ciclo CicloAsignatura { get; set; }

        public int PensumID { get; set; }
        public Pensum PensumAsignatura { get; set; }


        [ForeignKey("AsignaturaID")]
        public Asignatura Prerrequisito { get; set; }
    }
}