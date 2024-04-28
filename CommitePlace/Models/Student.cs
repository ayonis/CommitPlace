
using System.ComponentModel.DataAnnotations;

namespace Commiteeplace.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        public string ArabicName { get; set; }
        public string Degree { get; set; }
        public string Center { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
