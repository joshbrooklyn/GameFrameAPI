using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameFrameAPI.Entities
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public string PlatformAcronym { get; set; }
        public string PlatformName { get; set; }
        public string PlatformCompany { get; set; }
        public int Year { get; set; }
        public int UnitsSold { get; set; }
        public int ConsoleGeneration { get; set; }

        [JsonIgnore]
        public virtual ICollection<Game> Games { get; set; }
    }

    public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.HasKey(e => e.PlatformId);
            builder.Property(e => e.PlatformId).IsRequired();
            builder.Property(e => e.PlatformAcronym).IsRequired();
            builder.Property(e => e.PlatformName).IsRequired();
            builder.Property(e => e.PlatformCompany).IsRequired();

            List<Platform> SeedData = new List<Platform>();

            string filePath = Path.Combine("SeedData", "Game.Frame - Platforms.csv");
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        SeedData.Add(
                            new Platform()
                            {
                                PlatformId = Int32.Parse(csv.GetField("PlatformId")),
                                PlatformAcronym = csv.GetField("PlatformAcronym"),
                                PlatformName = csv.GetField("PlatformName"),
                                PlatformCompany = csv.GetField("PlatformCompany"),
                                Year = Int32.Parse(csv.GetField("Year")),
                                UnitsSold = Int32.Parse(csv.GetField("UnitsSold")),
                                ConsoleGeneration = Int32.Parse(csv.GetField("ConsoleGeneration"))
                            }
                        );
                    }
                }
            }

            builder.HasData(SeedData);
        }
    }
}
