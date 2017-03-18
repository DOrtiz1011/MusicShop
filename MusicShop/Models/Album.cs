using System.Collections.Generic;

namespace MusicShop.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int GenreID { get; set; }
        public int Year { get; set; }
        public string CoverUrl { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
