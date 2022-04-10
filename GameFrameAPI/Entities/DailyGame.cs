using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameFrameAPI.Entities
{
    public class DailyGame
    {
        public int DailyGameID { get; set; }
        public DateTime GameDate { get; set; }
        public virtual Game Game { get; set; }
    }

    public class DailyGameConfiguration : IEntityTypeConfiguration<DailyGame>
    {
        public void Configure(EntityTypeBuilder<DailyGame> builder)
        {
            builder.HasKey(e => e.DailyGameID);
            builder.Property(e => e.GameDate).IsRequired();
            builder.HasOne(e => e.Game)
              .WithMany(g => g.DailyGames);
        }
    }
}
