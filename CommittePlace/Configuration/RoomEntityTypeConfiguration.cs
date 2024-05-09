
using CommittePlace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommittePlace.Configuration
{
    public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(r => r.Id).HasColumnType("nvarchar(50)");
            builder.Property(r => r.Place).HasColumnType("nvarchar(200)");
        }

    }
}
