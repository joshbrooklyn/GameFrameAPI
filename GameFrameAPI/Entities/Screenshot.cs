using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameFrameAPI.Entities
{
    public class Screenshot
    {
        public int ScreenshotId { get; set; }
        public int SequenceNo { get; set; }
        public string ImageURL { get; set; }

        [JsonIgnore]
        public int GameId { get; set; }

        [JsonIgnore]
        public virtual Game Game { get; set; }
    }

    public class ScreenshotConfiguration : IEntityTypeConfiguration<Screenshot>
    {
        public void Configure(EntityTypeBuilder<Screenshot> builder)
        {
            builder.HasKey(e => e.ScreenshotId);
            builder.Property(e => e.SequenceNo).IsRequired();
            builder.Property(e => e.GameId).IsRequired();
            builder.Property(e => e.ImageURL).IsRequired();
            builder
                .HasOne(e => e.Game)
                .WithMany(g => g.Screenshots)
                .HasForeignKey(e => e.GameId);

            List<Screenshot> SeedData = new List<Screenshot>();

            string filePath = Path.Combine("SeedData", "Game.Frame - Screenshots.csv");
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();
                    int ScreenshotId = 1;

                    while (csv.Read())
                    {
                        string pattern = @"https:\/\/drive\.google\.com\/file\/d\/(.{1,})\/";
                        var match = Regex.Match(csv.GetField("ImageURL"), pattern);
                        string ImageId = match.Groups[1].Value;
                        string ImageURL = $"https://drive.google.com/thumbnail?id={ImageId}";

                        SeedData.Add(
                            new Screenshot()
                            {
                                
                                ScreenshotId = ScreenshotId,
                                GameId = Int32.Parse(csv.GetField("GameId")),
                                SequenceNo = Int32.Parse(csv.GetField("SequenceNo")),
                                ImageURL = ImageURL
                            }
                        );

                        ScreenshotId++;
                    }
                }
            }

            builder.HasData(SeedData);
        }
    }
}
