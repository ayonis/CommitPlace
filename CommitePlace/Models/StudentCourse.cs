using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commiteeplace.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class StudentCourse
    {
        
        [ForeignKey("Student")]
        public string StudentId { get; set; }
        [ForeignKey("Course")]
       
        public string CourseId { get; set; }
       
        public List<Student> Student { get; set; }
        public List<Course> Course { get; set; }
    }
}
