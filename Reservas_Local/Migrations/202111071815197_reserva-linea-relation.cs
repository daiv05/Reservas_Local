namespace Reservas_Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reservalinearelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LineaReservas", "Reserva_ReservaID", "dbo.Reservas");
            DropIndex("dbo.LineaReservas", new[] { "Reserva_ReservaID" });
            RenameColumn(table: "dbo.LineaReservas", name: "Reserva_ReservaID", newName: "ReservaID");
            AlterColumn("dbo.LineaReservas", "ReservaID", c => c.Int(nullable: false));
            CreateIndex("dbo.LineaReservas", "ReservaID");
            AddForeignKey("dbo.LineaReservas", "ReservaID", "dbo.Reservas", "ReservaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaReservas", "ReservaID", "dbo.Reservas");
            DropIndex("dbo.LineaReservas", new[] { "ReservaID" });
            AlterColumn("dbo.LineaReservas", "ReservaID", c => c.Int());
            RenameColumn(table: "dbo.LineaReservas", name: "ReservaID", newName: "Reserva_ReservaID");
            CreateIndex("dbo.LineaReservas", "Reserva_ReservaID");
            AddForeignKey("dbo.LineaReservas", "Reserva_ReservaID", "dbo.Reservas", "ReservaID");
        }
    }
}
