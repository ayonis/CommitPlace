using System.ComponentModel.DataAnnotations;

namespace Commiteeplace.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; }
        public string CourseName { get; set; }
        public DateTime ExamTime { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
