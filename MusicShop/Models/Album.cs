using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models
{
    public class Album
    {
        public int ID { get; set; }

        [StringLength(128)]
        [Index("IX_AlbumnTitleAndArtistId", 1,IsUnique = true)]
        public string Title { get; set; }

        [Index("IX_AlbumnTitleAndArtistId", 2, IsUnique = true)]
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
        public int Year { get; set; }

        [StringLength(256)]
        public string CoverUrl { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
