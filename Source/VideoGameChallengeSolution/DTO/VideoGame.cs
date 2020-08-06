using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VideoGame
    {
        public int VideoGameId { get; set; }
        public string Name { get; set; }
        public string ShortDecription { get; set; }
        public string FullDescription { get; set; }
        public string Gender { get; set; }
        public string CoverImageURL { get; set; }
        public string Publisher { get; set; }
        public string Platform { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
