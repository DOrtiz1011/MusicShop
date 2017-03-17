using MusicShop.DAL;
using MusicShop.Models;

namespace MusicShop.Database.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(MusicShopContext context) : base(context) { }
    }
}