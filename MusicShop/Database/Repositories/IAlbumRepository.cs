using MusicShop.Models;
using System.Collections.Generic;

namespace MusicShop.Database.Repositories
{
    internal interface IAlbumRepository
    {
        IEnumerable<Album> AdvancedSearch(string search, int genreId, int? fromYear, int? toYear, List<int> artistIds);
    }
}
