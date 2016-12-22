namespace testetivia.backend.infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CdNotNullUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cd", "Titulo", c => c.String(nullable: false));
            AlterColumn("dbo.Cd", "Artista", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cd", "Artista", c => c.String());
            AlterColumn("dbo.Cd", "Titulo", c => c.String());
        }
    }
}
