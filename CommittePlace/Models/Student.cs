
using System.ComponentModel.DataAnnotations;

namespace CommittePlace.Models
{
    public class Student
    {
      
        public string Id { get; set; }
        public string ArabicName { get; set; }
        public string Degree { get; set; }
        public string Center { get; set; }
        public List<Course> Courses { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }

    }
}
