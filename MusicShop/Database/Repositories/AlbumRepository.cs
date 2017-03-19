using MusicShop.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MusicShop.Database.Repositories
{
    internal sealed class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContext context) : base(context) { }

        public IEnumerable<Album> AdvancedSearch(string search, int genreId, int? fromYear, int? toYear, List<int> artistIds)
        {
            var query = GetAll();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Title.Contains(search));
            }

            if (artistIds?.Any() == true)
            {
                query = query.Where(x => artistIds.Contains(x.ArtistID));
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