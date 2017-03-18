using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MusicShop.DAL
{
    public class MusicShopInitializer : DropCreateDatabaseIfModelChanges<MusicShopContext>
    {
        protected override void Seed(MusicShopContext context)
        {
            new List<Album>
            {
                new Album { ID = 1, Title = "Visible Worlds", Artist = "Conductor", GenreID = 1, Year = 2000, CoverUrl = "http://s3.amazonaws.com/garysguide/de3245b95c564f9485392ff5fb1631b9original.png" },
                new Album { ID = 2, Title = "The Taste of Swing", Artist = "Andy Williams", GenreID = 2, Year = 2010, CoverUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Andy_williams_1969.JPG/220px-Andy_williams_1969.JPG" },
                new Album { ID = 3, Title = "H2O", Artist = "Poland Spring", GenreID = 3, Year = 1845, CoverUrl = "" },
                new Album { ID = 4, Title = "Of June", Artist = "Owl City", GenreID = 4, Year = 2010, CoverUrl = "" },
                new Album { ID = 5, Title = "Relections", Artist = "Steve Vai", GenreID = 5, Year = 2005, CoverUrl = "" },
                new Album { ID = 6, Title = "Live the Life", Artist = "Jacky Cheung", GenreID = 6, Year = 2007, CoverUrl = "" }
            }.ForEach(x => context.Albums.Add(x));

            new List<Track>
            {
                new Track { Number = 1, AlbumID = 1, SongTitle = "Connect", Length = new TimeSpan(0, 5, 0) },
                new Track { Number = 2, AlbumID = 1, SongTitle = "Life Segments", Length = new TimeSpan(0, 4, 0) },
                new Track { Number = 3, AlbumID = 1, SongTitle = "Gateways", Length = new TimeSpan(0, 8, 0) },
                new Track { Number = 4, AlbumID = 1, SongTitle = "Target Me", Length = new TimeSpan(0, 6, 24) },
                new Track { Number = 5, AlbumID = 1, SongTitle = "Tune In", Length = new TimeSpan(0, 4, 30) }
            }.ForEach(x => context.Tracks.Add(x));

            new List<Genre>
            {
                new Genre { ID = 1, Name = "New Age"},
                new Genre { ID = 2, Name = "Swing"},
                new Genre { ID = 3, Name = "Techno"},
                new Genre { ID = 4, Name = "Electronica"},
                new Genre { ID = 5, Name = "Rock"},
                new Genre { ID = 6, Name = "Pop"}
            }.ForEach(x => context.Genres.Add(x));

            context.SaveChanges();
        }
    }
}