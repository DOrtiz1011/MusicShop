using MusicShop.DAL;
using MusicShop.Models;
using System.Linq;

namespace MusicShop.Database.Repositories
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicShopContext context) : base(context) { }

        public IQueryable<Album> AdvancedSearch(string search, string genre, int? fromYear, int? toYear)
        {
            var query = GetAll();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Title.Contains(search) || x.Artist.Contains(search));
            }

            if (!string.IsNullOrEmpty(genre))
            {
                query = query.Where(x => x.Genre == genre);
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