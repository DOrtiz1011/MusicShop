using MusicShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.Database.Repositories
{
    internal interface IAlbumRepository
    {
        IQueryable<Album> AdvancedSearch(string search, int genreId, int? fromYear, int? toYear, List<int> artistIds);
    }
}
