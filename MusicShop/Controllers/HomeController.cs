using MusicShop.DAL;
using MusicShop.Database.Repositories;
using MusicShop.Models;
using System.Linq;
using System.Web.Mvc;

namespace MusicShop.Controllers
{
    public sealed class HomeController : Controller
    {
        private static readonly MusicShopContext db = new MusicShopContext();
        private readonly AlbumRepository albumRepository = new AlbumRepository(db);
        private readonly GenreRepository genreRepository = new GenreRepository(db);

        [HttpGet]
        public ActionResult Index() => View(new Store
        {
            Albums = albumRepository.GetAll().ToList(),
            Genres = genreRepository.GetAll().ToList()
        });

        [HttpPost]
        public ActionResult Index(string search, string genre, int? fromYear, int? toYear) => View(new Store
        {
            Albums = albumRepository.AdvancedSearch(search, genre, fromYear, toYear).ToList(),
            Genres = genreRepository.GetAll().ToList()
        });

        [HttpPost]
        public ActionResult Album(int id)
        {
            var album = albumRepository.GetById(id);
            return PartialView("AlbumnDetails", album);
        }
    }
}