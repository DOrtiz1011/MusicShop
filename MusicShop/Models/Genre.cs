using System.Collections.Generic;

namespace MusicShop.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
