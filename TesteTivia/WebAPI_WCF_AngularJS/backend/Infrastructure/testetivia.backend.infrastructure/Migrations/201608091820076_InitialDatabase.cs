namespace testetivia.backend.infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cd",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false),
                        Artista = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Genero = c.String(),
                        Duracao = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MusicaCds",
                c => new
                    {
                        Musica_Id = c.Int(nullable: false),
                        Cd_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Musica_Id, t.Cd_Id })
                .ForeignKey("dbo.Musica", t => t.Musica_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cd", t => t.Cd_Id, cascadeDelete: true)
                .Index(t => t.Musica_Id)
                .Index(t => t.Cd_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MusicaCds", "Cd_Id", "dbo.Cd");
            DropForeignKey("dbo.MusicaCds", "Musica_Id", "dbo.Musica");
            DropIndex("dbo.MusicaCds", new[] { "Cd_Id" });
            DropIndex("dbo.MusicaCds", new[] { "Musica_Id" });
            DropTable("dbo.MusicaCds");
            DropTable("dbo.Musica");
            DropTable("dbo.Cd");
        }
    }
}
