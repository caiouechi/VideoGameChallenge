using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DTO;

namespace DAL
{
    public class VideoGameContext : DbContext
    {
        public VideoGameContext() : base("VideoGameContext")
        {
        }

        public DbSet<VideoGame> VideoGames { get; set; }

    }
}
