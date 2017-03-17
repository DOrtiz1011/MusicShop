﻿using MusicShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MusicShop.DAL
{
    public class MusicShopContext : DbContext
    {
        public MusicShopContext() : base("MusicShopContext") { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Album>().HasMany(c => c.Tracks);
            modelBuilder.Entity<Genre>().HasMany(c => c.Albums);
        }
    }
}