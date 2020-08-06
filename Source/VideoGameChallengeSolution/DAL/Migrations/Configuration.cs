namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DTO;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.VideoGameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.VideoGameContext context)
        {
            if (!context.VideoGames.Any())
            {
                //  This method will be called after migrating to the latest version.
                for (int i = 0; i < 10; i++)
                {
                    context.VideoGames.Add(
                               new VideoGame
                               {
                                   Name = "VideoGame" + i,
                                   CoverImageURL = "img1",
                                   CreatedDate = DateTime.Now,
                                   FullDescription = "FullDescription" + i,
                                   Gender = "Gender" + i,
                                   Platform = "Platform" + i,
                                   Publisher = "Publisher" + i,
                                   ReleaseDate = DateTime.Now.AddDays(i),
                                   ShortDecription = "ShortDescription" + i
                               });
                }
            }
        }
    }
}