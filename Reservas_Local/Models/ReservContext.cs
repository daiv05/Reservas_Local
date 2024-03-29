﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservas_Local.Models
{
    public class ReservContext : DbContext
    {
        public DbSet<Actividad> Actividad { get; set; }
        public DbSet<TipoActividad> TipoActividad { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }
        public DbSet<Ciclo> Ciclo { get; set; }
        public DbSet<Anio> Anio { get; set; }
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Dia> Dia { get; set; }
        public DbSet<Edificio> Edificio { get; set; }
        public DbSet<Escuela> Escuela { get; set; }
        public DbSet<EstadoUser> EstadoUser { get; set; }
        public DbSet<Facultad> Facultad { get; set; }
        public DbSet<Fotografia> Fotografia { get; set; }
        public DbSet<Hora> Hora { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<LineaReserva> LineaReserva { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Pensum> Pensum { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Semana> Semana { get; set; }
        public DbSet<TipoAsignatura> TipoAsignatura { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }

        public System.Data.Entity.DbSet<Reservas_Local.Models.Docente> Docentes { get; set; }
    }
}