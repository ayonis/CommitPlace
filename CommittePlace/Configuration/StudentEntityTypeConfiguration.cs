using CommittePlace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommittePlace.Configuration
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(r => r.Id).HasColumnType("nvarchar(8)");
            builder.Property(s => s.ArabicName).HasColumnType("nvarchar(200)");
            builder.Property(s => s.Degree).HasColumnType("nvarchar(100)");
            builder.Property(s => s.Center).HasColumnType("nvarchar(100)");
        }
    }
}
