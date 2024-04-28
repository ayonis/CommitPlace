using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Commiteeplace.Models
{
    public class CommitDB : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-TGSO878;Initial Catalog=CommitDB;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
