using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class Docente
    {
        public int DocenteID { get; set; }
        public String NombreDocente { get; set; }
        public String ApellidoDocente { get; set; }
        public String CorreoDocente { get; set; }
        public String Contrasenia { get; set; }
        public String NIT { get; set; }
        public String DUI { get; set; }

        public int EstadoUserID { get; set; }
        public EstadoUser EstadoUsuario { get; set; }

        public ICollection<Reserva> MisReservas { get; set; }
    }
}