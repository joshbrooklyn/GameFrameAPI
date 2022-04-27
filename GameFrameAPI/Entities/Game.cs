using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GameFrameAPI.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }

        [JsonIgnore]
        public int PlatformId { get; set; }

        public int Year { get; set; }
        public int? CopiesSold { get; set; }

        public virtual Platform Platform { get; set; }
        public virtual ICollection<Screenshot> Screenshots { get; set; }

        [JsonIgnore]
        public virtual ICollection<DailyGame> DailyGames { get; set; }

        
    }        

    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(e => e.GameId);
            builder.Property(e => e.GameName).IsRequired();
            builder.Property(e => e.PlatformId).IsRequired();
            builder
                .HasOne(e => e.Platform)
                .WithMany(p => p.Games)
                .HasForeignKey(e=> e.PlatformId);

            List<Game> SeedData = new List<Game>();

            string filePath = Path.Combine("SeedData", "Game.Frame - Games.csv");
            
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        int? CopiesSold = null;

                        if (!String.IsNullOrEmpty(csv.GetField("CopiesSold")))
                            CopiesSold = Int32.Parse(csv.GetField("CopiesSold"));

                        SeedData.Add(
                            new Game()
                            {
                                GameId = Int32.Parse(csv.GetField("GameId")),
                                GameName = csv.GetField("GameName"),
                                PlatformId = Int32.Parse(csv.GetField("PlatformId")),
                                Year = Int32.Parse(csv.GetField("GameId")),
                                CopiesSold = CopiesSold
                            }
                        );
                    }
                }
            }

            builder.HasData(SeedData);
        }
    }
}
