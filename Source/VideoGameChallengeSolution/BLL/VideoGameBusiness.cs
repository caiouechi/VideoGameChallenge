using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.DAO;
using Newtonsoft.Json;

namespace BLL
{
    public class VideoGameBusiness
    {
        public List<VideoGame> getAllVideoGames()
        {
            VideoGameDAO videoGameDAO = new VideoGameDAO();
            return videoGameDAO.getAll();
        }

        public List<VideoGame> getVideoGamesByName(string videoGameName)
        {
            VideoGameDAO videoGameDAO = new VideoGameDAO();
            var videoGames = videoGameDAO.getAll();
            if (!String.IsNullOrEmpty(videoGameName))
            {
                videoGames = videoGames.Where(v => v.Name.ToUpper().Contains(videoGameName.ToUpper())).ToList();
            }
            return videoGames;
        }

        public bool updateVideoGame(VideoGame videoGameName)
        {
            VideoGameDAO videoGameDAO = new VideoGameDAO();
            return videoGameDAO.updateVideoGame(videoGameName);
        }
    }
}
