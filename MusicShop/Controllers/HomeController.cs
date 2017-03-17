using MusicShop.DAL;
using MusicShop.Database.Repositories;
using MusicShop.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MusicShop.Controllers
{
    public class HomeController : Controller
    {
        MusicShopContext db = new MusicShopContext();
        [HttpGet]
        public ActionResult Index()
        {
            var s = new Store
            {
                Albums = new AlbumRepository(db).GetAll().ToList(),
                Genres = new GenreRepository(db).GetAll().ToList()
            };

            return View(s);
        }

        [HttpPost]
        public ActionResult Index(string search, string genre, int? fromYear, int? toYear)
        {
            var query = new AlbumRepository(db).GetAll();

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

            var s = new Store
            {
                Albums = query.ToList(),
                Genres = new GenreRepository(db).GetAll().ToList()
            };

            return View(s);
        }

        [HttpPost]
        public ActionResult Album(int id)
        {
            throw new NotImplementedException();
        }
    }
}