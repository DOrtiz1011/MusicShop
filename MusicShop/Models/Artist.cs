using System.Collections.Generic;

namespace MusicShop.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}