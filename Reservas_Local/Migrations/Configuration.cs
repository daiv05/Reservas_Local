namespace Reservas_Local.Migrations
{
    using Reservas_Local.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Reservas_Local.Models.ReservContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Reservas_Local.Models.ReservContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Ciclo.AddOrUpdate(
                x => x.CicloID,
                new Ciclo() { CicloID = 1, TipoCiclo = "Par" },
                new Ciclo() { CicloID = 2, TipoCiclo = "Impar" }
            );

            context.Anio.AddOrUpdate(
                x => x.AnioID,
                new Anio() { AnioID = 1, AnioCurso = "2020" },
                new Anio() { AnioID = 2, AnioCurso = "2021" },
                new Anio() { AnioID = 3, AnioCurso = "2022" }
            );

            context.Pensum.AddOrUpdate(
                x => x.PensumID,
                new Pensum() { PensumID = 1, NombrePensum = "Sistemas98", Anio = "1998"},
                new Pensum() { PensumID = 2, NombrePensum = "Electrica15", Anio = "2015" }
            );

            context.TipoAsignatura.AddOrUpdate(
                x => x.TipoAsignaturaID,
                new TipoAsignatura() { TipoAsignaturaID = 1, AsignaturaTipo = "Obligatoria" },
                new TipoAsignatura() { TipoAsignaturaID = 2, AsignaturaTipo = "Electiva" }
            );

            context.Asignatura.AddOrUpdate(
                x => x.AsignaturaID,
                new Asignatura() { AsignaturaID = 1, CodAsignatura = "MAT115", NombreAsignatura = "Matematica I" , CicloID = 1, PensumID = 1, TipoAsignaturaID = 1, UV = 4 },
                new Asignatura() { AsignaturaID = 2, CodAsignatura = "PRN115", NombreAsignatura = "Programacion I" ,CicloID = 1, PensumID = 1, TipoAsignaturaID = 1, UV = 4 },
                new Asignatura() { AsignaturaID = 3, CodAsignatura = "EIM115", NombreAsignatura = "Electrica I" ,CicloID = 1, PensumID = 2, TipoAsignaturaID = 1, UV = 4 },
                new Asignatura() { AsignaturaID = 4, CodAsignatura = "FIR115", NombreAsignatura = "Fisica I" ,CicloID = 1, PensumID = 2, TipoAsignaturaID = 1, UV = 4 }
            );

            context.Asignatura.AddOrUpdate(
                x => x.AsignaturaID,
                new Asignatura() { AsignaturaID = 5, CodAsignatura = "MAT215", NombreAsignatura = "Matematica II", CicloID = 2, PensumID = 1, TipoAsignaturaID = 2, UV = 4 },
                new Asignatura() { AsignaturaID = 6, CodAsignatura = "PRN215", NombreAsignatura = "Programacion II", CicloID = 2, PensumID = 1, TipoAsignaturaID = 1, UV = 4 },
                new Asignatura() { AsignaturaID = 7, CodAsignatura = "EIM215", NombreAsignatura = "Electrica II", CicloID = 2, PensumID = 2, TipoAsignaturaID = 2, UV = 4 },
                new Asignatura() { AsignaturaID = 8, CodAsignatura = "FIR215", NombreAsignatura = "Fisica II", CicloID = 2, PensumID = 2, TipoAsignaturaID = 1, UV = 4 }
            );

            context.Carrera.AddOrUpdate(
                x => x.CarreraID,
                new Carrera() { CarreraID = 1, NomCarrera = "Ing. de Sistemas Informaticos", PensumID = 1 },
                new Carrera() { CarreraID = 2, NomCarrera = "Ing. Electrica", PensumID = 2 }
            );

            context.Dia.AddOrUpdate(
                x => x.DiaID,
                new Dia() { DiaID = 1, NombreDia = "Lunes"},
                new Dia() { DiaID = 2, NombreDia = "Martes" },
                new Dia() { DiaID = 3, NombreDia = "Miercoles" },
                new Dia() { DiaID = 4, NombreDia = "Jueves" },
                new Dia() { DiaID = 5, NombreDia = "Viernes" }
            );

            context.Facultad.AddOrUpdate(
                x => x.FacultadID,
                new Facultad() { FacultadID = 1, NombreFacu = "Facultad de Ingenieria y Arquitectura" }
            );

            context.Escuela.AddOrUpdate(
                x => x.EscuelaID,
                new Escuela() { EscuelaID = 1, NombreEscu = "Escuela de Ing. Electrica", FacultadID = 1 },
                new Escuela() { EscuelaID = 2, NombreEscu = "Escuela de Ing. de Sistemas Informaticos", FacultadID = 1 }
            );

            context.Edificio.AddOrUpdate(
                x => x.EdificioID,
                new Edificio() { EdificioID = 1, NombreEdif = "Edificio Dr. Rodriguez", NumPlantas = 2, EscuelaID = 1 },
                new Edificio() { EdificioID = 2, NombreEdif = "Edificio 13", NumPlantas = 2, EscuelaID = 2 }
            );

            /*
            context.EstadoUser.AddOrUpdate(
                x => x.EstadoUserID,
                new EstadoUser() { EstadoUserID = 1, Estado = "Activo"},
                new EstadoUser() { EstadoUserID = 2, Estado = "Inactivo" }
            );
            */

            context.Hora.AddOrUpdate(
                x => x.HoraID,
                new Hora() { HoraID = 1, HInicio = "6:00", HFin = "8:00" },
                new Hora() { HoraID = 1, HInicio = "9:00", HFin = "10:00" },
                new Hora() { HoraID = 1, HInicio = "11:00", HFin = "12:00" },
                new Hora() { HoraID = 1, HInicio = "1:00", HFin = "2:00" },
                new Hora() { HoraID = 1, HInicio = "3:00", HFin = "4:00" }
            );


            context.Local.AddOrUpdate(
                x => x.LocalID,
                new Local() { LocalID = 1, NombreLocal= "DR11", EdificioID = 1, Planta = 1, Altitud = "24253232", Latitud = "32523552" },
                new Local() { LocalID = 2, NombreLocal = "DR21", EdificioID = 1, Planta = 2, Altitud = "352525", Latitud = "32626525" },
                new Local() { LocalID = 3, NombreLocal = "ED11", EdificioID = 2, Planta = 1, Altitud = "3265252", Latitud = "867657" },
                new Local() { LocalID = 4, NombreLocal = "ED23", EdificioID = 2, Planta = 2, Altitud = "142536", Latitud = "097766" }
            );


            context.Semana.AddOrUpdate(
                x => x.SemanaID,
                new Semana() { SemanaID = 1, numSemana = 1 },
                new Semana() { SemanaID = 2, numSemana = 2 }
            );

            context.TipoActividad.AddOrUpdate(
                x => x.TipoActividadID,
                new TipoActividad() { TipoActividadID = 1, ActividadTipo = "Practica" },
                new TipoActividad() { TipoActividadID = 2, ActividadTipo = "Laboratorio" },
                new TipoActividad() { TipoActividadID = 3, ActividadTipo = "Parcial" }
            );

        }
    }
}
