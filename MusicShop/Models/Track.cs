using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models
{
    public class Track
    {
        public int ID { get; set; }

        [Index("IX_AlbumnIDNumberTitle", 1, IsUnique = true)]
        public int AlbumID { get; set; }

        [Index("IX_AlbumnIDNumberTitle", 2, IsUnique = true)]
        public int Number { get; set; }

        [StringLength(128)]
        [Index("IX_AlbumnIDNumberTitle", 3, IsUnique = true)]
        public string SongTitle { get; set; }

        public TimeSpan Length { get; set; }
    }
}
