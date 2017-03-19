using MusicShop.Models;
using System.Data.Entity;

namespace MusicShop.Database.Repositories
{
    internal sealed class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(DbContext context) : base(context) { }
    }
}