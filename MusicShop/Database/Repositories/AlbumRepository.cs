using MusicShop.Models;
using System.Data.Entity;
using System.Linq;

namespace MusicShop.Database.Repositories
{
    internal sealed class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContext context) : base(context) { }

        public IQueryable<Album> AdvancedSearch(string search, int genreId, int? fromYear, int? toYear)
        {
            var query = GetAll();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Title.Contains(search) || x.Artist.Contains(search));
            }

            if (genreId > 0)
            {
                query = query.Where(x => x.GenreID == genreId);
            }

            if (fromYear.HasValue)
            {
                query = query.Where(x => x.Year >= fromYear.Value);
            }

            if (toYear.HasValue)
            {
                query = query.Where(x => x.Year <= toYear.Value);
            }

            return query;
        }
    }
}