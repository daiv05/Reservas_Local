namespace Reservas_Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class localConUbi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locals", "Altitud", c => c.String());
            AddColumn("dbo.Locals", "Latitud", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locals", "Latitud");
            DropColumn("dbo.Locals", "Altitud");
        }
    }
}
