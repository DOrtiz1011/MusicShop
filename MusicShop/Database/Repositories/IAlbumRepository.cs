using MusicShop.Models;
using System.Linq;

namespace MusicShop.Database.Repositories
{
    public interface IAlbumRepository
    {
        IQueryable<Album> AdvancedSearch(string search, int genreId, int? fromYear, int? toYear);
    }
}
