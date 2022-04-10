using GameFrameAPI.Entities;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace GameFrameAPI.Models
{
    public class GamedleDBContext : DbContext
    {
        public DbSet<DailyGame> DailyGames { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Screenshot> Screenshots { get; set; }

        public GamedleDBContext(DbContextOptions<GamedleDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PlatformConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new ScreenshotConfiguration());
            modelBuilder.ApplyConfiguration(new DailyGameConfiguration());
        }
    }
}
