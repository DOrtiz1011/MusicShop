using MusicShop.Models;
using System.Data.Entity;

namespace MusicShop.Database.Repositories
{
    internal sealed class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(DbContext context) : base(context) { }
    }
}