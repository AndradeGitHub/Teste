namespace testetivia.backend.infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMusicaCds : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.MusicaCds", name: "Course_Id", newName: "Cd_Id");
            RenameIndex(table: "dbo.MusicaCds", name: "IX_Course_Id", newName: "IX_Cd_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.MusicaCds", name: "IX_Cd_Id", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.MusicaCds", name: "Cd_Id", newName: "Course_Id");
        }
    }
}
