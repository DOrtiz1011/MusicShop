using MusicShop.DAL;
using MusicShop.Models;

namespace MusicShop.Database.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicShopContext context) : base(context) { }
    }
}