using CommittePlace.Configuration;
using CommittePlace.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;

namespace CommittePlace.Models
{
    public class CommiteeDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-B0LUUR3;Initial Catalog=CommitteDB;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CourseEnityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            new StudentCourseEntityTypeConfiguration().Configure(modelBuilder.Entity<StudentCourse>());
            new RoomEntityTypeConfiguration().Configure(modelBuilder.Entity<Room>());
        }

        public List<StudentDataViewModel> GetStudentRoomsExams(string studentId)
        {
            
            var data = from studentCourse in StudentCourses
                       join student in Students on studentCourse.StudentId equals student.Id
                       join course in Courses on studentCourse.CourseId equals course.Id
                       join room in Rooms on studentCourse.RoomId equals room.Id
                       where student.Id == studentId
                       select new StudentDataViewModel
                       { StudentId = student.Id ,
                           StudentArabicName = student.ArabicName,
                           StudentDegree = student.Degree,
                           StudentCenter = student.Center,
                           CourseId = course.Id,
                           CourseName = course.CourseName,
                           ExamTime  = course.ExamTime,
                           RoomId = room.Id,
                           RoomPlace = room.Place};
            
            

            return data.ToList();
        }
    

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
