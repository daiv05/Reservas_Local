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
            /*
            var asignatura = new List<Asignatura>
            {
                new Asignatura {AsignaturaID = 1,   CodAsignatura = "MAT115",
                    NombreAsignatura = "Matematica I", UV = 4, TipoAsignaturaID = 1, CicloID = 1, PensumID = 1, Prerrequisito = null },
                new Asignatura {AsignaturaID = 2,   CodAsignatura = "MAT215",
                    NombreAsignatura = "Matematica I", UV = 4, TipoAsignaturaID = 1, CicloID = 1, PensumID = 1, Prerrequisito = null },
                new Asignatura {AsignaturaID = 3,   CodAsignatura = "MAT315",
                    NombreAsignatura = "Matematica I", UV = 4, TipoAsignaturaID = 1, CicloID = 1, PensumID = 1, Prerrequisito = null },
                new Asignatura {AsignaturaID = 4,   CodAsignatura = "MAT415",
                    NombreAsignatura = "Matematica I", UV = 4, TipoAsignaturaID = 1, CicloID = 1, PensumID = 1, Prerrequisito = null },
                new Asignatura {AsignaturaID = 5,   CodAsignatura = "MAT515",
                    NombreAsignatura = "Matematica I", UV = 4, TipoAsignaturaID = 1, CicloID = 1, PensumID = 1, Prerrequisito = null },

            };
            asignatura.ForEach(s => context.Asignatura.AddOrUpdate(p => p.CodAsignatura, s));
            context.SaveChanges();
            */
        }
    }
}
