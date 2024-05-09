using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommittePlace.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class StudentCourse
    {
        public string StudentId { get; set; }

        public string CourseId { get; set; }
        public string RoomId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
        public Room Room { get; set; }
    }
}
