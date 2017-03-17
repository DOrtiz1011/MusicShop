using MusicShop.DAL;
using MusicShop.Models;

namespace MusicShop.Database.Repositories
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicShopContext context) : base(context) { }
    }
}