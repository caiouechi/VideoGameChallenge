using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BLL;

namespace VideoGameWebAPIS.Controllers
{
    public class VideoGameController : ApiController
    {
        public List<VideoGame> getAll()
        {
            VideoGameBusiness videoGameBusinessBLL = new VideoGameBusiness();
            return videoGameBusinessBLL.getAllVideoGames();
        }

        [HttpGet]
        public List<VideoGame> getVideoGamesByName(string name)
        {
            VideoGameBusiness videoGameBusinessBLL = new VideoGameBusiness();
            return videoGameBusinessBLL.getVideoGamesByName(name);
        }

        [HttpPost]
        public bool updateVideoGame(VideoGame videoGame)
        {
            VideoGameBusiness videoGameBusinessBLL = new VideoGameBusiness();
            return videoGameBusinessBLL.updateVideoGame(videoGame);
        }
    }
}
