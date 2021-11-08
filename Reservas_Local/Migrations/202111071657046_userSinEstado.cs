namespace Reservas_Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userSinEstado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Docentes", "EstadoUserID", "dbo.EstadoUsers");
            DropIndex("dbo.Docentes", new[] { "EstadoUserID" });
            AddColumn("dbo.Docentes", "EstadoUser", c => c.String());
            DropColumn("dbo.Docentes", "EstadoUserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Docentes", "EstadoUserID", c => c.Int(nullable: false));
            DropColumn("dbo.Docentes", "EstadoUser");
            CreateIndex("dbo.Docentes", "EstadoUserID");
            AddForeignKey("dbo.Docentes", "EstadoUserID", "dbo.EstadoUsers", "EstadoUserID", cascadeDelete: true);
        }
    }
}
