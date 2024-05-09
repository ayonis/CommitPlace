using CommittePlace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommittePlace.Configuration
{
    public class CourseEnityTypeConfiguration : IEntityTypeConfiguration<Course>
    {


        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnType("nvarchar(6)");
            builder.Property(c => c.CourseName).IsRequired();
            builder.Property(c => c.CourseName).HasColumnType("nvarchar(150)");
            builder.Property(c => c.ExamTime).HasColumnType("varchar(100)");
            builder.Property(c => c.ExamTime).IsRequired();
           
        }
    }
}
