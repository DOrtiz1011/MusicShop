using MusicShop.DAL;
using MusicShop.Database.Repositories;
using MusicShop.Models;
using MusicShop.ViewModels;
using System.Collections.Generic;
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
        public ActionResult Index() => View(new StoreViewModel
        {
            Albums = GetAlbumViewModelList(albumRepository.GetAll().ToList()),
            Genres = genreRepository.GetAll().ToList()
        });

        [HttpPost]
        public ActionResult Index(string search, string genre, int? fromYear, int? toYear)
        {
            var genreId = genreRepository.SearchFor(x => x.Name == genre).Select(x => x.ID).SingleOrDefault();
            var albumList = albumRepository.AdvancedSearch(search, genreId, fromYear, toYear).ToList();

            return View(new StoreViewModel
            {
                Albums = GetAlbumViewModelList(albumList),
                Genres = genreRepository.GetAll().ToList()
            });
        }

        [HttpPost]
        public ActionResult Album(int id) => PartialView("_AlbumDetails", GetAlbumViewModel(id));

        public AlbumViewModel GetAlbumViewModel(int id)
        {
            var album = albumRepository.GetById(id);

            return new AlbumViewModel
            {
                Album = album,
                Genre = genreRepository.GetById(album.GenreID)
            };
        }

        public List<AlbumViewModel> GetAlbumViewModelList(IEnumerable<Album> albums)
        {
            var albumViewModelList = new List<AlbumViewModel>();

            foreach (var album in albums)
            {
                albumViewModelList.Add(new AlbumViewModel
                {
                    Album = album,
                    Genre = genreRepository.GetById(album.GenreID)
                });
            }

            return albumViewModelList;
        }
    }
}
