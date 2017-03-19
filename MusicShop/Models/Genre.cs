using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [StringLength(128)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
