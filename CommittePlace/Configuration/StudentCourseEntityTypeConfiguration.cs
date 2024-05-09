using CommittePlace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CommittePlace.Configuration
{
    public class StudentCourseEntityTypeConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Property(sc => sc.StudentId).HasColumnType("nvarchar(8)");
            builder.Property(sc => sc.CourseId).HasColumnType("nvarchar(6)");
            builder.HasOne(sc => sc.Student)
                    .WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);
            builder.HasOne(sc => sc.Course)
                    .WithMany(c => c.StudentCourses).HasForeignKey(sc => sc.CourseId);
            builder.HasOne(sc => sc.Room)
                    .WithMany(r => r.StudentCourses).HasForeignKey(sc => sc.RoomId);



        }
    }
}
