using MusicShop.Models;
using System.Collections.Generic;

namespace MusicShop.ViewModels
{
    public sealed class StoreViewModel
    {
        public List<AlbumViewModel> Albums { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
