namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        VideoGameId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDecription = c.String(),
                        FullDescription = c.String(),
                        Gender = c.String(),
                        CoverImageURL = c.String(),
                        Publisher = c.String(),
                        Platform = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VideoGameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VideoGames");
        }
    }
}
