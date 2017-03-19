using MusicShop.Models;

namespace MusicShop.ViewModels
{
    public sealed class AlbumViewModel
    {
        public Album Album { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}