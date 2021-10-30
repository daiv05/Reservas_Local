namespace Reservas_Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividads",
                c => new
                    {
                        ActividadID = c.Int(nullable: false, identity: true),
                        TipoActividadID = c.Int(nullable: false),
                        AsignaturaID = c.Int(nullable: false),
                        Ciclo = c.String(),
                        AnioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActividadID)
                .ForeignKey("dbo.Anios", t => t.AnioID, cascadeDelete: true)
                .ForeignKey("dbo.Asignaturas", t => t.AsignaturaID, cascadeDelete: true)
                .ForeignKey("dbo.TipoActividads", t => t.TipoActividadID, cascadeDelete: true)
                .Index(t => t.TipoActividadID)
                .Index(t => t.AsignaturaID)
                .Index(t => t.AnioID);
            
            CreateTable(
                "dbo.Anios",
                c => new
                    {
                        AnioID = c.Int(nullable: false, identity: true),
                        AnioCurso = c.String(),
                    })
                .PrimaryKey(t => t.AnioID);
            
            CreateTable(
                "dbo.Asignaturas",
                c => new
                    {
                        AsignaturaID = c.Int(nullable: false),
                        CodAsignatura = c.String(),
                        NombreAsignatura = c.String(),
                        UV = c.Int(nullable: false),
                        TipoAsignaturaID = c.Int(nullable: false),
                        CicloID = c.Int(nullable: false),
                        PensumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AsignaturaID)
                .ForeignKey("dbo.Cicloes", t => t.CicloID, cascadeDelete: true)
                .ForeignKey("dbo.Pensums", t => t.PensumID, cascadeDelete: true)
                .ForeignKey("dbo.TipoAsignaturas", t => t.TipoAsignaturaID, cascadeDelete: true)
                .Index(t => t.TipoAsignaturaID)
                .Index(t => t.CicloID)
                .Index(t => t.PensumID);
            
            CreateTable(
                "dbo.Cicloes",
                c => new
                    {
                        CicloID = c.Int(nullable: false, identity: true),
                        TipoCiclo = c.String(),
                    })
                .PrimaryKey(t => t.CicloID);
            
            CreateTable(
                "dbo.Pensums",
                c => new
                    {
                        PensumID = c.Int(nullable: false, identity: true),
                        NombrePensum = c.String(),
                        Anio = c.String(),
                    })
                .PrimaryKey(t => t.PensumID);
            
            CreateTable(
                "dbo.TipoAsignaturas",
                c => new
                    {
                        TipoAsignaturaID = c.Int(nullable: false, identity: true),
                        AsignaturaTipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoAsignaturaID);
            
            CreateTable(
                "dbo.TipoActividads",
                c => new
                    {
                        TipoActividadID = c.Int(nullable: false, identity: true),
                        ActividadTipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoActividadID);
            
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        CarreraID = c.Int(nullable: false, identity: true),
                        NomCarrera = c.String(),
                        PensumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarreraID)
                .ForeignKey("dbo.Pensums", t => t.PensumID, cascadeDelete: true)
                .Index(t => t.PensumID);
            
            CreateTable(
                "dbo.Dias",
                c => new
                    {
                        DiaID = c.Int(nullable: false, identity: true),
                        NombreDia = c.String(),
                    })
                .PrimaryKey(t => t.DiaID);
            
            CreateTable(
                "dbo.Edificios",
                c => new
                    {
                        EdificioID = c.Int(nullable: false, identity: true),
                        NombreEdif = c.String(),
                        EscuelaID = c.Int(nullable: false),
                        NumPlantas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EdificioID)
                .ForeignKey("dbo.Escuelas", t => t.EscuelaID, cascadeDelete: true)
                .Index(t => t.EscuelaID);
            
            CreateTable(
                "dbo.Escuelas",
                c => new
                    {
                        EscuelaID = c.Int(nullable: false, identity: true),
                        NombreEscu = c.String(),
                        FacultadID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EscuelaID)
                .ForeignKey("dbo.Facultads", t => t.FacultadID, cascadeDelete: true)
                .Index(t => t.FacultadID);
            
            CreateTable(
                "dbo.Facultads",
                c => new
                    {
                        FacultadID = c.Int(nullable: false, identity: true),
                        NombreFacu = c.String(),
                    })
                .PrimaryKey(t => t.FacultadID);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        LocalID = c.Int(nullable: false, identity: true),
                        NombreLocal = c.String(),
                        EdificioID = c.Int(nullable: false),
                        Planta = c.Int(nullable: false),
                        Puntuacion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.LocalID)
                .ForeignKey("dbo.Edificios", t => t.EdificioID, cascadeDelete: true)
                .Index(t => t.EdificioID);
            
            CreateTable(
                "dbo.Fotografias",
                c => new
                    {
                        FotografiaID = c.Int(nullable: false, identity: true),
                        Imagen = c.Binary(),
                        LocalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FotografiaID)
                .ForeignKey("dbo.Locals", t => t.LocalID, cascadeDelete: true)
                .Index(t => t.LocalID);
            
            CreateTable(
                "dbo.EstadoUsers",
                c => new
                    {
                        EstadoUserID = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.EstadoUserID);
            
            CreateTable(
                "dbo.Horas",
                c => new
                    {
                        HoraID = c.Int(nullable: false, identity: true),
                        HInicio = c.String(),
                        HFin = c.String(),
                    })
                .PrimaryKey(t => t.HoraID);
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        HorarioID = c.Int(nullable: false, identity: true),
                        HoraID = c.Int(nullable: false),
                        DiaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HorarioID)
                .ForeignKey("dbo.Dias", t => t.DiaID, cascadeDelete: true)
                .ForeignKey("dbo.Horas", t => t.HoraID, cascadeDelete: true)
                .Index(t => t.HoraID)
                .Index(t => t.DiaID);
            
            CreateTable(
                "dbo.LineaReservas",
                c => new
                    {
                        LineaReservaID = c.Int(nullable: false, identity: true),
                        LocalID = c.Int(nullable: false),
                        HorarioID = c.Int(nullable: false),
                        SemanaID = c.Int(nullable: false),
                        Reserva_ReservaID = c.Int(),
                    })
                .PrimaryKey(t => t.LineaReservaID)
                .ForeignKey("dbo.Horarios", t => t.HorarioID, cascadeDelete: true)
                .ForeignKey("dbo.Locals", t => t.LocalID, cascadeDelete: true)
                .ForeignKey("dbo.Semanas", t => t.SemanaID, cascadeDelete: true)
                .ForeignKey("dbo.Reservas", t => t.Reserva_ReservaID)
                .Index(t => t.LocalID)
                .Index(t => t.HorarioID)
                .Index(t => t.SemanaID)
                .Index(t => t.Reserva_ReservaID);
            
            CreateTable(
                "dbo.Semanas",
                c => new
                    {
                        SemanaID = c.Int(nullable: false, identity: true),
                        numSemana = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SemanaID);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ReservaID = c.Int(nullable: false, identity: true),
                        NombreReserva = c.String(),
                        Aproved = c.Boolean(nullable: false),
                        ActividadID = c.Int(nullable: false),
                        DocenteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaID)
                .ForeignKey("dbo.Actividads", t => t.ActividadID, cascadeDelete: true)
                .ForeignKey("dbo.Docentes", t => t.DocenteID, cascadeDelete: true)
                .Index(t => t.ActividadID)
                .Index(t => t.DocenteID);
            
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        DocenteID = c.Int(nullable: false, identity: true),
                        NombreDocente = c.String(),
                        ApellidoDocente = c.String(),
                        CorreoDocente = c.String(),
                        Contrasenia = c.String(),
                        NIT = c.String(),
                        DUI = c.String(),
                        EstadoUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocenteID)
                .ForeignKey("dbo.EstadoUsers", t => t.EstadoUserID, cascadeDelete: true)
                .Index(t => t.EstadoUserID);
            
            CreateTable(
                "dbo.Ubicacions",
                c => new
                    {
                        UbicacionID = c.Int(nullable: false, identity: true),
                        Latitud = c.String(),
                        Altitud = c.String(),
                    })
                .PrimaryKey(t => t.UbicacionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaReservas", "Reserva_ReservaID", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "DocenteID", "dbo.Docentes");
            DropForeignKey("dbo.Docentes", "EstadoUserID", "dbo.EstadoUsers");
            DropForeignKey("dbo.Reservas", "ActividadID", "dbo.Actividads");
            DropForeignKey("dbo.LineaReservas", "SemanaID", "dbo.Semanas");
            DropForeignKey("dbo.LineaReservas", "LocalID", "dbo.Locals");
            DropForeignKey("dbo.LineaReservas", "HorarioID", "dbo.Horarios");
            DropForeignKey("dbo.Horarios", "HoraID", "dbo.Horas");
            DropForeignKey("dbo.Horarios", "DiaID", "dbo.Dias");
            DropForeignKey("dbo.Fotografias", "LocalID", "dbo.Locals");
            DropForeignKey("dbo.Locals", "EdificioID", "dbo.Edificios");
            DropForeignKey("dbo.Escuelas", "FacultadID", "dbo.Facultads");
            DropForeignKey("dbo.Edificios", "EscuelaID", "dbo.Escuelas");
            DropForeignKey("dbo.Carreras", "PensumID", "dbo.Pensums");
            DropForeignKey("dbo.Actividads", "TipoActividadID", "dbo.TipoActividads");
            DropForeignKey("dbo.Actividads", "AsignaturaID", "dbo.Asignaturas");
            DropForeignKey("dbo.Asignaturas", "TipoAsignaturaID", "dbo.TipoAsignaturas");
            DropForeignKey("dbo.Asignaturas", "PensumID", "dbo.Pensums");
            DropForeignKey("dbo.Asignaturas", "CicloID", "dbo.Cicloes");
            DropForeignKey("dbo.Actividads", "AnioID", "dbo.Anios");
            DropIndex("dbo.Docentes", new[] { "EstadoUserID" });
            DropIndex("dbo.Reservas", new[] { "DocenteID" });
            DropIndex("dbo.Reservas", new[] { "ActividadID" });
            DropIndex("dbo.LineaReservas", new[] { "Reserva_ReservaID" });
            DropIndex("dbo.LineaReservas", new[] { "SemanaID" });
            DropIndex("dbo.LineaReservas", new[] { "HorarioID" });
            DropIndex("dbo.LineaReservas", new[] { "LocalID" });
            DropIndex("dbo.Horarios", new[] { "DiaID" });
            DropIndex("dbo.Horarios", new[] { "HoraID" });
            DropIndex("dbo.Fotografias", new[] { "LocalID" });
            DropIndex("dbo.Locals", new[] { "EdificioID" });
            DropIndex("dbo.Escuelas", new[] { "FacultadID" });
            DropIndex("dbo.Edificios", new[] { "EscuelaID" });
            DropIndex("dbo.Carreras", new[] { "PensumID" });
            DropIndex("dbo.Asignaturas", new[] { "PensumID" });
            DropIndex("dbo.Asignaturas", new[] { "CicloID" });
            DropIndex("dbo.Asignaturas", new[] { "TipoAsignaturaID" });
            DropIndex("dbo.Actividads", new[] { "AnioID" });
            DropIndex("dbo.Actividads", new[] { "AsignaturaID" });
            DropIndex("dbo.Actividads", new[] { "TipoActividadID" });
            DropTable("dbo.Ubicacions");
            DropTable("dbo.Docentes");
            DropTable("dbo.Reservas");
            DropTable("dbo.Semanas");
            DropTable("dbo.LineaReservas");
            DropTable("dbo.Horarios");
            DropTable("dbo.Horas");
            DropTable("dbo.EstadoUsers");
            DropTable("dbo.Fotografias");
            DropTable("dbo.Locals");
            DropTable("dbo.Facultads");
            DropTable("dbo.Escuelas");
            DropTable("dbo.Edificios");
            DropTable("dbo.Dias");
            DropTable("dbo.Carreras");
            DropTable("dbo.TipoActividads");
            DropTable("dbo.TipoAsignaturas");
            DropTable("dbo.Pensums");
            DropTable("dbo.Cicloes");
            DropTable("dbo.Asignaturas");
            DropTable("dbo.Anios");
            DropTable("dbo.Actividads");
        }
    }
}
