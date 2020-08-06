using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.DAO
{
    public class VideoGameDAO
    {
        public List<VideoGame> getAll()
        {
            using (var db = new VideoGameContext())
            {
                return db.VideoGames.ToList();
            }
        }

        public bool updateVideoGame(VideoGame videoGame)
        {
            using (var db = new VideoGameContext())
            {
                var videoGameTarget = db.VideoGames.Where(vg => vg.VideoGameId == videoGame.VideoGameId).FirstOrDefault();

                try
                {
                    db.Entry(videoGameTarget).CurrentValues.SetValues(videoGame);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            
            }
        }
    }
}
