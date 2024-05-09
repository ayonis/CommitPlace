using System.ComponentModel.DataAnnotations;

namespace CommittePlace.Models
{
    public class Course
    {
      
        public string Id { get; set; }
        public string CourseName { get; set; }
        public string ExamTime { get; set; }

        public List<Student> Students { get; set; }
        public List<StudentCourse> StudentCourses { get; set;}
    }
}
